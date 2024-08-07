const initialiserConnectionSignalR = () => {
    const connection = new signalR.HubConnectionBuilder()
        .withUrl("/lotohub",
            {
                transport: signalR.HttpTransportType.WebSockets,
                skipNegotiation: true
            })
        .withAutomaticReconnect()
        .withHubProtocol(new signalR.protocols.msgpack.MessagePackHubProtocol())
        .withStatefulReconnect({ bufferSize: 1000 })
        .build();

    connection.on("NouvelleDonneeRecue", ({ DonneeAjoutee }) => {

        document.getElementById('commentaire').value = DonneeAjoutee;
    });

    connection.on("UpdateCheckboxState", ({ Id, State }) => {
        const checkbox = document.getElementById(Id);

        checkbox.checked = State;
    
    });


    connection.start().then(function () {
        console.log('Connected!');
    }).catch(function (err) {
        return console.error(err.toString());
    });

    return connection;
}

const connection = initialiserConnectionSignalR();

/*const soumettreCommentaire = () => {

    const commentaire = document.getElementById('commentaire').value;


    //Faire un POST ici?

    if (!connection.state === "Connected") {
        location.reload
    }
    
        connection.invoke("SignalerDonnee", {
            DonneeAjoutee: commentaire
        }).catch(e => console.log(e.message));
    
}*/

const soumettreCommentaire = () => {
    const commentaire = document.getElementById('commentaire').value;

    if (connection.state !== "Connected") {
        location.reload();
    }

    fetch('/home/updatecomment', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ comment: commentaire })
    }).then(response => {
        if (response.ok) {
          
            connection.invoke("SignalerDonnee", {
                DonneeAjoutee: commentaire
            }).catch(e => console.log(e.message));
        }
    }).catch(e => console.log(e.message));
};



const soumettreEtatCheckbox = (id, state) => {


    if (!connection.state === "Connected") {
        location.reload
    }

    connection.invoke("UpdateCheckboxState",
        {
            Id: id, State: state
        }).catch(e => console.log(e.message));
}
