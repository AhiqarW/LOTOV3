using FichesLoto.Shared.Domain;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.Routing;
using Microsoft.Win32;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Net;
using System.Numerics;
using static System.Net.Mime.MediaTypeNames;

namespace FichesLoto.Services;

public class MockDataService
{
    private static Guid _societeId = new Guid("88c47fdc-900a-4fe6-bb3a-02ce2e5caf9d");
    private static Guid _ficheCadenassageId = new Guid("344ed994-0662-4bff-9483-6206ea9d6178");
    private static Guid _etapeMaitriseId01 = new Guid("a93da2c1-a76d-40de-a586-fe8cb9572041");
    private static Guid _etapeMaitriseId02 = new Guid("3f2fb7a4-55b7-45ac-b893-e28a94e1bec4");
    private static Guid _etapeMaitriseId03 = new Guid("a5732403-838b-497d-ba62-ffa1e401d140");
    private static Guid _etapeMaitriseId04 = new Guid("0b6aed21-377f-4649-ac97-c556524f85c0");

        private static Guid _accessoireId01 = new Guid("cceb3f27-b252-4427-baca-f9554ca69187");
    private static Guid _accessoireId02 = new Guid("32d7e94d-acb7-408a-80d9-7027f34f4c58");
    private static Guid _accessoireId03 = new Guid("3ddb8b87-ca89-4ccb-b5a9-a8857baedfc0");
    private static Guid _accessoireId04 = new Guid("3be532e5-a361-49df-8aac-1cddd57d2a3b");

    private static DescriptionGenerale? _descriptionGenerales = default;
    private static List<Accessoire>? _accessoires = default;
    private static List<PreparationEtapeControle>? _preparationEtapeControle = default;
    private static List<EtapeMaitrise>? _etapeMaitrise = default;
    private static List<EtapeMaitriseAccessoire>? _etapeMaitriseAccessoire = default;
    private static List<EtapeMaitrisePhoto>? _etapeMaitrisePhoto = default;
    private static List<Participant>? _participant = default;

    public static DescriptionGenerale? DescriptionGenerale()
    {
        _descriptionGenerales ??= InitializeMockDescriptionGenerale();
        return _descriptionGenerales;
    }

    public static List<Accessoire>? Accessoires()
    {
        _accessoires ??= InitializeMockAccessoire();
        return _accessoires;
    }

    public static List<PreparationEtapeControle>? PreparationEtapeControle()
    {
        _preparationEtapeControle ??= InitializeMockPreparationEtapeControle();
        return _preparationEtapeControle;
    }

    public static List<EtapeMaitrise>? EtapeMaitrise()
    {
        _etapeMaitrise ??= InitializeMockEtapeMaitrise();
        return _etapeMaitrise;
    }

    public static List<EtapeMaitriseAccessoire>? EtapeMaitriseAccessoire()
    {
        _etapeMaitriseAccessoire ??= InitializeMockEtapeMaitriseAccessoire();
        return _etapeMaitriseAccessoire;
    }

    public static List<EtapeMaitrisePhoto>? EtapeMaitrisePhoto()
    {
        _etapeMaitrisePhoto ??= InitializeMockEtapeMaitrisePhoto();
        return _etapeMaitrisePhoto;
    }

    public static List<Participant>? Participant()
    {
        _participant ??= InitializeMockParticipant();
        return _participant;
    }

    private static DescriptionGenerale? InitializeMockDescriptionGenerale()
    {
        return new DescriptionGenerale
        {

            NoFicheCadenassage = _ficheCadenassageId,
            NoFicheCadenassageUtilisation = Guid.NewGuid(),
            SocieteId = _societeId,
            NoFicheCadenassageInterne = "COIL VA1-002-9.424-MB",
            NomEquipement = "Transformateur Portable T-810-EXPLO-6-1 Station électrique ST-810-113-01",
            NoEquipement = "6131CHU13, 315-CH-012",
            NoLocalisation = 3,
            LocalisationAutreSpecifierFr = "Niveau Plateforme, Quai Central (00-210)",
            NoDepartement = 1,
            NoEmplacementEquipement = 5,
            EmplacementEquipementAutreSpecifierFr = "ST-370-124/22-01 (Sous-Station électrique 5kV)",
            InformationsSupplementairesFr = "<p style=\"background-color:transparent;color:#000000;font-family:Verdana,Geneva,sans-serif;font-size:12px;font-style:normal;font-variant:normal;font-weight:400;letter-spacing:normal;margin-bottom:12px;margin-left:0px;margin-right:0px;margin-top:0px;orphans:2;padding-bottom:0px;padding-left:2.4px;padding-right:2.4px;padding-top:0px;text-align:left;text-decoration:none;text-indent:0px;text-transform:none;-webkit-text-stroke-width:0px;white-space:normal;word-spacing:0px;\">Important: Ne jamais vous exposer à une chute vide car il y a un risque de projection. Il doit y avoir de la roche entre les chaînes.</p><p style=\"background-color:transparent;color:#000000;font-family:Verdana,Geneva,sans-serif;font-size:12px;font-style:normal;font-variant:normal;font-weight:400;letter-spacing:normal;margin-bottom:12px;margin-left:0px;margin-right:0px;margin-top:0px;orphans:2;padding-bottom:0px;padding-left:2.4px;padding-right:2.4px;padding-top:0px;text-align:left;text-decoration:none;text-indent:0px;text-transform:none;-webkit-text-stroke-width:0px;white-space:normal;word-spacing:0px;\">Se référer à la directive: LAR-MIN-DIR-2022 Accès et travaux près des marteaux.</p><br />",
            Photo = "../images/transformateur-portal.jpeg",
            DateCreation = DateTime.Now.AddDays(-5).AddHours(-3),
            DateModification = DateTime.Now.AddDays(-2).AddHours(-1),
            DescriptionLocalisationFr = "1500 - Salle des pompes (avec réservoir) fr",
            DescriptionLocalisationEn = "1500 - Salle des pompes (avec réservoir) en",
            DescriptionDepartementFr = "105 ECU - Salle de P-11-12-13-16-17-18-19 & compresseur. fr",
            DescriptionDepartementEn = "105 ECU - Salle de P-11-12-13-16-17-18-19 & compresseur. en",
            DescriptionEmplacementEquipementFr = "Salle entreposage équipements # 3 P169 fr",
            DescriptionEmplacementEquipementEn = "Salle entreposage équipements # 3 P169 en",
            DateUtilisation = DateTime.Now
        };
    }

    private static List<Accessoire>? InitializeMockAccessoire()
    {
        List<Accessoire> accessoires = new List<Accessoire>();

        accessoires.Add(
        new Accessoire
        {

            AccessoireId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionAccessoireFr = "Câble métalique 3 pieds",
            PhotoAccessoire = "../images/cable.png",
            Quantite = 1
        });

        accessoires.Add(
        new Accessoire
        {

            AccessoireId = Guid.NewGuid(),
            SocieteId = _societeId,
            PhotoAccessoire = "../images/cadenas.png",
            DescriptionAccessoireFr = "Cadenas",
            Quantite = 3
        });

        accessoires.Add(
        new Accessoire
        {

            AccessoireId = Guid.NewGuid(),
            SocieteId = _societeId,
            PhotoAccessoire = "../images/chaine.png",
            DescriptionAccessoireFr = "Chaîne",
            Quantite = 5
        });

        accessoires.Add(
        new Accessoire
        {

            AccessoireId = Guid.NewGuid(),
            SocieteId = _societeId,
            PhotoAccessoire = "../images/moraillon.png",
            DescriptionAccessoireFr = "Moraillon",
            Quantite = 2
        });

        return accessoires;
    }



    private static List<Participant>? InitializeMockParticipant()
    {
        List<Shared.Domain.Participant> infos = new List<Shared.Domain.Participant>();

        infos.Add(
        new Participant
        {
            ParticipantId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            Prenom = "Claire",
            Nom = "Lavoie",
            ParticipantActif = true,
            DateParticipant = DateTime.Now.AddHours(-22),
            DateHeure = DateTime.Now,
            StatutParticipant = Guid.NewGuid(),
            StatutParticipantDescription = "Rédaction"
        });

        infos.Add(
        new Participant
        {
            ParticipantId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            Prenom = "Yvon",
            Nom = "Lavallée",
            ParticipantActif = true,
            DateParticipant = DateTime.Now.AddHours(-12),
            DateHeure = DateTime.Now,
            StatutParticipant = Guid.NewGuid(),
            StatutParticipantDescription = "Validation"
        });

        infos.Add(
        new Participant
        {
            ParticipantId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            Prenom = "Idéphonse",
            Nom = "Laporte",
            ParticipantActif = true,
            DateParticipant = DateTime.Now.AddHours(-7),
            DateHeure = DateTime.Now,
            StatutParticipant = Guid.NewGuid(),
            StatutParticipantDescription = "Tester"
        });

        infos.Add(
        new Participant
        {
            ParticipantId = Guid.NewGuid(),
            UserId = Guid.NewGuid(),
            Prenom = "Louis",
            Nom = "Boucher",
            ParticipantActif = true,
            DateParticipant = DateTime.Now.AddHours(0),
            DateHeure = DateTime.Now,
            StatutParticipant = Guid.NewGuid(),
            StatutParticipantDescription = "Approuver"
        });

        return infos;
    }

    private static List<PreparationEtapeControle>? InitializeMockPreparationEtapeControle()
    {
        List<PreparationEtapeControle> infos = new List<PreparationEtapeControle>();

        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "Placer la porte au plus bas avant de procéder au cadenassage.",
            FaitPreparationEtapeControle = false,
            CategoriePreparationEtapeControle = 1, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });

        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "Préparer le cadenassage avec tous les accessoires.",
            FaitPreparationEtapeControle = false,
            CategoriePreparationEtapeControle = 1, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });

        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "Cadenassage ou décadenassage soyez vigilants.",
            FaitPreparationEtapeControle = false,
            CategoriePreparationEtapeControle = 1, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });

        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "Remplir le registre et se procurer le matériel de cadenassage.",
            FaitPreparationEtapeControle = false,
            CategoriePreparationEtapeControle = 1, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });

        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "Aviser le personnel concerné des travaux prévus.",
            FaitPreparationEtapeControle = false,
            CategoriePreparationEtapeControle = 1, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });

        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "Arrêter l'équipement selon la méthode appropriée.",
            FaitPreparationEtapeControle = true,
            CategoriePreparationEtapeControle = 1, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });

        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "Délimiter un périmètre de sécurité. (Si besoin) Seuls les travailleurs cadenassés peuvent se trouver dans la zone.",
            FaitPreparationEtapeControle = false,
            CategoriePreparationEtapeControle = 1, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });
        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "Placer la porte au plus bas avant de procéder au cadenassage.",
            FaitPreparationEtapeControle = false,
            CategoriePreparationEtapeControle = 1, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });



        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "RENORMALISER le train en remettant tous les éléments actionables dans leur état normal d'opération.",
            FaitPreparationEtapeControle = false,
            CategoriePreparationEtapeControle = 2, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });

        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "VÉRIFIER qu'aucun outil ou matériel n'ait été oublié dans la zone de travail et que tous les dispositifs d'isolation ont été renormalisés.",
            FaitPreparationEtapeControle = false,
            CategoriePreparationEtapeControle = 2, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });

        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "AVISER tout le personnel pouvant être affecté par la remise en état de service de l'équipement que les mécanismes de cadenassage ont été enlevés et que l'équipement est prêt à être utilisé.",
            FaitPreparationEtapeControle = false,
            CategoriePreparationEtapeControle = 2, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });

        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "ENLEVER les mécanismes de cadenassage des dispositifs d'isolation en suivant les instructions d'isolation en ordre inverse.",
            FaitPreparationEtapeControle = false,
            CategoriePreparationEtapeControle = 2, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });

        infos.Add(new PreparationEtapeControle
        {
            PreparationEtapeControleId = Guid.NewGuid(),
            SocieteId = _societeId,
            DescriptionPreparationEtapeControleFr = "VÉRIFIER que les dispositifs de sécurité sont en place, que l'aire de travail est nettoyée, que les outils et les articles non essentiels ont été enlevés de la zone de travail, que tout le personnel non requis ait quitté la zone dangereuse et que seul le personnel autorisé demeure sur place.",
            FaitPreparationEtapeControle = false,
            CategoriePreparationEtapeControle = 2, // 1 = Cadenassage, 2 = Décadenassage
            DateHeure = null
        });

        return infos;
    }

    private static List<EtapeMaitrise>? InitializeMockEtapeMaitrise()
    {
        List<EtapeMaitrise> infos = new List<EtapeMaitrise>();

        infos.Add(new EtapeMaitrise
        {
            EtapeMaitriseId = _etapeMaitriseId01,
            CategorieEtapeMaitrise = 1, // 1 = Cadenassage, 2 = Décadenassage
            NoFicheCadenassage = _ficheCadenassageId,
            EtapeMaitriseDepotId = Guid.NewGuid(),
            NoCategorieInstruction = Guid.NewGuid(),
            NoElement = Guid.NewGuid(),
            NoActionAPoser = Guid.NewGuid(),
            NoSourceEnergie = Guid.NewGuid(),
            NoPositionCadenassage = Guid.NewGuid(),
            NoEtape = 1,
            NoIdentification = "CLÉ B1, D1, B4 ou D4 avec l'indication MA005615",
            Emplacement = "HMI devant le cartonneur (à droite du magasin de cartons) ou tout autour de la machine (sous les lumières)",
            PhotoSourceEnergie = "../images/electricite.png",
            InformationsSupplementaires = "Si certain.e.s pourraient être découragé.e.s d'apprendre cette hausse, l’ARTM soutient dans un communiqué que cette indexation de 3 % demeure inférieure à l’inflation de 4,1% constatée dans la région métropolitaine au cours des douze derniers mois.",
            DateCreation = DateTime.Now,
            DateModification = DateTime.Now,
            NoPositionNormaleOperation = Guid.NewGuid(),
            DescriptionCategorieInstructionFr = "Cadenassage",
            DescriptionCategorieInstructionEn = "Lockout",
            DescriptionElementFr = "Disjoncteur",
            DescriptionElementEn = "Breaker",
            DescriptionActionAPoserFr = "Cadenasser",
            DescriptionActionAPoserEn = "Lockout",
            DescriptionSourceEnergieFr = "Électricité (240 Volts)",
            DescriptionSourceEnergieEn = "Electic (240 Volts)",
            DescriptionPositionCadenassageFr = "Ouvert",
            DescriptionPositionCadenassageEn = "Opened",
            DescriptionPositionCadenassagePositionNormaleFr = "Normalement Fermé",
            DescriptionPositionCadenassagePositionNormaleEn = "Normaly Closed",
            UsagerEtapeMaitriseFait = false
        });

        infos.Add(new EtapeMaitrise
        {
            EtapeMaitriseId = _etapeMaitriseId02,
            CategorieEtapeMaitrise = 1, // 1 = Cadenassage, 2 = Décadenassage
            NoFicheCadenassage = _ficheCadenassageId,
            EtapeMaitriseDepotId = Guid.NewGuid(),
            NoCategorieInstruction = Guid.NewGuid(),
            NoElement = Guid.NewGuid(),
            NoActionAPoser = Guid.NewGuid(),
            NoSourceEnergie = Guid.NewGuid(),
            NoPositionCadenassage = Guid.NewGuid(),
            NoEtape = 2,
            NoIdentification = "8979873495-DGFDG-56 AS-44",
            Emplacement = "Autour de la machine près des rayons X",
            PhotoSourceEnergie = "../images/electricite.png",
            InformationsSupplementaires = "",
            DateCreation = DateTime.Now,
            DateModification = DateTime.Now,
            NoPositionNormaleOperation = Guid.NewGuid(),
            DescriptionCategorieInstructionFr = "Vérification de mise à énergie zéro",
            DescriptionCategorieInstructionEn = "Energy zero",
            DescriptionElementFr = "Valve",
            DescriptionElementEn = "Valve",
            DescriptionActionAPoserFr = "Fermer",
            DescriptionActionAPoserEn = "Close",
            DescriptionSourceEnergieFr = "Eau chaude",
            DescriptionSourceEnergieEn = "Hot water",
            DescriptionPositionCadenassageFr = "Ouvert",
            DescriptionPositionCadenassageEn = "Opened",
            DescriptionPositionCadenassagePositionNormaleFr = "Normalement ouverte",
            DescriptionPositionCadenassagePositionNormaleEn = "Normaly Opened",
            UsagerEtapeMaitriseFait = false
        });

        infos.Add(new EtapeMaitrise
        {
            EtapeMaitriseId = _etapeMaitriseId03,
            CategorieEtapeMaitrise = 2, // 1 = Cadenassage, 2 = Décadenassage
            NoFicheCadenassage = _ficheCadenassageId,
            EtapeMaitriseDepotId = Guid.NewGuid(),
            NoCategorieInstruction = Guid.NewGuid(),
            NoElement = Guid.NewGuid(),
            NoActionAPoser = Guid.NewGuid(),
            NoSourceEnergie = Guid.NewGuid(),
            NoPositionCadenassage = Guid.NewGuid(),
            NoEtape = 1,
            NoIdentification = "8979873495-DGFDG-56 AS-44",
            Emplacement = "Autour de la machine près des rayons X",
            PhotoSourceEnergie = "../images/electricite.png",
            InformationsSupplementaires = "",
            DateCreation = DateTime.Now,
            DateModification = DateTime.Now,
            NoPositionNormaleOperation = Guid.NewGuid(),
            DescriptionCategorieInstructionFr = "Décadenassage",
            DescriptionCategorieInstructionEn = "Tagout",
            DescriptionElementFr = "Valve",
            DescriptionElementEn = "Valve",
            DescriptionActionAPoserFr = "Fermer",
            DescriptionActionAPoserEn = "Close",
            DescriptionActionAPoserInverseFr = "Ouvrir",
            DescriptionActionAPoserInverseEn = "Open",
            DescriptionSourceEnergieFr = "Eau chaude",
            DescriptionSourceEnergieEn = "Hot water",
            DescriptionPositionCadenassageFr = "Ouvert",
            DescriptionPositionCadenassageEn = "Opened",
            DescriptionPositionCadenassagePositionNormaleFr = "Normalement ouverte",
            DescriptionPositionCadenassagePositionNormaleEn = "Normaly Opened",
            UsagerEtapeMaitriseFait = false
        });

        return infos;
    }

    private static List<EtapeMaitriseAccessoire>? InitializeMockEtapeMaitriseAccessoire()
    {
        List<EtapeMaitriseAccessoire> infos = new List<EtapeMaitriseAccessoire>();

        infos.Add(new EtapeMaitriseAccessoire
        {
            EtapeMaitriseAccessoireId = Guid.NewGuid(),
            AccessoireId = _accessoireId01,
            EtapeMaitriseId = _etapeMaitriseId01,
            DescriptionAccessoireFr = "Câble métalique 3 pieds",
            DescriptionAccessoireEn = "3 feet Metalic Cable",
            PhotoAccessoire = "../images/cable.png",
            Quantite = 1

        });

        infos.Add(new EtapeMaitriseAccessoire
        {
            EtapeMaitriseAccessoireId = Guid.NewGuid(),
            AccessoireId = _accessoireId02,
            EtapeMaitriseId = _etapeMaitriseId01,
            DescriptionAccessoireFr = "Moraillon",
            DescriptionAccessoireEn = "Harsp",
            PhotoAccessoire = "../images/moraillon.png",
            Quantite = 1

        });

        infos.Add(new EtapeMaitriseAccessoire
        {
            EtapeMaitriseAccessoireId = Guid.NewGuid(),
            AccessoireId = _accessoireId03,
            EtapeMaitriseId = _etapeMaitriseId01,
            DescriptionAccessoireFr = "Chaîne",
            DescriptionAccessoireEn = "Chaine",
            PhotoAccessoire = "../images/chaine.png",
            Quantite = 2

        });

        infos.Add(new EtapeMaitriseAccessoire
        {
            EtapeMaitriseAccessoireId = Guid.NewGuid(),
            AccessoireId = _accessoireId03,
            EtapeMaitriseId = _etapeMaitriseId02,
            DescriptionAccessoireFr = "Chaîne",
            DescriptionAccessoireEn = "Chaine",
            PhotoAccessoire = "../images/chaine.png",
            Quantite = 3

        });


        return infos;
    }

    private static List<EtapeMaitrisePhoto>? InitializeMockEtapeMaitrisePhoto()
    {
        List<EtapeMaitrisePhoto> infos = new List<EtapeMaitrisePhoto>();

        infos.Add(
        new EtapeMaitrisePhoto
        {

            EtapeMaitrisePhotoId = Guid.NewGuid(),
            EtapeMaitriseId = _etapeMaitriseId01,
            DescriptionPhotoFr = "Disjoncteur panneau A-3245",
            Photo = "../images/disjoncteur01.jpg",
            DateCreation = DateTime.Now
        });
        infos.Add(
        new EtapeMaitrisePhoto
        {

            EtapeMaitrisePhotoId = Guid.NewGuid(),
            EtapeMaitriseId = _etapeMaitriseId01,
            DescriptionPhotoFr = "Disjoncteur BI-PHASE 345JK-DSF",
            Photo = "../images/disjoncteur02.jpg",
            DateCreation = DateTime.Now
        });
                infos.Add(
        new EtapeMaitrisePhoto
        {

            EtapeMaitrisePhotoId = Guid.NewGuid(),
            EtapeMaitriseId = _etapeMaitriseId01,
            DescriptionPhotoFr = "Disjoncteur OFF",
            Photo = "../images/disjoncteur03.jpg",
            DateCreation = DateTime.Now
        });

        infos.Add(
        new EtapeMaitrisePhoto
        {

        EtapeMaitrisePhotoId = Guid.NewGuid(),
        EtapeMaitriseId = _etapeMaitriseId02,
        DescriptionPhotoFr = "Valve Roff 45-SD",
        Photo = "../images/valve01.png",
        DateCreation = DateTime.Now
        });

        infos.Add(
        new EtapeMaitrisePhoto
        {

            EtapeMaitrisePhotoId = Guid.NewGuid(),
            EtapeMaitriseId = _etapeMaitriseId02,
            DescriptionPhotoFr = "Valve JHIIKJ",
            Photo = "../images/valve02.png",
            DateCreation = DateTime.Now
        });

        return infos;
    }
    }
