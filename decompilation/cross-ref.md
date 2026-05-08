# DB tables ↔ decompiled C# files

Map of every table in the three Access DBs to the decompiled 
source files that reference it (literal-string match).

| Table | DB | Files referencing |
|---|---|---|
| `ActCats` | ChmSteer | _(no references found)_ |
| `ActContParms` | MDBShell | `DBFuncs.cs`, `frmMDUpdOps.cs` |
| `ActExpModEst` | MDBShell | `DBFuncs.cs` |
| `ActExpModParms` | MDBShell | `DBFuncs.cs`, `frmMDUpdOps.cs` |
| `ActExpModels` | MDBShell | `DBFuncs.cs`, `frmMDUpdOps.cs` |
| `ActRelModMedia` | MDBShell | `DBFuncs.cs`, `frmMDUpdOps.cs` |
| `ActRelModParms` | MDBShell | `DBFuncs.cs`, `frmMDUpdOps.cs` |
| `ActRelModels` | MDBShell | `DBFuncs.cs`, `frmMDUpdOps.cs` |
| `Activities` | MDBShell | `DBFuncs.cs`, `frmMDUpdAct.cs`, `frmMDUpdCombRel.cs`, `frmMDUpdNW.cs`, `frmMDUpdOps.cs`, `frmMain.cs`, `protocomb.cs` |
| `Assessments` | MDBShell | `DBFuncs.cs`, `frmMDUpdContRpts.cs`, `frmMain.cs` |
| `Chemicals` | MDBShell | `DBFuncs.cs`, `frmMain.cs` |
| `Codes` | ChmSteer | _(no references found)_ |
| `ContactRpts` | MDBShell | `DBFuncs.cs` |
| `GSSOptions` | MDBShell | `DBFuncs.cs`, `frmMDUpdOps.cs` |
| `GssAutoSelectActs` | ChmSteer | _(no references found)_ |
| `Instructions` | ChmSteer | `frmMDSelAss.cs` |
| `IrerRels` | MDBShell | `DBFuncs.cs` |
| `ListOfActCats` | ChmSteer | _(no references found)_ |
| `ListOfActivities` | ChmSteer | `ExpModels.cs`, `RelModels.cs` |
| `ListOfAssStatus` | ChmSteer | `DBFuncs.cs`, `frmMDSelAss.cs`, `frmMDUpdGen.cs`, `frmMain.cs` |
| `ListOfAssessTypes` | ChmSteer | `DBFuncs.cs`, `frmMDSelAss.cs`, `frmMDUpdGen.cs`, `frmMain.cs` |
| `ListOfChemStates` | ChmSteer | _(no references found)_ |
| `ListOfMedia` | ChmSteer | `DBFuncs.cs`, `frmMain.cs` |
| `ListOfModels` | ChmSteer | `ChemStrX.cs`, `ExpModels.cs`, `RelModels.cs` |
| `ListOfOperations` | ChmSteer | _(no references found)_ |
| `ListOfOptData` | ChmSteer | _(no references found)_ |
| `ListOfParms` | ChmSteer | `frmMain.cs` |
| `ListOfPhyStates` | ChmSteer | `frmMDUpdPS.cs` |
| `ListOfValidActivities` | ChmSteer | `frmMDUpdAct.cs` |
| `ListOfValidModels` | ChmSteer | _(no references found)_ |
| `MSDS_ExpLimits` | MDBShell | `DBFuncs.cs` |
| `MediaDefaults` | ChmSteer | _(no references found)_ |
| `Meta2Defaults` | ChmSteer | _(no references found)_ |
| `MostLikelyActs` | ChmSteer | _(no references found)_ |
| `NAICS` | ChmSteer | `DBFuncs.cs`, `frmMDUpdOps.cs`, `frmMDUpdPD.cs`, `frmMain.cs` |
| `OpNAICS` | MDBShell | _(no references found)_ |
| `OpParms` | MDBShell | `DBFuncs.cs`, `frmMDUpdOps.cs` |
| `OpRel` | MDBShell | `DBFuncs.cs` |
| `OpSites` | MDBShell | `DBFuncs.cs` |
| `Operations` | MDBShell | `DBFuncs.cs`, `frmMDSaveGSS.cs`, `frmMDUpdOpIP.cs`, `frmMDUpdOps.cs`, `frmMDUpdRels.cs`, `frmMain.cs` |
| `ParmDefaults` | ChmSteer | _(no references found)_ |
| `ParmLabelOverrides` | ChmSteer | _(no references found)_ |
| `RelGroups` | MDBShell | _(no references found)_ |
| `RevisionHistory` | MDBShell | `DBFuncs.cs` |
| `SAT` | MDBShell | `DBFuncs.cs`, `crDriver.cs`, `frmMDUpdSat.cs`, `frmMain.cs` |
| `States` | ChmSteer | `Common.cs`, `frmMain.cs` |
| `Tron` | MDBShell | `DBFuncs.cs`, `frmMDUpdOps.cs`, `frmMain.cs` |
| `pel_rel_twa` | ChmSteer | `frmViewPels.cs` |