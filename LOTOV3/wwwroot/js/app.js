// Pour affecter la localisation au rapport telerik
var culture;

window.scrollToElementId = (elementId) => {
    console.info('scrolling to element', elementId);
    var element = document.querySelector(elementId);
    if (!element) {
        console.warn('element was not found', elementId);
        return false;
    }
    element.scrollIntoView();
    return true;
}

// Affecter l'URL du fichier Blob qui est créé à la balise de l'image et obtenir l'url
window.setImageAsBlob = async (elementId, imageStream) => {
    const arrayBuffer = await imageStream.arrayBuffer();
    const blob = new Blob([arrayBuffer]);
    const url = URL.createObjectURL(blob);
    var element = document.querySelector(elementId);
    if (!element) {
        console.warn('element was NOT found', elementId);
        return null;
    }
    else {
        console.warn('element was FOUND', elementId);
        element.setAttribute("src", url);
        return url;
    }
}

// Obtenir seulement URL du fichier Blob qui est créé.   Ne pas affecter la balise image
window.setBlob = async (imageStream) => {
    const arrayBuffer = await imageStream.arrayBuffer();
    const blob = new Blob([arrayBuffer]);
    const url = URL.createObjectURL(blob);
    console.warn('element URL ', url);
    return url;
    }

// Supprimer la référence URL maintenant inutile
window.revokeBlobURL = async (bloburl) => {
    URL.revokeObjectURL(bloburl);
}


// Pour aller au debut des dialogues risques et mesures préventives
function scrolltoId(selecteur) {
    var access = document.getElementById(selecteur);
    access.scrollIntoView();
}

// Indiquer la culture à utiliser
function setCultureName(cultureName) {
    culture = cultureName;
}

// Affecter la culture au rapport Telerik
window.trvEventHandlers = {
    setCultureReport: function (e, { deviceInfo }) {        
        deviceInfo["CurrentCulture"] = culture;
        deviceInfo["CurrentUICulture"] = culture;
    }
}
