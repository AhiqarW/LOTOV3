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

        alert("Voici la donnee ajoutee : " + DonneeAjoutee)
    });

    connection.start().then(function () {
        console.log('Connected!');
    }).catch(function (err) {
        return console.error(err.toString());
    });

    return connection;
}

const connection = initialiserConnectionSignalR();

const soumettreCommentaire = (commentaire) => {

    //Faire un POST ici?

    if (!connection.state === "Connected") {
        location.reload
    }
    
        connection.invoke("SignalerDonnee", {
            DonneeAjoutee: commentaire
        }).catch(e => console.log(e.message));
    
}
