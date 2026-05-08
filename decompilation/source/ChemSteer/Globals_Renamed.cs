using System;
using System.Drawing;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

[StandardModule]
internal sealed class Globals_Renamed
{
	public const string gblAppName = "ChemSTEER v3.2";

	public const string gblVersion = "Version 3.2";

	public const string gblVersionNmbr = "v3.2";

	public const string gblVersionDate = "May 12, 2016";

	public static string gblDBName;

	public static short gblAssessID;

	public static DateTime gblCRdate;

	public static bool gblIWasChanged;

	public static short gblPreviousType;

	public static short gblPreviousStatus;

	public static string gblPreviousYear;

	public static string gblPreviousID;

	public static string gblChemDateFormat = "MM/dd/yyyy";

	public static bool gblOpenMainAgain;

	public static bool gblDoEasyModels;

	public static bool gblAuthorizedUser;

	public static int gblImportAssessID;

	public const string gblDefaultVPlow = "0.001";

	public const string gblDefaultVPhigh = "35";

	public static short gblCurrentDV;

	public static short gblCurrentCR;

	public static short gblDataVersion;

	public static short gblFrmStartupUnloaded;

	public static short gblNumMetaNonDefaults;

	public static object[] gblMetaNonDefaults;

	public static object[] gblMetaNonDefaultCaps;

	public static Color gblColorOn;

	public static Color gblColorOff;

	public static Color gblTextOn;

	public static Color gblTextOff;

	public const double gcPI = 3.14159265359;

	public const short MaxModelsPerAct = 10;

	public const short MaxActsPerOp = 25;

	public const short MaxMedias = 18;

	public const short MaxModParms = 162;

	public const short MaxOpParms = 162;

	public const short MaxModOutputs = 18;

	public const short MaxContParms = 15;

	public const short MaxOpAttr = 99;

	public const short MaxOpChildren = 10;

	public const short MaxOpSpParms = 48;

	public const short MaxMiscOpParms = 2;

	public const short MaxGssOptions = 5;

	public static bool[] arParmValid = new bool[163];

	public static float[] arParmValues = new float[163];

	public static bool[] arParmValidSave = new bool[163];

	public static string[] arParmNames = new string[163];

	public static string[] arParmUnits = new string[163];

	public static short[] arParmType = new short[163];

	public static short[] arParmDS = new short[163];

	public static float[] arOutput = new float[19];

	public static short[] arParmOrder = new short[163];

	public const short gcYsOutput = 0;

	public const short gcNS = 1;

	public const short gcOD = 2;

	public const short gcOH = 3;

	public const short gcVP = 4;

	public const short gcMW = 5;

	public const short gcR = 6;

	public const short gcP = 7;

	public const short gcT = 8;

	public const short gcWFUsed = 9;

	public const short gcYprod = 10;

	public const short gcYrm = 11;

	public const short gcDMOProd = 12;

	public const short gcDMOchem = 13;

	public const short gcDMIrm = 14;

	public const short gcDMIchem = 15;

	public const short gcNby = 16;

	public const short gcNbd = 17;

	public const short gcODMax = 18;

	public const short gcVc = 19;

	public const short gcfc = 20;

	public const short gcVcar = 21;

	public const short gcf = 22;

	public const short gcrRE = 23;

	public const short gcNbld = 24;

	public const short gcNcar = 25;

	public const short gcdCB = 26;

	public const short gcVpaint = 27;

	public const short gcAcb = 28;

	public const short gcDrm = 29;

	public const short gcDprod = 30;

	public const short gcOHa = 31;

	public const short gcBMOprod = 32;

	public const short gcBMIChem_x_Nbd_y_Ls = 33;

	public const short gcHMxChem = 34;

	public const short gcHD = 35;

	public const short gcSconstant = 36;

	public const short gcQuConstant = 37;

	public const short gcEPA_1 = 39;

	public const short gcX = 40;

	public const short gcEY = 41;

	public const short gcBW = 42;

	public const short gcTE = 43;

	public const short gcb = 44;

	public const short gcMcE = 45;

	public const short gchCB = 46;

	public const short gcAT = 47;

	public const short gcATc = 48;

	public const short gcGinput = 49;

	public const short gcGoutput = 50;

	public const short gckCB = 51;

	public const short gcSrE = 52;

	public const short gcQcb = 53;

	public const short gcCmCvOption = 54;

	public const short gcS = 55;

	public const short gcQuCB = 56;

	public const short gcKcKmeta2 = 57;

	public const short gcSQuCB = 58;

	public const short gcYmist = 59;

	public const short gcFT = 60;

	public const short gcAH = 61;

	public const short gcKCk = 62;

	public const short gcVm = 63;

	public const short gcCmInput = 64;

	public const short gcCmOutput = 65;

	public const short gcCvOutput = 66;

	public const short gcCvInput = 67;

	public const short gcYsf = 68;

	public const short gcVzCB = 69;

	public const short gcKCkConstant = 70;

	public const short gchConstant = 71;

	public const short gcFreq = 72;

	public const short gcLFnoUD = 73;

	public const short gcLFautos = 74;

	public const short gcED = 75;

	public const short gcYl = 76;

	public const short gcYderm = 77;

	public const short gcYs = 78;

	public const short gcCF = 79;

	public const short gcWSchem = 80;

	public const short gcEF = 81;

	public const short gcSd = 82;

	public const short gcBMIrm_x_Nbd = 83;

	public const short gcBMIrm_x_Nbd_y_Ls = 84;

	public const short gcBMOprod_x_Nbd = 85;

	public const short gcBMOprod_x_Nbd_y_Ls = 86;

	public const short gcMCi_x_Ncd = 87;

	public const short gcBMIrm_x_Ls = 88;

	public const short gcBMOprod_x_Ls = 89;

	public const short gcCvk = 90;

	public const short gcNWexp = 91;

	public const short gcAmtToUse = 92;

	public const short gcODa = 93;

	public const short gcYi = 94;

	public const short gcVPpel = 95;

	public const short gcYpel = 96;

	public const short gcMWpel = 97;

	public const short gc250 = 98;

	public const short gcBMIrm = 99;

	public const short gcDi = 100;

	public const short gcHB = 101;

	public const short gcLs = 102;

	public const short gcBMIchem = 103;

	public const short gcBMOchem = 104;

	public const short gcNcy = 105;

	public const short gcBMOchem_x_Nbd = 106;

	public const short gcBMIchem_x_Nbd = 107;

	public const short gcBMOchem_x_Ls = 108;

	public const short gcBMIchem_x_Ls = 109;

	public const short gcMCi = 110;

	public const short gcMCi_x_Yi = 111;

	public const short gcMCi_x_Yi_x_Ncd = 112;

	public const short gcYsNonMeta = 113;

	public const short gcAMOprod = 114;

	public const short gcVbatch = 115;

	public const short gcDVIppaint = 116;

	public const short gcLF = 117;

	public const short gcXrm = 118;

	public const short gcXprod = 119;

	public const short gcXother = 120;

	public const short gcAVPrm = 121;

	public const short gcAVPprod = 122;

	public const short gcBMOChem_x_Nbd_y_Ls = 123;

	public const short gcYctw = 124;

	public const short gcDctw = 125;

	public const short gcRRctw = 126;

	public const short gcLFb = 127;

	public const short gcLFw = 128;

	public const short gcLFe = 129;

	public const short gcDRRchem = 130;

	public const short gcYbath = 131;

	public const short gcYrinse = 132;

	public const short gcDbath = 133;

	public const short gcDrinse = 134;

	public const short gcVbath = 135;

	public const short gcNbath = 136;

	public const short gcFreqbath = 137;

	public const short gcDVrinse = 138;

	public const short gcRinseE = 139;

	public const short gcEPVop = 140;

	public const short gcDVbath = 141;

	public const short gcWWTE = 142;

	public const short gcDstCntrl = 143;

	public const short gcSrEdc = 144;

	public const short gcVff = 145;

	public const short gcAer = 146;

	public const short gcVelocityNF = 147;

	public const short gcLnf = 148;

	public const short gcWnf = 149;

	public const short gcHnf = 150;

	public const short gcG = 151;

	public const short gcI = 152;

	public const short gcCnfOutput = 153;

	public const short gcCffOutput = 154;

	public const short rmA1 = 7;

	public const short rmA2 = 8;

	public const short rmA3 = 9;

	public const short rmA4 = 1;

	public const short rmA5 = 2;

	public const short rmA6 = 3;

	public const short rmA7 = 4;

	public const short rmA8 = 5;

	public const short rmA9 = 6;

	public const short rmA10 = 48;

	public const short rmA11 = 41;

	public const short rmCoolingTowerBlowdown = 12;

	public const short rmCoolingTowerWindage = 13;

	public const short rmCoolingTowerEvaporative = 14;

	public const short rmA21 = 39;

	public const short rmA22 = 42;

	public const short rmA23 = 43;

	public const short rmElectroSpentBath = 51;

	public const short rmElectroRinseWater = 52;

	public const short rmDustModel = 53;

	public const short emB1 = 21;

	public const short emB2 = 22;

	public const short emB3 = 23;

	public const short emB4 = 24;

	public const short emB5 = 49;

	public const short emB6 = 50;

	public const short emB7 = 40;

	public const short emB8 = 46;

	public const short emB9 = 25;

	public const short emB10 = 26;

	public const short emB11 = 27;

	public const short emB12 = 28;

	public const short emB13 = 29;

	public const short emB17 = 44;

	public const short emB18 = 18;

	public const short emB19 = 45;

	public const short emB20 = 47;

	public const short emB21 = 54;

	public static short intNumOps;

	public static double[] arOpPv = new double[2];

	public static bool[] arNoPre = new bool[2];

	public static short[,] arSubOpID = new short[2, 2];

	public static float[,] arSubPVf = new float[2, 2];

	public static double[,] arSubPvOp = new double[2, 2];

	public static string[] arPSInto1 = new string[2];

	public static string[] arPSInto2 = new string[2];

	public static string[] arPSOut1 = new string[2];

	public static string[] arPSOut2 = new string[2];

	public static string[] arPSIn1 = new string[2];

	public static string[] arPSIn2 = new string[2];

	public static string[] arPDesc = new string[2];

	public static string[,] arNaics1 = new string[2, 2];

	public static string[,] arNaics2 = new string[2, 2];

	public static float[,] arMiscOpParms = new float[2, 2];

	public static short[,] arGssOptions = new short[2, 2];

	public static string[,] arGssOther = new string[2, 2];

	public static string[] arBasis = new string[2];

	public static string[] arWaterBasis = new string[2];

	public static string[] arInhalationBasis = new string[2];

	public static string[] arDermalBasis = new string[2];

	public static string[] arRelAddNotes = new string[2];

	public static string[] arExpAddNotes = new string[2];

	public static long[,] arOpNumWorkers = new long[2, 2];

	public static string[] arOpNumWorkersBasis = new string[2];

	public static short[] arOpNumWorkersBasisEnabled = new short[2];

	public static string[,] arOSName = new string[2, 2];

	public static string[,] arOSAddr = new string[2, 2];

	public static string[,] arOSCity = new string[2, 2];

	public static string[,] arOSState = new string[2, 2];

	public static string[,] arOSZip = new string[2, 2];

	public static string[,] arOSCty = new string[2, 2];

	public static float[,] arOpParms = new float[2, 2];

	public static short[,] arOpParmsType = new short[2, 2];

	public static short[] arOpBorC = new short[2];

	public const short gcOpIsCont = 0;

	public const short gcOpIsBatch = 1;

	public static short[] arOpIoE = new short[2];

	public const short gcOpIsRawMaterial = 0;

	public const short gcOpIsProduct = 1;

	public static int[,] arOpMassBalDisc = new int[2, 2];

	public static float[,] arOpSP = new float[2, 2];

	public static short[,] arOpSPType = new short[2, 2];

	public const short gcXoptionRaoultsFormula = 3;

	public const short gcSprayGunType = 1;

	public const short gcOverSprayCntlType = 2;

	public const short gcBoothVentType = 3;

	public const short gcSpXrm_option = 4;

	public const short gcSpXprod_option = 5;

	public const short gcSpXother_option = 6;

	public const short gcSpXrm_Ya1 = 7;

	public const short gcSpXrm_Ya2 = 8;

	public const short gcSpXrm_Ya3 = 9;

	public const short gcSpXrm_Ya4 = 10;

	public const short gcSpXrm_Ya5 = 11;

	public const short gcSpXrm_MWa1 = 12;

	public const short gcSpXrm_MWa2 = 13;

	public const short gcSpXrm_MWa3 = 14;

	public const short gcSpXrm_MWa4 = 15;

	public const short gcSpXrm_MWa5 = 16;

	public const short gcSpXrm_RL = 17;

	public const short gcSpXrm_US = 18;

	public const short gcSpXprod_Ya1 = 19;

	public const short gcSpXprod_Ya2 = 20;

	public const short gcSpXprod_Ya3 = 21;

	public const short gcSpXprod_Ya4 = 22;

	public const short gcSpXprod_Ya5 = 23;

	public const short gcSpXprod_MWa1 = 24;

	public const short gcSpXprod_MWa2 = 25;

	public const short gcSpXprod_MWa3 = 26;

	public const short gcSpXprod_MWa4 = 27;

	public const short gcSpXprod_MWa5 = 28;

	public const short gcSpXprod_RL = 29;

	public const short gcSpXprod_US = 30;

	public const short gcSpXother_Ya1 = 31;

	public const short gcSpXother_Ya2 = 32;

	public const short gcSpXother_Ya3 = 33;

	public const short gcSpXother_Ya4 = 34;

	public const short gcSpXother_Ya5 = 35;

	public const short gcSpXother_MWa1 = 36;

	public const short gcSpXother_MWa2 = 37;

	public const short gcSpXother_MWa3 = 38;

	public const short gcSpXother_MWa4 = 39;

	public const short gcSpXother_MWa5 = 40;

	public const short gcSpXother_RL = 41;

	public const short gcSpXother_US = 42;

	public const short gcSpShowAuto = 43;

	public const short gcSpShowVP = 44;

	public const short gcSpShowAmt = 45;

	public const short gcSpShowElec = 46;

	public const short gcSpElecAddtvType = 47;

	public static short[] arOpType = new short[2];

	public static short[] arOpOrder = new short[2];

	public static string[] arOpName = new string[2];

	public static short[] arOpNeedsMassBalance = new short[2];

	public const short gcOpNeedsMassBalance = 1;

	public const short gcOpDoesntNeedMassBalance = 0;

	public static string[,] arSelActs = new string[2, 2];

	public static short[,] arSelActType = new short[2, 2];

	public static bool[,] arSelActRa = new bool[2, 2];

	public static bool[,] arSelActEa = new bool[2, 2];

	public static short[,] arSelActRaDMP = new short[2, 2];

	public static short[,] arSelActEaDMP = new short[2, 2];

	public static short[,] arSelActVolatile = new short[2, 2];

	public static string[,] arActNW_Route = new string[2, 2];

	public static long[,,] arActNumWorkers = new long[2, 2, 2];

	public static short[,] arActOrder = new short[2, 2];

	public const short gcActIsContainerRelatedForRM = 1;

	public const short gcActIsContainerRelatedForProd = 2;

	public const short gcActIsContainerRelatedForOther = 3;

	public const short gcActIsNonVolatile = 0;

	public const short gcActIsVolatile = 1;

	public const short gcDMP_Pending = 0;

	public const short gcDMP_InRange = 1;

	public const short gcDMP_OutOfRange = 2;

	public const short gcDMP_NoCondModels = 9;

	public static float[,,] arContParms = new float[2, 2, 2];

	public static short[,,] arContParmTypes = new short[2, 2, 2];

	public const short gccR = 1;

	public const short gccYi = 2;

	public const short gccVc = 3;

	public const short gccFc = 4;

	public const short gccDi = 5;

	public const short gccMCi = 6;

	public const short gccOHa = 7;

	public const short gccNcy = 8;

	public const short gccODa = 9;

	public const short gccNcd = 10;

	public const short gccMCi_x_Yi = 11;

	public const short gccMCi_x_Yi_x_Ncd = 12;

	public const short gccMCi_x_Ncd = 13;

	public const short gccDrmDprod = 14;

	public static short intOpIndex;

	public static short intActIndex;

	public static short intModIndex;

	public static short intDualIndex;

	public static short intNumRelModels;

	public static short[,,] arRelModels = new short[2, 2, 2];

	public static short[] arRelModType = new short[2];

	public static string[] arRelModBasis = new string[2];

	public static string[] arRelModNAICS = new string[2];

	public static short[] arRelModStatus = new short[2];

	public const short gcModelStatusNotRun = 0;

	public const short gcModelStatusRunUnsuccessfully = 1;

	public const short gcModelStatusRunSuccessfully = 2;

	public const short gcModelStatusParmsWereChanged = 3;

	public static short[,] arRelModOutputOn = new short[2, 2];

	public const short gcModelOutputIsEnabled = 1;

	public static string[,] arRelModChar = new string[2, 2];

	public static float[,] arRelModMedia = new float[2, 2];

	public const short gcMediaAir = 0;

	public const short gcMediaWater = 13;

	public const short gcMediaIncineration = 7;

	public const short gcMediaIncinerationOrLandfill = 8;

	public const short gcMediaLand = 11;

	public const short gcMediaOther = 16;

	public const short gcMediaDestroyed = 15;

	public const short gcMediaDeepwellInjection = 14;

	public const short gcMediaWaterAirIncinerationLandfill = 3;

	public const short gcMediaIncinerationLandfill = 8;

	public const short gcMediaWaterAirLandfill = 5;

	public const short gcMediaWaterIncinerationLandfill = 9;

	public static float[,,] arRelModParmsV = new float[2, 2, 2];

	public static short[,,] arRelModParmsT = new short[2, 2, 2];

	public static short[,,] arRelModParmsVC = new short[2, 2, 2];

	public static float[,] arRelModDRR = new float[2, 2];

	public static float[,] arRelModARR = new float[2, 2];

	public static short[,] arRelModDOR = new short[2, 2];

	public static short intNumExpModels;

	public const short gcInhModel = 0;

	public const short gcDerModel = 1;

	public static short[,,] arExpModels = new short[2, 2, 2];

	public static short[] arExpModType = new short[2];

	public static short[,] arExpModOutputOn = new short[2, 2];

	public static string[,] arExpModChar = new string[2, 2];

	public static string[] arExpModBasis = new string[2];

	public static short[] arExpModChmSt = new short[2];

	public static short[] arExpModUncertainty = new short[2];

	public const short gblInhIsUncertain = 1;

	public static short[] arExpModStatus = new short[2];

	public static float[,,] arExpModParmsV = new float[2, 2, 2];

	public static short[,,] arExpModParmsT = new short[2, 2, 2];

	public static short[,,] arExpModParmsVC = new short[2, 2, 2];

	public static string[,] arExpModInhRC = new string[2, 2];

	public static float[,,] arExpModEst = new float[2, 2, 2];

	public const short gcoDR = 1;

	public const short gcoFreq = 2;

	public const short gcoAR = 3;

	public const short gcoI = 4;

	public const short gcoILADD = 5;

	public const short gcoIADD = 6;

	public const short gcoIAPDR = 7;

	public const short gcoDexp = 8;

	public const short gcoDLADD = 9;

	public const short gcoDADD = 10;

	public const short gcoDAPDR = 11;

	public const short gcoTNWexp = 12;

	public const short gcoVNF = 13;

	public const short gcoFSA = 14;

	public const short gcoQNF = 15;

	public const short gcoQFF = 16;

	public const short gcoCnfTWA = 17;

	public const short gcoCffTWA = 18;

	public const short actSampleLiq = 1;

	public const short actLoadLiq5g = 3;

	public const short actLoadLiqSC = 4;

	public const short actLoadLiq55g = 5;

	public const short actLoadLiqRail = 8;

	public const short actLoadLiqTote = 6;

	public const short actLoadLiqTT = 7;

	public const short actUnLoadLiq5g = 11;

	public const short actUnLoadLiqSC = 12;

	public const short actUnLoadLiq55g = 13;

	public const short actUnLoadLiqTote = 14;

	public const short actUnLoadLiqRail = 16;

	public const short actUnLoadLiqTT = 15;

	public const short actCleanLR5g = 19;

	public const short actCleanLRSC = 20;

	public const short actCleanLR55g = 21;

	public const short actCleanLRTote = 22;

	public const short actCleanLRTT = 23;

	public const short actCleanLRRail = 24;

	public const short actCleanMultiV = 27;

	public const short actClean1LrgV = 28;

	public const short actClean1SmlV = 29;

	public const short actSamplLiqPr = 55;

	public const short actSamplLiqRM = 56;

	public const short actCleaningLiq5g = 61;

	public const short actCleaningLiqSC = 62;

	public const short actCleaningLiq55g = 63;

	public const short actCleaningLiqTote = 64;

	public const short actAutoOEMSprayCoating = 89;

	public const short actAutoRefinishingSprayCoating = 90;

	public const short actElectroplatingBath = 96;

	public const short gcPtDefault = 1;

	public const short gcPtUserSpec = 2;

	public const short gcPtNonDefault = 3;

	public const short gcPtDerived = 4;

	public const short gcPtConstant = 20;

	public const short gcPtModelOut = 21;

	public const short gcPtAmtOptions = 140;

	public const short gcPtFreqOptions = 141;

	public const short gcPtWFOptions = 142;

	public const short gcPtNotAvail = 999;

	public const string gcPtDefaultWords = "Default";

	public const string gcPtUserSpecWords = "User Specified";

	public const string gcPtNonDefaultWords = "Non-default";

	public const string gcPtDerivedWords = "Derived";

	public const string gcPtConstantWords = "Constant";

	public const string gcPtModelOutWords = "Model Output";

	public const short gcPVCLinked = 998;

	public const short gcPVCUser = 999;

	public const short gcPVCmass = -1000;

	public const short gcPVCchemVP = -1101;

	public const short gcPVCchemMW = -1102;

	public const short gcPVCchemDm = -1103;

	public const short gcPVCchemWs = -1104;

	public const short gcPVCcontMax = -1200;

	public const short gcPVCcontMin = -1299;

	public const short gcPVCmodelAll = -1300;

	public const short gcPVCmodelByAct = -1301;

	public const short gcPVCmodelByMod = -1302;

	public const string gcPVCLinkedWords = "Linked";

	public const string gcPVCUserWords = "User-defined";

	public const string gcPVCmassWords = "Mass Parm";

	public const string gcPVCchemWords = "Chem Parm";

	public const string gcPVCcontWords = "Cont Parm";

	public const string gcPVCmodelWords = "Model Parm";

	public const short gcML1101 = -1101;

	public const short gcML1102 = -1102;

	public const short gcML1103 = -1103;

	public const short gcML1104 = -1104;

	public const short gcML1105 = -1105;

	public const short gcML1106 = -1106;

	public const short gcML1107 = -1107;

	public const short gcML1108 = -1108;

	public const short gcML1109 = -1109;

	public const short gcML1110 = -1110;

	public const short gcML1111 = -1111;

	public const short gcML1112 = -1112;

	public const short gcML1114 = -1114;

	public const short gcML1115 = -1115;

	public const short gcML2101 = -2101;

	public const short gcML2102 = -2102;

	public const short gcML2103 = -2103;

	public const short gcML2104 = -2104;

	public const short gcML2105 = -2105;

	public const short gcML2106 = -2106;

	public const short gcML2107 = -2107;

	public const short gcML2108 = -2108;

	public const short gcML2109 = -2109;

	public const short gcML2110 = -2110;

	public const short gcML2111 = -2111;

	public const short gcML2112 = -2112;

	public const short gcML2113 = -2113;

	public const short gcML3101 = -3101;

	public const short gcML3102 = -3102;

	public const short gcML3103 = -3103;

	public const short gcML3104 = -3104;

	public const short gcML3105 = -3105;

	public const short gcML3106 = -3106;

	public const short gcML3107 = -3107;

	public const short gcML3108 = -3108;

	public const short gcML3109 = -3109;

	public const short gcML3110 = -3110;

	public const short gcML3111 = -3111;

	public const short gcML3112 = -3112;

	public const short gcML3113 = -3113;

	public const short gcML3114 = -3114;

	public const short gcML3115 = -3115;

	public const short gcML3116 = -3116;

	public const short gcML3117 = -3117;

	public const short gcML3118 = -3118;

	public const short gcML3119 = -3119;

	public const short gcML3120 = -3120;

	public const short gcML3121 = -3121;

	public const short gcML3122 = -3122;

	public const short gcML3123 = -3123;

	public const short gcML3124 = -3124;

	public const short gcML3125 = -3125;

	public const short gcML3126 = -3126;

	public const short gcML3127 = -3127;

	public const short gcML3128 = -3128;

	public const short gcML3129 = -3129;

	public const short gcML3130 = -3130;

	public const short gcML3131 = -3131;

	public const short gcSP_ShowIt = 1;

	public const short gcSP_HvlpGun = 1;

	public const short gcSP_ConvGun = 2;

	public const short gcSP_Waterwash = 1;

	public const short gcSP_DryFilter = 2;

	public const short gcSP_DownDraft = 1;

	public const short gcSP_CrossDraft = 2;

	public const short gcSP_OrganicComp = 1;

	public const short gcSP_SuspSolid = 2;

	public const short gcKcK_HvlpDowndraft = 1;

	public const short gcKcK_ConvDowndraft = 2;

	public const short gcKcK_HvlpCrossdraft = 3;

	public const short gcKcK_ConvCrossdraft = 4;

	public const short gblOpUDM = 1;

	public const short gblOpUDP = 2;

	public const short gblOpUDU = 3;

	public const short gcGSS_OEM = 100;

	public const short gcGSS_AutoRef = 101;

	public const short gcGSS_AdhForm = 102;

	public const short gcGSS_WaterCool = 103;

	public const short gcGSS_ElecBath = 104;

	public const short gblCondModelDefaultRule1 = -1001;

	public const short gblSPAll = 0;

	public const short gblSPAutoSprayCoating = 1;

	public const string gblSPAutoSprayCoatingDescription = "Automotive Spray Coating Model Factors";

	public const short gblSPVaporPressure = 2;

	public const string gblSPVaporPressureDescription = "Vapor Model Factors";

	public const short gblSPElectroAddtv = 3;

	public const string gblSPElectroAddtvDescription = "Electroplating Additive Type";

	public static string gblMsdsGE;

	public static string gblMsdsResp;

	public static string gblMsdsHE;

	public const string gblCrssText = "Neat:   Mfg:   Proc/Form:   End Use:   ";

	public const short gcChemStateIsVapor = 1;

	public const short gcChemStateIsMist = 2;

	public const short gcChemStateIsParticulate = 3;

	public const short gcChemStateIsAerosol = 4;

	public const short gcChemStateIsLiquid = 11;

	public const short gcChemStateIsSolid = 12;

	public const short gcOutputCharIsUserDefined = 999;
}
