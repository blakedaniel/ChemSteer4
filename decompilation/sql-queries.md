# Literal SQL queries embedded in ChemSteer.exe

Every `"SELECT/INSERT/UPDATE/DELETE..."` string literal in the 
decompiled C# source. Roughly 1:1 with the SQL ChemSTEER actually 
issues at runtime.

_232 SQL literals across 46 files._

## `ChemStrX.cs`

- L656: `SELECT PCat FROM ListOfModels WHERE ModelID=`
- L772: `SELECT pCat FROM ListOfModels WHERE ModelID=`
- L2547: `SELECT * FROM qryGetParms`
- L3185: `SELECT * FROM qryGetParms`

## `Common.cs`

- L54: `SELECT * FROM States`

## `DBFuncs.cs`

- L206: `DELETE * FROM OPERATIONS WHERE OpName = '`
- L276: `UPDATE OPERATIONS SET OpName = '`
- L669: `SELECT * FROM Operations WHERE OpName='`
- L816: `SELECT ScenarioID FROM Operations WHERE OpName='`
- L828: `SELECT * FROM OpNaics WHERE ScenarioID=`
- L877: `SELECT * FROM Activities WHERE ScenarioID=`
- L970: `SELECT * FROM OpParms WHERE ScenarioID=`
- L1061: `SELECT * FROM ActContParms WHERE ScenarioID=`
- L1132: `SELECT * FROM GSSOptions WHERE ScenarioID=`
- L1256: `SELECT * FROM ActRelModels WHERE ScenarioID=`
- L1258: `SELECT * FROM ActRelModParms WHERE RelParmsAN=0`
- L1260: `SELECT * FROM ActRelModMedia WHERE ScenarioID=`
- L1501: `SELECT * FROM ActExpModels WHERE ScenarioID=`
- L1503: `SELECT * FROM ActExpModParms WHERE ExpParmsAN=0`
- L2285: `SELECT crDate FROM Assessments WHERE AssessID=1`
- L2304: `SELECT * FROM Assessments WHERE AssessID=`
- L2777: `SELECT AssType FROM ListOfAssessTypes WHERE AssTypeID=`
- L2828: `SELECT AssStatus FROM ListOfAssStatus WHERE AssStatusID=`
- L3624: `SELECT * FROM Operations WHERE AssessID=`
- L3655: `SELECT * FROM OpNaics WHERE AssessID=`
- L3663: `Select naics, naicsdesc FROM NAICS`
- L3706: `SELECT * FROM OpSites WHERE AssessID=`
- L3761: `SELECT * FROM Activities WHERE AssessID=`
- L3788: `SELECT * FROM OpRel WHERE AssessID=`
- L3819: `SELECT * FROM OpParms WHERE AssessID=`
- L3842: `SELECT * FROM ActContParms WHERE AssessID=`
- L3865: `SELECT * FROM GSSOptions WHERE AssessID=`
- L4590: `SELECT * FROM Chemicals WHERE AssessID=`
- L4846: `SELECT * FROM ActRelModels WHERE AssessID=`
- L4848: `SELECT * FROM ActRelModParms WHERE RelParmsAN=0`
- L4850: `SELECT * FROM ActRelModMedia WHERE AssessID=`
- L5102: `SELECT * FROM ContactRpts WHERE AssessID=`
- L5206: `SELECT * FROM ActExpModels WHERE AssessID=`
- L5238: `SELECT * FROM ActExpModParms WHERE ExpParmsAN=`
- L5247: `SELECT * FROM ActExpModEst WHERE ExpParmsAN=`
- L5754: `SELECT * FROM ActRelModels WHERE AssessID=`
- L5897: `SELECT * FROM ActRelModParms WHERE RelParmsAN=`
- L5923: `SELECT MediaID, Pct FROM ActRelModMedia WHERE AssessID=`
- L6079: `SELECT * FROM MSDS_ExpLimits WHERE AssessID=`
- L6106: `SELECT * FROM SAT WHERE AssessID=`
- L6232: `SELECT * FROM MSDS_ExpLimits WHERE AssessID=`
- L6245: `SELECT * FROM SAT WHERE AssessID=`
- L6390: `SELECT * FROM ContactRpts WHERE AssessID=`
- L6515: `SELECT * FROM ListOfMedia ORDER BY SortID`
- L6533: `SELECT * FROM IrerRels WHERE AssessID=`
- L7402: `SELECT * FROM Operations WHERE AssessID=`
- L7434: `SELECT * FROM OpNaics WHERE AssessID=`
- L7455: `SELECT * FROM OpSites WHERE AssessID=`
- L7476: `SELECT * FROM Activities WHERE AssessID=`
- L7497: `SELECT * FROM OpRel WHERE AssessID=`
- L7518: `SELECT * FROM OpParms WHERE AssessID=`
- L7546: `SELECT * FROM ActContParms WHERE AssessID=`
- L7601: `SELECT * FROM GSSOptions WHERE AssessID=`
- L8336: `SELECT * FROM ActExpModels WHERE AssessID=`
- L8338: `SELECT * FROM ActExpModParms WHERE ExpParmsAN=0`
- L8340: `SELECT * FROM ActExpModEst WHERE ExpParmsAN=0`
- L8615: `SELECT * FROM Chemicals WHERE AssessID=`
- L9244: `SELECT * FROM Assessments WHERE AssessID=`
- L9268: `INSERT INTO ASSESSMENTS (EPAIDNumber) VALUES('_')`
- L9283: `SELECT * FROM Assessments WHERE EPAIDNumber='_'`
- L9923: `SELECT AssessID FROM Assessments`
- L10148: `SELECT * FROM RevisionHistory WHERE RevisionID=0`

## `ExpModels.cs`

- L91: `SELECT ModelName FROM ListOfModels WHERE ModelID=`
- L97: `SELECT ActName FROM ListOfActivities WHERE ActID=`

## `RelModels.cs`

- L122: `SELECT ModelName FROM ListOfModels WHERE ModelID=`
- L126: `SELECT ActName FROM ListOfActivities WHERE ActID=`

## `crDriver.cs`

- L92: `Select a folder and file name for your Contact report`
- L180: `SELECT * FROM SAT WHERE AssessID=`
- L395: `Select a folder and file name for your IRER report`

## `frmMDAddExpModel.cs`

- L567: `SELECT * FROM qryListOfDExpModels`
- L577: `SELECT * FROM qryListOfIExpModels`

## `frmMDAddRelModel.cs`

- L948: `SELECT * FROM qryListOfRelModels`
- L1478: `SELECT * FROM qryListOfRelModels`

## `frmMDCalcCtw.cs`

- L1352: `Select or enter an alternative chemical function/concentration within the cooling tower.`
- L1402: `Select or enter an alternative water recirculation rate within the cooling tower.`

## `frmMDCalcNS.cs`

- L1083: `Select a method for deriving Number of Sites`

## `frmMDCalcYprod.cs`

- L1216: `Select a new default for Yprod and press the OK button.`

## `frmMDDeleteGSS.cs`

- L244: `Delete`
- L272: `Delete Generic Scenario Operation`
- L301: `SELECT * FROM qryListGSS`
- L366: `Delete Generic Scenario Operation`
- L369: `Delete Generic Scenario`

## `frmMDPrefs.cs`

- L1143: `Select the ChemSTEER database you wish to make your default database`
- L1150: `Select the CRSS database you wish to make your default database`

## `frmMDRenameGSS.cs`

- L418: `SELECT * FROM qryListGSS`

## `frmMDRevisionHistory.cs`

- L435: `SELECT * FROM qryRevisionHistory WHERE AssessID=`

## `frmMDSaveGSS.cs`

- L327: `Select PDF`
- L381: `Select the operation you wish to save as a GSS.`
- L389: `SELECT * FROM Operations WHERE OpName='`
- L471: `Select the PDF file you would like associated with this GSS`
- L495: `SELECT GSS_PDF FROM Operations WHERE OpName='`

## `frmMDSelAss.cs`

- L1245: `Select Assessment`
- L1344: `SELECT * FROM ListOfAssessTypes`
- L1352: `SELECT * FROM ListOfAssStatus`

## `frmMDUpdAct.cs`

- L916: `Update Operation Sources/Activities`
- L1312: `SELECT * FROM qryListActCats`
- L1909: `SELECT * FROM qryListActCats`
- L1916: `SELECT ActID FROM ListOfValidActivities WHERE OpID=`

## `frmMDUpdChem.cs`

- L2996: `Update Chemical Information`

## `frmMDUpdExp.cs`

- L1016: `Update Exposure-Based Criteria`

## `frmMDUpdExpMod.cs`

- L2016: `SELECT * FROM qryListOfModelDescriptors`
- L2086: `SELECT * FROM qryListChemStatesD`
- L2090: `SELECT * FROM qryListChemStatesI`

## `frmMDUpdGen.cs`

- L2231: `Update General Information`
- L2405: `SELECT * FROM ListOfAssessTypes`
- L2413: `SELECT * FROM ListOfAssStatus`

## `frmMDUpdLVE.cs`

- L782: `Update Special LVE Considerations`

## `frmMDUpdLvePpe.cs`

- L389: `Update LVE Personal Protective Equipment`

## `frmMDUpdMsdsGE.cs`

- L668: `Update MSDS Requirements`

## `frmMDUpdMsdsTLV.cs`

- L1384: `Update Exposure Limits`
- L1507: `Update Exposure Limits`
- L1597: `Update Exposure Limits`

## `frmMDUpdNW.cs`

- L625: `Update Operation Total Number of Workers`

## `frmMDUpdNotepad.cs`

- L393: `Update Revision Notes / Assessment Overview`
- L398: `Update Additional Notes for the Release Summary`

## `frmMDUpdOpIP.cs`

- L3749: `Select type of operation and whether to use raw material or product`
- L4505: `Update Operation Mass Accounting Parameters`

## `frmMDUpdOps.cs`

- L1339: `Select assessment database`
- L2095: `SELECT * FROM qryListOfOperations WHERE OpID < 100`
- L2107: `SELECT * FROM qryListGSS`
- L4554: `SELECT * FROM Operations WHERE OpName='`
- L4666: `SELECT * FROM OpNaics WHERE ScenarioID=`
- L4731: `SELECT * FROM Activities WHERE ScenarioID=`
- L4746: `SELECT * FROM OpParms WHERE ScenarioID=`
- L4761: `SELECT * FROM ActContParms WHERE ScenarioID=`
- L4776: `SELECT * FROM GSSOptions WHERE ScenarioID=`
- L4791: `SELECT * FROM ActRelModels WHERE ScenarioID=`
- L4806: `SELECT * FROM ActExpModels WHERE ScenarioID=`
- L4962: `SELECT * FROM ActExpModParms WHERE ExpParmsAN=`
- L5097: `SELECT * FROM ActRelModParms WHERE RelParmsAN=`
- L5112: `SELECT MediaID, Pct FROM ActRelModMedia WHERE scenarioID=`
- L6169: `Select the ChemSTEER database from which you wish to import an operation`
- L6192: `SELECT dataVersion, crVersion, crDate FROM Tron`
- L6204: `SELECT * FROM qryOpen`
- L6246: `SELECT * FROM Operations WHERE AssessID=`
- L6641: `SELECT * FROM Operations WHERE AssessID=`
- L6773: `SELECT * FROM OpNaics WHERE AssessID=`
- L6838: `SELECT * FROM Activities WHERE AssessID=`
- L6853: `SELECT * FROM OpParms WHERE AssessID=`
- L6868: `SELECT * FROM ActContParms WHERE AssessID=`
- L6883: `SELECT * FROM GSSOptions WHERE AssessID=`
- L7313: `SELECT * FROM ActRelModels WHERE AssessID=`
- L7432: `SELECT * FROM ActRelModParms WHERE RelParmsAN=`
- L7458: `SELECT MediaID, Pct FROM ActRelModMedia WHERE AssessID=`
- L7593: `SELECT * FROM ActExpModels WHERE AssessID=`
- L7666: `SELECT * FROM ActExpModParms WHERE ExpParmsAN=`

## `frmMDUpdOptData.cs`

- L369: `Update P2 Considerations`
- L375: `Update Assumptions`

## `frmMDUpdOtherUses.cs`

- L736: `Update Other Uses and Consumer Use`

## `frmMDUpdPD.cs`

- L1134: `Update Operation Description`
- L1270: `SELECT * FROM NAICS ORDER BY NAICS`
- L1429: `SELECT * FROM NAICS`

## `frmMDUpdPS.cs`

- L894: `Update Operation Physical State`
- L971: `SELECT * FROM ListOfPhyStates`

## `frmMDUpdRelMed.cs`

- L3087: `Update Release Media Output Specifications`
- L3219: `SELECT * FROM qryListOfMedia`

## `frmMDUpdRelMod.cs`

- L1838: `SELECT * FROM qryListOfModelDescriptors`

## `frmMDUpdRels.cs`

- L780: `Update Operation Relationships`

## `frmMDUpdSat.cs`

- L2147: `Update SAT Data`
- L2372: `SELECT * FROM qryTrtSatRatings`
- L2391: `SELECT * FROM qryTrtM2G`

## `frmMDUpdSites.cs`

- L1700: `Update the operation's site information`
- L1841: `Update the operation's site information`
- L2025: `Update the operation's site information`

## `frmMain.cs`

- L13390: `Update NAICS and Description`
- L13477: `Update Physical State`
- L13697: `Update &Relationships`
- L13910: `Update &Sources/Activities`
- L13981: `Select the desired operation, source, and release model below. Read the \`
- L14540: `Select the desired operation and worker activity below. Read the \`
- L16260: `Update Optional Information`
- L18508: `Update General Information`
- L18523: `Update Revision Notes / Assessment Overview`
- L19328: `Select an operation below to change/update the mass balance parameters, container parameters, or shared parameters/factors.`
- L19737: `Update AVPrange`
- L19839: `Update Parameters`
- L21095: `SELECT dataVersion, crVersion, crDate FROM Tron`
- L22993: `SELECT * FROM qryListOfOptData`
- L23000: `SELECT * FROM ListOfParms`
- L23017: `SELECT ParmID FROM ListOfParms ORDER BY Abbr, ParmName`
- L23546: `SELECT * FROM qryGetParms`
- L24336: `SELECT * FROM qryListOfDExpModels`
- L24354: `SELECT * FROM qryListOfIExpModels`
- L24512: `SELECT * FROM qryListOfRelModels`
- L25870: `Select the ChemSTEER database containing the assessment you wish to delete`
- L25891: `SELECT * FROM qryOpen`
- L25940: `DELETE FROM Assessments WHERE AssessID=`
- L26059: `SELECT * FROM Chemsteer`
- L26218: `SELECT * FROM Chemsteer WHERE [PMN number]='`
- L26509: `SELECT AssType FROM ListOfAssessTypes WHERE AssTypeID=`
- L26528: `SELECT AssStatus FROM ListOfAssStatus WHERE AssStatusID=`
- L26927: `Select the ChemSTEER database you wish to open`
- L26999: `SELECT * FROM qryOpen`
- L27083: `SELECT dataVersion, crVersion, crDate FROM Tron`
- L27269: `SELECT * FROM OpNaics WHERE AssessID=`
- L27586: `Select a folder and name for your ChemSTEER database`
- L27693: `SELECT dataVersion FROM Tron`
- L27759: `DELETE * FROM Assessments WHERE AssessID=`
- L27871: `SELECT * FROM Chemsteer`
- L28674: `Update Parameters`
- L28675: `Update Parameters\`
- L28679: `Update Container Parameters`
- L28687: `Select the appropriate subtab below and click the 'Update Container Parameters' to specify the container size, fraction of total volume shipped in each type of container, unloading/loading rate, etc.`
- L28691: `Update Available Shared Parameters/Factors`
- L28698: `Update AVP Range`
- L28700: `Update Available Shared Parameters/Factors\`
- L28948: `Update Relationships\`
- L28961: `Update NAICS and Description\`
- L28974: `Update Physical States\`
- L28987: `Update Sources/Activities\`
- L29000: `Update Site Information\`
- L29173: `SELECT * FROM ListOfMedia ORDER BY MediaID`
- L29838: `Select the replacement scenarios.epa`

## `frmSelectEasyModel.cs`

- L392: `Select a model to run. You can only select one model. If you have changed your mind and do not want to run a model, select the Cancel button and you will be taken to the regular ChemSTEER screen.`
- L457: `Select a model`
- L590: `SELECT * FROM qryListOfRelModels WHERE MODELID NOT IN (12,13,14,51,52)`
- L612: `SELECT * FROM qryListOfDExpModels`
- L634: `SELECT * FROM qryListOfIExpModels`

## `frmUpdSP.cs`

- L3595: `Update Shared Parameter`
- L3632: `Update the Automotive Spray Coating Model Factors below`
- L3665: `Update the Vapor Pressure Correction Factor below`
- L3666: `Update Vapor Pressure Correction Factor`
- L3734: `Update the Electroplating Additive Type below`

## `frmUpdVP.cs`

- L442: `Update AVPrange`

## `frmViewCRSS.cs`

- L1793: `SELECT * FROM Chemsteer WHERE [PMN number]='`

## `frmViewPels.cs`

- L3982: `SELECT * FROM pel_rel_twa`

## `frmWaterAndInhBasis.cs`

- L424: `Select standard text`
