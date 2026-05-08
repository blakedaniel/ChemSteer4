using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using ADODB;
using AxMSComctlLib;
using AxMSFlexGridLib;
using ChemSteer.My;
using MSComctlLib;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.Compatibility.VB6;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;

namespace ChemSteer;

internal class frmMain : Form
{
	private static List<WeakReference> __ENCList = new List<WeakReference>();

	private IContainer components;

	public ToolTip ToolTip1;

	[AccessedThroughProperty("msfContacts")]
	private AxMSFlexGrid _msfContacts;

	[AccessedThroughProperty("_lstSelOps_0")]
	private ListBox __lstSelOps_0;

	[AccessedThroughProperty("cmdUpdOps")]
	private Button _cmdUpdOps;

	[AccessedThroughProperty("cmdUpdOpAct")]
	private Button _cmdUpdOpAct;

	[AccessedThroughProperty("msfSelActs")]
	private AxMSFlexGrid _msfSelActs;

	[AccessedThroughProperty("_fraOpTab_3")]
	private GroupBox __fraOpTab_3;

	[AccessedThroughProperty("cmdUpdPhyState")]
	private Button _cmdUpdPhyState;

	[AccessedThroughProperty("_lblPhyStateOtherInfo_2")]
	private Label __lblPhyStateOtherInfo_2;

	[AccessedThroughProperty("_lblPhyState_2")]
	private Label __lblPhyState_2;

	[AccessedThroughProperty("_Label4_10")]
	private Label __Label4_10;

	[AccessedThroughProperty("_lblPhyStateOtherInfo_1")]
	private Label __lblPhyStateOtherInfo_1;

	[AccessedThroughProperty("_lblPhyStateOtherInfo_0")]
	private Label __lblPhyStateOtherInfo_0;

	[AccessedThroughProperty("_Label4_8")]
	private Label __Label4_8;

	[AccessedThroughProperty("_lblPhyState_1")]
	private Label __lblPhyState_1;

	[AccessedThroughProperty("_lblPhyState_0")]
	private Label __lblPhyState_0;

	[AccessedThroughProperty("_Label4_4")]
	private Label __Label4_4;

	[AccessedThroughProperty("_Label4_1")]
	private Label __Label4_1;

	[AccessedThroughProperty("_Label4_6")]
	private Label __Label4_6;

	[AccessedThroughProperty("_fraOpTab_2")]
	private GroupBox __fraOpTab_2;

	[AccessedThroughProperty("msfNaics")]
	private AxMSFlexGrid _msfNaics;

	[AccessedThroughProperty("cmdUpdOpDesc")]
	private Button _cmdUpdOpDesc;

	[AccessedThroughProperty("txtPD")]
	private TextBox _txtPD;

	[AccessedThroughProperty("_Label4_11")]
	private Label __Label4_11;

	[AccessedThroughProperty("_fraOpTab_1")]
	private GroupBox __fraOpTab_1;

	[AccessedThroughProperty("cmdUpdRelations")]
	private Button _cmdUpdRelations;

	[AccessedThroughProperty("lblMyPvf")]
	private Label _lblMyPvf;

	[AccessedThroughProperty("_Label4_9")]
	private Label __Label4_9;

	[AccessedThroughProperty("lblMyPvop")]
	private Label _lblMyPvop;

	[AccessedThroughProperty("_Label4_7")]
	private Label __Label4_7;

	[AccessedThroughProperty("_Label4_3")]
	private Label __Label4_3;

	[AccessedThroughProperty("_fraOpTab_0")]
	private GroupBox __fraOpTab_0;

	[AccessedThroughProperty("cmdCopyOpSiteInfo")]
	private Button _cmdCopyOpSiteInfo;

	[AccessedThroughProperty("cmdUpdSites")]
	private Button _cmdUpdSites;

	[AccessedThroughProperty("msfSites")]
	private AxMSFlexGrid _msfSites;

	[AccessedThroughProperty("_Label4_5")]
	private Label __Label4_5;

	[AccessedThroughProperty("_fraOpTab_4")]
	private GroupBox __fraOpTab_4;

	[AccessedThroughProperty("tabOps")]
	private AxTabStrip _tabOps;

	[AccessedThroughProperty("_fraTab_2")]
	private GroupBox __fraTab_2;

	[AccessedThroughProperty("cmbRelActs")]
	private ComboBox _cmbRelActs;

	[AccessedThroughProperty("cmdRelAddNotes")]
	private Button _cmdRelAddNotes;

	[AccessedThroughProperty("cmdRelBasis")]
	private Button _cmdRelBasis;

	[AccessedThroughProperty("txtRelModelMsg")]
	private TextBox _txtRelModelMsg;

	[AccessedThroughProperty("cmbRelOps")]
	private ComboBox _cmbRelOps;

	[AccessedThroughProperty("cmdRunRelModel")]
	private Button _cmdRunRelModel;

	[AccessedThroughProperty("cmdViewModelInfo")]
	private Button _cmdViewModelInfo;

	[AccessedThroughProperty("cmdAddRelModel")]
	private Button _cmdAddRelModel;

	[AccessedThroughProperty("lstRelModels")]
	private ListBox _lstRelModels;

	[AccessedThroughProperty("cmdUpdRelMedia")]
	private Button _cmdUpdRelMedia;

	[AccessedThroughProperty("cmdRelComb")]
	private Button _cmdRelComb;

	[AccessedThroughProperty("msfRelEst")]
	private AxMSFlexGrid _msfRelEst;

	[AccessedThroughProperty("msfRelParms")]
	private AxMSFlexGrid _msfRelParms;

	[AccessedThroughProperty("tabRelSubTab")]
	private AxTabStrip _tabRelSubTab;

	[AccessedThroughProperty("_Label1_71")]
	private Label __Label1_71;

	[AccessedThroughProperty("_Label1_68")]
	private Label __Label1_68;

	[AccessedThroughProperty("_Label1_69")]
	private Label __Label1_69;

	[AccessedThroughProperty("_Label1_67")]
	private Label __Label1_67;

	[AccessedThroughProperty("lblRel")]
	private Label _lblRel;

	[AccessedThroughProperty("_fraTab_4")]
	private GroupBox __fraTab_4;

	[AccessedThroughProperty("cmbExpActs")]
	private ComboBox _cmbExpActs;

	[AccessedThroughProperty("cmdUpdateExpNw")]
	private Button _cmdUpdateExpNw;

	[AccessedThroughProperty("cmdInhBasis")]
	private Button _cmdInhBasis;

	[AccessedThroughProperty("cmdExpComb")]
	private Button _cmdExpComb;

	[AccessedThroughProperty("cmbExpOps")]
	private ComboBox _cmbExpOps;

	[AccessedThroughProperty("cmdRunExpModel")]
	private Button _cmdRunExpModel;

	[AccessedThroughProperty("cmdAddExpModel")]
	private Button _cmdAddExpModel;

	[AccessedThroughProperty("cmdViewExpModel")]
	private Button _cmdViewExpModel;

	[AccessedThroughProperty("lblInhClassInhMon")]
	private Label _lblInhClassInhMon;

	[AccessedThroughProperty("lblInhClassHazRating")]
	private Label _lblInhClassHazRating;

	[AccessedThroughProperty("lblInhClassExpLevel")]
	private Label _lblInhClassExpLevel;

	[AccessedThroughProperty("lblInhClassUncertainty")]
	private Label _lblInhClassUncertainty;

	[AccessedThroughProperty("_Label1_337")]
	private Label __Label1_337;

	[AccessedThroughProperty("_Label1_336")]
	private Label __Label1_336;

	[AccessedThroughProperty("_Label1_335")]
	private Label __Label1_335;

	[AccessedThroughProperty("_Label1_334")]
	private Label __Label1_334;

	[AccessedThroughProperty("_Label1_114")]
	private Label __Label1_114;

	[AccessedThroughProperty("lblInhClassNotes")]
	private Label _lblInhClassNotes;

	[AccessedThroughProperty("lblInhClass")]
	private Label _lblInhClass;

	[AccessedThroughProperty("_fraExpTab_2")]
	private GroupBox __fraExpTab_2;

	[AccessedThroughProperty("msfExpEst")]
	private AxMSFlexGrid _msfExpEst;

	[AccessedThroughProperty("_fraExpTab_3")]
	private GroupBox __fraExpTab_3;

	[AccessedThroughProperty("_txtExpModelMsg_0")]
	private TextBox __txtExpModelMsg_0;

	[AccessedThroughProperty("_msfExpParms_0")]
	private AxMSFlexGrid __msfExpParms_0;

	[AccessedThroughProperty("lblDExpModel")]
	private Label _lblDExpModel;

	[AccessedThroughProperty("_lblChemStateExp_0")]
	private Label __lblChemStateExp_0;

	[AccessedThroughProperty("_Label3_1")]
	private Label __Label3_1;

	[AccessedThroughProperty("_fraExpTab_0")]
	private GroupBox __fraExpTab_0;

	[AccessedThroughProperty("_txtExpModelMsg_1")]
	private TextBox __txtExpModelMsg_1;

	[AccessedThroughProperty("_msfExpParms_1")]
	private AxMSFlexGrid __msfExpParms_1;

	[AccessedThroughProperty("lblIExpModel")]
	private Label _lblIExpModel;

	[AccessedThroughProperty("_lblChemStateExp_1")]
	private Label __lblChemStateExp_1;

	[AccessedThroughProperty("_Label3_2")]
	private Label __Label3_2;

	[AccessedThroughProperty("_fraExpTab_1")]
	private GroupBox __fraExpTab_1;

	[AccessedThroughProperty("tabExp")]
	private AxTabStrip _tabExp;

	[AccessedThroughProperty("_Label1_74")]
	private Label __Label1_74;

	[AccessedThroughProperty("_Label1_73")]
	private Label __Label1_73;

	[AccessedThroughProperty("_Label1_72")]
	private Label __Label1_72;

	[AccessedThroughProperty("lblExpSubtab")]
	private Label _lblExpSubtab;

	[AccessedThroughProperty("_fraTab_5")]
	private GroupBox __fraTab_5;

	[AccessedThroughProperty("cmbOptInfo")]
	private ComboBox _cmbOptInfo;

	[AccessedThroughProperty("cmdUpdOptInfo")]
	private Button _cmdUpdOptInfo;

	[AccessedThroughProperty("txtAssumps")]
	private TextBox _txtAssumps;

	[AccessedThroughProperty("_Label1_55")]
	private Label __Label1_55;

	[AccessedThroughProperty("_fraOpInfo_4")]
	private GroupBox __fraOpInfo_4;

	[AccessedThroughProperty("txtSatAddPBTinfo")]
	private TextBox _txtSatAddPBTinfo;

	[AccessedThroughProperty("_Line2_3")]
	private Label __Line2_3;

	[AccessedThroughProperty("_lblSatEReq_8")]
	private Label __lblSatEReq_8;

	[AccessedThroughProperty("_lblSatHReq_8")]
	private Label __lblSatHReq_8;

	[AccessedThroughProperty("lblCC")]
	private Label _lblCC;

	[AccessedThroughProperty("_Line2_1")]
	private Label __Line2_1;

	[AccessedThroughProperty("_Label1_95")]
	private Label __Label1_95;

	[AccessedThroughProperty("_lblSatEReq_7")]
	private Label __lblSatEReq_7;

	[AccessedThroughProperty("_lblSatEReq_5")]
	private Label __lblSatEReq_5;

	[AccessedThroughProperty("_Label1_94")]
	private Label __Label1_94;

	[AccessedThroughProperty("_lblSatHReq_5")]
	private Label __lblSatHReq_5;

	[AccessedThroughProperty("_lblSatHReq_7")]
	private Label __lblSatHReq_7;

	[AccessedThroughProperty("lblSATdate")]
	private Label _lblSATdate;

	[AccessedThroughProperty("_Label1_92")]
	private Label __Label1_92;

	[AccessedThroughProperty("_Label1_91")]
	private Label __Label1_91;

	[AccessedThroughProperty("_Label1_60")]
	private Label __Label1_60;

	[AccessedThroughProperty("_Label1_90")]
	private Label __Label1_90;

	[AccessedThroughProperty("lblSatM2GOther")]
	private Label _lblSatM2GOther;

	[AccessedThroughProperty("_lblSatEReq_6")]
	private Label __lblSatEReq_6;

	[AccessedThroughProperty("_Label1_66")]
	private Label __Label1_66;

	[AccessedThroughProperty("_lblSatEReq_4")]
	private Label __lblSatEReq_4;

	[AccessedThroughProperty("_Label1_65")]
	private Label __Label1_65;

	[AccessedThroughProperty("_lblSatEReq_2")]
	private Label __lblSatEReq_2;

	[AccessedThroughProperty("_Label1_64")]
	private Label __Label1_64;

	[AccessedThroughProperty("_lblSatEReq_1")]
	private Label __lblSatEReq_1;

	[AccessedThroughProperty("_Label1_63")]
	private Label __Label1_63;

	[AccessedThroughProperty("_lblSatEReq_0")]
	private Label __lblSatEReq_0;

	[AccessedThroughProperty("_lblSatHReq_6")]
	private Label __lblSatHReq_6;

	[AccessedThroughProperty("_lblSatHReq_4")]
	private Label __lblSatHReq_4;

	[AccessedThroughProperty("_Label1_62")]
	private Label __Label1_62;

	[AccessedThroughProperty("_lblSatHReq_3")]
	private Label __lblSatHReq_3;

	[AccessedThroughProperty("_Label1_61")]
	private Label __Label1_61;

	[AccessedThroughProperty("_lblSatEReq_3")]
	private Label __lblSatEReq_3;

	[AccessedThroughProperty("_lblSatHReq_2")]
	private Label __lblSatHReq_2;

	[AccessedThroughProperty("_Label1_59")]
	private Label __Label1_59;

	[AccessedThroughProperty("_lblSatHReq_1")]
	private Label __lblSatHReq_1;

	[AccessedThroughProperty("_Label1_58")]
	private Label __Label1_58;

	[AccessedThroughProperty("_lblSatHReq_0")]
	private Label __lblSatHReq_0;

	[AccessedThroughProperty("_Label1_99")]
	private Label __Label1_99;

	[AccessedThroughProperty("_Label1_57")]
	private Label __Label1_57;

	[AccessedThroughProperty("_Label1_53")]
	private Label __Label1_53;

	[AccessedThroughProperty("lblSATER")]
	private Label _lblSATER;

	[AccessedThroughProperty("lblSatM2G")]
	private Label _lblSatM2G;

	[AccessedThroughProperty("lblSatTR")]
	private Label _lblSatTR;

	[AccessedThroughProperty("lblSatPR")]
	private Label _lblSatPR;

	[AccessedThroughProperty("lblSatBR")]
	private Label _lblSatBR;

	[AccessedThroughProperty("lblSATHR")]
	private Label _lblSATHR;

	[AccessedThroughProperty("_Label1_35")]
	private Label __Label1_35;

	[AccessedThroughProperty("_Label1_34")]
	private Label __Label1_34;

	[AccessedThroughProperty("_Label1_33")]
	private Label __Label1_33;

	[AccessedThroughProperty("_Line2_2")]
	private Label __Line2_2;

	[AccessedThroughProperty("_Label1_31")]
	private Label __Label1_31;

	[AccessedThroughProperty("_Label1_21")]
	private Label __Label1_21;

	[AccessedThroughProperty("_Line2_0")]
	private Label __Line2_0;

	[AccessedThroughProperty("_fraOpInfo_0")]
	private GroupBox __fraOpInfo_0;

	[AccessedThroughProperty("msfTlv")]
	private AxMSFlexGrid _msfTlv;

	[AccessedThroughProperty("_fraSubOI_1")]
	private GroupBox __fraSubOI_1;

	[AccessedThroughProperty("_txtMsds_2")]
	private TextBox __txtMsds_2;

	[AccessedThroughProperty("_txtMsds_1")]
	private TextBox __txtMsds_1;

	[AccessedThroughProperty("_txtMsds_0")]
	private TextBox __txtMsds_0;

	[AccessedThroughProperty("lblMsdsLab")]
	private Label _lblMsdsLab;

	[AccessedThroughProperty("lblMsdsInc")]
	private Label _lblMsdsInc;

	[AccessedThroughProperty("_Label1_78")]
	private Label __Label1_78;

	[AccessedThroughProperty("_Label1_77")]
	private Label __Label1_77;

	[AccessedThroughProperty("_Label1_76")]
	private Label __Label1_76;

	[AccessedThroughProperty("_Label1_75")]
	private Label __Label1_75;

	[AccessedThroughProperty("_Label1_98")]
	private Label __Label1_98;

	[AccessedThroughProperty("_fraSubOI_0")]
	private GroupBox __fraSubOI_0;

	[AccessedThroughProperty("txtLVEPPE")]
	private TextBox _txtLVEPPE;

	[AccessedThroughProperty("lblLVEPPE")]
	private Label _lblLVEPPE;

	[AccessedThroughProperty("lblOILvePpe")]
	private Label _lblOILvePpe;

	[AccessedThroughProperty("_fraSubOI_2")]
	private GroupBox __fraSubOI_2;

	[AccessedThroughProperty("tabSubOI")]
	private AxTabStrip _tabSubOI;

	[AccessedThroughProperty("_fraOpInfo_2")]
	private GroupBox __fraOpInfo_2;

	[AccessedThroughProperty("txtNumExpEstBasis")]
	private TextBox _txtNumExpEstBasis;

	[AccessedThroughProperty("lblExpBasedCriteria")]
	private Label _lblExpBasedCriteria;

	[AccessedThroughProperty("_Label1_113")]
	private Label __Label1_113;

	[AccessedThroughProperty("_Label1_112")]
	private Label __Label1_112;

	[AccessedThroughProperty("lblNumExpEst")]
	private Label _lblNumExpEst;

	[AccessedThroughProperty("_Label1_111")]
	private Label __Label1_111;

	[AccessedThroughProperty("_Label1_79")]
	private Label __Label1_79;

	[AccessedThroughProperty("_lblNumWMet_4")]
	private Label __lblNumWMet_4;

	[AccessedThroughProperty("_lblNumWMet_3")]
	private Label __lblNumWMet_3;

	[AccessedThroughProperty("_lblNumWMet_2")]
	private Label __lblNumWMet_2;

	[AccessedThroughProperty("_lblNumWMet_1")]
	private Label __lblNumWMet_1;

	[AccessedThroughProperty("_Label1_54")]
	private Label __Label1_54;

	[AccessedThroughProperty("_Label1_49")]
	private Label __Label1_49;

	[AccessedThroughProperty("_lblGT100WorkersW1to10_48")]
	private Label __lblGT100WorkersW1to10_48;

	[AccessedThroughProperty("_lblNumWMet_0")]
	private Label __lblNumWMet_0;

	[AccessedThroughProperty("lblNumExp")]
	private Label _lblNumExp;

	[AccessedThroughProperty("_Label1_47")]
	private Label __Label1_47;

	[AccessedThroughProperty("_Label1_46")]
	private Label __Label1_46;

	[AccessedThroughProperty("_Label1_45")]
	private Label __Label1_45;

	[AccessedThroughProperty("_fraOpInfo_1")]
	private GroupBox __fraOpInfo_1;

	[AccessedThroughProperty("txtMiscCRSSinfo")]
	private TextBox _txtMiscCRSSinfo;

	[AccessedThroughProperty("txtOtherUses")]
	private TextBox _txtOtherUses;

	[AccessedThroughProperty("_Label1_43")]
	private Label __Label1_43;

	[AccessedThroughProperty("lblCRSSdate")]
	private Label _lblCRSSdate;

	[AccessedThroughProperty("_Label1_89")]
	private Label __Label1_89;

	[AccessedThroughProperty("_Label1_88")]
	private Label __Label1_88;

	[AccessedThroughProperty("lblConsUse")]
	private Label _lblConsUse;

	[AccessedThroughProperty("lblOccExpRating")]
	private Label _lblOccExpRating;

	[AccessedThroughProperty("_Label1_22")]
	private Label __Label1_22;

	[AccessedThroughProperty("_Label1_44")]
	private Label __Label1_44;

	[AccessedThroughProperty("_fraOpInfo_5")]
	private GroupBox __fraOpInfo_5;

	[AccessedThroughProperty("chkp2rec")]
	private CheckBox _chkp2rec;

	[AccessedThroughProperty("txtP2Rec")]
	private TextBox _txtP2Rec;

	[AccessedThroughProperty("txtP2Cons")]
	private TextBox _txtP2Cons;

	[AccessedThroughProperty("_Label1_109")]
	private Label __Label1_109;

	[AccessedThroughProperty("_Label1_108")]
	private Label __Label1_108;

	[AccessedThroughProperty("_Label1_56")]
	private Label __Label1_56;

	[AccessedThroughProperty("_fraOpInfo_3")]
	private GroupBox __fraOpInfo_3;

	[AccessedThroughProperty("_Label1_96")]
	private Label __Label1_96;

	[AccessedThroughProperty("lblCOS")]
	private Label _lblCOS;

	[AccessedThroughProperty("_Label1_102")]
	private Label __Label1_102;

	[AccessedThroughProperty("lblBindingPV")]
	private Label _lblBindingPV;

	[AccessedThroughProperty("_Label1_106")]
	private Label __Label1_106;

	[AccessedThroughProperty("_Label2_13")]
	private Label __Label2_13;

	[AccessedThroughProperty("_Label1_105")]
	private Label __Label1_105;

	[AccessedThroughProperty("_Label1_40")]
	private Label __Label1_40;

	[AccessedThroughProperty("lblDomesticSubPV")]
	private Label _lblDomesticSubPV;

	[AccessedThroughProperty("lblImportedSubPV")]
	private Label _lblImportedSubPV;

	[AccessedThroughProperty("lblTotalSubPV")]
	private Label _lblTotalSubPV;

	[AccessedThroughProperty("_Label2_12")]
	private Label __Label2_12;

	[AccessedThroughProperty("_Label2_11")]
	private Label __Label2_11;

	[AccessedThroughProperty("_LVE_40")]
	private Label __LVE_40;

	[AccessedThroughProperty("_fraOpInfo_6")]
	private GroupBox __fraOpInfo_6;

	[AccessedThroughProperty("_Label1_50")]
	private Label __Label1_50;

	[AccessedThroughProperty("_fraTab_6")]
	private GroupBox __fraTab_6;

	[AccessedThroughProperty("cmdChemRegLimits")]
	private Button _cmdChemRegLimits;

	[AccessedThroughProperty("cmdViewExpLimits")]
	private Button _cmdViewExpLimits;

	[AccessedThroughProperty("cmdUpdChem")]
	private Button _cmdUpdChem;

	[AccessedThroughProperty("_Line3_4")]
	private Label __Line3_4;

	[AccessedThroughProperty("lblChemQualOtherDesc")]
	private Label _lblChemQualOtherDesc;

	[AccessedThroughProperty("lblChemQualP2RecDR")]
	private Label _lblChemQualP2RecDR;

	[AccessedThroughProperty("lblChemQualP2Rec")]
	private Label _lblChemQualP2Rec;

	[AccessedThroughProperty("_Label1_101")]
	private Label __Label1_101;

	[AccessedThroughProperty("lblChemQualOther")]
	private Label _lblChemQualOther;

	[AccessedThroughProperty("lblChemQualNX")]
	private Label _lblChemQualNX;

	[AccessedThroughProperty("lblChemQualYX")]
	private Label _lblChemQualYX;

	[AccessedThroughProperty("_Label1_100")]
	private Label __Label1_100;

	[AccessedThroughProperty("_Line3_3")]
	private Label __Line3_3;

	[AccessedThroughProperty("_Label1_97")]
	private Label __Label1_97;

	[AccessedThroughProperty("_Label1_27")]
	private Label __Label1_27;

	[AccessedThroughProperty("_Line3_2")]
	private Label __Line3_2;

	[AccessedThroughProperty("_Line3_1")]
	private Label __Line3_1;

	[AccessedThroughProperty("_Label1_19")]
	private Label __Label1_19;

	[AccessedThroughProperty("lblMF")]
	private Label _lblMF;

	[AccessedThroughProperty("_Label1_41")]
	private Label __Label1_41;

	[AccessedThroughProperty("lblLT1000")]
	private Label _lblLT1000;

	[AccessedThroughProperty("lblLT500")]
	private Label _lblLT500;

	[AccessedThroughProperty("_Label1_38")]
	private Label __Label1_38;

	[AccessedThroughProperty("_Label1_37")]
	private Label __Label1_37;

	[AccessedThroughProperty("_Label1_52")]
	private Label __Label1_52;

	[AccessedThroughProperty("_Label1_51")]
	private Label __Label1_51;

	[AccessedThroughProperty("lblTradeNames")]
	private Label _lblTradeNames;

	[AccessedThroughProperty("lblChemCat")]
	private Label _lblChemCat;

	[AccessedThroughProperty("_Label1_48")]
	private Label __Label1_48;

	[AccessedThroughProperty("_Label2_10")]
	private Label __Label2_10;

	[AccessedThroughProperty("_Label2_9")]
	private Label __Label2_9;

	[AccessedThroughProperty("lblNoticeType")]
	private Label _lblNoticeType;

	[AccessedThroughProperty("lblSolTemp")]
	private Label _lblSolTemp;

	[AccessedThroughProperty("lblDchemTemp")]
	private Label _lblDchemTemp;

	[AccessedThroughProperty("lblVPTemp")]
	private Label _lblVPTemp;

	[AccessedThroughProperty("lblBP")]
	private Label _lblBP;

	[AccessedThroughProperty("lblMP")]
	private Label _lblMP;

	[AccessedThroughProperty("lblSol")]
	private Label _lblSol;

	[AccessedThroughProperty("lblDchem")]
	private Label _lblDchem;

	[AccessedThroughProperty("lblMW")]
	private Label _lblMW;

	[AccessedThroughProperty("lblVP")]
	private Label _lblVP;

	[AccessedThroughProperty("lblPV")]
	private Label _lblPV;

	[AccessedThroughProperty("lblPVi")]
	private Label _lblPVi;

	[AccessedThroughProperty("lblPVd")]
	private Label _lblPVd;

	[AccessedThroughProperty("lblCas")]
	private Label _lblCas;

	[AccessedThroughProperty("lblChemName")]
	private Label _lblChemName;

	[AccessedThroughProperty("_Label1_42")]
	private Label __Label1_42;

	[AccessedThroughProperty("_Label1_39")]
	private Label __Label1_39;

	[AccessedThroughProperty("_Label1_16")]
	private Label __Label1_16;

	[AccessedThroughProperty("_Label2_8")]
	private Label __Label2_8;

	[AccessedThroughProperty("_Label2_7")]
	private Label __Label2_7;

	[AccessedThroughProperty("_Label1_28")]
	private Label __Label1_28;

	[AccessedThroughProperty("_Label1_23")]
	private Label __Label1_23;

	[AccessedThroughProperty("_Label2_6")]
	private Label __Label2_6;

	[AccessedThroughProperty("_Label2_2")]
	private Label __Label2_2;

	[AccessedThroughProperty("_Label2_5")]
	private Label __Label2_5;

	[AccessedThroughProperty("_Label2_4")]
	private Label __Label2_4;

	[AccessedThroughProperty("_Label2_3")]
	private Label __Label2_3;

	[AccessedThroughProperty("_Label2_1")]
	private Label __Label2_1;

	[AccessedThroughProperty("_Label2_0")]
	private Label __Label2_0;

	[AccessedThroughProperty("_Label2_22")]
	private Label __Label2_22;

	[AccessedThroughProperty("_Label1_20")]
	private Label __Label1_20;

	[AccessedThroughProperty("_Label1_18")]
	private Label __Label1_18;

	[AccessedThroughProperty("_Label1_17")]
	private Label __Label1_17;

	[AccessedThroughProperty("_Label1_15")]
	private Label __Label1_15;

	[AccessedThroughProperty("_Label1_14")]
	private Label __Label1_14;

	[AccessedThroughProperty("_Label1_3")]
	private Label __Label1_3;

	[AccessedThroughProperty("_Label1_2")]
	private Label __Label1_2;

	[AccessedThroughProperty("_fraTab_1")]
	private GroupBox __fraTab_1;

	[AccessedThroughProperty("txtConsCase")]
	private TextBox _txtConsCase;

	[AccessedThroughProperty("txtRevNotes")]
	private TextBox _txtRevNotes;

	[AccessedThroughProperty("cmdUpdGen")]
	private Button _cmdUpdGen;

	[AccessedThroughProperty("cmdComments")]
	private Button _cmdComments;

	[AccessedThroughProperty("cmdContRpt")]
	private Button _cmdContRpt;

	[AccessedThroughProperty("_Label1_110")]
	private Label __Label1_110;

	[AccessedThroughProperty("lblCurrentVersion")]
	private Label _lblCurrentVersion;

	[AccessedThroughProperty("lblAssessmentVersion")]
	private Label _lblAssessmentVersion;

	[AccessedThroughProperty("_Label1_107")]
	private Label __Label1_107;

	[AccessedThroughProperty("lblLastSaved")]
	private Label _lblLastSaved;

	[AccessedThroughProperty("_Label1_93")]
	private Label __Label1_93;

	[AccessedThroughProperty("_Label1_24")]
	private Label __Label1_24;

	[AccessedThroughProperty("lblConsCase")]
	private Label _lblConsCase;

	[AccessedThroughProperty("lblFiscalYear")]
	private Label _lblFiscalYear;

	[AccessedThroughProperty("_Label1_26")]
	private Label __Label1_26;

	[AccessedThroughProperty("lblNumCR")]
	private Label _lblNumCR;

	[AccessedThroughProperty("_Label1_12")]
	private Label __Label1_12;

	[AccessedThroughProperty("_Label1_36")]
	private Label __Label1_36;

	[AccessedThroughProperty("lblState")]
	private Label _lblState;

	[AccessedThroughProperty("lblZip")]
	private Label _lblZip;

	[AccessedThroughProperty("_lblAddr_1")]
	private Label __lblAddr_1;

	[AccessedThroughProperty("lblCity")]
	private Label _lblCity;

	[AccessedThroughProperty("_lblAddr_0")]
	private Label __lblAddr_0;

	[AccessedThroughProperty("lblCoName")]
	private Label _lblCoName;

	[AccessedThroughProperty("_lblEmail_1")]
	private Label __lblEmail_1;

	[AccessedThroughProperty("_lblEmail_0")]
	private Label __lblEmail_0;

	[AccessedThroughProperty("_lblPhone_1")]
	private Label __lblPhone_1;

	[AccessedThroughProperty("_lblPhone_0")]
	private Label __lblPhone_0;

	[AccessedThroughProperty("_lblAff_1")]
	private Label __lblAff_1;

	[AccessedThroughProperty("_lblAff_0")]
	private Label __lblAff_0;

	[AccessedThroughProperty("_lblName_1")]
	private Label __lblName_1;

	[AccessedThroughProperty("_lblName_0")]
	private Label __lblName_0;

	[AccessedThroughProperty("lblCBI")]
	private Label _lblCBI;

	[AccessedThroughProperty("lblDate")]
	private Label _lblDate;

	[AccessedThroughProperty("lblID")]
	private Label _lblID;

	[AccessedThroughProperty("lblStatus")]
	private Label _lblStatus;

	[AccessedThroughProperty("lblAssessType")]
	private Label _lblAssessType;

	[AccessedThroughProperty("_Label1_11")]
	private Label __Label1_11;

	[AccessedThroughProperty("_Line1_2")]
	private Label __Line1_2;

	[AccessedThroughProperty("_Line1_1")]
	private Label __Line1_1;

	[AccessedThroughProperty("_Label1_10")]
	private Label __Label1_10;

	[AccessedThroughProperty("_Label1_32")]
	private Label __Label1_32;

	[AccessedThroughProperty("_Label1_25")]
	private Label __Label1_25;

	[AccessedThroughProperty("_Label1_7")]
	private Label __Label1_7;

	[AccessedThroughProperty("_Line1_0")]
	private Label __Line1_0;

	[AccessedThroughProperty("_Label1_9")]
	private Label __Label1_9;

	[AccessedThroughProperty("_Label1_5")]
	private Label __Label1_5;

	[AccessedThroughProperty("_Label1_4")]
	private Label __Label1_4;

	[AccessedThroughProperty("_Label1_30")]
	private Label __Label1_30;

	[AccessedThroughProperty("_Label1_29")]
	private Label __Label1_29;

	[AccessedThroughProperty("_Label1_13")]
	private Label __Label1_13;

	[AccessedThroughProperty("_Label1_8")]
	private Label __Label1_8;

	[AccessedThroughProperty("_Label1_6")]
	private Label __Label1_6;

	[AccessedThroughProperty("_Label1_1")]
	private Label __Label1_1;

	[AccessedThroughProperty("_Label1_0")]
	private Label __Label1_0;

	[AccessedThroughProperty("_fraTab_0")]
	private GroupBox __fraTab_0;

	[AccessedThroughProperty("_lstSelOps_1")]
	private ListBox __lstSelOps_1;

	[AccessedThroughProperty("_msfCont_0")]
	private AxMSFlexGrid __msfCont_0;

	[AccessedThroughProperty("txtContDrm")]
	private TextBox _txtContDrm;

	[AccessedThroughProperty("lblDrmType")]
	private Label _lblDrmType;

	[AccessedThroughProperty("_lblContYrm_0")]
	private Label __lblContYrm_0;

	[AccessedThroughProperty("_lblContSumFC_0")]
	private Label __lblContSumFC_0;

	[AccessedThroughProperty("_Label1_81")]
	private Label __Label1_81;

	[AccessedThroughProperty("_fraConts_0")]
	private GroupBox __fraConts_0;

	[AccessedThroughProperty("_msfCont_2")]
	private AxMSFlexGrid __msfCont_2;

	[AccessedThroughProperty("_lblContYprod_0")]
	private Label __lblContYprod_0;

	[AccessedThroughProperty("_lblContYrm_1")]
	private Label __lblContYrm_1;

	[AccessedThroughProperty("_lblContSumFC_2")]
	private Label __lblContSumFC_2;

	[AccessedThroughProperty("_fraConts_2")]
	private GroupBox __fraConts_2;

	[AccessedThroughProperty("_msfCont_1")]
	private AxMSFlexGrid __msfCont_1;

	[AccessedThroughProperty("txtContDprod")]
	private TextBox _txtContDprod;

	[AccessedThroughProperty("lblDprodType")]
	private Label _lblDprodType;

	[AccessedThroughProperty("_lblContYprod_1")]
	private Label __lblContYprod_1;

	[AccessedThroughProperty("_lblContSumFC_1")]
	private Label __lblContSumFC_1;

	[AccessedThroughProperty("_Label1_80")]
	private Label __Label1_80;

	[AccessedThroughProperty("_fraConts_1")]
	private GroupBox __fraConts_1;

	[AccessedThroughProperty("_msfCont_3")]
	private AxMSFlexGrid __msfCont_3;

	[AccessedThroughProperty("lblContOD")]
	private Label _lblContOD;

	[AccessedThroughProperty("_fraConts_3")]
	private GroupBox __fraConts_3;

	[AccessedThroughProperty("tabConts")]
	private AxTabStrip _tabConts;

	[AccessedThroughProperty("_fraIP_1")]
	private GroupBox __fraIP_1;

	[AccessedThroughProperty("cmdUpdAVP")]
	private Button _cmdUpdAVP;

	[AccessedThroughProperty("msfSP")]
	private AxMSFlexGrid _msfSP;

	[AccessedThroughProperty("_Line1_3")]
	private Label __Line1_3;

	[AccessedThroughProperty("lblAVPhigh")]
	private Label _lblAVPhigh;

	[AccessedThroughProperty("lblAVPlow")]
	private Label _lblAVPlow;

	[AccessedThroughProperty("_Label1_86")]
	private Label __Label1_86;

	[AccessedThroughProperty("_Label1_85")]
	private Label __Label1_85;

	[AccessedThroughProperty("_fraIP_2")]
	private GroupBox __fraIP_2;

	[AccessedThroughProperty("msfOpIP")]
	private AxMSFlexGrid _msfOpIP;

	[AccessedThroughProperty("_fraIP_0")]
	private GroupBox __fraIP_0;

	[AccessedThroughProperty("tabIP")]
	private AxTabStrip _tabIP;

	[AccessedThroughProperty("_fraTab_3")]
	private GroupBox __fraTab_3;

	[AccessedThroughProperty("LVE")]
	private LabelArray _LVE;

	[AccessedThroughProperty("Label1")]
	private LabelArray _Label1;

	[AccessedThroughProperty("Label2")]
	private LabelArray _Label2;

	[AccessedThroughProperty("Label3")]
	private LabelArray _Label3;

	[AccessedThroughProperty("Label4")]
	private LabelArray _Label4;

	[AccessedThroughProperty("Line1")]
	private LabelArray _Line1;

	[AccessedThroughProperty("Line2")]
	private LabelArray _Line2;

	[AccessedThroughProperty("Line3")]
	private LabelArray _Line3;

	[AccessedThroughProperty("fraConts")]
	private GroupBoxArray _fraConts;

	[AccessedThroughProperty("fraExpTab")]
	private GroupBoxArray _fraExpTab;

	[AccessedThroughProperty("fraIP")]
	private GroupBoxArray _fraIP;

	[AccessedThroughProperty("fraOpInfo")]
	private GroupBoxArray _fraOpInfo;

	[AccessedThroughProperty("fraOpTab")]
	private GroupBoxArray _fraOpTab;

	[AccessedThroughProperty("fraSubOI")]
	private GroupBoxArray _fraSubOI;

	[AccessedThroughProperty("fraTab")]
	private GroupBoxArray _fraTab;

	[AccessedThroughProperty("lblAddr")]
	private LabelArray _lblAddr;

	[AccessedThroughProperty("lblAff")]
	private LabelArray _lblAff;

	[AccessedThroughProperty("lblChemStateExp")]
	private LabelArray _lblChemStateExp;

	[AccessedThroughProperty("lblContSumFC")]
	private LabelArray _lblContSumFC;

	[AccessedThroughProperty("lblContYprod")]
	private LabelArray _lblContYprod;

	[AccessedThroughProperty("lblContYrm")]
	private LabelArray _lblContYrm;

	[AccessedThroughProperty("lblEmail")]
	private LabelArray _lblEmail;

	[AccessedThroughProperty("lblGT100WorkersW1to10")]
	private LabelArray _lblGT100WorkersW1to10;

	[AccessedThroughProperty("lblName")]
	private LabelArray _lblName;

	[AccessedThroughProperty("lblNumWMet")]
	private LabelArray _lblNumWMet;

	[AccessedThroughProperty("lblPhone")]
	private LabelArray _lblPhone;

	[AccessedThroughProperty("lblPhyState")]
	private LabelArray _lblPhyState;

	[AccessedThroughProperty("lblPhyStateOtherInfo")]
	private LabelArray _lblPhyStateOtherInfo;

	[AccessedThroughProperty("lblSatEReq")]
	private LabelArray _lblSatEReq;

	[AccessedThroughProperty("lblSatHReq")]
	private LabelArray _lblSatHReq;

	[AccessedThroughProperty("mnuPreferences")]
	private MenuItemArray _mnuPreferences;

	[AccessedThroughProperty("txtExpModelMsg")]
	private TextBoxArray _txtExpModelMsg;

	[AccessedThroughProperty("txtMsds")]
	private TextBoxArray _txtMsds;

	[AccessedThroughProperty("mnuFileNew")]
	private MenuItem _mnuFileNew;

	[AccessedThroughProperty("mnuFileOpen")]
	private MenuItem _mnuFileOpen;

	[AccessedThroughProperty("mnuFileClose")]
	private MenuItem _mnuFileClose;

	[AccessedThroughProperty("mnuFileSep1")]
	private MenuItem _mnuFileSep1;

	[AccessedThroughProperty("mnuFileSave")]
	private MenuItem _mnuFileSave;

	[AccessedThroughProperty("mnuFileSaveAs")]
	private MenuItem _mnuFileSaveAs;

	[AccessedThroughProperty("mnuFileSep2")]
	private MenuItem _mnuFileSep2;

	[AccessedThroughProperty("mnuFileRevHistory")]
	private MenuItem _mnuFileRevHistory;

	[AccessedThroughProperty("mnuFileSep3")]
	private MenuItem _mnuFileSep3;

	[AccessedThroughProperty("mnuFileDelete")]
	private MenuItem _mnuFileDelete;

	[AccessedThroughProperty("mnuFileSep4")]
	private MenuItem _mnuFileSep4;

	[AccessedThroughProperty("mnuFileImportCRSS")]
	private MenuItem _mnuFileImportCRSS;

	[AccessedThroughProperty("mnuFileViewCRSS")]
	private MenuItem _mnuFileViewCRSS;

	[AccessedThroughProperty("mnuFileSep5")]
	private MenuItem _mnuFileSep5;

	[AccessedThroughProperty("mnuFileExit")]
	private MenuItem _mnuFileExit;

	[AccessedThroughProperty("mnuFile")]
	private MenuItem _mnuFile;

	[AccessedThroughProperty("mnuEditCut")]
	private MenuItem _mnuEditCut;

	[AccessedThroughProperty("mnuEditCopy")]
	private MenuItem _mnuEditCopy;

	[AccessedThroughProperty("mnuEditPaste")]
	private MenuItem _mnuEditPaste;

	[AccessedThroughProperty("mnuEdit")]
	private MenuItem _mnuEdit;

	[AccessedThroughProperty("_mnuPreferences_0")]
	private MenuItem __mnuPreferences_0;

	[AccessedThroughProperty("_mnuPreferences_1")]
	private MenuItem __mnuPreferences_1;

	[AccessedThroughProperty("_mnuPreferences_2")]
	private MenuItem __mnuPreferences_2;

	[AccessedThroughProperty("mnuPref")]
	private MenuItem _mnuPref;

	[AccessedThroughProperty("_mnuReportIRER_0")]
	private MenuItem __mnuReportIRER_0;

	[AccessedThroughProperty("mnuReportSep1")]
	private MenuItem _mnuReportSep1;

	[AccessedThroughProperty("_mnuReportCR_0")]
	private MenuItem __mnuReportCR_0;

	[AccessedThroughProperty("mnuReportSep2")]
	private MenuItem _mnuReportSep2;

	[AccessedThroughProperty("_mnuReportIRER_3")]
	private MenuItem __mnuReportIRER_3;

	[AccessedThroughProperty("mnuReportS")]
	private MenuItem _mnuReportS;

	[AccessedThroughProperty("mnuHelpViewUserGuide")]
	private MenuItem _mnuHelpViewUserGuide;

	[AccessedThroughProperty("mnuHelpAbout")]
	private MenuItem _mnuHelpAbout;

	[AccessedThroughProperty("mnuHelp")]
	private MenuItem _mnuHelp;

	[AccessedThroughProperty("_Label1_333")]
	private Label __Label1_333;

	[AccessedThroughProperty("_mnuReportIRER_1")]
	private MenuItem __mnuReportIRER_1;

	[AccessedThroughProperty("_mnuReportCR_1")]
	private MenuItem __mnuReportCR_1;

	[AccessedThroughProperty("_mnuReportIRER_2")]
	private MenuItem __mnuReportIRER_2;

	[AccessedThroughProperty("cmdGeneral")]
	private Button _cmdGeneral;

	[AccessedThroughProperty("cmdChemical")]
	private Button _cmdChemical;

	[AccessedThroughProperty("cmdOpParms")]
	private Button _cmdOpParms;

	[AccessedThroughProperty("cmdOperations")]
	private Button _cmdOperations;

	[AccessedThroughProperty("cmdExposures")]
	private Button _cmdExposures;

	[AccessedThroughProperty("cmdReleases")]
	private Button _cmdReleases;

	[AccessedThroughProperty("cmdOptionalInfo")]
	private Button _cmdOptionalInfo;

	[AccessedThroughProperty("cmdSiteInfo")]
	private Button _cmdSiteInfo;

	[AccessedThroughProperty("cmdSources")]
	private Button _cmdSources;

	[AccessedThroughProperty("cmdPhysicalStates")]
	private Button _cmdPhysicalStates;

	[AccessedThroughProperty("cmdDescription")]
	private Button _cmdDescription;

	[AccessedThroughProperty("cmdRelationships")]
	private Button _cmdRelationships;

	[AccessedThroughProperty("cmdRespirator")]
	private Button _cmdRespirator;

	[AccessedThroughProperty("cmdActivity")]
	private Button _cmdActivity;

	[AccessedThroughProperty("cmdInhalation")]
	private Button _cmdInhalation;

	[AccessedThroughProperty("cmdDermal")]
	private Button _cmdDermal;

	[AccessedThroughProperty("msfSubOps")]
	private AxMSFlexGrid _msfSubOps;

	[AccessedThroughProperty("Label6")]
	private Label _Label6;

	[AccessedThroughProperty("cmdSharedParms")]
	private Button _cmdSharedParms;

	[AccessedThroughProperty("cmdContainerParms")]
	private Button _cmdContainerParms;

	[AccessedThroughProperty("cmdMassBalParms")]
	private Button _cmdMassBalParms;

	[AccessedThroughProperty("cmdEstReleases")]
	private Button _cmdEstReleases;

	[AccessedThroughProperty("cmdRelParms")]
	private Button _cmdRelParms;

	[AccessedThroughProperty("Label7")]
	private Label _Label7;

	[AccessedThroughProperty("tabMain")]
	private AxTabStrip _tabMain;

	[AccessedThroughProperty("Label8")]
	private Label _Label8;

	[AccessedThroughProperty("Label9")]
	private Label _Label9;

	[AccessedThroughProperty("Label10")]
	private Label _Label10;

	[AccessedThroughProperty("Label11")]
	private Label _Label11;

	[AccessedThroughProperty("Label12")]
	private Label _Label12;

	[AccessedThroughProperty("cmdUpdOpIP")]
	private Button _cmdUpdOpIP;

	[AccessedThroughProperty("cmdReports")]
	private Button _cmdReports;

	[AccessedThroughProperty("Label13")]
	private Label _Label13;

	[AccessedThroughProperty("Label18")]
	private Label _Label18;

	[AccessedThroughProperty("Label17")]
	private Label _Label17;

	[AccessedThroughProperty("Label16")]
	private Label _Label16;

	[AccessedThroughProperty("Label14")]
	private Label _Label14;

	[AccessedThroughProperty("Label15")]
	private Label _Label15;

	[AccessedThroughProperty("_fraTab_7")]
	private GroupBox __fraTab_7;

	[AccessedThroughProperty("cmdSaveCombo")]
	private Button _cmdSaveCombo;

	[AccessedThroughProperty("cmdViewCombo")]
	private Button _cmdViewCombo;

	[AccessedThroughProperty("cmdSaveContact")]
	private Button _cmdSaveContact;

	[AccessedThroughProperty("cmdViewContact")]
	private Button _cmdViewContact;

	[AccessedThroughProperty("cmdSaveIRER")]
	private Button _cmdSaveIRER;

	[AccessedThroughProperty("cmdViewIRER")]
	private Button _cmdViewIRER;

	[AccessedThroughProperty("Label19")]
	private Label _Label19;

	[AccessedThroughProperty("mnuFileUpdateGSS")]
	private MenuItem _mnuFileUpdateGSS;

	[AccessedThroughProperty("mnuFileSaveGSS")]
	private MenuItem _mnuFileSaveGSS;

	[AccessedThroughProperty("mnuFileDeleteGSS")]
	private MenuItem _mnuFileDeleteGSS;

	[AccessedThroughProperty("mnuFileSep7")]
	private MenuItem _mnuFileSep7;

	[AccessedThroughProperty("LabelSubTabs3")]
	private Label _LabelSubTabs3;

	[AccessedThroughProperty("lblOpParmSubtabs")]
	private Label _lblOpParmSubtabs;

	[AccessedThroughProperty("mnuHelpViewQuickStartGuide")]
	private MenuItem _mnuHelpViewQuickStartGuide;

	[AccessedThroughProperty("txtSatRelatedCases")]
	private TextBox _txtSatRelatedCases;

	[AccessedThroughProperty("Label5")]
	private Label _Label5;

	[AccessedThroughProperty("Label21")]
	private Label _Label21;

	[AccessedThroughProperty("Label22")]
	private Label _Label22;

	[AccessedThroughProperty("Label23")]
	private Label _Label23;

	[AccessedThroughProperty("mnuFileEasyModels")]
	private MenuItem _mnuFileEasyModels;

	[AccessedThroughProperty("mnuFileSep6")]
	private MenuItem _mnuFileSep6;

	[AccessedThroughProperty("mnuFileRenameGSS")]
	private MenuItem _mnuFileRenameGSS;

	[AccessedThroughProperty("Label20")]
	private Label _Label20;

	[AccessedThroughProperty("CachedIRERcomb1")]
	private CachedIRERcomb _CachedIRERcomb1;

	[AccessedThroughProperty("txtChemGenUse")]
	private TextBox _txtChemGenUse;

	public MainMenu MainMenu1;

	private static frmMain m_vb6FormDefInstance;

	private static bool m_InitializingDefInstance;

	private short NodeCtr;

	private short MyCurrentTab;

	private short MyCurrentOpTab;

	private short MyCurrentIpTab;

	private short MyCurrentContSubTab;

	private short MyCurrentRelTab;

	private short MyCurrentExpTab;

	public string sContactInfoNotepad;

	public string sCRSSid;

	[SpecialName]
	private bool _0024STATIC_0024lstSelOps0_SelectedIndexChanged_002420211C1271_0024PreventRecursion;

	[SpecialName]
	private bool _0024STATIC_0024lstSelOps1_SelectedIndexChanged_002420211C1271_0024PreventRecursion;

	public virtual AxMSFlexGrid msfContacts
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfContacts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfContacts = value;
		}
	}

	public virtual ListBox _lstSelOps_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lstSelOps_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstSelOps_DoubleClick;
			EventHandler eventHandler2 = lstSelOps0_SelectedIndexChanged;
			if (__lstSelOps_0 != null)
			{
				((Control)__lstSelOps_0).DoubleClick -= eventHandler;
				__lstSelOps_0.SelectedIndexChanged -= eventHandler2;
			}
			__lstSelOps_0 = value;
			if (__lstSelOps_0 != null)
			{
				((Control)__lstSelOps_0).DoubleClick += eventHandler;
				__lstSelOps_0.SelectedIndexChanged += eventHandler2;
			}
		}
	}

	public virtual Button cmdUpdOps
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdOps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdOps_Click;
			if (_cmdUpdOps != null)
			{
				((Control)_cmdUpdOps).Click -= eventHandler;
			}
			_cmdUpdOps = value;
			if (_cmdUpdOps != null)
			{
				((Control)_cmdUpdOps).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdUpdOpAct
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdOpAct;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdOpAct_Click;
			if (_cmdUpdOpAct != null)
			{
				((Control)_cmdUpdOpAct).Click -= eventHandler;
			}
			_cmdUpdOpAct = value;
			if (_cmdUpdOpAct != null)
			{
				((Control)_cmdUpdOpAct).Click += eventHandler;
			}
		}
	}

	public virtual AxMSFlexGrid msfSelActs
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfSelActs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfSelActs = value;
		}
	}

	public virtual GroupBox _fraOpTab_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraOpTab_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraOpTab_3 = value;
		}
	}

	public virtual Button cmdUpdPhyState
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdPhyState;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdPhyState_Click;
			if (_cmdUpdPhyState != null)
			{
				((Control)_cmdUpdPhyState).Click -= eventHandler;
			}
			_cmdUpdPhyState = value;
			if (_cmdUpdPhyState != null)
			{
				((Control)_cmdUpdPhyState).Click += eventHandler;
			}
		}
	}

	public virtual Label _lblPhyStateOtherInfo_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblPhyStateOtherInfo_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblPhyStateOtherInfo_2 = value;
		}
	}

	public virtual Label _lblPhyState_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblPhyState_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblPhyState_2 = value;
		}
	}

	public virtual Label _Label4_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_10 = value;
		}
	}

	public virtual Label _lblPhyStateOtherInfo_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblPhyStateOtherInfo_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblPhyStateOtherInfo_1 = value;
		}
	}

	public virtual Label _lblPhyStateOtherInfo_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblPhyStateOtherInfo_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblPhyStateOtherInfo_0 = value;
		}
	}

	public virtual Label _Label4_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_8 = value;
		}
	}

	public virtual Label _lblPhyState_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblPhyState_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblPhyState_1 = value;
		}
	}

	public virtual Label _lblPhyState_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblPhyState_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblPhyState_0 = value;
		}
	}

	public virtual Label _Label4_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_4 = value;
		}
	}

	public virtual Label _Label4_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_1 = value;
		}
	}

	public virtual Label _Label4_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_6 = value;
		}
	}

	public virtual GroupBox _fraOpTab_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraOpTab_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraOpTab_2 = value;
		}
	}

	public virtual AxMSFlexGrid msfNaics
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfNaics;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfNaics = value;
		}
	}

	public virtual Button cmdUpdOpDesc
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdOpDesc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdOpDesc_Click;
			if (_cmdUpdOpDesc != null)
			{
				((Control)_cmdUpdOpDesc).Click -= eventHandler;
			}
			_cmdUpdOpDesc = value;
			if (_cmdUpdOpDesc != null)
			{
				((Control)_cmdUpdOpDesc).Click += eventHandler;
			}
		}
	}

	public virtual TextBox txtPD
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtPD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtPD = value;
		}
	}

	public virtual Label _Label4_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_11 = value;
		}
	}

	public virtual GroupBox _fraOpTab_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraOpTab_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraOpTab_1 = value;
		}
	}

	public virtual Button cmdUpdRelations
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdRelations;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdRelations_Click;
			if (_cmdUpdRelations != null)
			{
				((Control)_cmdUpdRelations).Click -= eventHandler;
			}
			_cmdUpdRelations = value;
			if (_cmdUpdRelations != null)
			{
				((Control)_cmdUpdRelations).Click += eventHandler;
			}
		}
	}

	public virtual Label lblMyPvf
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMyPvf;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMyPvf = value;
		}
	}

	public virtual Label _Label4_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_9 = value;
		}
	}

	public virtual Label lblMyPvop
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMyPvop;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMyPvop = value;
		}
	}

	public virtual Label _Label4_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_7 = value;
		}
	}

	public virtual Label _Label4_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_3 = value;
		}
	}

	public virtual GroupBox _fraOpTab_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraOpTab_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraOpTab_0 = value;
		}
	}

	public virtual Button cmdCopyOpSiteInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdCopyOpSiteInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdCopyOpSiteInfo_Click;
			if (_cmdCopyOpSiteInfo != null)
			{
				((Control)_cmdCopyOpSiteInfo).Click -= eventHandler;
			}
			_cmdCopyOpSiteInfo = value;
			if (_cmdCopyOpSiteInfo != null)
			{
				((Control)_cmdCopyOpSiteInfo).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdUpdSites
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdSites;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdSites_Click;
			if (_cmdUpdSites != null)
			{
				((Control)_cmdUpdSites).Click -= eventHandler;
			}
			_cmdUpdSites = value;
			if (_cmdUpdSites != null)
			{
				((Control)_cmdUpdSites).Click += eventHandler;
			}
		}
	}

	public virtual AxMSFlexGrid msfSites
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfSites;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfSites = value;
		}
	}

	public virtual Label _Label4_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label4_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label4_5 = value;
		}
	}

	public virtual GroupBox _fraOpTab_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraOpTab_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraOpTab_4 = value;
		}
	}

	public virtual AxTabStrip tabOps
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabOps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tabOps_ClickEvent;
			if (_tabOps != null)
			{
				_tabOps.ClickEvent -= eventHandler;
			}
			_tabOps = value;
			if (_tabOps != null)
			{
				_tabOps.ClickEvent += eventHandler;
			}
		}
	}

	public virtual GroupBox _fraTab_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraTab_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraTab_2 = value;
		}
	}

	public virtual ComboBox cmbRelActs
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbRelActs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbRelActs_SelectedIndexChanged;
			if (_cmbRelActs != null)
			{
				_cmbRelActs.SelectedIndexChanged -= eventHandler;
			}
			_cmbRelActs = value;
			if (_cmbRelActs != null)
			{
				_cmbRelActs.SelectedIndexChanged += eventHandler;
			}
		}
	}

	public virtual Button cmdRelAddNotes
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRelAddNotes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRelAddNotes_Click;
			if (_cmdRelAddNotes != null)
			{
				((Control)_cmdRelAddNotes).Click -= eventHandler;
			}
			_cmdRelAddNotes = value;
			if (_cmdRelAddNotes != null)
			{
				((Control)_cmdRelAddNotes).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdRelBasis
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRelBasis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRelBasis_Click;
			if (_cmdRelBasis != null)
			{
				((Control)_cmdRelBasis).Click -= eventHandler;
			}
			_cmdRelBasis = value;
			if (_cmdRelBasis != null)
			{
				((Control)_cmdRelBasis).Click += eventHandler;
			}
		}
	}

	public virtual TextBox txtRelModelMsg
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtRelModelMsg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtRelModelMsg = value;
		}
	}

	public virtual ComboBox cmbRelOps
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbRelOps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbrelops_SelectedIndexChanged;
			if (_cmbRelOps != null)
			{
				_cmbRelOps.SelectedIndexChanged -= eventHandler;
			}
			_cmbRelOps = value;
			if (_cmbRelOps != null)
			{
				_cmbRelOps.SelectedIndexChanged += eventHandler;
			}
		}
	}

	public virtual Button cmdRunRelModel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRunRelModel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRunRelModel_Click;
			if (_cmdRunRelModel != null)
			{
				((Control)_cmdRunRelModel).Click -= eventHandler;
			}
			_cmdRunRelModel = value;
			if (_cmdRunRelModel != null)
			{
				((Control)_cmdRunRelModel).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdViewModelInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdViewModelInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdViewModelInfo_Click;
			if (_cmdViewModelInfo != null)
			{
				((Control)_cmdViewModelInfo).Click -= eventHandler;
			}
			_cmdViewModelInfo = value;
			if (_cmdViewModelInfo != null)
			{
				((Control)_cmdViewModelInfo).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdAddRelModel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdAddRelModel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdAddRelModel_Click;
			if (_cmdAddRelModel != null)
			{
				((Control)_cmdAddRelModel).Click -= eventHandler;
			}
			_cmdAddRelModel = value;
			if (_cmdAddRelModel != null)
			{
				((Control)_cmdAddRelModel).Click += eventHandler;
			}
		}
	}

	public virtual ListBox lstRelModels
	{
		[DebuggerNonUserCode]
		get
		{
			return _lstRelModels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstRelModels_SelectedIndexChanged;
			if (_lstRelModels != null)
			{
				_lstRelModels.SelectedIndexChanged -= eventHandler;
			}
			_lstRelModels = value;
			if (_lstRelModels != null)
			{
				_lstRelModels.SelectedIndexChanged += eventHandler;
			}
		}
	}

	public virtual Button cmdUpdRelMedia
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdRelMedia;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdRelMedia_Click;
			if (_cmdUpdRelMedia != null)
			{
				((Control)_cmdUpdRelMedia).Click -= eventHandler;
			}
			_cmdUpdRelMedia = value;
			if (_cmdUpdRelMedia != null)
			{
				((Control)_cmdUpdRelMedia).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdRelComb
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRelComb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRelComb_Click;
			if (_cmdRelComb != null)
			{
				((Control)_cmdRelComb).Click -= eventHandler;
			}
			_cmdRelComb = value;
			if (_cmdRelComb != null)
			{
				((Control)_cmdRelComb).Click += eventHandler;
			}
		}
	}

	public virtual AxMSFlexGrid msfRelEst
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfRelEst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfRelEst = value;
		}
	}

	public virtual AxMSFlexGrid msfRelParms
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfRelParms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfRelParms = value;
		}
	}

	public virtual AxTabStrip tabRelSubTab
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabRelSubTab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tabRelSubTab_ClickEvent;
			if (_tabRelSubTab != null)
			{
				_tabRelSubTab.ClickEvent -= eventHandler;
			}
			_tabRelSubTab = value;
			if (_tabRelSubTab != null)
			{
				_tabRelSubTab.ClickEvent += eventHandler;
			}
		}
	}

	public virtual Label _Label1_71
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_71;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_71 = value;
		}
	}

	public virtual Label _Label1_68
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_68;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_68 = value;
		}
	}

	public virtual Label _Label1_69
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_69;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_69 = value;
		}
	}

	public virtual Label _Label1_67
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_67;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_67 = value;
		}
	}

	public virtual Label lblRel
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblRel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblRel = value;
		}
	}

	public virtual GroupBox _fraTab_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraTab_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraTab_4 = value;
		}
	}

	public virtual ComboBox cmbExpActs
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbExpActs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbExpActs_SelectedIndexChanged;
			if (_cmbExpActs != null)
			{
				_cmbExpActs.SelectedIndexChanged -= eventHandler;
			}
			_cmbExpActs = value;
			if (_cmbExpActs != null)
			{
				_cmbExpActs.SelectedIndexChanged += eventHandler;
			}
		}
	}

	public virtual Button cmdUpdateExpNw
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdateExpNw;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdateExpNw_Click;
			if (_cmdUpdateExpNw != null)
			{
				((Control)_cmdUpdateExpNw).Click -= eventHandler;
			}
			_cmdUpdateExpNw = value;
			if (_cmdUpdateExpNw != null)
			{
				((Control)_cmdUpdateExpNw).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdInhBasis
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdInhBasis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdInhBasis_Click;
			if (_cmdInhBasis != null)
			{
				((Control)_cmdInhBasis).Click -= eventHandler;
			}
			_cmdInhBasis = value;
			if (_cmdInhBasis != null)
			{
				((Control)_cmdInhBasis).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdExpComb
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdExpComb;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdExpComb_Click;
			if (_cmdExpComb != null)
			{
				((Control)_cmdExpComb).Click -= eventHandler;
			}
			_cmdExpComb = value;
			if (_cmdExpComb != null)
			{
				((Control)_cmdExpComb).Click += eventHandler;
			}
		}
	}

	public virtual ComboBox cmbExpOps
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbExpOps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbExpOps_SelectedIndexChanged;
			if (_cmbExpOps != null)
			{
				_cmbExpOps.SelectedIndexChanged -= eventHandler;
			}
			_cmbExpOps = value;
			if (_cmbExpOps != null)
			{
				_cmbExpOps.SelectedIndexChanged += eventHandler;
			}
		}
	}

	public virtual Button cmdRunExpModel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRunExpModel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRunExpModel_Click;
			if (_cmdRunExpModel != null)
			{
				((Control)_cmdRunExpModel).Click -= eventHandler;
			}
			_cmdRunExpModel = value;
			if (_cmdRunExpModel != null)
			{
				((Control)_cmdRunExpModel).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdAddExpModel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdAddExpModel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdAddExpModel_Click;
			if (_cmdAddExpModel != null)
			{
				((Control)_cmdAddExpModel).Click -= eventHandler;
			}
			_cmdAddExpModel = value;
			if (_cmdAddExpModel != null)
			{
				((Control)_cmdAddExpModel).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdViewExpModel
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdViewExpModel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdViewExpModel_Click;
			if (_cmdViewExpModel != null)
			{
				((Control)_cmdViewExpModel).Click -= eventHandler;
			}
			_cmdViewExpModel = value;
			if (_cmdViewExpModel != null)
			{
				((Control)_cmdViewExpModel).Click += eventHandler;
			}
		}
	}

	public virtual Label lblInhClassInhMon
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInhClassInhMon;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInhClassInhMon = value;
		}
	}

	public virtual Label lblInhClassHazRating
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInhClassHazRating;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInhClassHazRating = value;
		}
	}

	public virtual Label lblInhClassExpLevel
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInhClassExpLevel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInhClassExpLevel = value;
		}
	}

	public virtual Label lblInhClassUncertainty
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInhClassUncertainty;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInhClassUncertainty = value;
		}
	}

	public virtual Label _Label1_337
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_337;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = _Label1_337_Click;
			if (__Label1_337 != null)
			{
				((Control)__Label1_337).Click -= eventHandler;
			}
			__Label1_337 = value;
			if (__Label1_337 != null)
			{
				((Control)__Label1_337).Click += eventHandler;
			}
		}
	}

	public virtual Label _Label1_336
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_336;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_336 = value;
		}
	}

	public virtual Label _Label1_335
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_335;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_335 = value;
		}
	}

	public virtual Label _Label1_334
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_334;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_334 = value;
		}
	}

	public virtual Label _Label1_114
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_114;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_114 = value;
		}
	}

	public virtual Label lblInhClassNotes
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInhClassNotes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInhClassNotes = value;
		}
	}

	public virtual Label lblInhClass
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblInhClass;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblInhClass = value;
		}
	}

	public virtual GroupBox _fraExpTab_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraExpTab_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraExpTab_2 = value;
		}
	}

	public virtual AxMSFlexGrid msfExpEst
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfExpEst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfExpEst = value;
		}
	}

	public virtual GroupBox _fraExpTab_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraExpTab_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraExpTab_3 = value;
		}
	}

	public virtual TextBox _txtExpModelMsg_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtExpModelMsg_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtExpModelMsg_0 = value;
		}
	}

	public virtual AxMSFlexGrid _msfExpParms_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __msfExpParms_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__msfExpParms_0 = value;
		}
	}

	public virtual Label lblDExpModel
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDExpModel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDExpModel = value;
		}
	}

	public virtual Label _lblChemStateExp_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblChemStateExp_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblChemStateExp_0 = value;
		}
	}

	public virtual Label _Label3_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label3_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label3_1 = value;
		}
	}

	public virtual GroupBox _fraExpTab_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraExpTab_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraExpTab_0 = value;
		}
	}

	public virtual TextBox _txtExpModelMsg_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtExpModelMsg_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtExpModelMsg_1 = value;
		}
	}

	public virtual AxMSFlexGrid _msfExpParms_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __msfExpParms_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__msfExpParms_1 = value;
		}
	}

	public virtual Label lblIExpModel
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblIExpModel;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblIExpModel = value;
		}
	}

	public virtual Label _lblChemStateExp_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblChemStateExp_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblChemStateExp_1 = value;
		}
	}

	public virtual Label _Label3_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label3_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label3_2 = value;
		}
	}

	public virtual GroupBox _fraExpTab_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraExpTab_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraExpTab_1 = value;
		}
	}

	public virtual AxTabStrip tabExp
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabExp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tabExp_ClickEvent;
			if (_tabExp != null)
			{
				_tabExp.ClickEvent -= eventHandler;
			}
			_tabExp = value;
			if (_tabExp != null)
			{
				_tabExp.ClickEvent += eventHandler;
			}
		}
	}

	public virtual Label _Label1_74
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_74;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_74 = value;
		}
	}

	public virtual Label _Label1_73
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_73;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_73 = value;
		}
	}

	public virtual Label _Label1_72
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_72;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_72 = value;
		}
	}

	public virtual Label lblExpSubtab
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblExpSubtab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblExpSubtab = value;
		}
	}

	public virtual GroupBox _fraTab_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraTab_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraTab_5 = value;
		}
	}

	public virtual ComboBox cmbOptInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmbOptInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmbOptInfo_SelectedIndexChanged;
			if (_cmbOptInfo != null)
			{
				_cmbOptInfo.SelectedIndexChanged -= eventHandler;
			}
			_cmbOptInfo = value;
			if (_cmbOptInfo != null)
			{
				_cmbOptInfo.SelectedIndexChanged += eventHandler;
			}
		}
	}

	public virtual Button cmdUpdOptInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdOptInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdOptInfo_Click;
			if (_cmdUpdOptInfo != null)
			{
				((Control)_cmdUpdOptInfo).Click -= eventHandler;
			}
			_cmdUpdOptInfo = value;
			if (_cmdUpdOptInfo != null)
			{
				((Control)_cmdUpdOptInfo).Click += eventHandler;
			}
		}
	}

	public virtual TextBox txtAssumps
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtAssumps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtAssumps = value;
		}
	}

	public virtual Label _Label1_55
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_55;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_55 = value;
		}
	}

	public virtual GroupBox _fraOpInfo_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraOpInfo_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraOpInfo_4 = value;
		}
	}

	public virtual TextBox txtSatAddPBTinfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSatAddPBTinfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSatAddPBTinfo = value;
		}
	}

	public virtual Label _Line2_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_3 = value;
		}
	}

	public virtual Label _lblSatEReq_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatEReq_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatEReq_8 = value;
		}
	}

	public virtual Label _lblSatHReq_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatHReq_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatHReq_8 = value;
		}
	}

	public virtual Label lblCC
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCC = value;
		}
	}

	public virtual Label _Line2_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_1 = value;
		}
	}

	public virtual Label _Label1_95
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_95;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_95 = value;
		}
	}

	public virtual Label _lblSatEReq_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatEReq_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatEReq_7 = value;
		}
	}

	public virtual Label _lblSatEReq_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatEReq_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatEReq_5 = value;
		}
	}

	public virtual Label _Label1_94
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_94;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_94 = value;
		}
	}

	public virtual Label _lblSatHReq_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatHReq_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatHReq_5 = value;
		}
	}

	public virtual Label _lblSatHReq_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatHReq_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatHReq_7 = value;
		}
	}

	public virtual Label lblSATdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSATdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSATdate = value;
		}
	}

	public virtual Label _Label1_92
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_92;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_92 = value;
		}
	}

	public virtual Label _Label1_91
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_91;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_91 = value;
		}
	}

	public virtual Label _Label1_60
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_60;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_60 = value;
		}
	}

	public virtual Label _Label1_90
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_90;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_90 = value;
		}
	}

	public virtual Label lblSatM2GOther
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSatM2GOther;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSatM2GOther = value;
		}
	}

	public virtual Label _lblSatEReq_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatEReq_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatEReq_6 = value;
		}
	}

	public virtual Label _Label1_66
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_66;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_66 = value;
		}
	}

	public virtual Label _lblSatEReq_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatEReq_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatEReq_4 = value;
		}
	}

	public virtual Label _Label1_65
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_65;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_65 = value;
		}
	}

	public virtual Label _lblSatEReq_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatEReq_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatEReq_2 = value;
		}
	}

	public virtual Label _Label1_64
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_64;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_64 = value;
		}
	}

	public virtual Label _lblSatEReq_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatEReq_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatEReq_1 = value;
		}
	}

	public virtual Label _Label1_63
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_63;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_63 = value;
		}
	}

	public virtual Label _lblSatEReq_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatEReq_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatEReq_0 = value;
		}
	}

	public virtual Label _lblSatHReq_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatHReq_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatHReq_6 = value;
		}
	}

	public virtual Label _lblSatHReq_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatHReq_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatHReq_4 = value;
		}
	}

	public virtual Label _Label1_62
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_62;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_62 = value;
		}
	}

	public virtual Label _lblSatHReq_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatHReq_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatHReq_3 = value;
		}
	}

	public virtual Label _Label1_61
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_61;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_61 = value;
		}
	}

	public virtual Label _lblSatEReq_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatEReq_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatEReq_3 = value;
		}
	}

	public virtual Label _lblSatHReq_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatHReq_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatHReq_2 = value;
		}
	}

	public virtual Label _Label1_59
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_59;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_59 = value;
		}
	}

	public virtual Label _lblSatHReq_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatHReq_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatHReq_1 = value;
		}
	}

	public virtual Label _Label1_58
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_58;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_58 = value;
		}
	}

	public virtual Label _lblSatHReq_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblSatHReq_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblSatHReq_0 = value;
		}
	}

	public virtual Label _Label1_99
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_99;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_99 = value;
		}
	}

	public virtual Label _Label1_57
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_57;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_57 = value;
		}
	}

	public virtual Label _Label1_53
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_53;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_53 = value;
		}
	}

	public virtual Label lblSATER
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSATER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSATER = value;
		}
	}

	public virtual Label lblSatM2G
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSatM2G;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSatM2G = value;
		}
	}

	public virtual Label lblSatTR
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSatTR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSatTR = value;
		}
	}

	public virtual Label lblSatPR
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSatPR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSatPR = value;
		}
	}

	public virtual Label lblSatBR
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSatBR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSatBR = value;
		}
	}

	public virtual Label lblSATHR
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSATHR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSATHR = value;
		}
	}

	public virtual Label _Label1_35
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_35;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_35 = value;
		}
	}

	public virtual Label _Label1_34
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_34;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_34 = value;
		}
	}

	public virtual Label _Label1_33
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_33;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_33 = value;
		}
	}

	public virtual Label _Line2_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_2 = value;
		}
	}

	public virtual Label _Label1_31
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_31;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_31 = value;
		}
	}

	public virtual Label _Label1_21
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_21 = value;
		}
	}

	public virtual Label _Line2_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line2_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line2_0 = value;
		}
	}

	public virtual GroupBox _fraOpInfo_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraOpInfo_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraOpInfo_0 = value;
		}
	}

	public virtual AxMSFlexGrid msfTlv
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfTlv;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfTlv = value;
		}
	}

	public virtual GroupBox _fraSubOI_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraSubOI_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraSubOI_1 = value;
		}
	}

	public virtual TextBox _txtMsds_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMsds_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtMsds_2 = value;
		}
	}

	public virtual TextBox _txtMsds_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMsds_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtMsds_1 = value;
		}
	}

	public virtual TextBox _txtMsds_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __txtMsds_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__txtMsds_0 = value;
		}
	}

	public virtual Label lblMsdsLab
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMsdsLab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMsdsLab = value;
		}
	}

	public virtual Label lblMsdsInc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMsdsInc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMsdsInc = value;
		}
	}

	public virtual Label _Label1_78
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_78;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_78 = value;
		}
	}

	public virtual Label _Label1_77
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_77;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_77 = value;
		}
	}

	public virtual Label _Label1_76
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_76;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_76 = value;
		}
	}

	public virtual Label _Label1_75
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_75;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_75 = value;
		}
	}

	public virtual Label _Label1_98
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_98;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_98 = value;
		}
	}

	public virtual GroupBox _fraSubOI_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraSubOI_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraSubOI_0 = value;
		}
	}

	public virtual TextBox txtLVEPPE
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtLVEPPE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtLVEPPE = value;
		}
	}

	public virtual Label lblLVEPPE
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLVEPPE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLVEPPE = value;
		}
	}

	public virtual Label lblOILvePpe
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblOILvePpe;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblOILvePpe = value;
		}
	}

	public virtual GroupBox _fraSubOI_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraSubOI_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraSubOI_2 = value;
		}
	}

	public virtual AxTabStrip tabSubOI
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabSubOI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tabSubOI_ClickEvent;
			if (_tabSubOI != null)
			{
				_tabSubOI.ClickEvent -= eventHandler;
			}
			_tabSubOI = value;
			if (_tabSubOI != null)
			{
				_tabSubOI.ClickEvent += eventHandler;
			}
		}
	}

	public virtual GroupBox _fraOpInfo_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraOpInfo_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraOpInfo_2 = value;
		}
	}

	public virtual TextBox txtNumExpEstBasis
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtNumExpEstBasis;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtNumExpEstBasis = value;
		}
	}

	public virtual Label lblExpBasedCriteria
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblExpBasedCriteria;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblExpBasedCriteria = value;
		}
	}

	public virtual Label _Label1_113
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_113;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_113 = value;
		}
	}

	public virtual Label _Label1_112
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_112;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_112 = value;
		}
	}

	public virtual Label lblNumExpEst
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNumExpEst;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNumExpEst = value;
		}
	}

	public virtual Label _Label1_111
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_111;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_111 = value;
		}
	}

	public virtual Label _Label1_79
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_79;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_79 = value;
		}
	}

	public virtual Label _lblNumWMet_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblNumWMet_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblNumWMet_4 = value;
		}
	}

	public virtual Label _lblNumWMet_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblNumWMet_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblNumWMet_3 = value;
		}
	}

	public virtual Label _lblNumWMet_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblNumWMet_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblNumWMet_2 = value;
		}
	}

	public virtual Label _lblNumWMet_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblNumWMet_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblNumWMet_1 = value;
		}
	}

	public virtual Label _Label1_54
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_54;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_54 = value;
		}
	}

	public virtual Label _Label1_49
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_49;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_49 = value;
		}
	}

	public virtual Label _lblGT100WorkersW1to10_48
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblGT100WorkersW1to10_48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblGT100WorkersW1to10_48 = value;
		}
	}

	public virtual Label _lblNumWMet_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblNumWMet_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblNumWMet_0 = value;
		}
	}

	public virtual Label lblNumExp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNumExp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNumExp = value;
		}
	}

	public virtual Label _Label1_47
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_47;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_47 = value;
		}
	}

	public virtual Label _Label1_46
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_46;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_46 = value;
		}
	}

	public virtual Label _Label1_45
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_45;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_45 = value;
		}
	}

	public virtual GroupBox _fraOpInfo_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraOpInfo_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraOpInfo_1 = value;
		}
	}

	public virtual TextBox txtMiscCRSSinfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMiscCRSSinfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMiscCRSSinfo = value;
		}
	}

	public virtual TextBox txtOtherUses
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtOtherUses;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtOtherUses = value;
		}
	}

	public virtual Label _Label1_43
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_43;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_43 = value;
		}
	}

	public virtual Label lblCRSSdate
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCRSSdate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCRSSdate = value;
		}
	}

	public virtual Label _Label1_89
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_89;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_89 = value;
		}
	}

	public virtual Label _Label1_88
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_88;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_88 = value;
		}
	}

	public virtual Label lblConsUse
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblConsUse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblConsUse = value;
		}
	}

	public virtual Label lblOccExpRating
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblOccExpRating;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblOccExpRating = value;
		}
	}

	public virtual Label _Label1_22
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_22 = value;
		}
	}

	public virtual Label _Label1_44
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_44;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_44 = value;
		}
	}

	public virtual GroupBox _fraOpInfo_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraOpInfo_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraOpInfo_5 = value;
		}
	}

	public virtual CheckBox chkp2rec
	{
		[DebuggerNonUserCode]
		get
		{
			return _chkp2rec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_chkp2rec = value;
		}
	}

	public virtual TextBox txtP2Rec
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtP2Rec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtP2Rec = value;
		}
	}

	public virtual TextBox txtP2Cons
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtP2Cons;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtP2Cons = value;
		}
	}

	public virtual Label _Label1_109
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_109;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_109 = value;
		}
	}

	public virtual Label _Label1_108
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_108;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_108 = value;
		}
	}

	public virtual Label _Label1_56
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_56;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_56 = value;
		}
	}

	public virtual GroupBox _fraOpInfo_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraOpInfo_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraOpInfo_3 = value;
		}
	}

	public virtual Label _Label1_96
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_96;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_96 = value;
		}
	}

	public virtual Label lblCOS
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCOS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCOS = value;
		}
	}

	public virtual Label _Label1_102
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_102;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_102 = value;
		}
	}

	public virtual Label lblBindingPV
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBindingPV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBindingPV = value;
		}
	}

	public virtual Label _Label1_106
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_106;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_106 = value;
		}
	}

	public virtual Label _Label2_13
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_13 = value;
		}
	}

	public virtual Label _Label1_105
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_105;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_105 = value;
		}
	}

	public virtual Label _Label1_40
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_40 = value;
		}
	}

	public virtual Label lblDomesticSubPV
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDomesticSubPV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDomesticSubPV = value;
		}
	}

	public virtual Label lblImportedSubPV
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblImportedSubPV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblImportedSubPV = value;
		}
	}

	public virtual Label lblTotalSubPV
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTotalSubPV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTotalSubPV = value;
		}
	}

	public virtual Label _Label2_12
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_12 = value;
		}
	}

	public virtual Label _Label2_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_11 = value;
		}
	}

	public virtual Label _LVE_40
	{
		[DebuggerNonUserCode]
		get
		{
			return __LVE_40;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__LVE_40 = value;
		}
	}

	public virtual GroupBox _fraOpInfo_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraOpInfo_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraOpInfo_6 = value;
		}
	}

	public virtual Label _Label1_50
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_50;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_50 = value;
		}
	}

	public virtual GroupBox _fraTab_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraTab_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraTab_6 = value;
		}
	}

	public virtual Button cmdChemRegLimits
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdChemRegLimits;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdChemRegLimits_Click;
			if (_cmdChemRegLimits != null)
			{
				((Control)_cmdChemRegLimits).Click -= eventHandler;
			}
			_cmdChemRegLimits = value;
			if (_cmdChemRegLimits != null)
			{
				((Control)_cmdChemRegLimits).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdViewExpLimits
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdViewExpLimits;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdViewExpLimits_Click;
			if (_cmdViewExpLimits != null)
			{
				((Control)_cmdViewExpLimits).Click -= eventHandler;
			}
			_cmdViewExpLimits = value;
			if (_cmdViewExpLimits != null)
			{
				((Control)_cmdViewExpLimits).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdUpdChem
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdChem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdChem_Click;
			if (_cmdUpdChem != null)
			{
				((Control)_cmdUpdChem).Click -= eventHandler;
			}
			_cmdUpdChem = value;
			if (_cmdUpdChem != null)
			{
				((Control)_cmdUpdChem).Click += eventHandler;
			}
		}
	}

	public virtual Label _Line3_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line3_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line3_4 = value;
		}
	}

	public virtual Label lblChemQualOtherDesc
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChemQualOtherDesc;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChemQualOtherDesc = value;
		}
	}

	public virtual Label lblChemQualP2RecDR
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChemQualP2RecDR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChemQualP2RecDR = value;
		}
	}

	public virtual Label lblChemQualP2Rec
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChemQualP2Rec;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChemQualP2Rec = value;
		}
	}

	public virtual Label _Label1_101
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_101;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_101 = value;
		}
	}

	public virtual Label lblChemQualOther
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChemQualOther;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChemQualOther = value;
		}
	}

	public virtual Label lblChemQualNX
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChemQualNX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChemQualNX = value;
		}
	}

	public virtual Label lblChemQualYX
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChemQualYX;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChemQualYX = value;
		}
	}

	public virtual Label _Label1_100
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_100;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_100 = value;
		}
	}

	public virtual Label _Line3_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line3_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line3_3 = value;
		}
	}

	public virtual Label _Label1_97
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_97;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_97 = value;
		}
	}

	public virtual Label _Label1_27
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_27;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_27 = value;
		}
	}

	public virtual Label _Line3_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line3_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line3_2 = value;
		}
	}

	public virtual Label _Line3_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line3_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line3_1 = value;
		}
	}

	public virtual Label _Label1_19
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_19 = value;
		}
	}

	public virtual Label lblMF
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMF;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMF = value;
		}
	}

	public virtual Label _Label1_41
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_41;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_41 = value;
		}
	}

	public virtual Label lblLT1000
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLT1000;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLT1000 = value;
		}
	}

	public virtual Label lblLT500
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLT500;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLT500 = value;
		}
	}

	public virtual Label _Label1_38
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_38;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_38 = value;
		}
	}

	public virtual Label _Label1_37
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_37;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_37 = value;
		}
	}

	public virtual Label _Label1_52
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_52;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_52 = value;
		}
	}

	public virtual Label _Label1_51
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_51;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_51 = value;
		}
	}

	public virtual Label lblTradeNames
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblTradeNames;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblTradeNames = value;
		}
	}

	public virtual Label lblChemCat
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChemCat;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChemCat = value;
		}
	}

	public virtual Label _Label1_48
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_48;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_48 = value;
		}
	}

	public virtual Label _Label2_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_10 = value;
		}
	}

	public virtual Label _Label2_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_9 = value;
		}
	}

	public virtual Label lblNoticeType
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNoticeType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNoticeType = value;
		}
	}

	public virtual Label lblSolTemp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSolTemp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSolTemp = value;
		}
	}

	public virtual Label lblDchemTemp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDchemTemp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDchemTemp = value;
		}
	}

	public virtual Label lblVPTemp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblVPTemp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblVPTemp = value;
		}
	}

	public virtual Label lblBP
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblBP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblBP = value;
		}
	}

	public virtual Label lblMP
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMP = value;
		}
	}

	public virtual Label lblSol
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSol;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSol = value;
		}
	}

	public virtual Label lblDchem
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDchem;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDchem = value;
		}
	}

	public virtual Label lblMW
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblMW;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblMW = value;
		}
	}

	public virtual Label lblVP
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblVP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblVP = value;
		}
	}

	public virtual Label lblPV
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPV;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPV = value;
		}
	}

	public virtual Label lblPVi
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPVi;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPVi = value;
		}
	}

	public virtual Label lblPVd
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPVd;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPVd = value;
		}
	}

	public virtual Label lblCas
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCas;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCas = value;
		}
	}

	public virtual Label lblChemName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChemName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChemName = value;
		}
	}

	public virtual Label _Label1_42
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_42;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_42 = value;
		}
	}

	public virtual Label _Label1_39
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_39;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_39 = value;
		}
	}

	public virtual Label _Label1_16
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_16 = value;
		}
	}

	public virtual Label _Label2_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_8 = value;
		}
	}

	public virtual Label _Label2_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_7 = value;
		}
	}

	public virtual Label _Label1_28
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_28;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_28 = value;
		}
	}

	public virtual Label _Label1_23
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_23 = value;
		}
	}

	public virtual Label _Label2_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_6 = value;
		}
	}

	public virtual Label _Label2_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_2 = value;
		}
	}

	public virtual Label _Label2_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_5 = value;
		}
	}

	public virtual Label _Label2_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_4 = value;
		}
	}

	public virtual Label _Label2_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_3 = value;
		}
	}

	public virtual Label _Label2_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_1 = value;
		}
	}

	public virtual Label _Label2_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_0 = value;
		}
	}

	public virtual Label _Label2_22
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label2_22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label2_22 = value;
		}
	}

	public virtual Label _Label1_20
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_20 = value;
		}
	}

	public virtual Label _Label1_18
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_18 = value;
		}
	}

	public virtual Label _Label1_17
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_17 = value;
		}
	}

	public virtual Label _Label1_15
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_15 = value;
		}
	}

	public virtual Label _Label1_14
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_14 = value;
		}
	}

	public virtual Label _Label1_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_3 = value;
		}
	}

	public virtual Label _Label1_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_2 = value;
		}
	}

	public virtual GroupBox _fraTab_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraTab_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraTab_1 = value;
		}
	}

	public virtual TextBox txtConsCase
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtConsCase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtConsCase = value;
		}
	}

	public virtual TextBox txtRevNotes
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtRevNotes;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtRevNotes = value;
		}
	}

	private virtual Button cmdUpdGen
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdGen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdGen_Click;
			if (_cmdUpdGen != null)
			{
				((Control)_cmdUpdGen).Click -= eventHandler;
			}
			_cmdUpdGen = value;
			if (_cmdUpdGen != null)
			{
				((Control)_cmdUpdGen).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdComments
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdComments;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdComments_Click;
			if (_cmdComments != null)
			{
				((Control)_cmdComments).Click -= eventHandler;
			}
			_cmdComments = value;
			if (_cmdComments != null)
			{
				((Control)_cmdComments).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdContRpt
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdContRpt;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdContRpt_Click;
			if (_cmdContRpt != null)
			{
				((Control)_cmdContRpt).Click -= eventHandler;
			}
			_cmdContRpt = value;
			if (_cmdContRpt != null)
			{
				((Control)_cmdContRpt).Click += eventHandler;
			}
		}
	}

	public virtual Label _Label1_110
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_110;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_110 = value;
		}
	}

	public virtual Label lblCurrentVersion
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCurrentVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCurrentVersion = value;
		}
	}

	public virtual Label lblAssessmentVersion
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAssessmentVersion;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAssessmentVersion = value;
		}
	}

	public virtual Label _Label1_107
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_107;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_107 = value;
		}
	}

	public virtual Label lblLastSaved
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblLastSaved;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblLastSaved = value;
		}
	}

	public virtual Label _Label1_93
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_93;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_93 = value;
		}
	}

	public virtual Label _Label1_24
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_24;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_24 = value;
		}
	}

	public virtual Label lblConsCase
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblConsCase;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblConsCase = value;
		}
	}

	public virtual Label lblFiscalYear
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblFiscalYear;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblFiscalYear = value;
		}
	}

	public virtual Label _Label1_26
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_26;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_26 = value;
		}
	}

	public virtual Label lblNumCR
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNumCR;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNumCR = value;
		}
	}

	public virtual Label _Label1_12
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_12 = value;
		}
	}

	public virtual Label _Label1_36
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_36;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_36 = value;
		}
	}

	public virtual Label lblState
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblState;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblState = value;
		}
	}

	public virtual Label lblZip
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblZip;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblZip = value;
		}
	}

	public virtual Label _lblAddr_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblAddr_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblAddr_1 = value;
		}
	}

	public virtual Label lblCity
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCity = value;
		}
	}

	public virtual Label _lblAddr_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblAddr_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblAddr_0 = value;
		}
	}

	public virtual Label lblCoName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCoName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCoName = value;
		}
	}

	public virtual Label _lblEmail_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblEmail_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblEmail_1 = value;
		}
	}

	public virtual Label _lblEmail_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblEmail_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblEmail_0 = value;
		}
	}

	public virtual Label _lblPhone_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblPhone_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblPhone_1 = value;
		}
	}

	public virtual Label _lblPhone_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblPhone_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblPhone_0 = value;
		}
	}

	public virtual Label _lblAff_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblAff_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblAff_1 = value;
		}
	}

	public virtual Label _lblAff_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblAff_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblAff_0 = value;
		}
	}

	public virtual Label _lblName_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblName_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblName_1 = value;
		}
	}

	public virtual Label _lblName_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblName_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblName_0 = value;
		}
	}

	public virtual Label lblCBI
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblCBI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblCBI = value;
		}
	}

	public virtual Label lblDate
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDate;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDate = value;
		}
	}

	public virtual Label lblID
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblID;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblID = value;
		}
	}

	public virtual Label lblStatus
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblStatus;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblStatus = value;
		}
	}

	public virtual Label lblAssessType
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAssessType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAssessType = value;
		}
	}

	public virtual Label _Label1_11
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_11 = value;
		}
	}

	public virtual Label _Line1_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_2 = value;
		}
	}

	public virtual Label _Line1_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_1 = value;
		}
	}

	public virtual Label _Label1_10
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_10 = value;
		}
	}

	public virtual Label _Label1_32
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_32;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_32 = value;
		}
	}

	public virtual Label _Label1_25
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_25;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_25 = value;
		}
	}

	public virtual Label _Label1_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_7 = value;
		}
	}

	public virtual Label _Line1_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_0 = value;
		}
	}

	public virtual Label _Label1_9
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_9 = value;
		}
	}

	public virtual Label _Label1_5
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_5 = value;
		}
	}

	public virtual Label _Label1_4
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_4 = value;
		}
	}

	public virtual Label _Label1_30
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_30;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_30 = value;
		}
	}

	public virtual Label _Label1_29
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_29;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_29 = value;
		}
	}

	public virtual Label _Label1_13
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_13 = value;
		}
	}

	public virtual Label _Label1_8
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_8 = value;
		}
	}

	public virtual Label _Label1_6
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_6 = value;
		}
	}

	public virtual Label _Label1_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_1 = value;
		}
	}

	public virtual Label _Label1_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_0 = value;
		}
	}

	public virtual GroupBox _fraTab_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraTab_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraTab_0 = value;
		}
	}

	public virtual ListBox _lstSelOps_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lstSelOps_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = lstSelOps_DoubleClick;
			EventHandler eventHandler2 = lstSelOps1_SelectedIndexChanged;
			if (__lstSelOps_1 != null)
			{
				((Control)__lstSelOps_1).DoubleClick -= eventHandler;
				__lstSelOps_1.SelectedIndexChanged -= eventHandler2;
			}
			__lstSelOps_1 = value;
			if (__lstSelOps_1 != null)
			{
				((Control)__lstSelOps_1).DoubleClick += eventHandler;
				__lstSelOps_1.SelectedIndexChanged += eventHandler2;
			}
		}
	}

	public virtual AxMSFlexGrid _msfCont_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __msfCont_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = msfCont_DblClick;
			EventHandler eventHandler2 = msfCont_ClickEvent;
			if (__msfCont_0 != null)
			{
				__msfCont_0.DblClick -= eventHandler;
				__msfCont_0.ClickEvent -= eventHandler2;
			}
			__msfCont_0 = value;
			if (__msfCont_0 != null)
			{
				__msfCont_0.DblClick += eventHandler;
				__msfCont_0.ClickEvent += eventHandler2;
			}
		}
	}

	public virtual TextBox txtContDrm
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtContDrm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtContDrm_Leave;
			if (_txtContDrm != null)
			{
				((Control)_txtContDrm).Leave -= eventHandler;
			}
			_txtContDrm = value;
			if (_txtContDrm != null)
			{
				((Control)_txtContDrm).Leave += eventHandler;
			}
		}
	}

	public virtual Label lblDrmType
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDrmType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDrmType = value;
		}
	}

	public virtual Label _lblContYrm_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblContYrm_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblContYrm_0 = value;
		}
	}

	public virtual Label _lblContSumFC_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblContSumFC_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblContSumFC_0 = value;
		}
	}

	public virtual Label _Label1_81
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_81;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_81 = value;
		}
	}

	public virtual GroupBox _fraConts_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraConts_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraConts_0 = value;
		}
	}

	public virtual AxMSFlexGrid _msfCont_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __msfCont_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = msfCont_DblClick;
			EventHandler eventHandler2 = msfCont_ClickEvent;
			if (__msfCont_2 != null)
			{
				__msfCont_2.DblClick -= eventHandler;
				__msfCont_2.ClickEvent -= eventHandler2;
			}
			__msfCont_2 = value;
			if (__msfCont_2 != null)
			{
				__msfCont_2.DblClick += eventHandler;
				__msfCont_2.ClickEvent += eventHandler2;
			}
		}
	}

	public virtual Label _lblContYprod_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblContYprod_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblContYprod_0 = value;
		}
	}

	public virtual Label _lblContYrm_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblContYrm_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblContYrm_1 = value;
		}
	}

	public virtual Label _lblContSumFC_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblContSumFC_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblContSumFC_2 = value;
		}
	}

	public virtual GroupBox _fraConts_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraConts_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraConts_2 = value;
		}
	}

	public virtual AxMSFlexGrid _msfCont_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __msfCont_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = msfCont_DblClick;
			EventHandler eventHandler2 = msfCont_ClickEvent;
			if (__msfCont_1 != null)
			{
				__msfCont_1.DblClick -= eventHandler;
				__msfCont_1.ClickEvent -= eventHandler2;
			}
			__msfCont_1 = value;
			if (__msfCont_1 != null)
			{
				__msfCont_1.DblClick += eventHandler;
				__msfCont_1.ClickEvent += eventHandler2;
			}
		}
	}

	public virtual TextBox txtContDprod
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtContDprod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = txtContDprod_Leave;
			if (_txtContDprod != null)
			{
				((Control)_txtContDprod).Leave -= eventHandler;
			}
			_txtContDprod = value;
			if (_txtContDprod != null)
			{
				((Control)_txtContDprod).Leave += eventHandler;
			}
		}
	}

	public virtual Label lblDprodType
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblDprodType;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblDprodType = value;
		}
	}

	public virtual Label _lblContYprod_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblContYprod_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblContYprod_1 = value;
		}
	}

	public virtual Label _lblContSumFC_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __lblContSumFC_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__lblContSumFC_1 = value;
		}
	}

	public virtual Label _Label1_80
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_80;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_80 = value;
		}
	}

	public virtual GroupBox _fraConts_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraConts_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraConts_1 = value;
		}
	}

	public virtual AxMSFlexGrid _msfCont_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __msfCont_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = msfCont_DblClick;
			EventHandler eventHandler2 = msfCont_ClickEvent;
			if (__msfCont_3 != null)
			{
				__msfCont_3.DblClick -= eventHandler;
				__msfCont_3.ClickEvent -= eventHandler2;
			}
			__msfCont_3 = value;
			if (__msfCont_3 != null)
			{
				__msfCont_3.DblClick += eventHandler;
				__msfCont_3.ClickEvent += eventHandler2;
			}
		}
	}

	public virtual Label lblContOD
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblContOD;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblContOD = value;
		}
	}

	public virtual GroupBox _fraConts_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraConts_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraConts_3 = value;
		}
	}

	public virtual AxTabStrip tabConts
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabConts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = tabConts_ClickEvent;
			if (_tabConts != null)
			{
				_tabConts.ClickEvent -= eventHandler;
			}
			_tabConts = value;
			if (_tabConts != null)
			{
				_tabConts.ClickEvent += eventHandler;
			}
		}
	}

	public virtual GroupBox _fraIP_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraIP_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraIP_1 = value;
		}
	}

	public virtual Button cmdUpdAVP
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdAVP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdAVP_Click;
			if (_cmdUpdAVP != null)
			{
				((Control)_cmdUpdAVP).Click -= eventHandler;
			}
			_cmdUpdAVP = value;
			if (_cmdUpdAVP != null)
			{
				((Control)_cmdUpdAVP).Click += eventHandler;
			}
		}
	}

	public virtual AxMSFlexGrid msfSP
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfSP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = msfSP_DblClick;
			if (_msfSP != null)
			{
				_msfSP.DblClick -= eventHandler;
			}
			_msfSP = value;
			if (_msfSP != null)
			{
				_msfSP.DblClick += eventHandler;
			}
		}
	}

	public virtual Label _Line1_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __Line1_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Line1_3 = value;
		}
	}

	public virtual Label lblAVPhigh
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAVPhigh;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAVPhigh = value;
		}
	}

	public virtual Label lblAVPlow
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAVPlow;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAVPlow = value;
		}
	}

	public virtual Label _Label1_86
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_86;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_86 = value;
		}
	}

	public virtual Label _Label1_85
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_85;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_85 = value;
		}
	}

	public virtual GroupBox _fraIP_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraIP_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraIP_2 = value;
		}
	}

	public virtual AxMSFlexGrid msfOpIP
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfOpIP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfOpIP = value;
		}
	}

	public virtual GroupBox _fraIP_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraIP_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraIP_0 = value;
		}
	}

	public virtual AxTabStrip tabIP
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabIP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabIP = value;
		}
	}

	public virtual GroupBox _fraTab_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraTab_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraTab_3 = value;
		}
	}

	public virtual LabelArray LVE
	{
		[DebuggerNonUserCode]
		get
		{
			return _LVE;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LVE = value;
		}
	}

	public virtual LabelArray Label1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label1 = value;
		}
	}

	public virtual LabelArray Label2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label2 = value;
		}
	}

	public virtual LabelArray Label3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label3 = value;
		}
	}

	public virtual LabelArray Label4
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label4 = value;
		}
	}

	public virtual LabelArray Line1
	{
		[DebuggerNonUserCode]
		get
		{
			return _Line1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Line1 = value;
		}
	}

	public virtual LabelArray Line2
	{
		[DebuggerNonUserCode]
		get
		{
			return _Line2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Line2 = value;
		}
	}

	public virtual LabelArray Line3
	{
		[DebuggerNonUserCode]
		get
		{
			return _Line3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Line3 = value;
		}
	}

	public virtual GroupBoxArray fraConts
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraConts;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraConts = value;
		}
	}

	public virtual GroupBoxArray fraExpTab
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraExpTab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraExpTab = value;
		}
	}

	public virtual GroupBoxArray fraIP
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraIP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraIP = value;
		}
	}

	public virtual GroupBoxArray fraOpInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraOpInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraOpInfo = value;
		}
	}

	public virtual GroupBoxArray fraOpTab
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraOpTab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraOpTab = value;
		}
	}

	public virtual GroupBoxArray fraSubOI
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraSubOI;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraSubOI = value;
		}
	}

	public virtual GroupBoxArray fraTab
	{
		[DebuggerNonUserCode]
		get
		{
			return _fraTab;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_fraTab = value;
		}
	}

	public virtual LabelArray lblAddr
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAddr;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAddr = value;
		}
	}

	public virtual LabelArray lblAff
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblAff;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblAff = value;
		}
	}

	public virtual LabelArray lblChemStateExp
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblChemStateExp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblChemStateExp = value;
		}
	}

	public virtual LabelArray lblContSumFC
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblContSumFC;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblContSumFC = value;
		}
	}

	public virtual LabelArray lblContYprod
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblContYprod;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblContYprod = value;
		}
	}

	public virtual LabelArray lblContYrm
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblContYrm;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblContYrm = value;
		}
	}

	public virtual LabelArray lblEmail
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblEmail;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblEmail = value;
		}
	}

	public virtual LabelArray lblGT100WorkersW1to10
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblGT100WorkersW1to10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblGT100WorkersW1to10 = value;
		}
	}

	public virtual LabelArray lblName
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblName;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblName = value;
		}
	}

	public virtual LabelArray lblNumWMet
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblNumWMet;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblNumWMet = value;
		}
	}

	public virtual LabelArray lblPhone
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPhone;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPhone = value;
		}
	}

	public virtual LabelArray lblPhyState
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPhyState;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPhyState = value;
		}
	}

	public virtual LabelArray lblPhyStateOtherInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblPhyStateOtherInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblPhyStateOtherInfo = value;
		}
	}

	public virtual LabelArray lblSatEReq
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSatEReq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSatEReq = value;
		}
	}

	public virtual LabelArray lblSatHReq
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblSatHReq;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblSatHReq = value;
		}
	}

	public virtual MenuItemArray mnuPreferences
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuPreferences;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuPreferences_Click;
			if (_mnuPreferences != null)
			{
				_mnuPreferences.Click -= eventHandler;
			}
			_mnuPreferences = value;
			if (_mnuPreferences != null)
			{
				_mnuPreferences.Click += eventHandler;
			}
		}
	}

	public virtual TextBoxArray txtExpModelMsg
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtExpModelMsg;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtExpModelMsg = value;
		}
	}

	public virtual TextBoxArray txtMsds
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtMsds;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtMsds = value;
		}
	}

	public virtual MenuItem mnuFileNew
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileNew;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileNew_Click;
			if (_mnuFileNew != null)
			{
				_mnuFileNew.Click -= eventHandler;
			}
			_mnuFileNew = value;
			if (_mnuFileNew != null)
			{
				_mnuFileNew.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuFileOpen
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileOpen;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileOpen_Click;
			if (_mnuFileOpen != null)
			{
				_mnuFileOpen.Click -= eventHandler;
			}
			_mnuFileOpen = value;
			if (_mnuFileOpen != null)
			{
				_mnuFileOpen.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuFileClose
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileClose;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileClose_Click;
			if (_mnuFileClose != null)
			{
				_mnuFileClose.Click -= eventHandler;
			}
			_mnuFileClose = value;
			if (_mnuFileClose != null)
			{
				_mnuFileClose.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuFileSep1
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileSep1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuFileSep1 = value;
		}
	}

	public virtual MenuItem mnuFileSave
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileSave;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileSave_Click;
			if (_mnuFileSave != null)
			{
				_mnuFileSave.Click -= eventHandler;
			}
			_mnuFileSave = value;
			if (_mnuFileSave != null)
			{
				_mnuFileSave.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuFileSaveAs
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileSaveAs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileSaveAs_Click;
			if (_mnuFileSaveAs != null)
			{
				_mnuFileSaveAs.Click -= eventHandler;
			}
			_mnuFileSaveAs = value;
			if (_mnuFileSaveAs != null)
			{
				_mnuFileSaveAs.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuFileSep2
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileSep2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuFileSep2 = value;
		}
	}

	public virtual MenuItem mnuFileRevHistory
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileRevHistory;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileRevHistory_Click;
			if (_mnuFileRevHistory != null)
			{
				_mnuFileRevHistory.Click -= eventHandler;
			}
			_mnuFileRevHistory = value;
			if (_mnuFileRevHistory != null)
			{
				_mnuFileRevHistory.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuFileSep3
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileSep3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuFileSep3 = value;
		}
	}

	public virtual MenuItem mnuFileDelete
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileDelete;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileDelete_Click;
			if (_mnuFileDelete != null)
			{
				_mnuFileDelete.Click -= eventHandler;
			}
			_mnuFileDelete = value;
			if (_mnuFileDelete != null)
			{
				_mnuFileDelete.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuFileSep4
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileSep4;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuFileSep4 = value;
		}
	}

	public virtual MenuItem mnuFileImportCRSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileImportCRSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileImportCRSS_Click;
			EventHandler eventHandler2 = mnuFileImportCRSS_Popup;
			if (_mnuFileImportCRSS != null)
			{
				_mnuFileImportCRSS.Click -= eventHandler;
				_mnuFileImportCRSS.Popup -= eventHandler2;
			}
			_mnuFileImportCRSS = value;
			if (_mnuFileImportCRSS != null)
			{
				_mnuFileImportCRSS.Click += eventHandler;
				_mnuFileImportCRSS.Popup += eventHandler2;
			}
		}
	}

	public virtual MenuItem mnuFileViewCRSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileViewCRSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileViewCRSS_Click;
			if (_mnuFileViewCRSS != null)
			{
				_mnuFileViewCRSS.Click -= eventHandler;
			}
			_mnuFileViewCRSS = value;
			if (_mnuFileViewCRSS != null)
			{
				_mnuFileViewCRSS.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuFileSep5
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileSep5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuFileSep5 = value;
		}
	}

	public virtual MenuItem mnuFileExit
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileExit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileExit_Click;
			if (_mnuFileExit != null)
			{
				_mnuFileExit.Click -= eventHandler;
			}
			_mnuFileExit = value;
			if (_mnuFileExit != null)
			{
				_mnuFileExit.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuFile
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFile;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuFile = value;
		}
	}

	public virtual MenuItem mnuEditCut
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuEditCut;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuEditCut = value;
		}
	}

	public virtual MenuItem mnuEditCopy
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuEditCopy;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuEditCopy = value;
		}
	}

	public virtual MenuItem mnuEditPaste
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuEditPaste;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuEditPaste = value;
		}
	}

	public virtual MenuItem mnuEdit
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuEdit;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuEdit = value;
		}
	}

	public virtual MenuItem _mnuPreferences_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __mnuPreferences_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__mnuPreferences_0 = value;
		}
	}

	public virtual MenuItem _mnuPreferences_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __mnuPreferences_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__mnuPreferences_1 = value;
		}
	}

	public virtual MenuItem _mnuPreferences_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __mnuPreferences_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__mnuPreferences_2 = value;
		}
	}

	public virtual MenuItem mnuPref
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuPref;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuPref = value;
		}
	}

	public virtual MenuItem _mnuReportIRER_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __mnuReportIRER_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuReportIRER0_Click;
			if (__mnuReportIRER_0 != null)
			{
				__mnuReportIRER_0.Click -= eventHandler;
			}
			__mnuReportIRER_0 = value;
			if (__mnuReportIRER_0 != null)
			{
				__mnuReportIRER_0.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuReportSep1
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuReportSep1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuReportSep1 = value;
		}
	}

	public virtual MenuItem _mnuReportCR_0
	{
		[DebuggerNonUserCode]
		get
		{
			return __mnuReportCR_0;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuReportCR0_Click;
			if (__mnuReportCR_0 != null)
			{
				__mnuReportCR_0.Click -= eventHandler;
			}
			__mnuReportCR_0 = value;
			if (__mnuReportCR_0 != null)
			{
				__mnuReportCR_0.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuReportSep2
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuReportSep2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuReportSep2 = value;
		}
	}

	public virtual MenuItem _mnuReportIRER_3
	{
		[DebuggerNonUserCode]
		get
		{
			return __mnuReportIRER_3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuReportIRERandCR_Click;
			if (__mnuReportIRER_3 != null)
			{
				__mnuReportIRER_3.Click -= eventHandler;
			}
			__mnuReportIRER_3 = value;
			if (__mnuReportIRER_3 != null)
			{
				__mnuReportIRER_3.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuReportS
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuReportS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuReportS = value;
		}
	}

	public virtual MenuItem mnuHelpViewUserGuide
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuHelpViewUserGuide;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuHelpViewUserGuide_Click;
			if (_mnuHelpViewUserGuide != null)
			{
				_mnuHelpViewUserGuide.Click -= eventHandler;
			}
			_mnuHelpViewUserGuide = value;
			if (_mnuHelpViewUserGuide != null)
			{
				_mnuHelpViewUserGuide.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuHelpAbout
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuHelpAbout;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuHelpAbout_Click;
			if (_mnuHelpAbout != null)
			{
				_mnuHelpAbout.Click -= eventHandler;
			}
			_mnuHelpAbout = value;
			if (_mnuHelpAbout != null)
			{
				_mnuHelpAbout.Click += eventHandler;
			}
		}
	}

	public virtual MenuItem mnuHelp
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuHelp;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuHelp = value;
		}
	}

	public virtual Label _Label1_333
	{
		[DebuggerNonUserCode]
		get
		{
			return __Label1_333;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__Label1_333 = value;
		}
	}

	internal virtual MenuItem _mnuReportIRER_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __mnuReportIRER_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuReportIRER1_Click;
			if (__mnuReportIRER_1 != null)
			{
				__mnuReportIRER_1.Click -= eventHandler;
			}
			__mnuReportIRER_1 = value;
			if (__mnuReportIRER_1 != null)
			{
				__mnuReportIRER_1.Click += eventHandler;
			}
		}
	}

	internal virtual MenuItem _mnuReportCR_1
	{
		[DebuggerNonUserCode]
		get
		{
			return __mnuReportCR_1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuReportCR1_Click;
			if (__mnuReportCR_1 != null)
			{
				__mnuReportCR_1.Click -= eventHandler;
			}
			__mnuReportCR_1 = value;
			if (__mnuReportCR_1 != null)
			{
				__mnuReportCR_1.Click += eventHandler;
			}
		}
	}

	internal virtual MenuItem _mnuReportIRER_2
	{
		[DebuggerNonUserCode]
		get
		{
			return __mnuReportIRER_2;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuReportIRERandCR2_Click;
			if (__mnuReportIRER_2 != null)
			{
				__mnuReportIRER_2.Click -= eventHandler;
			}
			__mnuReportIRER_2 = value;
			if (__mnuReportIRER_2 != null)
			{
				__mnuReportIRER_2.Click += eventHandler;
			}
		}
	}

	public virtual Button cmdGeneral
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdGeneral;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdGeneral_click;
			if (_cmdGeneral != null)
			{
				((Control)_cmdGeneral).Click -= eventHandler;
			}
			_cmdGeneral = value;
			if (_cmdGeneral != null)
			{
				((Control)_cmdGeneral).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdChemical
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdChemical;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdChemical_Click;
			if (_cmdChemical != null)
			{
				((Control)_cmdChemical).Click -= eventHandler;
			}
			_cmdChemical = value;
			if (_cmdChemical != null)
			{
				((Control)_cmdChemical).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdOpParms
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOpParms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOpParms_Click;
			if (_cmdOpParms != null)
			{
				((Control)_cmdOpParms).Click -= eventHandler;
			}
			_cmdOpParms = value;
			if (_cmdOpParms != null)
			{
				((Control)_cmdOpParms).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdOperations
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOperations;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOperations_Click;
			if (_cmdOperations != null)
			{
				((Control)_cmdOperations).Click -= eventHandler;
			}
			_cmdOperations = value;
			if (_cmdOperations != null)
			{
				((Control)_cmdOperations).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdExposures
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdExposures;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdExposures_Click;
			if (_cmdExposures != null)
			{
				((Control)_cmdExposures).Click -= eventHandler;
			}
			_cmdExposures = value;
			if (_cmdExposures != null)
			{
				((Control)_cmdExposures).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdReleases
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdReleases;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdReleases_Click;
			if (_cmdReleases != null)
			{
				((Control)_cmdReleases).Click -= eventHandler;
			}
			_cmdReleases = value;
			if (_cmdReleases != null)
			{
				((Control)_cmdReleases).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdOptionalInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdOptionalInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdOptionalInfo_Click;
			if (_cmdOptionalInfo != null)
			{
				((Control)_cmdOptionalInfo).Click -= eventHandler;
			}
			_cmdOptionalInfo = value;
			if (_cmdOptionalInfo != null)
			{
				((Control)_cmdOptionalInfo).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdSiteInfo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSiteInfo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSiteInfo_Click;
			if (_cmdSiteInfo != null)
			{
				((Control)_cmdSiteInfo).Click -= eventHandler;
			}
			_cmdSiteInfo = value;
			if (_cmdSiteInfo != null)
			{
				((Control)_cmdSiteInfo).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdSources
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSources;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSources_Click;
			if (_cmdSources != null)
			{
				((Control)_cmdSources).Click -= eventHandler;
			}
			_cmdSources = value;
			if (_cmdSources != null)
			{
				((Control)_cmdSources).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdPhysicalStates
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdPhysicalStates;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdPhysicalStates_Click;
			if (_cmdPhysicalStates != null)
			{
				((Control)_cmdPhysicalStates).Click -= eventHandler;
			}
			_cmdPhysicalStates = value;
			if (_cmdPhysicalStates != null)
			{
				((Control)_cmdPhysicalStates).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdDescription
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdDescription;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdDescription_Click;
			if (_cmdDescription != null)
			{
				((Control)_cmdDescription).Click -= eventHandler;
			}
			_cmdDescription = value;
			if (_cmdDescription != null)
			{
				((Control)_cmdDescription).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdRelationships
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRelationships;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRelationships_Click;
			if (_cmdRelationships != null)
			{
				((Control)_cmdRelationships).Click -= eventHandler;
			}
			_cmdRelationships = value;
			if (_cmdRelationships != null)
			{
				((Control)_cmdRelationships).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdRespirator
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRespirator;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRespirator_Click;
			if (_cmdRespirator != null)
			{
				((Control)_cmdRespirator).Click -= eventHandler;
			}
			_cmdRespirator = value;
			if (_cmdRespirator != null)
			{
				((Control)_cmdRespirator).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdActivity
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdActivity;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdActivity_Click;
			if (_cmdActivity != null)
			{
				((Control)_cmdActivity).Click -= eventHandler;
			}
			_cmdActivity = value;
			if (_cmdActivity != null)
			{
				((Control)_cmdActivity).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdInhalation
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdInhalation;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdInhalation_Click;
			if (_cmdInhalation != null)
			{
				((Control)_cmdInhalation).Click -= eventHandler;
			}
			_cmdInhalation = value;
			if (_cmdInhalation != null)
			{
				((Control)_cmdInhalation).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdDermal
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdDermal;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdDermal_Click;
			if (_cmdDermal != null)
			{
				((Control)_cmdDermal).Click -= eventHandler;
			}
			_cmdDermal = value;
			if (_cmdDermal != null)
			{
				((Control)_cmdDermal).Click += eventHandler;
			}
		}
	}

	public virtual AxMSFlexGrid msfSubOps
	{
		[DebuggerNonUserCode]
		get
		{
			return _msfSubOps;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_msfSubOps = value;
		}
	}

	internal virtual Label Label6
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label6 = value;
		}
	}

	public virtual Button cmdSharedParms
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSharedParms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSharedParms_Click;
			if (_cmdSharedParms != null)
			{
				((Control)_cmdSharedParms).Click -= eventHandler;
			}
			_cmdSharedParms = value;
			if (_cmdSharedParms != null)
			{
				((Control)_cmdSharedParms).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdContainerParms
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdContainerParms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdContainerParms_Click;
			if (_cmdContainerParms != null)
			{
				((Control)_cmdContainerParms).Click -= eventHandler;
			}
			_cmdContainerParms = value;
			if (_cmdContainerParms != null)
			{
				((Control)_cmdContainerParms).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdMassBalParms
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdMassBalParms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdMassBalParms_Click;
			if (_cmdMassBalParms != null)
			{
				((Control)_cmdMassBalParms).Click -= eventHandler;
			}
			_cmdMassBalParms = value;
			if (_cmdMassBalParms != null)
			{
				((Control)_cmdMassBalParms).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdEstReleases
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdEstReleases;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdEstReleases_Click;
			if (_cmdEstReleases != null)
			{
				((Control)_cmdEstReleases).Click -= eventHandler;
			}
			_cmdEstReleases = value;
			if (_cmdEstReleases != null)
			{
				((Control)_cmdEstReleases).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdRelParms
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdRelParms;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdRelParms_Click;
			if (_cmdRelParms != null)
			{
				((Control)_cmdRelParms).Click -= eventHandler;
			}
			_cmdRelParms = value;
			if (_cmdRelParms != null)
			{
				((Control)_cmdRelParms).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label7
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label7 = value;
		}
	}

	public virtual AxTabStrip tabMain
	{
		[DebuggerNonUserCode]
		get
		{
			return _tabMain;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_tabMain = value;
		}
	}

	internal virtual Label Label8
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label8;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label8 = value;
		}
	}

	internal virtual Label Label9
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label9;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label9 = value;
		}
	}

	public virtual Label Label10
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label10;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label10 = value;
		}
	}

	public virtual Label Label11
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label11;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label11 = value;
		}
	}

	public virtual Label Label12
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label12;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label12 = value;
		}
	}

	public virtual Button cmdUpdOpIP
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdUpdOpIP;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdUpdOpIP_Click;
			if (_cmdUpdOpIP != null)
			{
				((Control)_cmdUpdOpIP).Click -= eventHandler;
			}
			_cmdUpdOpIP = value;
			if (_cmdUpdOpIP != null)
			{
				((Control)_cmdUpdOpIP).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdReports
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdReports;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdReports_Click;
			if (_cmdReports != null)
			{
				((Control)_cmdReports).Click -= eventHandler;
			}
			_cmdReports = value;
			if (_cmdReports != null)
			{
				((Control)_cmdReports).Click += eventHandler;
			}
		}
	}

	internal virtual Label Label13
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label13;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label13 = value;
		}
	}

	internal virtual Label Label18
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label18;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label18 = value;
		}
	}

	internal virtual Label Label17
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label17;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label17 = value;
		}
	}

	internal virtual Label Label16
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label16;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label16 = value;
		}
	}

	internal virtual Label Label14
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label14;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label14 = value;
		}
	}

	internal virtual Label Label15
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label15;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label15 = value;
		}
	}

	internal virtual GroupBox _fraTab_7
	{
		[DebuggerNonUserCode]
		get
		{
			return __fraTab_7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			__fraTab_7 = value;
		}
	}

	public virtual Button cmdSaveCombo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSaveCombo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSaveCombo_Click;
			if (_cmdSaveCombo != null)
			{
				((Control)_cmdSaveCombo).Click -= eventHandler;
			}
			_cmdSaveCombo = value;
			if (_cmdSaveCombo != null)
			{
				((Control)_cmdSaveCombo).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdViewCombo
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdViewCombo;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdViewCombo_Click;
			if (_cmdViewCombo != null)
			{
				((Control)_cmdViewCombo).Click -= eventHandler;
			}
			_cmdViewCombo = value;
			if (_cmdViewCombo != null)
			{
				((Control)_cmdViewCombo).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdSaveContact
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSaveContact;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSaveContact_Click;
			if (_cmdSaveContact != null)
			{
				((Control)_cmdSaveContact).Click -= eventHandler;
			}
			_cmdSaveContact = value;
			if (_cmdSaveContact != null)
			{
				((Control)_cmdSaveContact).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdViewContact
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdViewContact;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdViewContact_Click;
			if (_cmdViewContact != null)
			{
				((Control)_cmdViewContact).Click -= eventHandler;
			}
			_cmdViewContact = value;
			if (_cmdViewContact != null)
			{
				((Control)_cmdViewContact).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdSaveIRER
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdSaveIRER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdSaveIRER_Click;
			if (_cmdSaveIRER != null)
			{
				((Control)_cmdSaveIRER).Click -= eventHandler;
			}
			_cmdSaveIRER = value;
			if (_cmdSaveIRER != null)
			{
				((Control)_cmdSaveIRER).Click += eventHandler;
			}
		}
	}

	public virtual Button cmdViewIRER
	{
		[DebuggerNonUserCode]
		get
		{
			return _cmdViewIRER;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = cmdViewIRER_Click;
			if (_cmdViewIRER != null)
			{
				((Control)_cmdViewIRER).Click -= eventHandler;
			}
			_cmdViewIRER = value;
			if (_cmdViewIRER != null)
			{
				((Control)_cmdViewIRER).Click += eventHandler;
			}
		}
	}

	public virtual Label Label19
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label19;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label19 = value;
		}
	}

	internal virtual MenuItem mnuFileUpdateGSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileUpdateGSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileUpdateGSS_Click;
			if (_mnuFileUpdateGSS != null)
			{
				_mnuFileUpdateGSS.Click -= eventHandler;
			}
			_mnuFileUpdateGSS = value;
			if (_mnuFileUpdateGSS != null)
			{
				_mnuFileUpdateGSS.Click += eventHandler;
			}
		}
	}

	internal virtual MenuItem mnuFileSaveGSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileSaveGSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileSaveGSS_Click;
			if (_mnuFileSaveGSS != null)
			{
				_mnuFileSaveGSS.Click -= eventHandler;
			}
			_mnuFileSaveGSS = value;
			if (_mnuFileSaveGSS != null)
			{
				_mnuFileSaveGSS.Click += eventHandler;
			}
		}
	}

	internal virtual MenuItem mnuFileDeleteGSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileDeleteGSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileDeleteGSS_Click;
			if (_mnuFileDeleteGSS != null)
			{
				_mnuFileDeleteGSS.Click -= eventHandler;
			}
			_mnuFileDeleteGSS = value;
			if (_mnuFileDeleteGSS != null)
			{
				_mnuFileDeleteGSS.Click += eventHandler;
			}
		}
	}

	internal virtual MenuItem mnuFileSep7
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileSep7;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuFileSep7 = value;
		}
	}

	public virtual Label LabelSubTabs3
	{
		[DebuggerNonUserCode]
		get
		{
			return _LabelSubTabs3;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_LabelSubTabs3 = value;
		}
	}

	public virtual Label lblOpParmSubtabs
	{
		[DebuggerNonUserCode]
		get
		{
			return _lblOpParmSubtabs;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_lblOpParmSubtabs = value;
		}
	}

	internal virtual MenuItem mnuHelpViewQuickStartGuide
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuHelpViewQuickStartGuide;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuHelpViewQuickStartGuide_Click;
			if (_mnuHelpViewQuickStartGuide != null)
			{
				_mnuHelpViewQuickStartGuide.Click -= eventHandler;
			}
			_mnuHelpViewQuickStartGuide = value;
			if (_mnuHelpViewQuickStartGuide != null)
			{
				_mnuHelpViewQuickStartGuide.Click += eventHandler;
			}
		}
	}

	public virtual TextBox txtSatRelatedCases
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtSatRelatedCases;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtSatRelatedCases = value;
		}
	}

	public virtual Label Label5
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label5;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label5 = value;
		}
	}

	public virtual Label Label21
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label21;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label21 = value;
		}
	}

	public virtual Label Label22
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label22;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label22 = value;
		}
	}

	public virtual Label Label23
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label23;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label23 = value;
		}
	}

	internal virtual MenuItem mnuFileEasyModels
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileEasyModels;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileEasyModels_Click;
			if (_mnuFileEasyModels != null)
			{
				_mnuFileEasyModels.Click -= eventHandler;
			}
			_mnuFileEasyModels = value;
			if (_mnuFileEasyModels != null)
			{
				_mnuFileEasyModels.Click += eventHandler;
			}
		}
	}

	internal virtual MenuItem mnuFileSep6
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileSep6;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_mnuFileSep6 = value;
		}
	}

	internal virtual MenuItem mnuFileRenameGSS
	{
		[DebuggerNonUserCode]
		get
		{
			return _mnuFileRenameGSS;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			EventHandler eventHandler = mnuFileRenameGSS_Click;
			if (_mnuFileRenameGSS != null)
			{
				_mnuFileRenameGSS.Click -= eventHandler;
			}
			_mnuFileRenameGSS = value;
			if (_mnuFileRenameGSS != null)
			{
				_mnuFileRenameGSS.Click += eventHandler;
			}
		}
	}

	internal virtual Label Label20
	{
		[DebuggerNonUserCode]
		get
		{
			return _Label20;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_Label20 = value;
		}
	}

	internal virtual CachedIRERcomb CachedIRERcomb1
	{
		[DebuggerNonUserCode]
		get
		{
			return _CachedIRERcomb1;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_CachedIRERcomb1 = value;
		}
	}

	public virtual TextBox txtChemGenUse
	{
		[DebuggerNonUserCode]
		get
		{
			return _txtChemGenUse;
		}
		[MethodImpl(MethodImplOptions.Synchronized)]
		[DebuggerNonUserCode]
		set
		{
			_txtChemGenUse = value;
		}
	}

	public static frmMain DefInstance
	{
		get
		{
			if (m_vb6FormDefInstance == null || (((Control)m_vb6FormDefInstance).IsDisposed ? true : false))
			{
				m_InitializingDefInstance = true;
				m_vb6FormDefInstance = new frmMain();
				m_InitializingDefInstance = false;
			}
			return m_vb6FormDefInstance;
		}
		set
		{
			m_vb6FormDefInstance = value;
		}
	}

	[DebuggerNonUserCode]
	private static void __ENCAddToList(object value)
	{
		checked
		{
			lock (__ENCList)
			{
				if (__ENCList.Count == __ENCList.Capacity)
				{
					int num = 0;
					int num2 = __ENCList.Count - 1;
					int num3 = 0;
					while (true)
					{
						int num4 = num3;
						int num5 = num2;
						if (num4 > num5)
						{
							break;
						}
						WeakReference weakReference = __ENCList[num3];
						if (weakReference.IsAlive)
						{
							if (num3 != num)
							{
								__ENCList[num] = __ENCList[num3];
							}
							num++;
						}
						num3++;
					}
					__ENCList.RemoveRange(num, __ENCList.Count - num);
					__ENCList.Capacity = __ENCList.Count;
				}
				__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}
	}

	public frmMain()
	{
		((Form)this).Shown += frmMain_Shown;
		((Form)this).Load += frmMain_Load;
		((Form)this).Closing += frmMain_Closing;
		((Form)this).Closed += frmMain_Closed;
		__ENCAddToList(this);
		if (m_vb6FormDefInstance == null)
		{
			if (m_InitializingDefInstance)
			{
				m_vb6FormDefInstance = this;
			}
			else
			{
				try
				{
					if ((object)Assembly.GetExecutingAssembly().EntryPoint.DeclaringType == ((object)this).GetType())
					{
						m_vb6FormDefInstance = this;
					}
				}
				catch (Exception projectError)
				{
					ProjectData.SetProjectError(projectError);
					ProjectData.ClearProjectError();
				}
			}
		}
		InitializeComponent();
	}

	protected override void Dispose(bool Disposing)
	{
		if (Disposing && components != null)
		{
			components.Dispose();
		}
		((Form)this).Dispose(Disposing);
	}

	[DebuggerStepThrough]
	private void InitializeComponent()
	{
		//IL_0023: Unknown result type (might be due to invalid IL or missing references)
		//IL_002d: Expected O, but got Unknown
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0038: Expected O, but got Unknown
		//IL_003a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0044: Expected O, but got Unknown
		//IL_0046: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected O, but got Unknown
		//IL_0052: Unknown result type (might be due to invalid IL or missing references)
		//IL_005c: Expected O, but got Unknown
		//IL_005e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0068: Expected O, but got Unknown
		//IL_006a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0074: Expected O, but got Unknown
		//IL_0076: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Expected O, but got Unknown
		//IL_0082: Unknown result type (might be due to invalid IL or missing references)
		//IL_008c: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		//IL_009a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a4: Expected O, but got Unknown
		//IL_00a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b0: Expected O, but got Unknown
		//IL_00b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00bc: Expected O, but got Unknown
		//IL_00be: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c8: Expected O, but got Unknown
		//IL_00ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d4: Expected O, but got Unknown
		//IL_00d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e0: Expected O, but got Unknown
		//IL_00e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ec: Expected O, but got Unknown
		//IL_00ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_00f8: Expected O, but got Unknown
		//IL_00fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0104: Expected O, but got Unknown
		//IL_0106: Unknown result type (might be due to invalid IL or missing references)
		//IL_0110: Expected O, but got Unknown
		//IL_0112: Unknown result type (might be due to invalid IL or missing references)
		//IL_011c: Expected O, but got Unknown
		//IL_011e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Expected O, but got Unknown
		//IL_012a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0134: Expected O, but got Unknown
		//IL_0136: Unknown result type (might be due to invalid IL or missing references)
		//IL_0140: Expected O, but got Unknown
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		//IL_014e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0158: Expected O, but got Unknown
		//IL_015a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0164: Expected O, but got Unknown
		//IL_0166: Unknown result type (might be due to invalid IL or missing references)
		//IL_0170: Expected O, but got Unknown
		//IL_0172: Unknown result type (might be due to invalid IL or missing references)
		//IL_017c: Expected O, but got Unknown
		//IL_017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0188: Expected O, but got Unknown
		//IL_018a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0194: Expected O, but got Unknown
		//IL_0196: Unknown result type (might be due to invalid IL or missing references)
		//IL_01a0: Expected O, but got Unknown
		//IL_01a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ac: Expected O, but got Unknown
		//IL_01ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b8: Expected O, but got Unknown
		//IL_01ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c4: Expected O, but got Unknown
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01d0: Expected O, but got Unknown
		//IL_01d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_01dc: Expected O, but got Unknown
		//IL_01de: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Expected O, but got Unknown
		//IL_01ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f4: Expected O, but got Unknown
		//IL_01f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0200: Expected O, but got Unknown
		//IL_0202: Unknown result type (might be due to invalid IL or missing references)
		//IL_020c: Expected O, but got Unknown
		//IL_020e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0218: Expected O, but got Unknown
		//IL_021a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0224: Expected O, but got Unknown
		//IL_0226: Unknown result type (might be due to invalid IL or missing references)
		//IL_0230: Expected O, but got Unknown
		//IL_0232: Unknown result type (might be due to invalid IL or missing references)
		//IL_023c: Expected O, but got Unknown
		//IL_023e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0248: Expected O, but got Unknown
		//IL_024a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0254: Expected O, but got Unknown
		//IL_0256: Unknown result type (might be due to invalid IL or missing references)
		//IL_0260: Expected O, but got Unknown
		//IL_0262: Unknown result type (might be due to invalid IL or missing references)
		//IL_026c: Expected O, but got Unknown
		//IL_026e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0278: Expected O, but got Unknown
		//IL_027a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0284: Expected O, but got Unknown
		//IL_0286: Unknown result type (might be due to invalid IL or missing references)
		//IL_0290: Expected O, but got Unknown
		//IL_0292: Unknown result type (might be due to invalid IL or missing references)
		//IL_029c: Expected O, but got Unknown
		//IL_029e: Unknown result type (might be due to invalid IL or missing references)
		//IL_02a8: Expected O, but got Unknown
		//IL_02aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_02b4: Expected O, but got Unknown
		//IL_02b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02c0: Expected O, but got Unknown
		//IL_02c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02cc: Expected O, but got Unknown
		//IL_02ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d8: Expected O, but got Unknown
		//IL_02da: Unknown result type (might be due to invalid IL or missing references)
		//IL_02e4: Expected O, but got Unknown
		//IL_02e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_02f0: Expected O, but got Unknown
		//IL_02f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_02fc: Expected O, but got Unknown
		//IL_02fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0308: Expected O, but got Unknown
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0314: Expected O, but got Unknown
		//IL_0316: Unknown result type (might be due to invalid IL or missing references)
		//IL_0320: Expected O, but got Unknown
		//IL_0322: Unknown result type (might be due to invalid IL or missing references)
		//IL_032c: Expected O, but got Unknown
		//IL_032e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0338: Expected O, but got Unknown
		//IL_033a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0344: Expected O, but got Unknown
		//IL_0346: Unknown result type (might be due to invalid IL or missing references)
		//IL_0350: Expected O, but got Unknown
		//IL_0352: Unknown result type (might be due to invalid IL or missing references)
		//IL_035c: Expected O, but got Unknown
		//IL_035e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0368: Expected O, but got Unknown
		//IL_036a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0374: Expected O, but got Unknown
		//IL_0376: Unknown result type (might be due to invalid IL or missing references)
		//IL_0380: Expected O, but got Unknown
		//IL_0382: Unknown result type (might be due to invalid IL or missing references)
		//IL_038c: Expected O, but got Unknown
		//IL_038e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0398: Expected O, but got Unknown
		//IL_039a: Unknown result type (might be due to invalid IL or missing references)
		//IL_03a4: Expected O, but got Unknown
		//IL_03a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03b0: Expected O, but got Unknown
		//IL_03b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03bc: Expected O, but got Unknown
		//IL_03be: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c8: Expected O, but got Unknown
		//IL_03ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_03d4: Expected O, but got Unknown
		//IL_03d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_03e0: Expected O, but got Unknown
		//IL_03e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_03ec: Expected O, but got Unknown
		//IL_03ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_03f8: Expected O, but got Unknown
		//IL_03fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0404: Expected O, but got Unknown
		//IL_0406: Unknown result type (might be due to invalid IL or missing references)
		//IL_0410: Expected O, but got Unknown
		//IL_0412: Unknown result type (might be due to invalid IL or missing references)
		//IL_041c: Expected O, but got Unknown
		//IL_041e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0428: Expected O, but got Unknown
		//IL_042a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0434: Expected O, but got Unknown
		//IL_0436: Unknown result type (might be due to invalid IL or missing references)
		//IL_0440: Expected O, but got Unknown
		//IL_0442: Unknown result type (might be due to invalid IL or missing references)
		//IL_044c: Expected O, but got Unknown
		//IL_044e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0458: Expected O, but got Unknown
		//IL_045a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0464: Expected O, but got Unknown
		//IL_0466: Unknown result type (might be due to invalid IL or missing references)
		//IL_0470: Expected O, but got Unknown
		//IL_0472: Unknown result type (might be due to invalid IL or missing references)
		//IL_047c: Expected O, but got Unknown
		//IL_047e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0488: Expected O, but got Unknown
		//IL_048a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0494: Expected O, but got Unknown
		//IL_0496: Unknown result type (might be due to invalid IL or missing references)
		//IL_04a0: Expected O, but got Unknown
		//IL_04a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04ac: Expected O, but got Unknown
		//IL_04ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_04b8: Expected O, but got Unknown
		//IL_04ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_04c4: Expected O, but got Unknown
		//IL_04c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_04d0: Expected O, but got Unknown
		//IL_04d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_04dc: Expected O, but got Unknown
		//IL_04de: Unknown result type (might be due to invalid IL or missing references)
		//IL_04e8: Expected O, but got Unknown
		//IL_04ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_04f4: Expected O, but got Unknown
		//IL_04f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0500: Expected O, but got Unknown
		//IL_0502: Unknown result type (might be due to invalid IL or missing references)
		//IL_050c: Expected O, but got Unknown
		//IL_050e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0518: Expected O, but got Unknown
		//IL_051a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0524: Expected O, but got Unknown
		//IL_0526: Unknown result type (might be due to invalid IL or missing references)
		//IL_0530: Expected O, but got Unknown
		//IL_0532: Unknown result type (might be due to invalid IL or missing references)
		//IL_053c: Expected O, but got Unknown
		//IL_053e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0548: Expected O, but got Unknown
		//IL_054a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0554: Expected O, but got Unknown
		//IL_0556: Unknown result type (might be due to invalid IL or missing references)
		//IL_0560: Expected O, but got Unknown
		//IL_0562: Unknown result type (might be due to invalid IL or missing references)
		//IL_056c: Expected O, but got Unknown
		//IL_056e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0578: Expected O, but got Unknown
		//IL_057a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0584: Expected O, but got Unknown
		//IL_0586: Unknown result type (might be due to invalid IL or missing references)
		//IL_0590: Expected O, but got Unknown
		//IL_0592: Unknown result type (might be due to invalid IL or missing references)
		//IL_059c: Expected O, but got Unknown
		//IL_059e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05a8: Expected O, but got Unknown
		//IL_05aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_05b4: Expected O, but got Unknown
		//IL_05b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05c0: Expected O, but got Unknown
		//IL_05c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05cc: Expected O, but got Unknown
		//IL_05ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_05d8: Expected O, but got Unknown
		//IL_05da: Unknown result type (might be due to invalid IL or missing references)
		//IL_05e4: Expected O, but got Unknown
		//IL_05e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_05f0: Expected O, but got Unknown
		//IL_05f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fc: Expected O, but got Unknown
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0608: Expected O, but got Unknown
		//IL_060a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0614: Expected O, but got Unknown
		//IL_0616: Unknown result type (might be due to invalid IL or missing references)
		//IL_0620: Expected O, but got Unknown
		//IL_0622: Unknown result type (might be due to invalid IL or missing references)
		//IL_062c: Expected O, but got Unknown
		//IL_062e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0638: Expected O, but got Unknown
		//IL_063a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0644: Expected O, but got Unknown
		//IL_0646: Unknown result type (might be due to invalid IL or missing references)
		//IL_0650: Expected O, but got Unknown
		//IL_0652: Unknown result type (might be due to invalid IL or missing references)
		//IL_065c: Expected O, but got Unknown
		//IL_065e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0668: Expected O, but got Unknown
		//IL_066a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0674: Expected O, but got Unknown
		//IL_0676: Unknown result type (might be due to invalid IL or missing references)
		//IL_0680: Expected O, but got Unknown
		//IL_0682: Unknown result type (might be due to invalid IL or missing references)
		//IL_068c: Expected O, but got Unknown
		//IL_068e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0698: Expected O, but got Unknown
		//IL_069a: Unknown result type (might be due to invalid IL or missing references)
		//IL_06a4: Expected O, but got Unknown
		//IL_06a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06b0: Expected O, but got Unknown
		//IL_06b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06bc: Expected O, but got Unknown
		//IL_06be: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c8: Expected O, but got Unknown
		//IL_06ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_06d4: Expected O, but got Unknown
		//IL_06d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_06e0: Expected O, but got Unknown
		//IL_06e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_06ec: Expected O, but got Unknown
		//IL_06ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_06f8: Expected O, but got Unknown
		//IL_06fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0704: Expected O, but got Unknown
		//IL_0706: Unknown result type (might be due to invalid IL or missing references)
		//IL_0710: Expected O, but got Unknown
		//IL_0712: Unknown result type (might be due to invalid IL or missing references)
		//IL_071c: Expected O, but got Unknown
		//IL_071e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0728: Expected O, but got Unknown
		//IL_072a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0734: Expected O, but got Unknown
		//IL_0736: Unknown result type (might be due to invalid IL or missing references)
		//IL_0740: Expected O, but got Unknown
		//IL_0742: Unknown result type (might be due to invalid IL or missing references)
		//IL_074c: Expected O, but got Unknown
		//IL_074e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0758: Expected O, but got Unknown
		//IL_075a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0764: Expected O, but got Unknown
		//IL_0766: Unknown result type (might be due to invalid IL or missing references)
		//IL_0770: Expected O, but got Unknown
		//IL_0772: Unknown result type (might be due to invalid IL or missing references)
		//IL_077c: Expected O, but got Unknown
		//IL_077e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0788: Expected O, but got Unknown
		//IL_078a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0794: Expected O, but got Unknown
		//IL_0796: Unknown result type (might be due to invalid IL or missing references)
		//IL_07a0: Expected O, but got Unknown
		//IL_07a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07ac: Expected O, but got Unknown
		//IL_07ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_07b8: Expected O, but got Unknown
		//IL_07ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_07c4: Expected O, but got Unknown
		//IL_07c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_07d0: Expected O, but got Unknown
		//IL_07d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_07dc: Expected O, but got Unknown
		//IL_07de: Unknown result type (might be due to invalid IL or missing references)
		//IL_07e8: Expected O, but got Unknown
		//IL_07ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_07f4: Expected O, but got Unknown
		//IL_07f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0800: Expected O, but got Unknown
		//IL_0802: Unknown result type (might be due to invalid IL or missing references)
		//IL_080c: Expected O, but got Unknown
		//IL_080e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0818: Expected O, but got Unknown
		//IL_081a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0824: Expected O, but got Unknown
		//IL_0826: Unknown result type (might be due to invalid IL or missing references)
		//IL_0830: Expected O, but got Unknown
		//IL_0832: Unknown result type (might be due to invalid IL or missing references)
		//IL_083c: Expected O, but got Unknown
		//IL_083e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0848: Expected O, but got Unknown
		//IL_084a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0854: Expected O, but got Unknown
		//IL_0856: Unknown result type (might be due to invalid IL or missing references)
		//IL_0860: Expected O, but got Unknown
		//IL_0862: Unknown result type (might be due to invalid IL or missing references)
		//IL_086c: Expected O, but got Unknown
		//IL_086e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0878: Expected O, but got Unknown
		//IL_087a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0884: Expected O, but got Unknown
		//IL_0886: Unknown result type (might be due to invalid IL or missing references)
		//IL_0890: Expected O, but got Unknown
		//IL_0892: Unknown result type (might be due to invalid IL or missing references)
		//IL_089c: Expected O, but got Unknown
		//IL_089e: Unknown result type (might be due to invalid IL or missing references)
		//IL_08a8: Expected O, but got Unknown
		//IL_08aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_08b4: Expected O, but got Unknown
		//IL_08b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08c0: Expected O, but got Unknown
		//IL_08c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08cc: Expected O, but got Unknown
		//IL_08ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_08d8: Expected O, but got Unknown
		//IL_08da: Unknown result type (might be due to invalid IL or missing references)
		//IL_08e4: Expected O, but got Unknown
		//IL_08e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_08f0: Expected O, but got Unknown
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_08fc: Expected O, but got Unknown
		//IL_08fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0908: Expected O, but got Unknown
		//IL_090a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0914: Expected O, but got Unknown
		//IL_0916: Unknown result type (might be due to invalid IL or missing references)
		//IL_0920: Expected O, but got Unknown
		//IL_0922: Unknown result type (might be due to invalid IL or missing references)
		//IL_092c: Expected O, but got Unknown
		//IL_092e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0938: Expected O, but got Unknown
		//IL_093a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0944: Expected O, but got Unknown
		//IL_0946: Unknown result type (might be due to invalid IL or missing references)
		//IL_0950: Expected O, but got Unknown
		//IL_0952: Unknown result type (might be due to invalid IL or missing references)
		//IL_095c: Expected O, but got Unknown
		//IL_095e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0968: Expected O, but got Unknown
		//IL_096a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0974: Expected O, but got Unknown
		//IL_0976: Unknown result type (might be due to invalid IL or missing references)
		//IL_0980: Expected O, but got Unknown
		//IL_0982: Unknown result type (might be due to invalid IL or missing references)
		//IL_098c: Expected O, but got Unknown
		//IL_098e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0998: Expected O, but got Unknown
		//IL_099a: Unknown result type (might be due to invalid IL or missing references)
		//IL_09a4: Expected O, but got Unknown
		//IL_09a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09b0: Expected O, but got Unknown
		//IL_09b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09bc: Expected O, but got Unknown
		//IL_09be: Unknown result type (might be due to invalid IL or missing references)
		//IL_09c8: Expected O, but got Unknown
		//IL_09ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_09d4: Expected O, but got Unknown
		//IL_09d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_09e0: Expected O, but got Unknown
		//IL_09e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_09ec: Expected O, but got Unknown
		//IL_09ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_09f8: Expected O, but got Unknown
		//IL_09fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a04: Expected O, but got Unknown
		//IL_0a06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a10: Expected O, but got Unknown
		//IL_0a12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a1c: Expected O, but got Unknown
		//IL_0a1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a28: Expected O, but got Unknown
		//IL_0a2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a34: Expected O, but got Unknown
		//IL_0a36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a40: Expected O, but got Unknown
		//IL_0a42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a4c: Expected O, but got Unknown
		//IL_0a4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a58: Expected O, but got Unknown
		//IL_0a5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a64: Expected O, but got Unknown
		//IL_0a66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a70: Expected O, but got Unknown
		//IL_0a72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a7c: Expected O, but got Unknown
		//IL_0a7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a88: Expected O, but got Unknown
		//IL_0a8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0a94: Expected O, but got Unknown
		//IL_0a96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aa0: Expected O, but got Unknown
		//IL_0aa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0aac: Expected O, but got Unknown
		//IL_0aae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ab8: Expected O, but got Unknown
		//IL_0aba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ac4: Expected O, but got Unknown
		//IL_0ac6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ad0: Expected O, but got Unknown
		//IL_0ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0adc: Expected O, but got Unknown
		//IL_0ade: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ae8: Expected O, but got Unknown
		//IL_0aea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0af4: Expected O, but got Unknown
		//IL_0af6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b00: Expected O, but got Unknown
		//IL_0b02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b0c: Expected O, but got Unknown
		//IL_0b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b18: Expected O, but got Unknown
		//IL_0b1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b24: Expected O, but got Unknown
		//IL_0b26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b30: Expected O, but got Unknown
		//IL_0b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b3c: Expected O, but got Unknown
		//IL_0b3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b48: Expected O, but got Unknown
		//IL_0b4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b54: Expected O, but got Unknown
		//IL_0b56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b60: Expected O, but got Unknown
		//IL_0b62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b6c: Expected O, but got Unknown
		//IL_0b6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b78: Expected O, but got Unknown
		//IL_0b7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b84: Expected O, but got Unknown
		//IL_0b86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b90: Expected O, but got Unknown
		//IL_0b92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0b9c: Expected O, but got Unknown
		//IL_0b9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ba8: Expected O, but got Unknown
		//IL_0baa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bb4: Expected O, but got Unknown
		//IL_0bb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bc0: Expected O, but got Unknown
		//IL_0bc2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bcc: Expected O, but got Unknown
		//IL_0bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bd8: Expected O, but got Unknown
		//IL_0bda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0be4: Expected O, but got Unknown
		//IL_0be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bf0: Expected O, but got Unknown
		//IL_0bf2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0bfc: Expected O, but got Unknown
		//IL_0bfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c08: Expected O, but got Unknown
		//IL_0c0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c14: Expected O, but got Unknown
		//IL_0c16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c20: Expected O, but got Unknown
		//IL_0c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c2c: Expected O, but got Unknown
		//IL_0c2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c38: Expected O, but got Unknown
		//IL_0c3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c44: Expected O, but got Unknown
		//IL_0c46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c50: Expected O, but got Unknown
		//IL_0c52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c5c: Expected O, but got Unknown
		//IL_0c5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c68: Expected O, but got Unknown
		//IL_0c6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c74: Expected O, but got Unknown
		//IL_0c76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c80: Expected O, but got Unknown
		//IL_0c82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c8c: Expected O, but got Unknown
		//IL_0c8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0c98: Expected O, but got Unknown
		//IL_0c9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ca4: Expected O, but got Unknown
		//IL_0ca6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cb0: Expected O, but got Unknown
		//IL_0cb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cbc: Expected O, but got Unknown
		//IL_0cbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cc8: Expected O, but got Unknown
		//IL_0cca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cd4: Expected O, but got Unknown
		//IL_0cd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ce0: Expected O, but got Unknown
		//IL_0ce2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cec: Expected O, but got Unknown
		//IL_0cee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0cf8: Expected O, but got Unknown
		//IL_0cfa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d04: Expected O, but got Unknown
		//IL_0d06: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d10: Expected O, but got Unknown
		//IL_0d12: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d1c: Expected O, but got Unknown
		//IL_0d1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d28: Expected O, but got Unknown
		//IL_0d2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d34: Expected O, but got Unknown
		//IL_0d36: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d40: Expected O, but got Unknown
		//IL_0d42: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d4c: Expected O, but got Unknown
		//IL_0d4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d58: Expected O, but got Unknown
		//IL_0d5a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d64: Expected O, but got Unknown
		//IL_0d66: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d70: Expected O, but got Unknown
		//IL_0d72: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d7c: Expected O, but got Unknown
		//IL_0d7e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d88: Expected O, but got Unknown
		//IL_0d8a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0d94: Expected O, but got Unknown
		//IL_0d96: Unknown result type (might be due to invalid IL or missing references)
		//IL_0da0: Expected O, but got Unknown
		//IL_0da2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dac: Expected O, but got Unknown
		//IL_0dae: Unknown result type (might be due to invalid IL or missing references)
		//IL_0db8: Expected O, but got Unknown
		//IL_0dba: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dc4: Expected O, but got Unknown
		//IL_0dc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0dd0: Expected O, but got Unknown
		//IL_0dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ddc: Expected O, but got Unknown
		//IL_0dde: Unknown result type (might be due to invalid IL or missing references)
		//IL_0de8: Expected O, but got Unknown
		//IL_0dea: Unknown result type (might be due to invalid IL or missing references)
		//IL_0df4: Expected O, but got Unknown
		//IL_0df6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e00: Expected O, but got Unknown
		//IL_0e02: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e0c: Expected O, but got Unknown
		//IL_0e0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e18: Expected O, but got Unknown
		//IL_0e1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e24: Expected O, but got Unknown
		//IL_0e26: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e30: Expected O, but got Unknown
		//IL_0e32: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e3c: Expected O, but got Unknown
		//IL_0e3e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e48: Expected O, but got Unknown
		//IL_0e4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e54: Expected O, but got Unknown
		//IL_0e56: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e60: Expected O, but got Unknown
		//IL_0e62: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e6c: Expected O, but got Unknown
		//IL_0e6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e78: Expected O, but got Unknown
		//IL_0e7a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e84: Expected O, but got Unknown
		//IL_0e86: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e90: Expected O, but got Unknown
		//IL_0e92: Unknown result type (might be due to invalid IL or missing references)
		//IL_0e9c: Expected O, but got Unknown
		//IL_0e9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ea8: Expected O, but got Unknown
		//IL_0eaa: Unknown result type (might be due to invalid IL or missing references)
		//IL_0eb4: Expected O, but got Unknown
		//IL_0eb6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ec0: Expected O, but got Unknown
		//IL_0ec2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ecc: Expected O, but got Unknown
		//IL_0ece: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ed8: Expected O, but got Unknown
		//IL_0eda: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ee4: Expected O, but got Unknown
		//IL_0ee6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ef0: Expected O, but got Unknown
		//IL_0ef2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0efc: Expected O, but got Unknown
		//IL_0efe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f08: Expected O, but got Unknown
		//IL_0f0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f14: Expected O, but got Unknown
		//IL_0f16: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f20: Expected O, but got Unknown
		//IL_0f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f2c: Expected O, but got Unknown
		//IL_0f2e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f38: Expected O, but got Unknown
		//IL_0f3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f44: Expected O, but got Unknown
		//IL_0f46: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f50: Expected O, but got Unknown
		//IL_0f52: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f5c: Expected O, but got Unknown
		//IL_0f5e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f68: Expected O, but got Unknown
		//IL_0f6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f74: Expected O, but got Unknown
		//IL_0f76: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f80: Expected O, but got Unknown
		//IL_0f82: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f8c: Expected O, but got Unknown
		//IL_0f8e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0f98: Expected O, but got Unknown
		//IL_0f9a: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fa4: Expected O, but got Unknown
		//IL_0fa6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fb0: Expected O, but got Unknown
		//IL_0fb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fbc: Expected O, but got Unknown
		//IL_0fbe: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fc8: Expected O, but got Unknown
		//IL_0fca: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fd4: Expected O, but got Unknown
		//IL_0fd6: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fe0: Expected O, but got Unknown
		//IL_0fe2: Unknown result type (might be due to invalid IL or missing references)
		//IL_0fec: Expected O, but got Unknown
		//IL_0fee: Unknown result type (might be due to invalid IL or missing references)
		//IL_0ff8: Expected O, but got Unknown
		//IL_0ffa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1004: Expected O, but got Unknown
		//IL_1006: Unknown result type (might be due to invalid IL or missing references)
		//IL_1010: Expected O, but got Unknown
		//IL_1012: Unknown result type (might be due to invalid IL or missing references)
		//IL_101c: Expected O, but got Unknown
		//IL_101e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1028: Expected O, but got Unknown
		//IL_102a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1034: Expected O, but got Unknown
		//IL_1036: Unknown result type (might be due to invalid IL or missing references)
		//IL_1040: Expected O, but got Unknown
		//IL_1042: Unknown result type (might be due to invalid IL or missing references)
		//IL_104c: Expected O, but got Unknown
		//IL_104e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1058: Expected O, but got Unknown
		//IL_105a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1064: Expected O, but got Unknown
		//IL_1066: Unknown result type (might be due to invalid IL or missing references)
		//IL_1070: Expected O, but got Unknown
		//IL_1072: Unknown result type (might be due to invalid IL or missing references)
		//IL_107c: Expected O, but got Unknown
		//IL_107e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1088: Expected O, but got Unknown
		//IL_108a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1094: Expected O, but got Unknown
		//IL_1096: Unknown result type (might be due to invalid IL or missing references)
		//IL_10a0: Expected O, but got Unknown
		//IL_10a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ac: Expected O, but got Unknown
		//IL_10ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_10b8: Expected O, but got Unknown
		//IL_10ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_10c4: Expected O, but got Unknown
		//IL_10c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_10d0: Expected O, but got Unknown
		//IL_10d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_10dc: Expected O, but got Unknown
		//IL_10de: Unknown result type (might be due to invalid IL or missing references)
		//IL_10e8: Expected O, but got Unknown
		//IL_10ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_10f4: Expected O, but got Unknown
		//IL_10f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1100: Expected O, but got Unknown
		//IL_1102: Unknown result type (might be due to invalid IL or missing references)
		//IL_110c: Expected O, but got Unknown
		//IL_110e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1118: Expected O, but got Unknown
		//IL_111a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1124: Expected O, but got Unknown
		//IL_1126: Unknown result type (might be due to invalid IL or missing references)
		//IL_1130: Expected O, but got Unknown
		//IL_1132: Unknown result type (might be due to invalid IL or missing references)
		//IL_113c: Expected O, but got Unknown
		//IL_113e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1148: Expected O, but got Unknown
		//IL_114a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1154: Expected O, but got Unknown
		//IL_1156: Unknown result type (might be due to invalid IL or missing references)
		//IL_1160: Expected O, but got Unknown
		//IL_1162: Unknown result type (might be due to invalid IL or missing references)
		//IL_116c: Expected O, but got Unknown
		//IL_116e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1178: Expected O, but got Unknown
		//IL_117a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1184: Expected O, but got Unknown
		//IL_1186: Unknown result type (might be due to invalid IL or missing references)
		//IL_1190: Expected O, but got Unknown
		//IL_1192: Unknown result type (might be due to invalid IL or missing references)
		//IL_119c: Expected O, but got Unknown
		//IL_119e: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a8: Expected O, but got Unknown
		//IL_11aa: Unknown result type (might be due to invalid IL or missing references)
		//IL_11b4: Expected O, but got Unknown
		//IL_11b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c0: Expected O, but got Unknown
		//IL_11c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11cc: Expected O, but got Unknown
		//IL_11ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d8: Expected O, but got Unknown
		//IL_11da: Unknown result type (might be due to invalid IL or missing references)
		//IL_11e4: Expected O, but got Unknown
		//IL_11e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f0: Expected O, but got Unknown
		//IL_11f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_11fc: Expected O, but got Unknown
		//IL_11fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1208: Expected O, but got Unknown
		//IL_120a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1214: Expected O, but got Unknown
		//IL_1216: Unknown result type (might be due to invalid IL or missing references)
		//IL_1220: Expected O, but got Unknown
		//IL_1222: Unknown result type (might be due to invalid IL or missing references)
		//IL_122c: Expected O, but got Unknown
		//IL_122e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1238: Expected O, but got Unknown
		//IL_123a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1244: Expected O, but got Unknown
		//IL_1246: Unknown result type (might be due to invalid IL or missing references)
		//IL_1250: Expected O, but got Unknown
		//IL_1252: Unknown result type (might be due to invalid IL or missing references)
		//IL_125c: Expected O, but got Unknown
		//IL_125e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1268: Expected O, but got Unknown
		//IL_126a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1274: Expected O, but got Unknown
		//IL_1276: Unknown result type (might be due to invalid IL or missing references)
		//IL_1280: Expected O, but got Unknown
		//IL_1282: Unknown result type (might be due to invalid IL or missing references)
		//IL_128c: Expected O, but got Unknown
		//IL_128e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1298: Expected O, but got Unknown
		//IL_129a: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a4: Expected O, but got Unknown
		//IL_12a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b0: Expected O, but got Unknown
		//IL_12b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12bc: Expected O, but got Unknown
		//IL_12be: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c8: Expected O, but got Unknown
		//IL_12ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_12d4: Expected O, but got Unknown
		//IL_12d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e0: Expected O, but got Unknown
		//IL_12e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ec: Expected O, but got Unknown
		//IL_12ee: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f8: Expected O, but got Unknown
		//IL_12fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1304: Expected O, but got Unknown
		//IL_1306: Unknown result type (might be due to invalid IL or missing references)
		//IL_1310: Expected O, but got Unknown
		//IL_1312: Unknown result type (might be due to invalid IL or missing references)
		//IL_131c: Expected O, but got Unknown
		//IL_131e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1328: Expected O, but got Unknown
		//IL_132a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1334: Expected O, but got Unknown
		//IL_1336: Unknown result type (might be due to invalid IL or missing references)
		//IL_1340: Expected O, but got Unknown
		//IL_1342: Unknown result type (might be due to invalid IL or missing references)
		//IL_134c: Expected O, but got Unknown
		//IL_134e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1358: Expected O, but got Unknown
		//IL_135a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1364: Expected O, but got Unknown
		//IL_1366: Unknown result type (might be due to invalid IL or missing references)
		//IL_1370: Expected O, but got Unknown
		//IL_1372: Unknown result type (might be due to invalid IL or missing references)
		//IL_137c: Expected O, but got Unknown
		//IL_137e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1388: Expected O, but got Unknown
		//IL_138a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1394: Expected O, but got Unknown
		//IL_1396: Unknown result type (might be due to invalid IL or missing references)
		//IL_13a0: Expected O, but got Unknown
		//IL_13a2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13ac: Expected O, but got Unknown
		//IL_13ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b8: Expected O, but got Unknown
		//IL_13ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c4: Expected O, but got Unknown
		//IL_13c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d0: Expected O, but got Unknown
		//IL_13d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_13dc: Expected O, but got Unknown
		//IL_13de: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e8: Expected O, but got Unknown
		//IL_13ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f4: Expected O, but got Unknown
		//IL_13f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_1400: Expected O, but got Unknown
		//IL_1402: Unknown result type (might be due to invalid IL or missing references)
		//IL_140c: Expected O, but got Unknown
		//IL_140e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1418: Expected O, but got Unknown
		//IL_141a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1424: Expected O, but got Unknown
		//IL_1426: Unknown result type (might be due to invalid IL or missing references)
		//IL_1430: Expected O, but got Unknown
		//IL_1432: Unknown result type (might be due to invalid IL or missing references)
		//IL_143c: Expected O, but got Unknown
		//IL_143e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1448: Expected O, but got Unknown
		//IL_144a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1454: Expected O, but got Unknown
		//IL_1456: Unknown result type (might be due to invalid IL or missing references)
		//IL_1460: Expected O, but got Unknown
		//IL_1462: Unknown result type (might be due to invalid IL or missing references)
		//IL_146c: Expected O, but got Unknown
		//IL_146e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1478: Expected O, but got Unknown
		//IL_1480: Unknown result type (might be due to invalid IL or missing references)
		//IL_148a: Expected O, but got Unknown
		//IL_1492: Unknown result type (might be due to invalid IL or missing references)
		//IL_149c: Expected O, but got Unknown
		//IL_14a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_14ae: Expected O, but got Unknown
		//IL_14b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_14c0: Expected O, but got Unknown
		//IL_14c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_14d2: Expected O, but got Unknown
		//IL_14da: Unknown result type (might be due to invalid IL or missing references)
		//IL_14e4: Expected O, but got Unknown
		//IL_14ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_14f6: Expected O, but got Unknown
		//IL_14fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_1508: Expected O, but got Unknown
		//IL_1510: Unknown result type (might be due to invalid IL or missing references)
		//IL_151a: Expected O, but got Unknown
		//IL_1522: Unknown result type (might be due to invalid IL or missing references)
		//IL_152c: Expected O, but got Unknown
		//IL_1534: Unknown result type (might be due to invalid IL or missing references)
		//IL_153e: Expected O, but got Unknown
		//IL_1546: Unknown result type (might be due to invalid IL or missing references)
		//IL_1550: Expected O, but got Unknown
		//IL_1558: Unknown result type (might be due to invalid IL or missing references)
		//IL_1562: Expected O, but got Unknown
		//IL_156a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1574: Expected O, but got Unknown
		//IL_157c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1586: Expected O, but got Unknown
		//IL_158e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1598: Expected O, but got Unknown
		//IL_15a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_15aa: Expected O, but got Unknown
		//IL_15b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bc: Expected O, but got Unknown
		//IL_15c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_15ce: Expected O, but got Unknown
		//IL_15d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e0: Expected O, but got Unknown
		//IL_15e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f2: Expected O, but got Unknown
		//IL_15fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_1604: Expected O, but got Unknown
		//IL_160c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1616: Expected O, but got Unknown
		//IL_161e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1628: Expected O, but got Unknown
		//IL_1630: Unknown result type (might be due to invalid IL or missing references)
		//IL_163a: Expected O, but got Unknown
		//IL_1642: Unknown result type (might be due to invalid IL or missing references)
		//IL_164c: Expected O, but got Unknown
		//IL_1654: Unknown result type (might be due to invalid IL or missing references)
		//IL_165e: Expected O, but got Unknown
		//IL_1666: Unknown result type (might be due to invalid IL or missing references)
		//IL_1670: Expected O, but got Unknown
		//IL_1678: Unknown result type (might be due to invalid IL or missing references)
		//IL_1682: Expected O, but got Unknown
		//IL_168a: Unknown result type (might be due to invalid IL or missing references)
		//IL_1694: Expected O, but got Unknown
		//IL_169c: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a6: Expected O, but got Unknown
		//IL_16a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16b2: Expected O, but got Unknown
		//IL_16b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_16be: Expected O, but got Unknown
		//IL_16c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16ca: Expected O, but got Unknown
		//IL_16cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d6: Expected O, but got Unknown
		//IL_16d8: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e2: Expected O, but got Unknown
		//IL_16ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f4: Expected O, but got Unknown
		//IL_16fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1706: Expected O, but got Unknown
		//IL_170e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1718: Expected O, but got Unknown
		//IL_1719: Unknown result type (might be due to invalid IL or missing references)
		//IL_1723: Expected O, but got Unknown
		//IL_1725: Unknown result type (might be due to invalid IL or missing references)
		//IL_172f: Expected O, but got Unknown
		//IL_1731: Unknown result type (might be due to invalid IL or missing references)
		//IL_173b: Expected O, but got Unknown
		//IL_173d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1747: Expected O, but got Unknown
		//IL_1749: Unknown result type (might be due to invalid IL or missing references)
		//IL_1753: Expected O, but got Unknown
		//IL_1755: Unknown result type (might be due to invalid IL or missing references)
		//IL_175f: Expected O, but got Unknown
		//IL_1761: Unknown result type (might be due to invalid IL or missing references)
		//IL_176b: Expected O, but got Unknown
		//IL_176d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1777: Expected O, but got Unknown
		//IL_1779: Unknown result type (might be due to invalid IL or missing references)
		//IL_1783: Expected O, but got Unknown
		//IL_1785: Unknown result type (might be due to invalid IL or missing references)
		//IL_178f: Expected O, but got Unknown
		//IL_1791: Unknown result type (might be due to invalid IL or missing references)
		//IL_179b: Expected O, but got Unknown
		//IL_179d: Unknown result type (might be due to invalid IL or missing references)
		//IL_17a7: Expected O, but got Unknown
		//IL_17a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17b3: Expected O, but got Unknown
		//IL_17b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bf: Expected O, but got Unknown
		//IL_17c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17cb: Expected O, but got Unknown
		//IL_17cd: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d7: Expected O, but got Unknown
		//IL_17d9: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e3: Expected O, but got Unknown
		//IL_17e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ef: Expected O, but got Unknown
		//IL_17f1: Unknown result type (might be due to invalid IL or missing references)
		//IL_17fb: Expected O, but got Unknown
		//IL_17fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1807: Expected O, but got Unknown
		//IL_1809: Unknown result type (might be due to invalid IL or missing references)
		//IL_1813: Expected O, but got Unknown
		//IL_1815: Unknown result type (might be due to invalid IL or missing references)
		//IL_181f: Expected O, but got Unknown
		//IL_1821: Unknown result type (might be due to invalid IL or missing references)
		//IL_182b: Expected O, but got Unknown
		//IL_182d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1837: Expected O, but got Unknown
		//IL_1839: Unknown result type (might be due to invalid IL or missing references)
		//IL_1843: Expected O, but got Unknown
		//IL_1845: Unknown result type (might be due to invalid IL or missing references)
		//IL_184f: Expected O, but got Unknown
		//IL_1851: Unknown result type (might be due to invalid IL or missing references)
		//IL_185b: Expected O, but got Unknown
		//IL_185d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1867: Expected O, but got Unknown
		//IL_1869: Unknown result type (might be due to invalid IL or missing references)
		//IL_1873: Expected O, but got Unknown
		//IL_1875: Unknown result type (might be due to invalid IL or missing references)
		//IL_187f: Expected O, but got Unknown
		//IL_1881: Unknown result type (might be due to invalid IL or missing references)
		//IL_188b: Expected O, but got Unknown
		//IL_188d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1897: Expected O, but got Unknown
		//IL_1899: Unknown result type (might be due to invalid IL or missing references)
		//IL_18a3: Expected O, but got Unknown
		//IL_18a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18af: Expected O, but got Unknown
		//IL_18b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18bb: Expected O, but got Unknown
		//IL_18bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c7: Expected O, but got Unknown
		//IL_18c9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d3: Expected O, but got Unknown
		//IL_18d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_18df: Expected O, but got Unknown
		//IL_18e1: Unknown result type (might be due to invalid IL or missing references)
		//IL_18eb: Expected O, but got Unknown
		//IL_18ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_18f7: Expected O, but got Unknown
		//IL_18f9: Unknown result type (might be due to invalid IL or missing references)
		//IL_1903: Expected O, but got Unknown
		//IL_1905: Unknown result type (might be due to invalid IL or missing references)
		//IL_190f: Expected O, but got Unknown
		//IL_1911: Unknown result type (might be due to invalid IL or missing references)
		//IL_191b: Expected O, but got Unknown
		//IL_191d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1927: Expected O, but got Unknown
		//IL_1929: Unknown result type (might be due to invalid IL or missing references)
		//IL_1933: Expected O, but got Unknown
		//IL_1935: Unknown result type (might be due to invalid IL or missing references)
		//IL_193f: Expected O, but got Unknown
		//IL_1941: Unknown result type (might be due to invalid IL or missing references)
		//IL_194b: Expected O, but got Unknown
		//IL_194d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1957: Expected O, but got Unknown
		//IL_1959: Unknown result type (might be due to invalid IL or missing references)
		//IL_1963: Expected O, but got Unknown
		//IL_1965: Unknown result type (might be due to invalid IL or missing references)
		//IL_196f: Expected O, but got Unknown
		//IL_1971: Unknown result type (might be due to invalid IL or missing references)
		//IL_197b: Expected O, but got Unknown
		//IL_197d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1987: Expected O, but got Unknown
		//IL_1989: Unknown result type (might be due to invalid IL or missing references)
		//IL_1993: Expected O, but got Unknown
		//IL_1995: Unknown result type (might be due to invalid IL or missing references)
		//IL_199f: Expected O, but got Unknown
		//IL_19a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_19ab: Expected O, but got Unknown
		//IL_19b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c3: Expected O, but got Unknown
		//IL_1e50: Unknown result type (might be due to invalid IL or missing references)
		//IL_1e5a: Expected O, but got Unknown
		//IL_2010: Unknown result type (might be due to invalid IL or missing references)
		//IL_201a: Expected O, but got Unknown
		//IL_2104: Unknown result type (might be due to invalid IL or missing references)
		//IL_210e: Expected O, but got Unknown
		//IL_21df: Unknown result type (might be due to invalid IL or missing references)
		//IL_21e9: Expected O, but got Unknown
		//IL_22bd: Unknown result type (might be due to invalid IL or missing references)
		//IL_22c7: Expected O, but got Unknown
		//IL_2394: Unknown result type (might be due to invalid IL or missing references)
		//IL_239e: Expected O, but got Unknown
		//IL_246b: Unknown result type (might be due to invalid IL or missing references)
		//IL_2475: Expected O, but got Unknown
		//IL_2542: Unknown result type (might be due to invalid IL or missing references)
		//IL_254c: Expected O, but got Unknown
		//IL_2619: Unknown result type (might be due to invalid IL or missing references)
		//IL_2623: Expected O, but got Unknown
		//IL_26ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_26f7: Expected O, but got Unknown
		//IL_27ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_27b7: Expected O, but got Unknown
		//IL_28e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_28ec: Expected O, but got Unknown
		//IL_29b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_29bd: Expected O, but got Unknown
		//IL_2a61: Unknown result type (might be due to invalid IL or missing references)
		//IL_2a6b: Expected O, but got Unknown
		//IL_2ad2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2adc: Expected O, but got Unknown
		//IL_2bb2: Unknown result type (might be due to invalid IL or missing references)
		//IL_2bbc: Expected O, but got Unknown
		//IL_2c9c: Unknown result type (might be due to invalid IL or missing references)
		//IL_2ca6: Expected O, but got Unknown
		//IL_2e94: Unknown result type (might be due to invalid IL or missing references)
		//IL_2e9e: Expected O, but got Unknown
		//IL_2f65: Unknown result type (might be due to invalid IL or missing references)
		//IL_2f6f: Expected O, but got Unknown
		//IL_300d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3017: Expected O, but got Unknown
		//IL_30ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_30f7: Expected O, but got Unknown
		//IL_31c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_31d0: Expected O, but got Unknown
		//IL_329c: Unknown result type (might be due to invalid IL or missing references)
		//IL_32a6: Expected O, but got Unknown
		//IL_3391: Unknown result type (might be due to invalid IL or missing references)
		//IL_339b: Expected O, but got Unknown
		//IL_346a: Unknown result type (might be due to invalid IL or missing references)
		//IL_3474: Expected O, but got Unknown
		//IL_3536: Unknown result type (might be due to invalid IL or missing references)
		//IL_3540: Expected O, but got Unknown
		//IL_362d: Unknown result type (might be due to invalid IL or missing references)
		//IL_3637: Expected O, but got Unknown
		//IL_3710: Unknown result type (might be due to invalid IL or missing references)
		//IL_371a: Expected O, but got Unknown
		//IL_37e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_37f0: Expected O, but got Unknown
		//IL_38c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_38ca: Expected O, but got Unknown
		//IL_39a7: Unknown result type (might be due to invalid IL or missing references)
		//IL_39b1: Expected O, but got Unknown
		//IL_3b32: Unknown result type (might be due to invalid IL or missing references)
		//IL_3b3c: Expected O, but got Unknown
		//IL_3bf6: Unknown result type (might be due to invalid IL or missing references)
		//IL_3c00: Expected O, but got Unknown
		//IL_3c9e: Unknown result type (might be due to invalid IL or missing references)
		//IL_3ca8: Expected O, but got Unknown
		//IL_3d77: Unknown result type (might be due to invalid IL or missing references)
		//IL_3d81: Expected O, but got Unknown
		//IL_3de5: Unknown result type (might be due to invalid IL or missing references)
		//IL_3def: Expected O, but got Unknown
		//IL_3eac: Unknown result type (might be due to invalid IL or missing references)
		//IL_3eb6: Expected O, but got Unknown
		//IL_3f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_3f9e: Expected O, but got Unknown
		//IL_405b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4065: Expected O, but got Unknown
		//IL_4142: Unknown result type (might be due to invalid IL or missing references)
		//IL_414c: Expected O, but got Unknown
		//IL_427b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4285: Expected O, but got Unknown
		//IL_4361: Unknown result type (might be due to invalid IL or missing references)
		//IL_436b: Expected O, but got Unknown
		//IL_4423: Unknown result type (might be due to invalid IL or missing references)
		//IL_442d: Expected O, but got Unknown
		//IL_44cb: Unknown result type (might be due to invalid IL or missing references)
		//IL_44d5: Expected O, but got Unknown
		//IL_45a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_45ab: Expected O, but got Unknown
		//IL_4679: Unknown result type (might be due to invalid IL or missing references)
		//IL_4683: Expected O, but got Unknown
		//IL_471a: Unknown result type (might be due to invalid IL or missing references)
		//IL_4724: Expected O, but got Unknown
		//IL_47eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_47f5: Expected O, but got Unknown
		//IL_4893: Unknown result type (might be due to invalid IL or missing references)
		//IL_489d: Expected O, but got Unknown
		//IL_496c: Unknown result type (might be due to invalid IL or missing references)
		//IL_4976: Expected O, but got Unknown
		//IL_49e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_49f0: Expected O, but got Unknown
		//IL_4c3d: Unknown result type (might be due to invalid IL or missing references)
		//IL_4c47: Expected O, but got Unknown
		//IL_4d31: Unknown result type (might be due to invalid IL or missing references)
		//IL_4d3b: Expected O, but got Unknown
		//IL_4e71: Unknown result type (might be due to invalid IL or missing references)
		//IL_4e7b: Expected O, but got Unknown
		//IL_4f4b: Unknown result type (might be due to invalid IL or missing references)
		//IL_4f55: Expected O, but got Unknown
		//IL_502f: Unknown result type (might be due to invalid IL or missing references)
		//IL_5039: Expected O, but got Unknown
		//IL_50e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_50ef: Expected O, but got Unknown
		//IL_51b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_51c3: Expected O, but got Unknown
		//IL_529a: Unknown result type (might be due to invalid IL or missing references)
		//IL_52a4: Expected O, but got Unknown
		//IL_537a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5384: Expected O, but got Unknown
		//IL_542d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5437: Expected O, but got Unknown
		//IL_5501: Unknown result type (might be due to invalid IL or missing references)
		//IL_550b: Expected O, but got Unknown
		//IL_55d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_55df: Expected O, but got Unknown
		//IL_56a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_56b0: Expected O, but got Unknown
		//IL_576a: Unknown result type (might be due to invalid IL or missing references)
		//IL_5774: Expected O, but got Unknown
		//IL_5847: Unknown result type (might be due to invalid IL or missing references)
		//IL_5851: Expected O, but got Unknown
		//IL_58b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_58bf: Expected O, but got Unknown
		//IL_5990: Unknown result type (might be due to invalid IL or missing references)
		//IL_599a: Expected O, but got Unknown
		//IL_5a68: Unknown result type (might be due to invalid IL or missing references)
		//IL_5a72: Expected O, but got Unknown
		//IL_5b4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_5b57: Expected O, but got Unknown
		//IL_5c22: Unknown result type (might be due to invalid IL or missing references)
		//IL_5c2c: Expected O, but got Unknown
		//IL_5d0c: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d16: Expected O, but got Unknown
		//IL_5d90: Unknown result type (might be due to invalid IL or missing references)
		//IL_5d9a: Expected O, but got Unknown
		//IL_5dfe: Unknown result type (might be due to invalid IL or missing references)
		//IL_5e08: Expected O, but got Unknown
		//IL_60c8: Unknown result type (might be due to invalid IL or missing references)
		//IL_60d2: Expected O, but got Unknown
		//IL_62b5: Unknown result type (might be due to invalid IL or missing references)
		//IL_62bf: Expected O, but got Unknown
		//IL_639e: Unknown result type (might be due to invalid IL or missing references)
		//IL_63a8: Expected O, but got Unknown
		//IL_6468: Unknown result type (might be due to invalid IL or missing references)
		//IL_6472: Expected O, but got Unknown
		//IL_6532: Unknown result type (might be due to invalid IL or missing references)
		//IL_653c: Expected O, but got Unknown
		//IL_65fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_6606: Expected O, but got Unknown
		//IL_66c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_66cd: Expected O, but got Unknown
		//IL_67a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_67ae: Expected O, but got Unknown
		//IL_6885: Unknown result type (might be due to invalid IL or missing references)
		//IL_688f: Expected O, but got Unknown
		//IL_6963: Unknown result type (might be due to invalid IL or missing references)
		//IL_696d: Expected O, but got Unknown
		//IL_6a44: Unknown result type (might be due to invalid IL or missing references)
		//IL_6a4e: Expected O, but got Unknown
		//IL_6b0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_6b15: Expected O, but got Unknown
		//IL_6be6: Unknown result type (might be due to invalid IL or missing references)
		//IL_6bf0: Expected O, but got Unknown
		//IL_6cad: Unknown result type (might be due to invalid IL or missing references)
		//IL_6cb7: Expected O, but got Unknown
		//IL_6d74: Unknown result type (might be due to invalid IL or missing references)
		//IL_6d7e: Expected O, but got Unknown
		//IL_6e9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_6ea7: Expected O, but got Unknown
		//IL_6f86: Unknown result type (might be due to invalid IL or missing references)
		//IL_6f90: Expected O, but got Unknown
		//IL_7071: Unknown result type (might be due to invalid IL or missing references)
		//IL_707b: Expected O, but got Unknown
		//IL_70df: Unknown result type (might be due to invalid IL or missing references)
		//IL_70e9: Expected O, but got Unknown
		//IL_71a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_71af: Expected O, but got Unknown
		//IL_727f: Unknown result type (might be due to invalid IL or missing references)
		//IL_7289: Expected O, but got Unknown
		//IL_73ba: Unknown result type (might be due to invalid IL or missing references)
		//IL_73c4: Expected O, but got Unknown
		//IL_74b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_74ba: Expected O, but got Unknown
		//IL_759b: Unknown result type (might be due to invalid IL or missing references)
		//IL_75a5: Expected O, but got Unknown
		//IL_7609: Unknown result type (might be due to invalid IL or missing references)
		//IL_7613: Expected O, but got Unknown
		//IL_76cf: Unknown result type (might be due to invalid IL or missing references)
		//IL_76d9: Expected O, but got Unknown
		//IL_77a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_77b3: Expected O, but got Unknown
		//IL_7888: Unknown result type (might be due to invalid IL or missing references)
		//IL_7892: Expected O, but got Unknown
		//IL_7976: Unknown result type (might be due to invalid IL or missing references)
		//IL_7980: Expected O, but got Unknown
		//IL_79e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_79f1: Expected O, but got Unknown
		//IL_7b37: Unknown result type (might be due to invalid IL or missing references)
		//IL_7b41: Expected O, but got Unknown
		//IL_7c11: Unknown result type (might be due to invalid IL or missing references)
		//IL_7c1b: Expected O, but got Unknown
		//IL_7ceb: Unknown result type (might be due to invalid IL or missing references)
		//IL_7cf5: Expected O, but got Unknown
		//IL_7dd2: Unknown result type (might be due to invalid IL or missing references)
		//IL_7ddc: Expected O, but got Unknown
		//IL_7e95: Unknown result type (might be due to invalid IL or missing references)
		//IL_7e9f: Expected O, but got Unknown
		//IL_7f6c: Unknown result type (might be due to invalid IL or missing references)
		//IL_7f76: Expected O, but got Unknown
		//IL_8050: Unknown result type (might be due to invalid IL or missing references)
		//IL_805a: Expected O, but got Unknown
		//IL_8103: Unknown result type (might be due to invalid IL or missing references)
		//IL_810d: Expected O, but got Unknown
		//IL_81da: Unknown result type (might be due to invalid IL or missing references)
		//IL_81e4: Expected O, but got Unknown
		//IL_82ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_82b8: Expected O, but got Unknown
		//IL_8385: Unknown result type (might be due to invalid IL or missing references)
		//IL_838f: Expected O, but got Unknown
		//IL_846d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8477: Expected O, but got Unknown
		//IL_8545: Unknown result type (might be due to invalid IL or missing references)
		//IL_854f: Expected O, but got Unknown
		//IL_861d: Unknown result type (might be due to invalid IL or missing references)
		//IL_8627: Expected O, but got Unknown
		//IL_8709: Unknown result type (might be due to invalid IL or missing references)
		//IL_8713: Expected O, but got Unknown
		//IL_8777: Unknown result type (might be due to invalid IL or missing references)
		//IL_8781: Expected O, but got Unknown
		//IL_8947: Unknown result type (might be due to invalid IL or missing references)
		//IL_8951: Expected O, but got Unknown
		//IL_8f94: Unknown result type (might be due to invalid IL or missing references)
		//IL_8f9e: Expected O, but got Unknown
		//IL_9077: Unknown result type (might be due to invalid IL or missing references)
		//IL_9081: Expected O, but got Unknown
		//IL_9171: Unknown result type (might be due to invalid IL or missing references)
		//IL_917b: Expected O, but got Unknown
		//IL_92e6: Unknown result type (might be due to invalid IL or missing references)
		//IL_92f0: Expected O, but got Unknown
		//IL_93bf: Unknown result type (might be due to invalid IL or missing references)
		//IL_93c9: Expected O, but got Unknown
		//IL_9498: Unknown result type (might be due to invalid IL or missing references)
		//IL_94a2: Expected O, but got Unknown
		//IL_95d2: Unknown result type (might be due to invalid IL or missing references)
		//IL_95dc: Expected O, but got Unknown
		//IL_96ca: Unknown result type (might be due to invalid IL or missing references)
		//IL_96d4: Expected O, but got Unknown
		//IL_97a6: Unknown result type (might be due to invalid IL or missing references)
		//IL_97b0: Expected O, but got Unknown
		//IL_9872: Unknown result type (might be due to invalid IL or missing references)
		//IL_987c: Expected O, but got Unknown
		//IL_9966: Unknown result type (might be due to invalid IL or missing references)
		//IL_9970: Expected O, but got Unknown
		//IL_9a3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_9a46: Expected O, but got Unknown
		//IL_9b18: Unknown result type (might be due to invalid IL or missing references)
		//IL_9b22: Expected O, but got Unknown
		//IL_9bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_9bd8: Expected O, but got Unknown
		//IL_9cac: Unknown result type (might be due to invalid IL or missing references)
		//IL_9cb6: Expected O, but got Unknown
		//IL_9d87: Unknown result type (might be due to invalid IL or missing references)
		//IL_9d91: Expected O, but got Unknown
		//IL_9e6f: Unknown result type (might be due to invalid IL or missing references)
		//IL_9e79: Expected O, but got Unknown
		//IL_9f67: Unknown result type (might be due to invalid IL or missing references)
		//IL_9f71: Expected O, but got Unknown
		//IL_a02d: Unknown result type (might be due to invalid IL or missing references)
		//IL_a037: Expected O, but got Unknown
		//IL_a0fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_a106: Expected O, but got Unknown
		//IL_a1f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_a1fe: Expected O, but got Unknown
		//IL_a2c0: Unknown result type (might be due to invalid IL or missing references)
		//IL_a2ca: Expected O, but got Unknown
		//IL_a3b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_a3c2: Expected O, but got Unknown
		//IL_a484: Unknown result type (might be due to invalid IL or missing references)
		//IL_a48e: Expected O, but got Unknown
		//IL_a57c: Unknown result type (might be due to invalid IL or missing references)
		//IL_a586: Expected O, but got Unknown
		//IL_a648: Unknown result type (might be due to invalid IL or missing references)
		//IL_a652: Expected O, but got Unknown
		//IL_a740: Unknown result type (might be due to invalid IL or missing references)
		//IL_a74a: Expected O, but got Unknown
		//IL_a819: Unknown result type (might be due to invalid IL or missing references)
		//IL_a823: Expected O, but got Unknown
		//IL_a8f5: Unknown result type (might be due to invalid IL or missing references)
		//IL_a8ff: Expected O, but got Unknown
		//IL_a9be: Unknown result type (might be due to invalid IL or missing references)
		//IL_a9c8: Expected O, but got Unknown
		//IL_aab3: Unknown result type (might be due to invalid IL or missing references)
		//IL_aabd: Expected O, but got Unknown
		//IL_ab7c: Unknown result type (might be due to invalid IL or missing references)
		//IL_ab86: Expected O, but got Unknown
		//IL_ac71: Unknown result type (might be due to invalid IL or missing references)
		//IL_ac7b: Expected O, but got Unknown
		//IL_ad4a: Unknown result type (might be due to invalid IL or missing references)
		//IL_ad54: Expected O, but got Unknown
		//IL_ae13: Unknown result type (might be due to invalid IL or missing references)
		//IL_ae1d: Expected O, but got Unknown
		//IL_af08: Unknown result type (might be due to invalid IL or missing references)
		//IL_af12: Expected O, but got Unknown
		//IL_afd1: Unknown result type (might be due to invalid IL or missing references)
		//IL_afdb: Expected O, but got Unknown
		//IL_b0c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_b0d0: Expected O, but got Unknown
		//IL_b18f: Unknown result type (might be due to invalid IL or missing references)
		//IL_b199: Expected O, but got Unknown
		//IL_b277: Unknown result type (might be due to invalid IL or missing references)
		//IL_b281: Expected O, but got Unknown
		//IL_b35a: Unknown result type (might be due to invalid IL or missing references)
		//IL_b364: Expected O, but got Unknown
		//IL_b448: Unknown result type (might be due to invalid IL or missing references)
		//IL_b452: Expected O, but got Unknown
		//IL_b50e: Unknown result type (might be due to invalid IL or missing references)
		//IL_b518: Expected O, but got Unknown
		//IL_b5d1: Unknown result type (might be due to invalid IL or missing references)
		//IL_b5db: Expected O, but got Unknown
		//IL_b6a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_b6ae: Expected O, but got Unknown
		//IL_b777: Unknown result type (might be due to invalid IL or missing references)
		//IL_b781: Expected O, but got Unknown
		//IL_b84a: Unknown result type (might be due to invalid IL or missing references)
		//IL_b854: Expected O, but got Unknown
		//IL_b903: Unknown result type (might be due to invalid IL or missing references)
		//IL_b90d: Expected O, but got Unknown
		//IL_b9eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_b9f5: Expected O, but got Unknown
		//IL_bad3: Unknown result type (might be due to invalid IL or missing references)
		//IL_badd: Expected O, but got Unknown
		//IL_bc39: Unknown result type (might be due to invalid IL or missing references)
		//IL_bc43: Expected O, but got Unknown
		//IL_bd1d: Unknown result type (might be due to invalid IL or missing references)
		//IL_bd27: Expected O, but got Unknown
		//IL_bebe: Unknown result type (might be due to invalid IL or missing references)
		//IL_bec8: Expected O, but got Unknown
		//IL_bfd5: Unknown result type (might be due to invalid IL or missing references)
		//IL_bfdf: Expected O, but got Unknown
		//IL_c0bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_c0c5: Expected O, but got Unknown
		//IL_c18f: Unknown result type (might be due to invalid IL or missing references)
		//IL_c199: Expected O, but got Unknown
		//IL_c289: Unknown result type (might be due to invalid IL or missing references)
		//IL_c293: Expected O, but got Unknown
		//IL_c370: Unknown result type (might be due to invalid IL or missing references)
		//IL_c37a: Expected O, but got Unknown
		//IL_c45b: Unknown result type (might be due to invalid IL or missing references)
		//IL_c465: Expected O, but got Unknown
		//IL_c5a1: Unknown result type (might be due to invalid IL or missing references)
		//IL_c5ab: Expected O, but got Unknown
		//IL_c687: Unknown result type (might be due to invalid IL or missing references)
		//IL_c691: Expected O, but got Unknown
		//IL_c797: Unknown result type (might be due to invalid IL or missing references)
		//IL_c7a1: Expected O, but got Unknown
		//IL_c8a4: Unknown result type (might be due to invalid IL or missing references)
		//IL_c8ae: Expected O, but got Unknown
		//IL_c9b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_c9bb: Expected O, but got Unknown
		//IL_ca92: Unknown result type (might be due to invalid IL or missing references)
		//IL_ca9c: Expected O, but got Unknown
		//IL_cb66: Unknown result type (might be due to invalid IL or missing references)
		//IL_cb70: Expected O, but got Unknown
		//IL_cc4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_cc58: Expected O, but got Unknown
		//IL_cd36: Unknown result type (might be due to invalid IL or missing references)
		//IL_cd40: Expected O, but got Unknown
		//IL_ce1e: Unknown result type (might be due to invalid IL or missing references)
		//IL_ce28: Expected O, but got Unknown
		//IL_cf03: Unknown result type (might be due to invalid IL or missing references)
		//IL_cf0d: Expected O, but got Unknown
		//IL_cfed: Unknown result type (might be due to invalid IL or missing references)
		//IL_cff7: Expected O, but got Unknown
		//IL_d05e: Unknown result type (might be due to invalid IL or missing references)
		//IL_d068: Expected O, but got Unknown
		//IL_d2d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_d2df: Expected O, but got Unknown
		//IL_d3c5: Unknown result type (might be due to invalid IL or missing references)
		//IL_d3cf: Expected O, but got Unknown
		//IL_d4c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_d4cc: Expected O, but got Unknown
		//IL_d588: Unknown result type (might be due to invalid IL or missing references)
		//IL_d592: Expected O, but got Unknown
		//IL_d673: Unknown result type (might be due to invalid IL or missing references)
		//IL_d67d: Expected O, but got Unknown
		//IL_d76b: Unknown result type (might be due to invalid IL or missing references)
		//IL_d775: Expected O, but got Unknown
		//IL_d82e: Unknown result type (might be due to invalid IL or missing references)
		//IL_d838: Expected O, but got Unknown
		//IL_d919: Unknown result type (might be due to invalid IL or missing references)
		//IL_d923: Expected O, but got Unknown
		//IL_da11: Unknown result type (might be due to invalid IL or missing references)
		//IL_da1b: Expected O, but got Unknown
		//IL_daf4: Unknown result type (might be due to invalid IL or missing references)
		//IL_dafe: Expected O, but got Unknown
		//IL_dbda: Unknown result type (might be due to invalid IL or missing references)
		//IL_dbe4: Expected O, but got Unknown
		//IL_dcc0: Unknown result type (might be due to invalid IL or missing references)
		//IL_dcca: Expected O, but got Unknown
		//IL_dd99: Unknown result type (might be due to invalid IL or missing references)
		//IL_dda3: Expected O, but got Unknown
		//IL_de80: Unknown result type (might be due to invalid IL or missing references)
		//IL_de8a: Expected O, but got Unknown
		//IL_df6b: Unknown result type (might be due to invalid IL or missing references)
		//IL_df75: Expected O, but got Unknown
		//IL_e062: Unknown result type (might be due to invalid IL or missing references)
		//IL_e06c: Expected O, but got Unknown
		//IL_e148: Unknown result type (might be due to invalid IL or missing references)
		//IL_e152: Expected O, but got Unknown
		//IL_e20b: Unknown result type (might be due to invalid IL or missing references)
		//IL_e215: Expected O, but got Unknown
		//IL_e2f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_e300: Expected O, but got Unknown
		//IL_e3e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_e3ee: Expected O, but got Unknown
		//IL_e4dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_e4e6: Expected O, but got Unknown
		//IL_e58e: Unknown result type (might be due to invalid IL or missing references)
		//IL_e598: Expected O, but got Unknown
		//IL_e73b: Unknown result type (might be due to invalid IL or missing references)
		//IL_e745: Expected O, but got Unknown
		//IL_e82e: Unknown result type (might be due to invalid IL or missing references)
		//IL_e838: Expected O, but got Unknown
		//IL_e925: Unknown result type (might be due to invalid IL or missing references)
		//IL_e92f: Expected O, but got Unknown
		//IL_ea12: Unknown result type (might be due to invalid IL or missing references)
		//IL_ea1c: Expected O, but got Unknown
		//IL_eb0a: Unknown result type (might be due to invalid IL or missing references)
		//IL_eb14: Expected O, but got Unknown
		//IL_ebbd: Unknown result type (might be due to invalid IL or missing references)
		//IL_ebc7: Expected O, but got Unknown
		//IL_ec98: Unknown result type (might be due to invalid IL or missing references)
		//IL_eca2: Expected O, but got Unknown
		//IL_ed7d: Unknown result type (might be due to invalid IL or missing references)
		//IL_ed87: Expected O, but got Unknown
		//IL_ee43: Unknown result type (might be due to invalid IL or missing references)
		//IL_ee4d: Expected O, but got Unknown
		//IL_ef0d: Unknown result type (might be due to invalid IL or missing references)
		//IL_ef17: Expected O, but got Unknown
		//IL_efe8: Unknown result type (might be due to invalid IL or missing references)
		//IL_eff2: Expected O, but got Unknown
		//IL_f14c: Unknown result type (might be due to invalid IL or missing references)
		//IL_f156: Expected O, but got Unknown
		//IL_f22f: Unknown result type (might be due to invalid IL or missing references)
		//IL_f239: Expected O, but got Unknown
		//IL_f320: Unknown result type (might be due to invalid IL or missing references)
		//IL_f32a: Expected O, but got Unknown
		//IL_f416: Unknown result type (might be due to invalid IL or missing references)
		//IL_f420: Expected O, but got Unknown
		//IL_f4ff: Unknown result type (might be due to invalid IL or missing references)
		//IL_f509: Expected O, but got Unknown
		//IL_f5dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_f5e7: Expected O, but got Unknown
		//IL_f6b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_f6c2: Expected O, but got Unknown
		//IL_f8d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_f8dd: Expected O, but got Unknown
		//IL_f9b9: Unknown result type (might be due to invalid IL or missing references)
		//IL_f9c3: Expected O, but got Unknown
		//IL_fab1: Unknown result type (might be due to invalid IL or missing references)
		//IL_fabb: Expected O, but got Unknown
		//IL_fb6a: Unknown result type (might be due to invalid IL or missing references)
		//IL_fb74: Expected O, but got Unknown
		//IL_fc5f: Unknown result type (might be due to invalid IL or missing references)
		//IL_fc69: Expected O, but got Unknown
		//IL_fd15: Unknown result type (might be due to invalid IL or missing references)
		//IL_fd1f: Expected O, but got Unknown
		//IL_fe00: Unknown result type (might be due to invalid IL or missing references)
		//IL_fe0a: Expected O, but got Unknown
		//IL_fede: Unknown result type (might be due to invalid IL or missing references)
		//IL_fee8: Expected O, but got Unknown
		//IL_ffc6: Unknown result type (might be due to invalid IL or missing references)
		//IL_ffd0: Expected O, but got Unknown
		//IL_100bb: Unknown result type (might be due to invalid IL or missing references)
		//IL_100c5: Expected O, but got Unknown
		//IL_1017e: Unknown result type (might be due to invalid IL or missing references)
		//IL_10188: Expected O, but got Unknown
		//IL_10241: Unknown result type (might be due to invalid IL or missing references)
		//IL_1024b: Expected O, but got Unknown
		//IL_102fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_10304: Expected O, but got Unknown
		//IL_103d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_103df: Expected O, but got Unknown
		//IL_104b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_104ba: Expected O, but got Unknown
		//IL_105c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_105ce: Expected O, but got Unknown
		//IL_106b4: Unknown result type (might be due to invalid IL or missing references)
		//IL_106be: Expected O, but got Unknown
		//IL_1079e: Unknown result type (might be due to invalid IL or missing references)
		//IL_107a8: Expected O, but got Unknown
		//IL_10ed8: Unknown result type (might be due to invalid IL or missing references)
		//IL_10ee2: Expected O, but got Unknown
		//IL_10fcc: Unknown result type (might be due to invalid IL or missing references)
		//IL_10fd6: Expected O, but got Unknown
		//IL_11090: Unknown result type (might be due to invalid IL or missing references)
		//IL_1109a: Expected O, but got Unknown
		//IL_111d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_111e0: Expected O, but got Unknown
		//IL_112be: Unknown result type (might be due to invalid IL or missing references)
		//IL_112c8: Expected O, but got Unknown
		//IL_11395: Unknown result type (might be due to invalid IL or missing references)
		//IL_1139f: Expected O, but got Unknown
		//IL_114f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_114fe: Expected O, but got Unknown
		//IL_115c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_115d1: Expected O, but got Unknown
		//IL_1169a: Unknown result type (might be due to invalid IL or missing references)
		//IL_116a4: Expected O, but got Unknown
		//IL_11760: Unknown result type (might be due to invalid IL or missing references)
		//IL_1176a: Expected O, but got Unknown
		//IL_11865: Unknown result type (might be due to invalid IL or missing references)
		//IL_1186f: Expected O, but got Unknown
		//IL_11938: Unknown result type (might be due to invalid IL or missing references)
		//IL_11942: Expected O, but got Unknown
		//IL_11a0b: Unknown result type (might be due to invalid IL or missing references)
		//IL_11a15: Expected O, but got Unknown
		//IL_11ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_11adb: Expected O, but got Unknown
		//IL_11c47: Unknown result type (might be due to invalid IL or missing references)
		//IL_11c51: Expected O, but got Unknown
		//IL_11d3f: Unknown result type (might be due to invalid IL or missing references)
		//IL_11d49: Expected O, but got Unknown
		//IL_11f33: Unknown result type (might be due to invalid IL or missing references)
		//IL_11f3d: Expected O, but got Unknown
		//IL_12038: Unknown result type (might be due to invalid IL or missing references)
		//IL_12042: Expected O, but got Unknown
		//IL_120f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_120fe: Expected O, but got Unknown
		//IL_121ec: Unknown result type (might be due to invalid IL or missing references)
		//IL_121f6: Expected O, but got Unknown
		//IL_122b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_122bc: Expected O, but got Unknown
		//IL_1236b: Unknown result type (might be due to invalid IL or missing references)
		//IL_12375: Expected O, but got Unknown
		//IL_12456: Unknown result type (might be due to invalid IL or missing references)
		//IL_12460: Expected O, but got Unknown
		//IL_12541: Unknown result type (might be due to invalid IL or missing references)
		//IL_1254b: Expected O, but got Unknown
		//IL_12629: Unknown result type (might be due to invalid IL or missing references)
		//IL_12633: Expected O, but got Unknown
		//IL_1271e: Unknown result type (might be due to invalid IL or missing references)
		//IL_12728: Expected O, but got Unknown
		//IL_127e7: Unknown result type (might be due to invalid IL or missing references)
		//IL_127f1: Expected O, but got Unknown
		//IL_128a0: Unknown result type (might be due to invalid IL or missing references)
		//IL_128aa: Expected O, but got Unknown
		//IL_12985: Unknown result type (might be due to invalid IL or missing references)
		//IL_1298f: Expected O, but got Unknown
		//IL_12a63: Unknown result type (might be due to invalid IL or missing references)
		//IL_12a6d: Expected O, but got Unknown
		//IL_12b4e: Unknown result type (might be due to invalid IL or missing references)
		//IL_12b58: Expected O, but got Unknown
		//IL_12c17: Unknown result type (might be due to invalid IL or missing references)
		//IL_12c21: Expected O, but got Unknown
		//IL_12cdd: Unknown result type (might be due to invalid IL or missing references)
		//IL_12ce7: Expected O, but got Unknown
		//IL_12da3: Unknown result type (might be due to invalid IL or missing references)
		//IL_12dad: Expected O, but got Unknown
		//IL_12e69: Unknown result type (might be due to invalid IL or missing references)
		//IL_12e73: Expected O, but got Unknown
		//IL_12f3c: Unknown result type (might be due to invalid IL or missing references)
		//IL_12f46: Expected O, but got Unknown
		//IL_1300f: Unknown result type (might be due to invalid IL or missing references)
		//IL_13019: Expected O, but got Unknown
		//IL_130d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_130df: Expected O, but got Unknown
		//IL_1319b: Unknown result type (might be due to invalid IL or missing references)
		//IL_131a5: Expected O, but got Unknown
		//IL_13261: Unknown result type (might be due to invalid IL or missing references)
		//IL_1326b: Expected O, but got Unknown
		//IL_13327: Unknown result type (might be due to invalid IL or missing references)
		//IL_13331: Expected O, but got Unknown
		//IL_133ed: Unknown result type (might be due to invalid IL or missing references)
		//IL_133f7: Expected O, but got Unknown
		//IL_134b3: Unknown result type (might be due to invalid IL or missing references)
		//IL_134bd: Expected O, but got Unknown
		//IL_13579: Unknown result type (might be due to invalid IL or missing references)
		//IL_13583: Expected O, but got Unknown
		//IL_1363f: Unknown result type (might be due to invalid IL or missing references)
		//IL_13649: Expected O, but got Unknown
		//IL_136f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_13702: Expected O, but got Unknown
		//IL_137e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_137ed: Expected O, but got Unknown
		//IL_138ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_138d8: Expected O, but got Unknown
		//IL_139b6: Unknown result type (might be due to invalid IL or missing references)
		//IL_139c0: Expected O, but got Unknown
		//IL_13a9d: Unknown result type (might be due to invalid IL or missing references)
		//IL_13aa7: Expected O, but got Unknown
		//IL_13b84: Unknown result type (might be due to invalid IL or missing references)
		//IL_13b8e: Expected O, but got Unknown
		//IL_13c79: Unknown result type (might be due to invalid IL or missing references)
		//IL_13c83: Expected O, but got Unknown
		//IL_13d6e: Unknown result type (might be due to invalid IL or missing references)
		//IL_13d78: Expected O, but got Unknown
		//IL_13e48: Unknown result type (might be due to invalid IL or missing references)
		//IL_13e52: Expected O, but got Unknown
		//IL_13f22: Unknown result type (might be due to invalid IL or missing references)
		//IL_13f2c: Expected O, but got Unknown
		//IL_13ffc: Unknown result type (might be due to invalid IL or missing references)
		//IL_14006: Expected O, but got Unknown
		//IL_140d6: Unknown result type (might be due to invalid IL or missing references)
		//IL_140e0: Expected O, but got Unknown
		//IL_141b0: Unknown result type (might be due to invalid IL or missing references)
		//IL_141ba: Expected O, but got Unknown
		//IL_1428a: Unknown result type (might be due to invalid IL or missing references)
		//IL_14294: Expected O, but got Unknown
		//IL_14364: Unknown result type (might be due to invalid IL or missing references)
		//IL_1436e: Expected O, but got Unknown
		//IL_1443f: Unknown result type (might be due to invalid IL or missing references)
		//IL_14449: Expected O, but got Unknown
		//IL_14527: Unknown result type (might be due to invalid IL or missing references)
		//IL_14531: Expected O, but got Unknown
		//IL_1460f: Unknown result type (might be due to invalid IL or missing references)
		//IL_14619: Expected O, but got Unknown
		//IL_146f7: Unknown result type (might be due to invalid IL or missing references)
		//IL_14701: Expected O, but got Unknown
		//IL_147de: Unknown result type (might be due to invalid IL or missing references)
		//IL_147e8: Expected O, but got Unknown
		//IL_148c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_148cc: Expected O, but got Unknown
		//IL_149a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_149ad: Expected O, but got Unknown
		//IL_14fa2: Unknown result type (might be due to invalid IL or missing references)
		//IL_14fac: Expected O, but got Unknown
		//IL_15089: Unknown result type (might be due to invalid IL or missing references)
		//IL_15093: Expected O, but got Unknown
		//IL_151dc: Unknown result type (might be due to invalid IL or missing references)
		//IL_151e6: Expected O, but got Unknown
		//IL_152e4: Unknown result type (might be due to invalid IL or missing references)
		//IL_152ee: Expected O, but got Unknown
		//IL_153de: Unknown result type (might be due to invalid IL or missing references)
		//IL_153e8: Expected O, but got Unknown
		//IL_154b2: Unknown result type (might be due to invalid IL or missing references)
		//IL_154bc: Expected O, but got Unknown
		//IL_15589: Unknown result type (might be due to invalid IL or missing references)
		//IL_15593: Expected O, but got Unknown
		//IL_15660: Unknown result type (might be due to invalid IL or missing references)
		//IL_1566a: Expected O, but got Unknown
		//IL_15758: Unknown result type (might be due to invalid IL or missing references)
		//IL_15762: Expected O, but got Unknown
		//IL_1582e: Unknown result type (might be due to invalid IL or missing references)
		//IL_15838: Expected O, but got Unknown
		//IL_15905: Unknown result type (might be due to invalid IL or missing references)
		//IL_1590f: Expected O, but got Unknown
		//IL_159fa: Unknown result type (might be due to invalid IL or missing references)
		//IL_15a04: Expected O, but got Unknown
		//IL_15ad1: Unknown result type (might be due to invalid IL or missing references)
		//IL_15adb: Expected O, but got Unknown
		//IL_15bb9: Unknown result type (might be due to invalid IL or missing references)
		//IL_15bc3: Expected O, but got Unknown
		//IL_15cae: Unknown result type (might be due to invalid IL or missing references)
		//IL_15cb8: Expected O, but got Unknown
		//IL_15d71: Unknown result type (might be due to invalid IL or missing references)
		//IL_15d7b: Expected O, but got Unknown
		//IL_15e2a: Unknown result type (might be due to invalid IL or missing references)
		//IL_15e34: Expected O, but got Unknown
		//IL_15f1f: Unknown result type (might be due to invalid IL or missing references)
		//IL_15f29: Expected O, but got Unknown
		//IL_15ff6: Unknown result type (might be due to invalid IL or missing references)
		//IL_16000: Expected O, but got Unknown
		//IL_160f3: Unknown result type (might be due to invalid IL or missing references)
		//IL_160fd: Expected O, but got Unknown
		//IL_161eb: Unknown result type (might be due to invalid IL or missing references)
		//IL_161f5: Expected O, but got Unknown
		//IL_162ae: Unknown result type (might be due to invalid IL or missing references)
		//IL_162b8: Expected O, but got Unknown
		//IL_16371: Unknown result type (might be due to invalid IL or missing references)
		//IL_1637b: Expected O, but got Unknown
		//IL_1644a: Unknown result type (might be due to invalid IL or missing references)
		//IL_16454: Expected O, but got Unknown
		//IL_16510: Unknown result type (might be due to invalid IL or missing references)
		//IL_1651a: Expected O, but got Unknown
		//IL_165e9: Unknown result type (might be due to invalid IL or missing references)
		//IL_165f3: Expected O, but got Unknown
		//IL_166af: Unknown result type (might be due to invalid IL or missing references)
		//IL_166b9: Expected O, but got Unknown
		//IL_1678b: Unknown result type (might be due to invalid IL or missing references)
		//IL_16795: Expected O, but got Unknown
		//IL_16864: Unknown result type (might be due to invalid IL or missing references)
		//IL_1686e: Expected O, but got Unknown
		//IL_16940: Unknown result type (might be due to invalid IL or missing references)
		//IL_1694a: Expected O, but got Unknown
		//IL_16a19: Unknown result type (might be due to invalid IL or missing references)
		//IL_16a23: Expected O, but got Unknown
		//IL_16af5: Unknown result type (might be due to invalid IL or missing references)
		//IL_16aff: Expected O, but got Unknown
		//IL_16bce: Unknown result type (might be due to invalid IL or missing references)
		//IL_16bd8: Expected O, but got Unknown
		//IL_16caa: Unknown result type (might be due to invalid IL or missing references)
		//IL_16cb4: Expected O, but got Unknown
		//IL_16d83: Unknown result type (might be due to invalid IL or missing references)
		//IL_16d8d: Expected O, but got Unknown
		//IL_16e57: Unknown result type (might be due to invalid IL or missing references)
		//IL_16e61: Expected O, but got Unknown
		//IL_16f1a: Unknown result type (might be due to invalid IL or missing references)
		//IL_16f24: Expected O, but got Unknown
		//IL_16fe0: Unknown result type (might be due to invalid IL or missing references)
		//IL_16fea: Expected O, but got Unknown
		//IL_170a3: Unknown result type (might be due to invalid IL or missing references)
		//IL_170ad: Expected O, but got Unknown
		//IL_17159: Unknown result type (might be due to invalid IL or missing references)
		//IL_17163: Expected O, but got Unknown
		//IL_17333: Unknown result type (might be due to invalid IL or missing references)
		//IL_1733d: Expected O, but got Unknown
		//IL_17418: Unknown result type (might be due to invalid IL or missing references)
		//IL_17422: Expected O, but got Unknown
		//IL_174fd: Unknown result type (might be due to invalid IL or missing references)
		//IL_17507: Expected O, but got Unknown
		//IL_175d5: Unknown result type (might be due to invalid IL or missing references)
		//IL_175df: Expected O, but got Unknown
		//IL_1772d: Unknown result type (might be due to invalid IL or missing references)
		//IL_17737: Expected O, but got Unknown
		//IL_17812: Unknown result type (might be due to invalid IL or missing references)
		//IL_1781c: Expected O, but got Unknown
		//IL_178f6: Unknown result type (might be due to invalid IL or missing references)
		//IL_17900: Expected O, but got Unknown
		//IL_179d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_179e1: Expected O, but got Unknown
		//IL_17abf: Unknown result type (might be due to invalid IL or missing references)
		//IL_17ac9: Expected O, but got Unknown
		//IL_17ba4: Unknown result type (might be due to invalid IL or missing references)
		//IL_17bae: Expected O, but got Unknown
		//IL_17c85: Unknown result type (might be due to invalid IL or missing references)
		//IL_17c8f: Expected O, but got Unknown
		//IL_17d69: Unknown result type (might be due to invalid IL or missing references)
		//IL_17d73: Expected O, but got Unknown
		//IL_17e4d: Unknown result type (might be due to invalid IL or missing references)
		//IL_17e57: Expected O, but got Unknown
		//IL_17f31: Unknown result type (might be due to invalid IL or missing references)
		//IL_17f3b: Expected O, but got Unknown
		//IL_18117: Unknown result type (might be due to invalid IL or missing references)
		//IL_18121: Expected O, but got Unknown
		//IL_1820b: Unknown result type (might be due to invalid IL or missing references)
		//IL_18215: Expected O, but got Unknown
		//IL_18334: Unknown result type (might be due to invalid IL or missing references)
		//IL_1833e: Expected O, but got Unknown
		//IL_18437: Unknown result type (might be due to invalid IL or missing references)
		//IL_18441: Expected O, but got Unknown
		//IL_18522: Unknown result type (might be due to invalid IL or missing references)
		//IL_1852c: Expected O, but got Unknown
		//IL_18593: Unknown result type (might be due to invalid IL or missing references)
		//IL_1859d: Expected O, but got Unknown
		//IL_186a5: Unknown result type (might be due to invalid IL or missing references)
		//IL_186af: Expected O, but got Unknown
		//IL_18790: Unknown result type (might be due to invalid IL or missing references)
		//IL_1879a: Expected O, but got Unknown
		//IL_18801: Unknown result type (might be due to invalid IL or missing references)
		//IL_1880b: Expected O, but got Unknown
		//IL_188de: Unknown result type (might be due to invalid IL or missing references)
		//IL_188e8: Expected O, but got Unknown
		//IL_189b8: Unknown result type (might be due to invalid IL or missing references)
		//IL_189c2: Expected O, but got Unknown
		//IL_18b0e: Unknown result type (might be due to invalid IL or missing references)
		//IL_18b18: Expected O, but got Unknown
		//IL_18bf9: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c03: Expected O, but got Unknown
		//IL_18c77: Unknown result type (might be due to invalid IL or missing references)
		//IL_18c81: Expected O, but got Unknown
		//IL_18d3a: Unknown result type (might be due to invalid IL or missing references)
		//IL_18d44: Expected O, but got Unknown
		//IL_18e01: Unknown result type (might be due to invalid IL or missing references)
		//IL_18e0b: Expected O, but got Unknown
		//IL_18edb: Unknown result type (might be due to invalid IL or missing references)
		//IL_18ee5: Expected O, but got Unknown
		//IL_18fb8: Unknown result type (might be due to invalid IL or missing references)
		//IL_18fc2: Expected O, but got Unknown
		//IL_1910c: Unknown result type (might be due to invalid IL or missing references)
		//IL_19116: Expected O, but got Unknown
		//IL_191ea: Unknown result type (might be due to invalid IL or missing references)
		//IL_191f4: Expected O, but got Unknown
		//IL_19268: Unknown result type (might be due to invalid IL or missing references)
		//IL_19272: Expected O, but got Unknown
		//IL_1932b: Unknown result type (might be due to invalid IL or missing references)
		//IL_19335: Expected O, but got Unknown
		//IL_193f2: Unknown result type (might be due to invalid IL or missing references)
		//IL_193fc: Expected O, but got Unknown
		//IL_194cc: Unknown result type (might be due to invalid IL or missing references)
		//IL_194d6: Expected O, but got Unknown
		//IL_195a9: Unknown result type (might be due to invalid IL or missing references)
		//IL_195b3: Expected O, but got Unknown
		//IL_1968a: Unknown result type (might be due to invalid IL or missing references)
		//IL_19694: Expected O, but got Unknown
		//IL_19701: Unknown result type (might be due to invalid IL or missing references)
		//IL_1970b: Expected O, but got Unknown
		//IL_197e0: Unknown result type (might be due to invalid IL or missing references)
		//IL_197ea: Expected O, but got Unknown
		//IL_198de: Unknown result type (might be due to invalid IL or missing references)
		//IL_198e8: Expected O, but got Unknown
		//IL_199c7: Unknown result type (might be due to invalid IL or missing references)
		//IL_199d1: Expected O, but got Unknown
		//IL_19aa4: Unknown result type (might be due to invalid IL or missing references)
		//IL_19aae: Expected O, but got Unknown
		//IL_19b90: Unknown result type (might be due to invalid IL or missing references)
		//IL_19b9a: Expected O, but got Unknown
		//IL_19c54: Unknown result type (might be due to invalid IL or missing references)
		//IL_19c5e: Expected O, but got Unknown
		//IL_19d18: Unknown result type (might be due to invalid IL or missing references)
		//IL_19d22: Expected O, but got Unknown
		//IL_19df0: Unknown result type (might be due to invalid IL or missing references)
		//IL_19dfa: Expected O, but got Unknown
		//IL_19f41: Unknown result type (might be due to invalid IL or missing references)
		//IL_19f4b: Expected O, but got Unknown
		//IL_1a018: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a022: Expected O, but got Unknown
		//IL_1a0e2: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a0ec: Expected O, but got Unknown
		//IL_1a1bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a1c6: Expected O, but got Unknown
		//IL_1a296: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a2a0: Expected O, but got Unknown
		//IL_1a36d: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a377: Expected O, but got Unknown
		//IL_1a437: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a441: Expected O, but got Unknown
		//IL_1a4ab: Unknown result type (might be due to invalid IL or missing references)
		//IL_1a4b5: Expected O, but got Unknown
		//IL_1ad40: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ad4a: Expected O, but got Unknown
		//IL_1ae29: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ae33: Expected O, but got Unknown
		//IL_1af12: Unknown result type (might be due to invalid IL or missing references)
		//IL_1af1c: Expected O, but got Unknown
		//IL_1aff1: Unknown result type (might be due to invalid IL or missing references)
		//IL_1affb: Expected O, but got Unknown
		//IL_1b0dd: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b0e7: Expected O, but got Unknown
		//IL_1b1bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b1c6: Expected O, but got Unknown
		//IL_1b2a8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b2b2: Expected O, but got Unknown
		//IL_1b394: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b39e: Expected O, but got Unknown
		//IL_1b4e5: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b4ef: Expected O, but got Unknown
		//IL_1b59e: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b5a8: Expected O, but got Unknown
		//IL_1b665: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b66f: Expected O, but got Unknown
		//IL_1b73c: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b746: Expected O, but got Unknown
		//IL_1b812: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b81c: Expected O, but got Unknown
		//IL_1b8e8: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b8f2: Expected O, but got Unknown
		//IL_1b9be: Unknown result type (might be due to invalid IL or missing references)
		//IL_1b9c8: Expected O, but got Unknown
		//IL_1ba94: Unknown result type (might be due to invalid IL or missing references)
		//IL_1ba9e: Expected O, but got Unknown
		//IL_1bb74: Unknown result type (might be due to invalid IL or missing references)
		//IL_1bb7e: Expected O, but got Unknown
		//IL_1bdfc: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be06: Expected O, but got Unknown
		//IL_1be13: Unknown result type (might be due to invalid IL or missing references)
		//IL_1be1d: Expected O, but got Unknown
		components = new Container();
		ComponentResourceManager componentResourceManager = new ComponentResourceManager(typeof(frmMain));
		ToolTip1 = new ToolTip(components);
		msfContacts = new AxMSFlexGrid();
		_fraTab_2 = new GroupBox();
		Label5 = new Label();
		LabelSubTabs3 = new Label();
		cmdPhysicalStates = new Button();
		cmdSiteInfo = new Button();
		cmdSources = new Button();
		cmdDescription = new Button();
		cmdRelationships = new Button();
		_lstSelOps_0 = new ListBox();
		cmdUpdOps = new Button();
		_fraOpTab_1 = new GroupBox();
		Label15 = new Label();
		msfNaics = new AxMSFlexGrid();
		cmdUpdOpDesc = new Button();
		txtPD = new TextBox();
		_Label4_11 = new Label();
		_fraOpTab_2 = new GroupBox();
		Label16 = new Label();
		cmdUpdPhyState = new Button();
		_lblPhyStateOtherInfo_2 = new Label();
		_lblPhyState_2 = new Label();
		_Label4_10 = new Label();
		_lblPhyStateOtherInfo_1 = new Label();
		_lblPhyStateOtherInfo_0 = new Label();
		_Label4_8 = new Label();
		_lblPhyState_1 = new Label();
		_lblPhyState_0 = new Label();
		_Label4_4 = new Label();
		_Label4_1 = new Label();
		_Label4_6 = new Label();
		_fraOpTab_0 = new GroupBox();
		Label14 = new Label();
		cmdUpdRelations = new Button();
		msfSubOps = new AxMSFlexGrid();
		lblMyPvf = new Label();
		_Label4_9 = new Label();
		lblMyPvop = new Label();
		_Label4_7 = new Label();
		_Label4_3 = new Label();
		_fraOpTab_4 = new GroupBox();
		_Label4_5 = new Label();
		Label18 = new Label();
		cmdCopyOpSiteInfo = new Button();
		cmdUpdSites = new Button();
		msfSites = new AxMSFlexGrid();
		_fraOpTab_3 = new GroupBox();
		Label17 = new Label();
		cmdUpdOpAct = new Button();
		msfSelActs = new AxMSFlexGrid();
		tabOps = new AxTabStrip();
		_fraTab_4 = new GroupBox();
		Label22 = new Label();
		Label9 = new Label();
		cmdEstReleases = new Button();
		cmdRelParms = new Button();
		cmbRelActs = new ComboBox();
		cmdRelAddNotes = new Button();
		cmdRelBasis = new Button();
		txtRelModelMsg = new TextBox();
		cmbRelOps = new ComboBox();
		cmdRunRelModel = new Button();
		cmdViewModelInfo = new Button();
		cmdAddRelModel = new Button();
		lstRelModels = new ListBox();
		cmdUpdRelMedia = new Button();
		msfRelParms = new AxMSFlexGrid();
		_Label1_71 = new Label();
		_Label1_68 = new Label();
		_Label1_69 = new Label();
		_Label1_67 = new Label();
		lblRel = new Label();
		msfRelEst = new AxMSFlexGrid();
		tabRelSubTab = new AxTabStrip();
		cmdRelComb = new Button();
		_fraTab_5 = new GroupBox();
		_fraExpTab_2 = new GroupBox();
		lblInhClassInhMon = new Label();
		lblInhClassHazRating = new Label();
		lblInhClassExpLevel = new Label();
		lblInhClassUncertainty = new Label();
		_Label1_337 = new Label();
		_Label1_336 = new Label();
		_Label1_335 = new Label();
		_Label1_334 = new Label();
		_Label1_333 = new Label();
		_Label1_114 = new Label();
		lblInhClassNotes = new Label();
		lblInhClass = new Label();
		Label23 = new Label();
		_fraExpTab_0 = new GroupBox();
		_txtExpModelMsg_0 = new TextBox();
		_msfExpParms_0 = new AxMSFlexGrid();
		lblDExpModel = new Label();
		_lblChemStateExp_0 = new Label();
		_Label3_1 = new Label();
		_fraExpTab_1 = new GroupBox();
		_txtExpModelMsg_1 = new TextBox();
		_msfExpParms_1 = new AxMSFlexGrid();
		lblIExpModel = new Label();
		_lblChemStateExp_1 = new Label();
		_Label3_2 = new Label();
		_fraExpTab_3 = new GroupBox();
		msfExpEst = new AxMSFlexGrid();
		cmdDermal = new Button();
		Label6 = new Label();
		cmdRespirator = new Button();
		cmdInhalation = new Button();
		cmdActivity = new Button();
		cmbExpActs = new ComboBox();
		cmdUpdateExpNw = new Button();
		cmdInhBasis = new Button();
		cmbExpOps = new ComboBox();
		cmdRunExpModel = new Button();
		cmdAddExpModel = new Button();
		cmdViewExpModel = new Button();
		_Label1_74 = new Label();
		_Label1_73 = new Label();
		_Label1_72 = new Label();
		lblExpSubtab = new Label();
		tabExp = new AxTabStrip();
		cmdExpComb = new Button();
		_fraTab_6 = new GroupBox();
		Label20 = new Label();
		_fraOpInfo_0 = new GroupBox();
		txtSatAddPBTinfo = new TextBox();
		txtSatRelatedCases = new TextBox();
		_Line2_3 = new Label();
		_lblSatEReq_8 = new Label();
		_lblSatHReq_8 = new Label();
		lblCC = new Label();
		_Line2_1 = new Label();
		_Label1_95 = new Label();
		_lblSatEReq_7 = new Label();
		_lblSatEReq_5 = new Label();
		_Label1_94 = new Label();
		_lblSatHReq_5 = new Label();
		_lblSatHReq_7 = new Label();
		lblSATdate = new Label();
		_Label1_92 = new Label();
		_Label1_91 = new Label();
		_Label1_60 = new Label();
		_Label1_90 = new Label();
		lblSatM2GOther = new Label();
		_lblSatEReq_6 = new Label();
		_Label1_66 = new Label();
		_lblSatEReq_4 = new Label();
		_Label1_65 = new Label();
		_lblSatEReq_2 = new Label();
		_Label1_64 = new Label();
		_lblSatEReq_1 = new Label();
		_Label1_63 = new Label();
		_lblSatEReq_0 = new Label();
		_lblSatHReq_6 = new Label();
		_lblSatHReq_4 = new Label();
		_Label1_62 = new Label();
		_lblSatHReq_3 = new Label();
		_Label1_61 = new Label();
		_lblSatEReq_3 = new Label();
		_lblSatHReq_2 = new Label();
		_Label1_59 = new Label();
		_lblSatHReq_1 = new Label();
		_Label1_58 = new Label();
		_lblSatHReq_0 = new Label();
		_Label1_99 = new Label();
		_Label1_57 = new Label();
		_Label1_53 = new Label();
		lblSATER = new Label();
		lblSatM2G = new Label();
		lblSatTR = new Label();
		lblSatPR = new Label();
		lblSatBR = new Label();
		lblSATHR = new Label();
		_Label1_35 = new Label();
		_Label1_34 = new Label();
		_Label1_33 = new Label();
		_Line2_2 = new Label();
		_Label1_31 = new Label();
		_Label1_21 = new Label();
		_Line2_0 = new Label();
		_fraOpInfo_2 = new GroupBox();
		_fraSubOI_2 = new GroupBox();
		lblOILvePpe = new Label();
		txtLVEPPE = new TextBox();
		lblLVEPPE = new Label();
		_fraSubOI_1 = new GroupBox();
		msfTlv = new AxMSFlexGrid();
		_fraSubOI_0 = new GroupBox();
		_txtMsds_2 = new TextBox();
		_txtMsds_1 = new TextBox();
		_txtMsds_0 = new TextBox();
		lblMsdsLab = new Label();
		lblMsdsInc = new Label();
		_Label1_78 = new Label();
		_Label1_77 = new Label();
		_Label1_76 = new Label();
		_Label1_75 = new Label();
		_Label1_98 = new Label();
		tabSubOI = new AxTabStrip();
		cmdUpdOptInfo = new Button();
		_fraOpInfo_1 = new GroupBox();
		txtNumExpEstBasis = new TextBox();
		lblExpBasedCriteria = new Label();
		_Label1_113 = new Label();
		_Label1_112 = new Label();
		lblNumExpEst = new Label();
		_Label1_111 = new Label();
		_Label1_79 = new Label();
		_lblNumWMet_4 = new Label();
		_lblNumWMet_3 = new Label();
		_lblNumWMet_2 = new Label();
		_lblNumWMet_1 = new Label();
		_Label1_54 = new Label();
		_Label1_49 = new Label();
		_lblGT100WorkersW1to10_48 = new Label();
		_lblNumWMet_0 = new Label();
		lblNumExp = new Label();
		_Label1_47 = new Label();
		_Label1_46 = new Label();
		_Label1_45 = new Label();
		cmbOptInfo = new ComboBox();
		_Label1_50 = new Label();
		_fraOpInfo_5 = new GroupBox();
		txtMiscCRSSinfo = new TextBox();
		txtOtherUses = new TextBox();
		_Label1_43 = new Label();
		lblCRSSdate = new Label();
		_Label1_89 = new Label();
		_Label1_88 = new Label();
		lblConsUse = new Label();
		lblOccExpRating = new Label();
		_Label1_22 = new Label();
		_Label1_44 = new Label();
		_fraOpInfo_3 = new GroupBox();
		chkp2rec = new CheckBox();
		txtP2Rec = new TextBox();
		txtP2Cons = new TextBox();
		_Label1_109 = new Label();
		_Label1_108 = new Label();
		_Label1_56 = new Label();
		_fraOpInfo_6 = new GroupBox();
		_Label1_96 = new Label();
		lblCOS = new Label();
		_Label1_102 = new Label();
		lblBindingPV = new Label();
		_Label1_106 = new Label();
		_Label2_13 = new Label();
		_Label1_105 = new Label();
		_Label1_40 = new Label();
		lblDomesticSubPV = new Label();
		lblImportedSubPV = new Label();
		lblTotalSubPV = new Label();
		_Label2_12 = new Label();
		_Label2_11 = new Label();
		_LVE_40 = new Label();
		_fraOpInfo_4 = new GroupBox();
		txtAssumps = new TextBox();
		_Label1_55 = new Label();
		_fraTab_1 = new GroupBox();
		Label12 = new Label();
		Label11 = new Label();
		Label8 = new Label();
		_Label1_17 = new Label();
		cmdViewExpLimits = new Button();
		cmdUpdChem = new Button();
		_Line3_4 = new Label();
		lblChemQualOtherDesc = new Label();
		lblChemQualP2RecDR = new Label();
		lblChemQualP2Rec = new Label();
		_Label1_101 = new Label();
		lblChemQualOther = new Label();
		lblChemQualNX = new Label();
		lblChemQualYX = new Label();
		_Label1_100 = new Label();
		_Line3_3 = new Label();
		_Label1_97 = new Label();
		_Label1_27 = new Label();
		_Line3_2 = new Label();
		_Line3_1 = new Label();
		_Label1_19 = new Label();
		lblMF = new Label();
		_Label1_41 = new Label();
		lblLT1000 = new Label();
		lblLT500 = new Label();
		_Label1_38 = new Label();
		_Label1_37 = new Label();
		_Label1_52 = new Label();
		_Label1_51 = new Label();
		lblTradeNames = new Label();
		lblChemCat = new Label();
		_Label1_48 = new Label();
		_Label2_10 = new Label();
		_Label2_9 = new Label();
		lblNoticeType = new Label();
		lblSolTemp = new Label();
		lblDchemTemp = new Label();
		lblVPTemp = new Label();
		lblBP = new Label();
		lblMP = new Label();
		lblSol = new Label();
		lblDchem = new Label();
		lblMW = new Label();
		lblVP = new Label();
		lblPV = new Label();
		lblPVi = new Label();
		lblPVd = new Label();
		lblCas = new Label();
		lblChemName = new Label();
		_Label1_42 = new Label();
		_Label1_39 = new Label();
		_Label1_16 = new Label();
		_Label2_8 = new Label();
		_Label2_7 = new Label();
		_Label1_28 = new Label();
		_Label1_23 = new Label();
		_Label2_6 = new Label();
		_Label2_2 = new Label();
		_Label2_5 = new Label();
		_Label2_4 = new Label();
		_Label2_3 = new Label();
		_Label2_1 = new Label();
		_Label2_0 = new Label();
		_Label2_22 = new Label();
		_Label1_20 = new Label();
		_Label1_18 = new Label();
		_Label1_15 = new Label();
		_Label1_14 = new Label();
		_Label1_3 = new Label();
		_Label1_2 = new Label();
		cmdChemRegLimits = new Button();
		_fraTab_0 = new GroupBox();
		Label10 = new Label();
		Label7 = new Label();
		txtConsCase = new TextBox();
		txtRevNotes = new TextBox();
		cmdUpdGen = new Button();
		cmdComments = new Button();
		cmdContRpt = new Button();
		_Label1_110 = new Label();
		lblCurrentVersion = new Label();
		lblAssessmentVersion = new Label();
		_Label1_107 = new Label();
		lblLastSaved = new Label();
		_Label1_93 = new Label();
		_Label1_24 = new Label();
		lblConsCase = new Label();
		lblFiscalYear = new Label();
		_Label1_26 = new Label();
		lblNumCR = new Label();
		_Label1_12 = new Label();
		_Label1_36 = new Label();
		lblState = new Label();
		lblZip = new Label();
		_lblAddr_1 = new Label();
		lblCity = new Label();
		_lblAddr_0 = new Label();
		lblCoName = new Label();
		_lblEmail_1 = new Label();
		_lblEmail_0 = new Label();
		_lblPhone_1 = new Label();
		_lblPhone_0 = new Label();
		_lblAff_1 = new Label();
		_lblAff_0 = new Label();
		_lblName_1 = new Label();
		_lblName_0 = new Label();
		lblCBI = new Label();
		lblDate = new Label();
		lblID = new Label();
		lblStatus = new Label();
		lblAssessType = new Label();
		_Label1_11 = new Label();
		_Line1_2 = new Label();
		_Line1_1 = new Label();
		_Label1_10 = new Label();
		_Label1_32 = new Label();
		_Label1_25 = new Label();
		_Label1_7 = new Label();
		_Line1_0 = new Label();
		_Label1_9 = new Label();
		_Label1_5 = new Label();
		_Label1_4 = new Label();
		_Label1_30 = new Label();
		_Label1_29 = new Label();
		_Label1_13 = new Label();
		_Label1_8 = new Label();
		_Label1_6 = new Label();
		_Label1_1 = new Label();
		_Label1_0 = new Label();
		_fraTab_3 = new GroupBox();
		Label21 = new Label();
		_fraIP_1 = new GroupBox();
		_fraConts_3 = new GroupBox();
		_msfCont_3 = new AxMSFlexGrid();
		lblContOD = new Label();
		_fraConts_2 = new GroupBox();
		_msfCont_2 = new AxMSFlexGrid();
		_lblContYprod_0 = new Label();
		_lblContYrm_1 = new Label();
		_lblContSumFC_2 = new Label();
		_fraConts_1 = new GroupBox();
		_msfCont_1 = new AxMSFlexGrid();
		txtContDprod = new TextBox();
		lblDprodType = new Label();
		_lblContYprod_1 = new Label();
		_lblContSumFC_1 = new Label();
		_Label1_80 = new Label();
		_fraConts_0 = new GroupBox();
		_msfCont_0 = new AxMSFlexGrid();
		txtContDrm = new TextBox();
		lblDrmType = new Label();
		_lblContYrm_0 = new Label();
		_lblContSumFC_0 = new Label();
		_Label1_81 = new Label();
		tabConts = new AxTabStrip();
		_fraIP_0 = new GroupBox();
		msfOpIP = new AxMSFlexGrid();
		_fraIP_2 = new GroupBox();
		cmdUpdAVP = new Button();
		msfSP = new AxMSFlexGrid();
		_Line1_3 = new Label();
		lblAVPhigh = new Label();
		lblAVPlow = new Label();
		_Label1_86 = new Label();
		_Label1_85 = new Label();
		Label13 = new Label();
		cmdUpdOpIP = new Button();
		lblOpParmSubtabs = new Label();
		cmdSharedParms = new Button();
		cmdContainerParms = new Button();
		cmdMassBalParms = new Button();
		_lstSelOps_1 = new ListBox();
		tabIP = new AxTabStrip();
		tabMain = new AxTabStrip();
		LVE = new LabelArray(components);
		Label1 = new LabelArray(components);
		Label2 = new LabelArray(components);
		Label3 = new LabelArray(components);
		Label4 = new LabelArray(components);
		Line1 = new LabelArray(components);
		Line2 = new LabelArray(components);
		Line3 = new LabelArray(components);
		fraConts = new GroupBoxArray(components);
		fraExpTab = new GroupBoxArray(components);
		fraIP = new GroupBoxArray(components);
		fraOpInfo = new GroupBoxArray(components);
		fraOpTab = new GroupBoxArray(components);
		fraSubOI = new GroupBoxArray(components);
		fraTab = new GroupBoxArray(components);
		lblAddr = new LabelArray(components);
		lblAff = new LabelArray(components);
		lblChemStateExp = new LabelArray(components);
		lblContSumFC = new LabelArray(components);
		lblContYprod = new LabelArray(components);
		lblContYrm = new LabelArray(components);
		lblEmail = new LabelArray(components);
		lblGT100WorkersW1to10 = new LabelArray(components);
		lblName = new LabelArray(components);
		lblNumWMet = new LabelArray(components);
		lblPhone = new LabelArray(components);
		lblPhyState = new LabelArray(components);
		lblPhyStateOtherInfo = new LabelArray(components);
		lblSatEReq = new LabelArray(components);
		lblSatHReq = new LabelArray(components);
		mnuPreferences = new MenuItemArray(components);
		_mnuPreferences_0 = new MenuItem();
		_mnuPreferences_1 = new MenuItem();
		_mnuPreferences_2 = new MenuItem();
		_mnuReportCR_0 = new MenuItem();
		_mnuReportIRER_0 = new MenuItem();
		txtExpModelMsg = new TextBoxArray(components);
		txtMsds = new TextBoxArray(components);
		MainMenu1 = new MainMenu(components);
		mnuFile = new MenuItem();
		mnuFileNew = new MenuItem();
		mnuFileOpen = new MenuItem();
		mnuFileClose = new MenuItem();
		mnuFileSep1 = new MenuItem();
		mnuFileSave = new MenuItem();
		mnuFileSaveAs = new MenuItem();
		mnuFileSep2 = new MenuItem();
		mnuFileUpdateGSS = new MenuItem();
		mnuFileSaveGSS = new MenuItem();
		mnuFileRenameGSS = new MenuItem();
		mnuFileDeleteGSS = new MenuItem();
		mnuFileSep7 = new MenuItem();
		mnuFileRevHistory = new MenuItem();
		mnuFileSep3 = new MenuItem();
		mnuFileDelete = new MenuItem();
		mnuFileSep4 = new MenuItem();
		mnuFileImportCRSS = new MenuItem();
		mnuFileViewCRSS = new MenuItem();
		mnuFileSep5 = new MenuItem();
		mnuFileEasyModels = new MenuItem();
		mnuFileSep6 = new MenuItem();
		mnuFileExit = new MenuItem();
		mnuEdit = new MenuItem();
		mnuEditCut = new MenuItem();
		mnuEditCopy = new MenuItem();
		mnuEditPaste = new MenuItem();
		mnuPref = new MenuItem();
		mnuReportS = new MenuItem();
		_mnuReportIRER_1 = new MenuItem();
		mnuReportSep1 = new MenuItem();
		_mnuReportCR_1 = new MenuItem();
		mnuReportSep2 = new MenuItem();
		_mnuReportIRER_2 = new MenuItem();
		_mnuReportIRER_3 = new MenuItem();
		mnuHelp = new MenuItem();
		mnuHelpViewQuickStartGuide = new MenuItem();
		mnuHelpViewUserGuide = new MenuItem();
		mnuHelpAbout = new MenuItem();
		cmdGeneral = new Button();
		cmdChemical = new Button();
		cmdOpParms = new Button();
		cmdOperations = new Button();
		cmdExposures = new Button();
		cmdReleases = new Button();
		cmdOptionalInfo = new Button();
		cmdReports = new Button();
		_fraTab_7 = new GroupBox();
		Label19 = new Label();
		cmdSaveCombo = new Button();
		cmdViewCombo = new Button();
		cmdSaveContact = new Button();
		cmdViewContact = new Button();
		cmdSaveIRER = new Button();
		cmdViewIRER = new Button();
		CachedIRERcomb1 = new CachedIRERcomb();
		txtChemGenUse = new TextBox();
		((ISupportInitialize)msfContacts).BeginInit();
		((Control)_fraTab_2).SuspendLayout();
		((Control)_fraOpTab_1).SuspendLayout();
		((ISupportInitialize)msfNaics).BeginInit();
		((Control)_fraOpTab_2).SuspendLayout();
		((Control)_fraOpTab_0).SuspendLayout();
		((ISupportInitialize)msfSubOps).BeginInit();
		((Control)_fraOpTab_4).SuspendLayout();
		((ISupportInitialize)msfSites).BeginInit();
		((Control)_fraOpTab_3).SuspendLayout();
		((ISupportInitialize)msfSelActs).BeginInit();
		((ISupportInitialize)tabOps).BeginInit();
		((Control)_fraTab_4).SuspendLayout();
		((ISupportInitialize)msfRelParms).BeginInit();
		((ISupportInitialize)msfRelEst).BeginInit();
		((ISupportInitialize)tabRelSubTab).BeginInit();
		((Control)_fraTab_5).SuspendLayout();
		((Control)_fraExpTab_2).SuspendLayout();
		((Control)_fraExpTab_0).SuspendLayout();
		((ISupportInitialize)_msfExpParms_0).BeginInit();
		((Control)_fraExpTab_1).SuspendLayout();
		((ISupportInitialize)_msfExpParms_1).BeginInit();
		((Control)_fraExpTab_3).SuspendLayout();
		((ISupportInitialize)msfExpEst).BeginInit();
		((ISupportInitialize)tabExp).BeginInit();
		((Control)_fraTab_6).SuspendLayout();
		((Control)_fraOpInfo_0).SuspendLayout();
		((Control)_fraOpInfo_2).SuspendLayout();
		((Control)_fraSubOI_2).SuspendLayout();
		((Control)_fraSubOI_1).SuspendLayout();
		((ISupportInitialize)msfTlv).BeginInit();
		((Control)_fraSubOI_0).SuspendLayout();
		((ISupportInitialize)tabSubOI).BeginInit();
		((Control)_fraOpInfo_1).SuspendLayout();
		((Control)_fraOpInfo_5).SuspendLayout();
		((Control)_fraOpInfo_3).SuspendLayout();
		((Control)_fraOpInfo_6).SuspendLayout();
		((Control)_fraOpInfo_4).SuspendLayout();
		((Control)_fraTab_1).SuspendLayout();
		((Control)_fraTab_0).SuspendLayout();
		((Control)_fraTab_3).SuspendLayout();
		((Control)_fraIP_1).SuspendLayout();
		((Control)_fraConts_3).SuspendLayout();
		((ISupportInitialize)_msfCont_3).BeginInit();
		((Control)_fraConts_2).SuspendLayout();
		((ISupportInitialize)_msfCont_2).BeginInit();
		((Control)_fraConts_1).SuspendLayout();
		((ISupportInitialize)_msfCont_1).BeginInit();
		((Control)_fraConts_0).SuspendLayout();
		((ISupportInitialize)_msfCont_0).BeginInit();
		((ISupportInitialize)tabConts).BeginInit();
		((Control)_fraIP_0).SuspendLayout();
		((ISupportInitialize)msfOpIP).BeginInit();
		((Control)_fraIP_2).SuspendLayout();
		((ISupportInitialize)msfSP).BeginInit();
		((ISupportInitialize)tabIP).BeginInit();
		((ISupportInitialize)tabMain).BeginInit();
		((ISupportInitialize)LVE).BeginInit();
		((ISupportInitialize)Label1).BeginInit();
		((ISupportInitialize)Label2).BeginInit();
		((ISupportInitialize)Label3).BeginInit();
		((ISupportInitialize)Label4).BeginInit();
		((ISupportInitialize)Line1).BeginInit();
		((ISupportInitialize)Line2).BeginInit();
		((ISupportInitialize)Line3).BeginInit();
		((ISupportInitialize)fraConts).BeginInit();
		((ISupportInitialize)fraExpTab).BeginInit();
		((ISupportInitialize)fraIP).BeginInit();
		((ISupportInitialize)fraOpInfo).BeginInit();
		((ISupportInitialize)fraOpTab).BeginInit();
		((ISupportInitialize)fraSubOI).BeginInit();
		((ISupportInitialize)fraTab).BeginInit();
		((ISupportInitialize)lblAddr).BeginInit();
		((ISupportInitialize)lblAff).BeginInit();
		((ISupportInitialize)lblChemStateExp).BeginInit();
		((ISupportInitialize)lblContSumFC).BeginInit();
		((ISupportInitialize)lblContYprod).BeginInit();
		((ISupportInitialize)lblContYrm).BeginInit();
		((ISupportInitialize)lblEmail).BeginInit();
		((ISupportInitialize)lblGT100WorkersW1to10).BeginInit();
		((ISupportInitialize)lblName).BeginInit();
		((ISupportInitialize)lblNumWMet).BeginInit();
		((ISupportInitialize)lblPhone).BeginInit();
		((ISupportInitialize)lblPhyState).BeginInit();
		((ISupportInitialize)lblPhyStateOtherInfo).BeginInit();
		((ISupportInitialize)lblSatEReq).BeginInit();
		((ISupportInitialize)lblSatHReq).BeginInit();
		((ISupportInitialize)mnuPreferences).BeginInit();
		((ISupportInitialize)txtExpModelMsg).BeginInit();
		((ISupportInitialize)txtMsds).BeginInit();
		((Control)_fraTab_7).SuspendLayout();
		((Control)this).SuspendLayout();
		AxMSFlexGrid obj = msfContacts;
		Point location = new Point(792, 588);
		((Control)obj).Location = location;
		((Control)msfContacts).Name = "msfContacts";
		((AxHost)msfContacts).OcxState = (State)componentResourceManager.GetObject("msfContacts.OcxState");
		AxMSFlexGrid obj2 = msfContacts;
		Size size = new Size(113, 33);
		((Control)obj2).Size = size;
		((Control)msfContacts).TabIndex = 281;
		((Control)msfContacts).Visible = false;
		((Control)_fraTab_2).BackColor = SystemColors.Control;
		((Control)_fraTab_2).Controls.Add((Control)(object)Label5);
		((Control)_fraTab_2).Controls.Add((Control)(object)LabelSubTabs3);
		((Control)_fraTab_2).Controls.Add((Control)(object)cmdPhysicalStates);
		((Control)_fraTab_2).Controls.Add((Control)(object)cmdSiteInfo);
		((Control)_fraTab_2).Controls.Add((Control)(object)cmdSources);
		((Control)_fraTab_2).Controls.Add((Control)(object)cmdDescription);
		((Control)_fraTab_2).Controls.Add((Control)(object)cmdRelationships);
		((Control)_fraTab_2).Controls.Add((Control)(object)_lstSelOps_0);
		((Control)_fraTab_2).Controls.Add((Control)(object)cmdUpdOps);
		((Control)_fraTab_2).Controls.Add((Control)(object)_fraOpTab_1);
		((Control)_fraTab_2).Controls.Add((Control)(object)_fraOpTab_2);
		((Control)_fraTab_2).Controls.Add((Control)(object)_fraOpTab_0);
		((Control)_fraTab_2).Controls.Add((Control)(object)_fraOpTab_4);
		((Control)_fraTab_2).Controls.Add((Control)(object)_fraOpTab_3);
		((Control)_fraTab_2).Controls.Add((Control)(object)tabOps);
		((Control)_fraTab_2).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraTab_2).ForeColor = SystemColors.ControlText;
		fraTab.SetIndex(_fraTab_2, (short)2);
		GroupBox fraTab_ = _fraTab_2;
		location = new Point(124, 15);
		((Control)fraTab_).Location = location;
		((Control)_fraTab_2).Name = "_fraTab_2";
		((Control)_fraTab_2).RightToLeft = (RightToLeft)0;
		GroupBox fraTab_2 = _fraTab_2;
		size = new Size(785, 606);
		((Control)fraTab_2).Size = size;
		((Control)_fraTab_2).TabIndex = 51;
		_fraTab_2.TabStop = false;
		_fraTab_2.Text = "3. Operations";
		((Control)_fraTab_2).Visible = false;
		((Control)Label5).BackColor = SystemColors.Control;
		((Control)Label5).Cursor = Cursors.Default;
		((Control)Label5).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label5).ForeColor = SystemColors.ControlText;
		Label label = Label5;
		location = new Point(16, 23);
		((Control)label).Location = location;
		((Control)Label5).Name = "Label5";
		((Control)Label5).RightToLeft = (RightToLeft)0;
		Label label2 = Label5;
		size = new Size(748, 49);
		((Control)label2).Size = size;
		((Control)Label5).TabIndex = 107;
		((Control)Label5).Tag = "";
		Label5.Text = componentResourceManager.GetString("Label5.Text");
		((Control)LabelSubTabs3).BackColor = SystemColors.Control;
		((Control)LabelSubTabs3).Cursor = Cursors.Default;
		((Control)LabelSubTabs3).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)LabelSubTabs3).ForeColor = SystemColors.ControlText;
		Label labelSubTabs = LabelSubTabs3;
		location = new Point(18, 199);
		((Control)labelSubTabs).Location = location;
		((Control)LabelSubTabs3).Name = "LabelSubTabs3";
		((Control)LabelSubTabs3).RightToLeft = (RightToLeft)0;
		Label labelSubTabs2 = LabelSubTabs3;
		size = new Size(748, 66);
		((Control)labelSubTabs2).Size = size;
		((Control)LabelSubTabs3).TabIndex = 105;
		((Control)LabelSubTabs3).Tag = "";
		LabelSubTabs3.Text = componentResourceManager.GetString("LabelSubTabs3.Text");
		((ButtonBase)cmdPhysicalStates).BackColor = SystemColors.Control;
		((Control)cmdPhysicalStates).Cursor = Cursors.Default;
		((Control)cmdPhysicalStates).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdPhysicalStates).ForeColor = SystemColors.ControlText;
		Button obj3 = cmdPhysicalStates;
		location = new Point(318, 159);
		((Control)obj3).Location = location;
		((Control)cmdPhysicalStates).Name = "cmdPhysicalStates";
		((Control)cmdPhysicalStates).RightToLeft = (RightToLeft)0;
		Button obj4 = cmdPhysicalStates;
		size = new Size(151, 32);
		((Control)obj4).Size = size;
		((Control)cmdPhysicalStates).TabIndex = 99;
		((ButtonBase)cmdPhysicalStates).Text = "3c. &Physical States";
		((ButtonBase)cmdPhysicalStates).UseVisualStyleBackColor = false;
		((ButtonBase)cmdSiteInfo).BackColor = SystemColors.Control;
		((Control)cmdSiteInfo).Cursor = Cursors.Default;
		((Control)cmdSiteInfo).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdSiteInfo).ForeColor = SystemColors.ControlText;
		Button obj5 = cmdSiteInfo;
		location = new Point(620, 159);
		((Control)obj5).Location = location;
		((Control)cmdSiteInfo).Name = "cmdSiteInfo";
		((Control)cmdSiteInfo).RightToLeft = (RightToLeft)0;
		Button obj6 = cmdSiteInfo;
		size = new Size(149, 32);
		((Control)obj6).Size = size;
		((Control)cmdSiteInfo).TabIndex = 101;
		((ButtonBase)cmdSiteInfo).Text = "3e. Site &Information";
		((ButtonBase)cmdSiteInfo).UseVisualStyleBackColor = false;
		((ButtonBase)cmdSources).BackColor = SystemColors.Control;
		((Control)cmdSources).Cursor = Cursors.Default;
		((Control)cmdSources).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdSources).ForeColor = SystemColors.ControlText;
		Button obj7 = cmdSources;
		location = new Point(469, 159);
		((Control)obj7).Location = location;
		((Control)cmdSources).Name = "cmdSources";
		((Control)cmdSources).RightToLeft = (RightToLeft)0;
		Button obj8 = cmdSources;
		size = new Size(151, 32);
		((Control)obj8).Size = size;
		((Control)cmdSources).TabIndex = 100;
		((ButtonBase)cmdSources).Text = "3d. &Sources/Activities";
		((ButtonBase)cmdSources).UseVisualStyleBackColor = false;
		((ButtonBase)cmdDescription).BackColor = SystemColors.Control;
		((Control)cmdDescription).Cursor = Cursors.Default;
		((Control)cmdDescription).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdDescription).ForeColor = SystemColors.ControlText;
		Button obj9 = cmdDescription;
		location = new Point(167, 159);
		((Control)obj9).Location = location;
		((Control)cmdDescription).Name = "cmdDescription";
		((Control)cmdDescription).RightToLeft = (RightToLeft)0;
		Button obj10 = cmdDescription;
		size = new Size(151, 32);
		((Control)obj10).Size = size;
		((Control)cmdDescription).TabIndex = 98;
		((ButtonBase)cmdDescription).Text = "3b. Description";
		((ButtonBase)cmdDescription).UseVisualStyleBackColor = false;
		((ButtonBase)cmdRelationships).BackColor = Color.DimGray;
		((Control)cmdRelationships).Cursor = Cursors.Default;
		((Control)cmdRelationships).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdRelationships).ForeColor = Color.White;
		Button obj11 = cmdRelationships;
		location = new Point(16, 159);
		((Control)obj11).Location = location;
		((Control)cmdRelationships).Name = "cmdRelationships";
		((Control)cmdRelationships).RightToLeft = (RightToLeft)0;
		Button obj12 = cmdRelationships;
		size = new Size(151, 32);
		((Control)obj12).Size = size;
		((Control)cmdRelationships).TabIndex = 97;
		((ButtonBase)cmdRelationships).Text = "3a. Relationships";
		((ButtonBase)cmdRelationships).UseVisualStyleBackColor = false;
		_lstSelOps_0.BackColor = SystemColors.Window;
		((Control)_lstSelOps_0).Cursor = Cursors.Default;
		_lstSelOps_0.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_lstSelOps_0.ForeColor = SystemColors.WindowText;
		_lstSelOps_0.ItemHeight = 14;
		ListBox lstSelOps_ = _lstSelOps_0;
		location = new Point(19, 76);
		((Control)lstSelOps_).Location = location;
		((Control)_lstSelOps_0).Name = "_lstSelOps_0";
		_lstSelOps_0.RightToLeft = (RightToLeft)0;
		ListBox lstSelOps_2 = _lstSelOps_0;
		size = new Size(561, 74);
		((Control)lstSelOps_2).Size = size;
		((Control)_lstSelOps_0).TabIndex = 0;
		((ButtonBase)cmdUpdOps).BackColor = SystemColors.Control;
		((Control)cmdUpdOps).Cursor = Cursors.Default;
		((Control)cmdUpdOps).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdOps).ForeColor = SystemColors.ControlText;
		Button obj13 = cmdUpdOps;
		location = new Point(589, 76);
		((Control)obj13).Location = location;
		((Control)cmdUpdOps).Name = "cmdUpdOps";
		((Control)cmdUpdOps).RightToLeft = (RightToLeft)0;
		Button obj14 = cmdUpdOps;
		size = new Size(185, 27);
		((Control)obj14).Size = size;
		((Control)cmdUpdOps).TabIndex = 1;
		((ButtonBase)cmdUpdOps).Text = "Add / Update &Operations";
		((ButtonBase)cmdUpdOps).UseVisualStyleBackColor = false;
		((Control)_fraOpTab_1).BackColor = SystemColors.Control;
		((Control)_fraOpTab_1).Controls.Add((Control)(object)Label15);
		((Control)_fraOpTab_1).Controls.Add((Control)(object)msfNaics);
		((Control)_fraOpTab_1).Controls.Add((Control)(object)cmdUpdOpDesc);
		((Control)_fraOpTab_1).Controls.Add((Control)(object)txtPD);
		((Control)_fraOpTab_1).Controls.Add((Control)(object)_Label4_11);
		((Control)_fraOpTab_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraOpTab_1).ForeColor = SystemColors.ControlText;
		fraOpTab.SetIndex(_fraOpTab_1, (short)1);
		GroupBox fraOpTab_ = _fraOpTab_1;
		location = new Point(16, 263);
		((Control)fraOpTab_).Location = location;
		((Control)_fraOpTab_1).Name = "_fraOpTab_1";
		((Control)_fraOpTab_1).RightToLeft = (RightToLeft)0;
		GroupBox fraOpTab_2 = _fraOpTab_1;
		size = new Size(753, 327);
		((Control)fraOpTab_2).Size = size;
		((Control)_fraOpTab_1).TabIndex = 94;
		_fraOpTab_1.TabStop = false;
		((Control)_fraOpTab_1).Visible = false;
		Label15.AutoSize = true;
		((Control)Label15).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label3 = Label15;
		location = new Point(4, 260);
		((Control)label3).Location = location;
		((Control)Label15).Name = "Label15";
		Label label4 = Label15;
		size = new Size(106, 14);
		((Control)label4).Size = size;
		((Control)Label15).TabIndex = 395;
		Label15.Text = "Operation Actions";
		AxMSFlexGrid obj15 = msfNaics;
		location = new Point(16, 16);
		((Control)obj15).Location = location;
		((Control)msfNaics).Name = "msfNaics";
		((AxHost)msfNaics).OcxState = (State)componentResourceManager.GetObject("msfNaics.OcxState");
		AxMSFlexGrid obj16 = msfNaics;
		size = new Size(729, 136);
		((Control)obj16).Size = size;
		((Control)msfNaics).TabIndex = 178;
		((ButtonBase)cmdUpdOpDesc).BackColor = SystemColors.Control;
		((Control)cmdUpdOpDesc).Cursor = Cursors.Default;
		((Control)cmdUpdOpDesc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdOpDesc).ForeColor = SystemColors.ControlText;
		Button obj17 = cmdUpdOpDesc;
		location = new Point(4, 285);
		((Control)obj17).Location = location;
		((Control)cmdUpdOpDesc).Name = "cmdUpdOpDesc";
		((Control)cmdUpdOpDesc).RightToLeft = (RightToLeft)0;
		Button obj18 = cmdUpdOpDesc;
		size = new Size(177, 41);
		((Control)obj18).Size = size;
		((Control)cmdUpdOpDesc).TabIndex = 98;
		((ButtonBase)cmdUpdOpDesc).Text = "Update NAICS and Description";
		((ButtonBase)cmdUpdOpDesc).UseVisualStyleBackColor = false;
		txtPD.AcceptsReturn = true;
		((TextBoxBase)txtPD).BackColor = SystemColors.Control;
		((Control)txtPD).Cursor = Cursors.IBeam;
		((Control)txtPD).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtPD).ForeColor = SystemColors.WindowText;
		TextBox obj19 = txtPD;
		location = new Point(16, 172);
		((Control)obj19).Location = location;
		((TextBoxBase)txtPD).MaxLength = 0;
		txtPD.Multiline = true;
		((Control)txtPD).Name = "txtPD";
		((TextBoxBase)txtPD).ReadOnly = true;
		((Control)txtPD).RightToLeft = (RightToLeft)0;
		txtPD.ScrollBars = (ScrollBars)2;
		TextBox obj20 = txtPD;
		size = new Size(729, 79);
		((Control)obj20).Size = size;
		((Control)txtPD).TabIndex = 95;
		((Control)_Label4_11).BackColor = SystemColors.Control;
		((Control)_Label4_11).Cursor = Cursors.Default;
		((Control)_Label4_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_11).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_11, (short)11);
		Label label4_ = _Label4_11;
		location = new Point(16, 156);
		((Control)label4_).Location = location;
		((Control)_Label4_11).Name = "_Label4_11";
		((Control)_Label4_11).RightToLeft = (RightToLeft)0;
		Label label4_2 = _Label4_11;
		size = new Size(129, 17);
		((Control)label4_2).Size = size;
		((Control)_Label4_11).TabIndex = 284;
		_Label4_11.Text = "Process Description:";
		((Control)_fraOpTab_2).BackColor = SystemColors.Control;
		((Control)_fraOpTab_2).Controls.Add((Control)(object)Label16);
		((Control)_fraOpTab_2).Controls.Add((Control)(object)cmdUpdPhyState);
		((Control)_fraOpTab_2).Controls.Add((Control)(object)_lblPhyStateOtherInfo_2);
		((Control)_fraOpTab_2).Controls.Add((Control)(object)_lblPhyState_2);
		((Control)_fraOpTab_2).Controls.Add((Control)(object)_Label4_10);
		((Control)_fraOpTab_2).Controls.Add((Control)(object)_lblPhyStateOtherInfo_1);
		((Control)_fraOpTab_2).Controls.Add((Control)(object)_lblPhyStateOtherInfo_0);
		((Control)_fraOpTab_2).Controls.Add((Control)(object)_Label4_8);
		((Control)_fraOpTab_2).Controls.Add((Control)(object)_lblPhyState_1);
		((Control)_fraOpTab_2).Controls.Add((Control)(object)_lblPhyState_0);
		((Control)_fraOpTab_2).Controls.Add((Control)(object)_Label4_4);
		((Control)_fraOpTab_2).Controls.Add((Control)(object)_Label4_1);
		((Control)_fraOpTab_2).Controls.Add((Control)(object)_Label4_6);
		((Control)_fraOpTab_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraOpTab_2).ForeColor = SystemColors.ControlText;
		fraOpTab.SetIndex(_fraOpTab_2, (short)2);
		GroupBox fraOpTab_3 = _fraOpTab_2;
		location = new Point(16, 263);
		((Control)fraOpTab_3).Location = location;
		((Control)_fraOpTab_2).Name = "_fraOpTab_2";
		((Control)_fraOpTab_2).RightToLeft = (RightToLeft)0;
		GroupBox fraOpTab_4 = _fraOpTab_2;
		size = new Size(753, 327);
		((Control)fraOpTab_4).Size = size;
		((Control)_fraOpTab_2).TabIndex = 96;
		_fraOpTab_2.TabStop = false;
		((Control)_fraOpTab_2).Visible = false;
		Label16.AutoSize = true;
		((Control)Label16).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label5 = Label16;
		location = new Point(4, 260);
		((Control)label5).Location = location;
		((Control)Label16).Name = "Label16";
		Label label6 = Label16;
		size = new Size(106, 14);
		((Control)label6).Size = size;
		((Control)Label16).TabIndex = 396;
		Label16.Text = "Operation Actions";
		((ButtonBase)cmdUpdPhyState).BackColor = SystemColors.Control;
		((Control)cmdUpdPhyState).Cursor = Cursors.Default;
		((Control)cmdUpdPhyState).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdPhyState).ForeColor = SystemColors.ControlText;
		Button obj21 = cmdUpdPhyState;
		location = new Point(4, 285);
		((Control)obj21).Location = location;
		((Control)cmdUpdPhyState).Name = "cmdUpdPhyState";
		((Control)cmdUpdPhyState).RightToLeft = (RightToLeft)0;
		Button obj22 = cmdUpdPhyState;
		size = new Size(177, 41);
		((Control)obj22).Size = size;
		((Control)cmdUpdPhyState).TabIndex = 97;
		((ButtonBase)cmdUpdPhyState).Text = "Update Physical State";
		((ButtonBase)cmdUpdPhyState).UseVisualStyleBackColor = false;
		((Control)_lblPhyStateOtherInfo_2).BackColor = SystemColors.Control;
		_lblPhyStateOtherInfo_2.BorderStyle = (BorderStyle)2;
		((Control)_lblPhyStateOtherInfo_2).Cursor = Cursors.Default;
		((Control)_lblPhyStateOtherInfo_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblPhyStateOtherInfo_2).ForeColor = SystemColors.ControlText;
		lblPhyStateOtherInfo.SetIndex(_lblPhyStateOtherInfo_2, (short)2);
		Label lblPhyStateOtherInfo_ = _lblPhyStateOtherInfo_2;
		location = new Point(304, 112);
		((Control)lblPhyStateOtherInfo_).Location = location;
		((Control)_lblPhyStateOtherInfo_2).Name = "_lblPhyStateOtherInfo_2";
		((Control)_lblPhyStateOtherInfo_2).RightToLeft = (RightToLeft)0;
		Label lblPhyStateOtherInfo_2 = _lblPhyStateOtherInfo_2;
		size = new Size(417, 17);
		((Control)lblPhyStateOtherInfo_2).Size = size;
		((Control)_lblPhyStateOtherInfo_2).TabIndex = 190;
		((Control)_lblPhyState_2).BackColor = SystemColors.Control;
		_lblPhyState_2.BorderStyle = (BorderStyle)2;
		((Control)_lblPhyState_2).Cursor = Cursors.Default;
		((Control)_lblPhyState_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblPhyState_2).ForeColor = SystemColors.ControlText;
		lblPhyState.SetIndex(_lblPhyState_2, (short)2);
		Label lblPhyState_ = _lblPhyState_2;
		location = new Point(224, 112);
		((Control)lblPhyState_).Location = location;
		((Control)_lblPhyState_2).Name = "_lblPhyState_2";
		((Control)_lblPhyState_2).RightToLeft = (RightToLeft)0;
		Label lblPhyState_2 = _lblPhyState_2;
		size = new Size(73, 17);
		((Control)lblPhyState_2).Size = size;
		((Control)_lblPhyState_2).TabIndex = 189;
		_lblPhyState_2.TextAlign = (ContentAlignment)4;
		((Control)_Label4_10).BackColor = SystemColors.Control;
		((Control)_Label4_10).Cursor = Cursors.Default;
		((Control)_Label4_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_10).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_10, (short)10);
		Label label4_3 = _Label4_10;
		location = new Point(64, 112);
		((Control)label4_3).Location = location;
		((Control)_Label4_10).Name = "_Label4_10";
		((Control)_Label4_10).RightToLeft = (RightToLeft)0;
		Label label4_4 = _Label4_10;
		size = new Size(153, 17);
		((Control)label4_4).Size = size;
		((Control)_Label4_10).TabIndex = 188;
		_Label4_10.Text = "Chemical in the Operation:";
		_Label4_10.TextAlign = (ContentAlignment)4;
		((Control)_lblPhyStateOtherInfo_1).BackColor = SystemColors.Control;
		_lblPhyStateOtherInfo_1.BorderStyle = (BorderStyle)2;
		((Control)_lblPhyStateOtherInfo_1).Cursor = Cursors.Default;
		((Control)_lblPhyStateOtherInfo_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblPhyStateOtherInfo_1).ForeColor = SystemColors.ControlText;
		lblPhyStateOtherInfo.SetIndex(_lblPhyStateOtherInfo_1, (short)1);
		Label lblPhyStateOtherInfo_3 = _lblPhyStateOtherInfo_1;
		location = new Point(304, 88);
		((Control)lblPhyStateOtherInfo_3).Location = location;
		((Control)_lblPhyStateOtherInfo_1).Name = "_lblPhyStateOtherInfo_1";
		((Control)_lblPhyStateOtherInfo_1).RightToLeft = (RightToLeft)0;
		Label lblPhyStateOtherInfo_4 = _lblPhyStateOtherInfo_1;
		size = new Size(417, 17);
		((Control)lblPhyStateOtherInfo_4).Size = size;
		((Control)_lblPhyStateOtherInfo_1).TabIndex = 187;
		((Control)_lblPhyStateOtherInfo_0).BackColor = SystemColors.Control;
		_lblPhyStateOtherInfo_0.BorderStyle = (BorderStyle)2;
		((Control)_lblPhyStateOtherInfo_0).Cursor = Cursors.Default;
		((Control)_lblPhyStateOtherInfo_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblPhyStateOtherInfo_0).ForeColor = SystemColors.ControlText;
		lblPhyStateOtherInfo.SetIndex(_lblPhyStateOtherInfo_0, (short)0);
		Label lblPhyStateOtherInfo_5 = _lblPhyStateOtherInfo_0;
		location = new Point(304, 64);
		((Control)lblPhyStateOtherInfo_5).Location = location;
		((Control)_lblPhyStateOtherInfo_0).Name = "_lblPhyStateOtherInfo_0";
		((Control)_lblPhyStateOtherInfo_0).RightToLeft = (RightToLeft)0;
		Label lblPhyStateOtherInfo_6 = _lblPhyStateOtherInfo_0;
		size = new Size(417, 17);
		((Control)lblPhyStateOtherInfo_6).Size = size;
		((Control)_lblPhyStateOtherInfo_0).TabIndex = 186;
		((Control)_Label4_8).BackColor = SystemColors.Control;
		((Control)_Label4_8).Cursor = Cursors.Default;
		((Control)_Label4_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_8).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_8, (short)8);
		Label label4_5 = _Label4_8;
		location = new Point(304, 48);
		((Control)label4_5).Location = location;
		((Control)_Label4_8).Name = "_Label4_8";
		((Control)_Label4_8).RightToLeft = (RightToLeft)0;
		Label label4_6 = _Label4_8;
		size = new Size(225, 17);
		((Control)label4_6).Size = size;
		((Control)_Label4_8).TabIndex = 185;
		_Label4_8.Text = "Other Information";
		_Label4_8.TextAlign = (ContentAlignment)2;
		((Control)_lblPhyState_1).BackColor = SystemColors.Control;
		_lblPhyState_1.BorderStyle = (BorderStyle)2;
		((Control)_lblPhyState_1).Cursor = Cursors.Default;
		((Control)_lblPhyState_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblPhyState_1).ForeColor = SystemColors.ControlText;
		lblPhyState.SetIndex(_lblPhyState_1, (short)1);
		Label lblPhyState_3 = _lblPhyState_1;
		location = new Point(224, 88);
		((Control)lblPhyState_3).Location = location;
		((Control)_lblPhyState_1).Name = "_lblPhyState_1";
		((Control)_lblPhyState_1).RightToLeft = (RightToLeft)0;
		Label lblPhyState_4 = _lblPhyState_1;
		size = new Size(73, 17);
		((Control)lblPhyState_4).Size = size;
		((Control)_lblPhyState_1).TabIndex = 184;
		_lblPhyState_1.TextAlign = (ContentAlignment)4;
		((Control)_lblPhyState_0).BackColor = SystemColors.Control;
		_lblPhyState_0.BorderStyle = (BorderStyle)2;
		((Control)_lblPhyState_0).Cursor = Cursors.Default;
		((Control)_lblPhyState_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblPhyState_0).ForeColor = SystemColors.ControlText;
		lblPhyState.SetIndex(_lblPhyState_0, (short)0);
		Label lblPhyState_5 = _lblPhyState_0;
		location = new Point(224, 64);
		((Control)lblPhyState_5).Location = location;
		((Control)_lblPhyState_0).Name = "_lblPhyState_0";
		((Control)_lblPhyState_0).RightToLeft = (RightToLeft)0;
		Label lblPhyState_6 = _lblPhyState_0;
		size = new Size(73, 17);
		((Control)lblPhyState_6).Size = size;
		((Control)_lblPhyState_0).TabIndex = 183;
		_lblPhyState_0.TextAlign = (ContentAlignment)4;
		((Control)_Label4_4).BackColor = SystemColors.Control;
		((Control)_Label4_4).Cursor = Cursors.Default;
		((Control)_Label4_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_4).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_4, (short)4);
		Label label4_7 = _Label4_4;
		location = new Point(224, 48);
		((Control)label4_7).Location = location;
		((Control)_Label4_4).Name = "_Label4_4";
		((Control)_Label4_4).RightToLeft = (RightToLeft)0;
		Label label4_8 = _Label4_4;
		size = new Size(81, 17);
		((Control)label4_8).Size = size;
		((Control)_Label4_4).TabIndex = 182;
		_Label4_4.Text = "Physical State";
		((Control)_Label4_1).BackColor = SystemColors.Control;
		((Control)_Label4_1).Cursor = Cursors.Default;
		((Control)_Label4_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_1).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_1, (short)1);
		Label label4_9 = _Label4_1;
		location = new Point(64, 88);
		((Control)label4_9).Location = location;
		((Control)_Label4_1).Name = "_Label4_1";
		((Control)_Label4_1).RightToLeft = (RightToLeft)0;
		Label label4_10 = _Label4_1;
		size = new Size(153, 17);
		((Control)label4_10).Size = size;
		((Control)_Label4_1).TabIndex = 179;
		_Label4_1.Text = "Chemical out of the Operation:";
		_Label4_1.TextAlign = (ContentAlignment)4;
		((Control)_Label4_6).BackColor = SystemColors.Control;
		((Control)_Label4_6).Cursor = Cursors.Default;
		((Control)_Label4_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_6).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_6, (short)6);
		Label label4_11 = _Label4_6;
		location = new Point(32, 64);
		((Control)label4_11).Location = location;
		((Control)_Label4_6).Name = "_Label4_6";
		((Control)_Label4_6).RightToLeft = (RightToLeft)0;
		Label label4_12 = _Label4_6;
		size = new Size(185, 17);
		((Control)label4_12).Size = size;
		((Control)_Label4_6).TabIndex = 102;
		_Label4_6.Text = "Chemical into the Operation:";
		_Label4_6.TextAlign = (ContentAlignment)4;
		((Control)_fraOpTab_0).BackColor = SystemColors.Control;
		((Control)_fraOpTab_0).Controls.Add((Control)(object)Label14);
		((Control)_fraOpTab_0).Controls.Add((Control)(object)cmdUpdRelations);
		((Control)_fraOpTab_0).Controls.Add((Control)(object)msfSubOps);
		((Control)_fraOpTab_0).Controls.Add((Control)(object)lblMyPvf);
		((Control)_fraOpTab_0).Controls.Add((Control)(object)_Label4_9);
		((Control)_fraOpTab_0).Controls.Add((Control)(object)lblMyPvop);
		((Control)_fraOpTab_0).Controls.Add((Control)(object)_Label4_7);
		((Control)_fraOpTab_0).Controls.Add((Control)(object)_Label4_3);
		((Control)_fraOpTab_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraOpTab_0).ForeColor = SystemColors.ControlText;
		fraOpTab.SetIndex(_fraOpTab_0, (short)0);
		GroupBox fraOpTab_5 = _fraOpTab_0;
		location = new Point(16, 263);
		((Control)fraOpTab_5).Location = location;
		((Control)_fraOpTab_0).Name = "_fraOpTab_0";
		((Control)_fraOpTab_0).RightToLeft = (RightToLeft)0;
		GroupBox fraOpTab_6 = _fraOpTab_0;
		size = new Size(753, 327);
		((Control)fraOpTab_6).Size = size;
		((Control)_fraOpTab_0).TabIndex = 67;
		_fraOpTab_0.TabStop = false;
		Label14.AutoSize = true;
		((Control)Label14).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label7 = Label14;
		location = new Point(4, 260);
		((Control)label7).Location = location;
		((Control)Label14).Name = "Label14";
		Label label8 = Label14;
		size = new Size(106, 14);
		((Control)label8).Size = size;
		((Control)Label14).TabIndex = 394;
		Label14.Text = "Operation Actions";
		((ButtonBase)cmdUpdRelations).BackColor = SystemColors.Control;
		((Control)cmdUpdRelations).Cursor = Cursors.Default;
		((Control)cmdUpdRelations).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdRelations).ForeColor = SystemColors.ControlText;
		Button obj23 = cmdUpdRelations;
		location = new Point(4, 285);
		((Control)obj23).Location = location;
		((Control)cmdUpdRelations).Name = "cmdUpdRelations";
		((Control)cmdUpdRelations).RightToLeft = (RightToLeft)0;
		Button obj24 = cmdUpdRelations;
		size = new Size(177, 41);
		((Control)obj24).Size = size;
		((Control)cmdUpdRelations).TabIndex = 85;
		((ButtonBase)cmdUpdRelations).Text = "Update &Relationships";
		((ButtonBase)cmdUpdRelations).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj25 = msfSubOps;
		location = new Point(16, 40);
		((Control)obj25).Location = location;
		((Control)msfSubOps).Name = "msfSubOps";
		((AxHost)msfSubOps).OcxState = (State)componentResourceManager.GetObject("msfSubOps.OcxState");
		AxMSFlexGrid obj26 = msfSubOps;
		size = new Size(729, 188);
		((Control)obj26).Size = size;
		((Control)msfSubOps).TabIndex = 84;
		((Control)lblMyPvf).BackColor = SystemColors.Control;
		((Control)lblMyPvf).Cursor = Cursors.Default;
		((Control)lblMyPvf).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMyPvf).ForeColor = SystemColors.ControlText;
		Label obj27 = lblMyPvf;
		location = new Point(616, 16);
		((Control)obj27).Location = location;
		((Control)lblMyPvf).Name = "lblMyPvf";
		((Control)lblMyPvf).RightToLeft = (RightToLeft)0;
		Label obj28 = lblMyPvf;
		size = new Size(65, 17);
		((Control)obj28).Size = size;
		((Control)lblMyPvf).TabIndex = 250;
		lblMyPvf.Text = "n/a";
		((Control)_Label4_9).BackColor = SystemColors.Control;
		((Control)_Label4_9).Cursor = Cursors.Default;
		((Control)_Label4_9).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_9).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_9, (short)9);
		Label label4_13 = _Label4_9;
		location = new Point(576, 16);
		((Control)label4_13).Location = location;
		((Control)_Label4_9).Name = "_Label4_9";
		((Control)_Label4_9).RightToLeft = (RightToLeft)0;
		Label label4_14 = _Label4_9;
		size = new Size(33, 17);
		((Control)label4_14).Size = size;
		((Control)_Label4_9).TabIndex = 249;
		_Label4_9.Text = "PVf:";
		_Label4_9.TextAlign = (ContentAlignment)4;
		((Control)lblMyPvop).BackColor = SystemColors.Control;
		((Control)lblMyPvop).Cursor = Cursors.Default;
		((Control)lblMyPvop).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMyPvop).ForeColor = SystemColors.ControlText;
		Label obj29 = lblMyPvop;
		location = new Point(432, 16);
		((Control)obj29).Location = location;
		((Control)lblMyPvop).Name = "lblMyPvop";
		((Control)lblMyPvop).RightToLeft = (RightToLeft)0;
		Label obj30 = lblMyPvop;
		size = new Size(121, 17);
		((Control)obj30).Size = size;
		((Control)lblMyPvop).TabIndex = 248;
		lblMyPvop.Text = "n/a";
		((Control)_Label4_7).BackColor = SystemColors.Control;
		((Control)_Label4_7).Cursor = Cursors.Default;
		((Control)_Label4_7).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_7).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_7, (short)7);
		Label label4_15 = _Label4_7;
		location = new Point(376, 16);
		((Control)label4_15).Location = location;
		((Control)_Label4_7).Name = "_Label4_7";
		((Control)_Label4_7).RightToLeft = (RightToLeft)0;
		Label label4_16 = _Label4_7;
		size = new Size(49, 17);
		((Control)label4_16).Size = size;
		((Control)_Label4_7).TabIndex = 247;
		_Label4_7.Text = "PVop:";
		_Label4_7.TextAlign = (ContentAlignment)4;
		((Control)_Label4_3).BackColor = SystemColors.Control;
		((Control)_Label4_3).Cursor = Cursors.Default;
		((Control)_Label4_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_3).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_3, (short)3);
		Label label4_17 = _Label4_3;
		location = new Point(16, 24);
		((Control)label4_17).Location = location;
		((Control)_Label4_3).Name = "_Label4_3";
		((Control)_Label4_3).RightToLeft = (RightToLeft)0;
		Label label4_18 = _Label4_3;
		size = new Size(129, 17);
		((Control)label4_18).Size = size;
		((Control)_Label4_3).TabIndex = 80;
		_Label4_3.Text = "Subsequent Operations:";
		((Control)_fraOpTab_4).BackColor = SystemColors.Control;
		((Control)_fraOpTab_4).Controls.Add((Control)(object)_Label4_5);
		((Control)_fraOpTab_4).Controls.Add((Control)(object)Label18);
		((Control)_fraOpTab_4).Controls.Add((Control)(object)cmdCopyOpSiteInfo);
		((Control)_fraOpTab_4).Controls.Add((Control)(object)cmdUpdSites);
		((Control)_fraOpTab_4).Controls.Add((Control)(object)msfSites);
		((Control)_fraOpTab_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraOpTab_4).ForeColor = SystemColors.ControlText;
		fraOpTab.SetIndex(_fraOpTab_4, (short)4);
		GroupBox fraOpTab_7 = _fraOpTab_4;
		location = new Point(16, 263);
		((Control)fraOpTab_7).Location = location;
		((Control)_fraOpTab_4).Name = "_fraOpTab_4";
		((Control)_fraOpTab_4).RightToLeft = (RightToLeft)0;
		GroupBox fraOpTab_8 = _fraOpTab_4;
		size = new Size(753, 327);
		((Control)fraOpTab_8).Size = size;
		((Control)_fraOpTab_4).TabIndex = 68;
		_fraOpTab_4.TabStop = false;
		((Control)_fraOpTab_4).Visible = false;
		((Control)_Label4_5).BackColor = SystemColors.Control;
		((Control)_Label4_5).Cursor = Cursors.Default;
		((Control)_Label4_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label4_5).ForeColor = SystemColors.ControlText;
		Label4.SetIndex(_Label4_5, (short)5);
		Label label4_19 = _Label4_5;
		location = new Point(16, 16);
		((Control)label4_19).Location = location;
		((Control)_Label4_5).Name = "_Label4_5";
		((Control)_Label4_5).RightToLeft = (RightToLeft)0;
		Label label4_20 = _Label4_5;
		size = new Size(201, 17);
		((Control)label4_20).Size = size;
		((Control)_Label4_5).TabIndex = 101;
		_Label4_5.Text = "Operation Site Information:";
		Label18.AutoSize = true;
		((Control)Label18).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label9 = Label18;
		location = new Point(4, 260);
		((Control)label9).Location = location;
		((Control)Label18).Name = "Label18";
		Label label10 = Label18;
		size = new Size(106, 14);
		((Control)label10).Size = size;
		((Control)Label18).TabIndex = 396;
		Label18.Text = "Operation Actions";
		((ButtonBase)cmdCopyOpSiteInfo).BackColor = SystemColors.Control;
		((Control)cmdCopyOpSiteInfo).Cursor = Cursors.Default;
		((Control)cmdCopyOpSiteInfo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdCopyOpSiteInfo).ForeColor = SystemColors.ControlText;
		Button obj31 = cmdCopyOpSiteInfo;
		location = new Point(191, 285);
		((Control)obj31).Location = location;
		((Control)cmdCopyOpSiteInfo).Name = "cmdCopyOpSiteInfo";
		((Control)cmdCopyOpSiteInfo).RightToLeft = (RightToLeft)0;
		Button obj32 = cmdCopyOpSiteInfo;
		size = new Size(177, 41);
		((Control)obj32).Size = size;
		((Control)cmdCopyOpSiteInfo).TabIndex = 4;
		((ButtonBase)cmdCopyOpSiteInfo).Text = "&Copy Previous Operation";
		((ButtonBase)cmdCopyOpSiteInfo).UseVisualStyleBackColor = false;
		((ButtonBase)cmdUpdSites).BackColor = SystemColors.Control;
		((Control)cmdUpdSites).Cursor = Cursors.Default;
		((Control)cmdUpdSites).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdSites).ForeColor = SystemColors.ControlText;
		Button obj33 = cmdUpdSites;
		location = new Point(4, 285);
		((Control)obj33).Location = location;
		((Control)cmdUpdSites).Name = "cmdUpdSites";
		((Control)cmdUpdSites).RightToLeft = (RightToLeft)0;
		Button obj34 = cmdUpdSites;
		size = new Size(177, 41);
		((Control)obj34).Size = size;
		((Control)cmdUpdSites).TabIndex = 3;
		((ButtonBase)cmdUpdSites).Text = "&Update Site Information";
		((ButtonBase)cmdUpdSites).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj35 = msfSites;
		location = new Point(16, 32);
		((Control)obj35).Location = location;
		((Control)msfSites).Name = "msfSites";
		((AxHost)msfSites).OcxState = (State)componentResourceManager.GetObject("msfSites.OcxState");
		AxMSFlexGrid obj36 = msfSites;
		size = new Size(721, 216);
		((Control)obj36).Size = size;
		((Control)msfSites).TabIndex = 2;
		((Control)_fraOpTab_3).BackColor = SystemColors.Control;
		((Control)_fraOpTab_3).Controls.Add((Control)(object)Label17);
		((Control)_fraOpTab_3).Controls.Add((Control)(object)cmdUpdOpAct);
		((Control)_fraOpTab_3).Controls.Add((Control)(object)msfSelActs);
		((Control)_fraOpTab_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraOpTab_3).ForeColor = SystemColors.ControlText;
		fraOpTab.SetIndex(_fraOpTab_3, (short)3);
		GroupBox fraOpTab_9 = _fraOpTab_3;
		location = new Point(16, 263);
		((Control)fraOpTab_9).Location = location;
		((Control)_fraOpTab_3).Name = "_fraOpTab_3";
		((Control)_fraOpTab_3).RightToLeft = (RightToLeft)0;
		GroupBox fraOpTab_10 = _fraOpTab_3;
		size = new Size(753, 337);
		((Control)fraOpTab_10).Size = size;
		((Control)_fraOpTab_3).TabIndex = 91;
		_fraOpTab_3.TabStop = false;
		((Control)_fraOpTab_3).Visible = false;
		Label17.AutoSize = true;
		((Control)Label17).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		Label label11 = Label17;
		location = new Point(4, 260);
		((Control)label11).Location = location;
		((Control)Label17).Name = "Label17";
		Label label12 = Label17;
		size = new Size(106, 14);
		((Control)label12).Size = size;
		((Control)Label17).TabIndex = 396;
		Label17.Text = "Operation Actions";
		((ButtonBase)cmdUpdOpAct).BackColor = SystemColors.Control;
		((Control)cmdUpdOpAct).Cursor = Cursors.Default;
		((Control)cmdUpdOpAct).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdOpAct).ForeColor = SystemColors.ControlText;
		Button obj37 = cmdUpdOpAct;
		location = new Point(4, 285);
		((Control)obj37).Location = location;
		((Control)cmdUpdOpAct).Name = "cmdUpdOpAct";
		((Control)cmdUpdOpAct).RightToLeft = (RightToLeft)0;
		Button obj38 = cmdUpdOpAct;
		size = new Size(177, 41);
		((Control)obj38).Size = size;
		((Control)cmdUpdOpAct).TabIndex = 99;
		((ButtonBase)cmdUpdOpAct).Text = "Update &Sources/Activities";
		((ButtonBase)cmdUpdOpAct).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj39 = msfSelActs;
		location = new Point(16, 16);
		((Control)obj39).Location = location;
		((Control)msfSelActs).Name = "msfSelActs";
		((AxHost)msfSelActs).OcxState = (State)componentResourceManager.GetObject("msfSelActs.OcxState");
		AxMSFlexGrid obj40 = msfSelActs;
		size = new Size(729, 221);
		((Control)obj40).Size = size;
		((Control)msfSelActs).TabIndex = 210;
		AxTabStrip obj41 = tabOps;
		location = new Point(15, 200);
		((Control)obj41).Location = location;
		((Control)tabOps).Name = "tabOps";
		((AxHost)tabOps).OcxState = (State)componentResourceManager.GetObject("tabOps.OcxState");
		AxTabStrip obj42 = tabOps;
		size = new Size(762, 236);
		((Control)obj42).Size = size;
		((Control)tabOps).TabIndex = 66;
		((Control)_fraTab_4).BackColor = SystemColors.Control;
		((Control)_fraTab_4).Controls.Add((Control)(object)Label22);
		((Control)_fraTab_4).Controls.Add((Control)(object)Label9);
		((Control)_fraTab_4).Controls.Add((Control)(object)cmdEstReleases);
		((Control)_fraTab_4).Controls.Add((Control)(object)cmdRelParms);
		((Control)_fraTab_4).Controls.Add((Control)(object)cmbRelActs);
		((Control)_fraTab_4).Controls.Add((Control)(object)cmdRelAddNotes);
		((Control)_fraTab_4).Controls.Add((Control)(object)cmdRelBasis);
		((Control)_fraTab_4).Controls.Add((Control)(object)txtRelModelMsg);
		((Control)_fraTab_4).Controls.Add((Control)(object)cmbRelOps);
		((Control)_fraTab_4).Controls.Add((Control)(object)cmdRunRelModel);
		((Control)_fraTab_4).Controls.Add((Control)(object)cmdViewModelInfo);
		((Control)_fraTab_4).Controls.Add((Control)(object)cmdAddRelModel);
		((Control)_fraTab_4).Controls.Add((Control)(object)lstRelModels);
		((Control)_fraTab_4).Controls.Add((Control)(object)cmdUpdRelMedia);
		((Control)_fraTab_4).Controls.Add((Control)(object)msfRelParms);
		((Control)_fraTab_4).Controls.Add((Control)(object)_Label1_71);
		((Control)_fraTab_4).Controls.Add((Control)(object)_Label1_68);
		((Control)_fraTab_4).Controls.Add((Control)(object)_Label1_69);
		((Control)_fraTab_4).Controls.Add((Control)(object)_Label1_67);
		((Control)_fraTab_4).Controls.Add((Control)(object)lblRel);
		((Control)_fraTab_4).Controls.Add((Control)(object)msfRelEst);
		((Control)_fraTab_4).Controls.Add((Control)(object)tabRelSubTab);
		((Control)_fraTab_4).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraTab_4).ForeColor = SystemColors.ControlText;
		fraTab.SetIndex(_fraTab_4, (short)4);
		GroupBox fraTab_3 = _fraTab_4;
		location = new Point(124, 15);
		((Control)fraTab_3).Location = location;
		((Control)_fraTab_4).Name = "_fraTab_4";
		((Control)_fraTab_4).RightToLeft = (RightToLeft)0;
		GroupBox fraTab_4 = _fraTab_4;
		size = new Size(785, 605);
		((Control)fraTab_4).Size = size;
		((Control)_fraTab_4).TabIndex = 77;
		_fraTab_4.TabStop = false;
		_fraTab_4.Text = "5. Estimating Chemical Releases";
		((Control)_fraTab_4).Visible = false;
		((Control)Label22).BackColor = SystemColors.Control;
		((Control)Label22).Cursor = Cursors.Default;
		((Control)Label22).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label22).ForeColor = SystemColors.ControlText;
		Label label13 = Label22;
		location = new Point(16, 23);
		((Control)label13).Location = location;
		((Control)Label22).Name = "Label22";
		((Control)Label22).RightToLeft = (RightToLeft)0;
		Label label14 = Label22;
		size = new Size(753, 34);
		((Control)label14).Size = size;
		((Control)Label22).TabIndex = 393;
		Label22.Text = "Select the desired operation, source, and release model below. Read the \"Estimating Chemical Releases Tab\" topic of the User Guide for more detailed information.";
		Label9.AutoSize = true;
		Label label15 = Label9;
		location = new Point(20, 524);
		((Control)label15).Location = location;
		((Control)Label9).Name = "Label9";
		Label label16 = Label9;
		size = new Size(187, 14);
		((Control)label16).Size = size;
		((Control)Label9).TabIndex = 392;
		Label9.Text = "Chemical Release Model Actions";
		((ButtonBase)cmdEstReleases).BackColor = SystemColors.Control;
		((Control)cmdEstReleases).Cursor = Cursors.Default;
		((Control)cmdEstReleases).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdEstReleases).ForeColor = SystemColors.ControlText;
		Button obj43 = cmdEstReleases;
		location = new Point(195, 133);
		((Control)obj43).Location = location;
		((Control)cmdEstReleases).Name = "cmdEstReleases";
		((Control)cmdEstReleases).RightToLeft = (RightToLeft)0;
		Button obj44 = cmdEstReleases;
		size = new Size(179, 32);
		((Control)obj44).Size = size;
		((Control)cmdEstReleases).TabIndex = 379;
		((ButtonBase)cmdEstReleases).Text = "5b. Estimated Releases";
		((ButtonBase)cmdEstReleases).UseVisualStyleBackColor = false;
		((ButtonBase)cmdRelParms).BackColor = Color.DimGray;
		((Control)cmdRelParms).Cursor = Cursors.Default;
		((Control)cmdRelParms).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdRelParms).ForeColor = Color.White;
		Button obj45 = cmdRelParms;
		location = new Point(16, 133);
		((Control)obj45).Location = location;
		((Control)cmdRelParms).Name = "cmdRelParms";
		((Control)cmdRelParms).RightToLeft = (RightToLeft)0;
		Button obj46 = cmdRelParms;
		size = new Size(179, 32);
		((Control)obj46).Size = size;
		((Control)cmdRelParms).TabIndex = 378;
		((ButtonBase)cmdRelParms).Text = "5a. Release Input Parameters";
		((ButtonBase)cmdRelParms).UseVisualStyleBackColor = false;
		cmbRelActs.BackColor = SystemColors.Window;
		((Control)cmbRelActs).Cursor = Cursors.Default;
		cmbRelActs.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbRelActs).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbRelActs.ForeColor = SystemColors.WindowText;
		ComboBox obj47 = cmbRelActs;
		location = new Point(77, 94);
		((Control)obj47).Location = location;
		((Control)cmbRelActs).Name = "cmbRelActs";
		((Control)cmbRelActs).RightToLeft = (RightToLeft)0;
		ComboBox obj48 = cmbRelActs;
		size = new Size(372, 22);
		((Control)obj48).Size = size;
		((Control)cmbRelActs).TabIndex = 377;
		((ButtonBase)cmdRelAddNotes).BackColor = SystemColors.Control;
		((Control)cmdRelAddNotes).Cursor = Cursors.Default;
		((Control)cmdRelAddNotes).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRelAddNotes).ForeColor = SystemColors.ControlText;
		Button obj49 = cmdRelAddNotes;
		location = new Point(528, 549);
		((Control)obj49).Location = location;
		((Control)cmdRelAddNotes).Name = "cmdRelAddNotes";
		((Control)cmdRelAddNotes).RightToLeft = (RightToLeft)0;
		Button obj50 = cmdRelAddNotes;
		size = new Size(121, 37);
		((Control)obj50).Size = size;
		((Control)cmdRelAddNotes).TabIndex = 22;
		((ButtonBase)cmdRelAddNotes).Text = "Additional &Notes for the Release Summary";
		((ButtonBase)cmdRelAddNotes).UseVisualStyleBackColor = false;
		((ButtonBase)cmdRelBasis).BackColor = SystemColors.Control;
		((Control)cmdRelBasis).Cursor = Cursors.Default;
		((Control)cmdRelBasis).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRelBasis).ForeColor = SystemColors.ControlText;
		Button obj51 = cmdRelBasis;
		location = new Point(400, 549);
		((Control)obj51).Location = location;
		((Control)cmdRelBasis).Name = "cmdRelBasis";
		((Control)cmdRelBasis).RightToLeft = (RightToLeft)0;
		Button obj52 = cmdRelBasis;
		size = new Size(121, 37);
		((Control)obj52).Size = size;
		((Control)cmdRelBasis).TabIndex = 21;
		((ButtonBase)cmdRelBasis).Text = "Introductory Notes for the Release &Summary";
		((ButtonBase)cmdRelBasis).UseVisualStyleBackColor = false;
		txtRelModelMsg.AcceptsReturn = true;
		((TextBoxBase)txtRelModelMsg).BackColor = SystemColors.Menu;
		((Control)txtRelModelMsg).Cursor = Cursors.IBeam;
		((Control)txtRelModelMsg).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtRelModelMsg).ForeColor = SystemColors.WindowText;
		TextBox obj53 = txtRelModelMsg;
		location = new Point(16, 208);
		((Control)obj53).Location = location;
		((TextBoxBase)txtRelModelMsg).MaxLength = 0;
		((Control)txtRelModelMsg).Name = "txtRelModelMsg";
		((TextBoxBase)txtRelModelMsg).ReadOnly = true;
		((Control)txtRelModelMsg).RightToLeft = (RightToLeft)0;
		TextBox obj54 = txtRelModelMsg;
		size = new Size(758, 20);
		((Control)obj54).Size = size;
		((Control)txtRelModelMsg).TabIndex = 324;
		cmbRelOps.BackColor = SystemColors.Window;
		((Control)cmbRelOps).Cursor = Cursors.Default;
		cmbRelOps.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbRelOps).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbRelOps.ForeColor = SystemColors.WindowText;
		ComboBox obj55 = cmbRelOps;
		location = new Point(77, 65);
		((Control)obj55).Location = location;
		((Control)cmbRelOps).Name = "cmbRelOps";
		((Control)cmbRelOps).RightToLeft = (RightToLeft)0;
		ComboBox obj56 = cmbRelOps;
		size = new Size(345, 22);
		((Control)obj56).Size = size;
		((Control)cmbRelOps).TabIndex = 14;
		((ButtonBase)cmdRunRelModel).BackColor = SystemColors.Control;
		((Control)cmdRunRelModel).Cursor = Cursors.Default;
		((Control)cmdRunRelModel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRunRelModel).ForeColor = SystemColors.ControlText;
		Button obj57 = cmdRunRelModel;
		location = new Point(656, 549);
		((Control)obj57).Location = location;
		((Control)cmdRunRelModel).Name = "cmdRunRelModel";
		((Control)cmdRunRelModel).RightToLeft = (RightToLeft)0;
		Button obj58 = cmdRunRelModel;
		size = new Size(121, 37);
		((Control)obj58).Size = size;
		((Control)cmdRunRelModel).TabIndex = 23;
		((ButtonBase)cmdRunRelModel).Text = "&Run Model(s)";
		((ButtonBase)cmdRunRelModel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdViewModelInfo).BackColor = SystemColors.Control;
		((Control)cmdViewModelInfo).Cursor = Cursors.Default;
		((Control)cmdViewModelInfo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdViewModelInfo).ForeColor = SystemColors.ControlText;
		Button obj59 = cmdViewModelInfo;
		location = new Point(148, 549);
		((Control)obj59).Location = location;
		((Control)cmdViewModelInfo).Name = "cmdViewModelInfo";
		((Control)cmdViewModelInfo).RightToLeft = (RightToLeft)0;
		Button obj60 = cmdViewModelInfo;
		size = new Size(121, 37);
		((Control)obj60).Size = size;
		((Control)cmdViewModelInfo).TabIndex = 19;
		((ButtonBase)cmdViewModelInfo).Text = "View/Update Model &Information";
		((ButtonBase)cmdViewModelInfo).UseVisualStyleBackColor = false;
		((ButtonBase)cmdAddRelModel).BackColor = SystemColors.Control;
		((Control)cmdAddRelModel).Cursor = Cursors.Default;
		((Control)cmdAddRelModel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdAddRelModel).ForeColor = SystemColors.ControlText;
		Button obj61 = cmdAddRelModel;
		location = new Point(22, 549);
		((Control)obj61).Location = location;
		((Control)cmdAddRelModel).Name = "cmdAddRelModel";
		((Control)cmdAddRelModel).RightToLeft = (RightToLeft)0;
		Button obj62 = cmdAddRelModel;
		size = new Size(121, 37);
		((Control)obj62).Size = size;
		((Control)cmdAddRelModel).TabIndex = 18;
		((ButtonBase)cmdAddRelModel).Text = "&Add or Remove a Release model";
		((ButtonBase)cmdAddRelModel).UseVisualStyleBackColor = false;
		lstRelModels.BackColor = SystemColors.Window;
		((Control)lstRelModels).Cursor = Cursors.Default;
		lstRelModels.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		lstRelModels.ForeColor = SystemColors.WindowText;
		lstRelModels.ItemHeight = 14;
		ListBox obj63 = lstRelModels;
		location = new Point(518, 66);
		((Control)obj63).Location = location;
		((Control)lstRelModels).Name = "lstRelModels";
		lstRelModels.RightToLeft = (RightToLeft)0;
		ListBox obj64 = lstRelModels;
		size = new Size(258, 46);
		((Control)obj64).Size = size;
		((Control)lstRelModels).TabIndex = 15;
		((ButtonBase)cmdUpdRelMedia).BackColor = SystemColors.Control;
		((Control)cmdUpdRelMedia).Cursor = Cursors.Default;
		((Control)cmdUpdRelMedia).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdRelMedia).ForeColor = SystemColors.ControlText;
		Button obj65 = cmdUpdRelMedia;
		location = new Point(274, 549);
		((Control)obj65).Location = location;
		((Control)cmdUpdRelMedia).Name = "cmdUpdRelMedia";
		((Control)cmdUpdRelMedia).RightToLeft = (RightToLeft)0;
		Button obj66 = cmdUpdRelMedia;
		size = new Size(121, 37);
		((Control)obj66).Size = size;
		((Control)cmdUpdRelMedia).TabIndex = 20;
		((ButtonBase)cmdUpdRelMedia).Text = "&Modify Media of Release";
		((ButtonBase)cmdUpdRelMedia).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj67 = msfRelParms;
		location = new Point(16, 227);
		((Control)obj67).Location = location;
		((Control)msfRelParms).Name = "msfRelParms";
		((AxHost)msfRelParms).OcxState = (State)componentResourceManager.GetObject("msfRelParms.OcxState");
		AxMSFlexGrid obj68 = msfRelParms;
		size = new Size(761, 282);
		((Control)obj68).Size = size;
		((Control)msfRelParms).TabIndex = 16;
		((Control)_Label1_71).BackColor = SystemColors.Control;
		((Control)_Label1_71).Cursor = Cursors.Default;
		((Control)_Label1_71).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_71).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_71, (short)71);
		Label label1_ = _Label1_71;
		location = new Point(77, 93);
		((Control)label1_).Location = location;
		((Control)_Label1_71).Name = "_Label1_71";
		((Control)_Label1_71).RightToLeft = (RightToLeft)0;
		Label label1_2 = _Label1_71;
		size = new Size(153, 17);
		((Control)label1_2).Size = size;
		((Control)_Label1_71).TabIndex = 242;
		_Label1_71.Text = "No release expected";
		((Control)_Label1_68).BackColor = SystemColors.Control;
		((Control)_Label1_68).Cursor = Cursors.Default;
		((Control)_Label1_68).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_68).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_68, (short)68);
		Label label1_3 = _Label1_68;
		location = new Point(16, 65);
		((Control)label1_3).Location = location;
		((Control)_Label1_68).Name = "_Label1_68";
		((Control)_Label1_68).RightToLeft = (RightToLeft)0;
		Label label1_4 = _Label1_68;
		size = new Size(64, 19);
		((Control)label1_4).Size = size;
		((Control)_Label1_68).TabIndex = 241;
		_Label1_68.Text = "Operation:";
		((Control)_Label1_69).BackColor = SystemColors.Control;
		((Control)_Label1_69).Cursor = Cursors.Default;
		((Control)_Label1_69).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_69).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_69, (short)69);
		Label label1_5 = _Label1_69;
		location = new Point(413, 68);
		((Control)label1_5).Location = location;
		((Control)_Label1_69).Name = "_Label1_69";
		((Control)_Label1_69).RightToLeft = (RightToLeft)0;
		Label label1_6 = _Label1_69;
		size = new Size(105, 29);
		((Control)label1_6).Size = size;
		((Control)_Label1_69).TabIndex = 109;
		_Label1_69.Text = "Release Model(s):";
		_Label1_69.TextAlign = (ContentAlignment)4;
		((Control)_Label1_67).BackColor = SystemColors.Control;
		((Control)_Label1_67).Cursor = Cursors.Default;
		((Control)_Label1_67).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_67).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_67, (short)67);
		Label label1_7 = _Label1_67;
		location = new Point(16, 93);
		((Control)label1_7).Location = location;
		((Control)_Label1_67).Name = "_Label1_67";
		((Control)_Label1_67).RightToLeft = (RightToLeft)0;
		Label label1_8 = _Label1_67;
		size = new Size(49, 17);
		((Control)label1_8).Size = size;
		((Control)_Label1_67).TabIndex = 108;
		_Label1_67.Text = "Source: ";
		((Control)lblRel).BackColor = SystemColors.Control;
		((Control)lblRel).Cursor = Cursors.Default;
		((Control)lblRel).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblRel).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(lblRel, (short)70);
		Label obj69 = lblRel;
		location = new Point(18, 172);
		((Control)obj69).Location = location;
		((Control)lblRel).Name = "lblRel";
		((Control)lblRel).RightToLeft = (RightToLeft)0;
		Label obj70 = lblRel;
		size = new Size(753, 34);
		((Control)obj70).Size = size;
		((Control)lblRel).TabIndex = 107;
		lblRel.Text = componentResourceManager.GetString("lblRel.Text");
		AxMSFlexGrid obj71 = msfRelEst;
		location = new Point(16, 207);
		((Control)obj71).Location = location;
		((Control)msfRelEst).Name = "msfRelEst";
		((AxHost)msfRelEst).OcxState = (State)componentResourceManager.GetObject("msfRelEst.OcxState");
		AxMSFlexGrid obj72 = msfRelEst;
		size = new Size(761, 262);
		((Control)obj72).Size = size;
		((Control)msfRelEst).TabIndex = 17;
		((Control)msfRelEst).Visible = false;
		AxTabStrip obj73 = tabRelSubTab;
		location = new Point(67, 208);
		((Control)obj73).Location = location;
		((Control)tabRelSubTab).Name = "tabRelSubTab";
		((AxHost)tabRelSubTab).OcxState = (State)componentResourceManager.GetObject("tabRelSubTab.OcxState");
		AxTabStrip obj74 = tabRelSubTab;
		size = new Size(701, 200);
		((Control)obj74).Size = size;
		((Control)tabRelSubTab).TabIndex = 24;
		((ButtonBase)cmdRelComb).BackColor = SystemColors.InactiveCaption;
		((Control)cmdRelComb).Cursor = Cursors.Default;
		((Control)cmdRelComb).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRelComb).ForeColor = SystemColors.ControlText;
		Button obj75 = cmdRelComb;
		location = new Point(881, 576);
		((Control)obj75).Location = location;
		((Control)cmdRelComb).Name = "cmdRelComb";
		((Control)cmdRelComb).RightToLeft = (RightToLeft)0;
		Button obj76 = cmdRelComb;
		size = new Size(105, 29);
		((Control)obj76).Size = size;
		((Control)cmdRelComb).TabIndex = 43;
		((ButtonBase)cmdRelComb).Text = "View/Update &Combinations";
		((ButtonBase)cmdRelComb).UseVisualStyleBackColor = false;
		((Control)cmdRelComb).Visible = false;
		((Control)_fraTab_5).BackColor = SystemColors.Control;
		((Control)_fraTab_5).Controls.Add((Control)(object)_fraExpTab_2);
		((Control)_fraTab_5).Controls.Add((Control)(object)Label23);
		((Control)_fraTab_5).Controls.Add((Control)(object)_fraExpTab_0);
		((Control)_fraTab_5).Controls.Add((Control)(object)_fraExpTab_1);
		((Control)_fraTab_5).Controls.Add((Control)(object)_fraExpTab_3);
		((Control)_fraTab_5).Controls.Add((Control)(object)cmdDermal);
		((Control)_fraTab_5).Controls.Add((Control)(object)Label6);
		((Control)_fraTab_5).Controls.Add((Control)(object)cmdRespirator);
		((Control)_fraTab_5).Controls.Add((Control)(object)cmdInhalation);
		((Control)_fraTab_5).Controls.Add((Control)(object)cmdActivity);
		((Control)_fraTab_5).Controls.Add((Control)(object)cmbExpActs);
		((Control)_fraTab_5).Controls.Add((Control)(object)cmdUpdateExpNw);
		((Control)_fraTab_5).Controls.Add((Control)(object)cmdInhBasis);
		((Control)_fraTab_5).Controls.Add((Control)(object)cmbExpOps);
		((Control)_fraTab_5).Controls.Add((Control)(object)cmdRunExpModel);
		((Control)_fraTab_5).Controls.Add((Control)(object)cmdAddExpModel);
		((Control)_fraTab_5).Controls.Add((Control)(object)cmdViewExpModel);
		((Control)_fraTab_5).Controls.Add((Control)(object)_Label1_74);
		((Control)_fraTab_5).Controls.Add((Control)(object)_Label1_73);
		((Control)_fraTab_5).Controls.Add((Control)(object)_Label1_72);
		((Control)_fraTab_5).Controls.Add((Control)(object)lblExpSubtab);
		((Control)_fraTab_5).Controls.Add((Control)(object)tabExp);
		((Control)_fraTab_5).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraTab_5).ForeColor = SystemColors.ControlText;
		fraTab.SetIndex(_fraTab_5, (short)5);
		GroupBox fraTab_5 = _fraTab_5;
		location = new Point(124, 15);
		((Control)fraTab_5).Location = location;
		((Control)_fraTab_5).Name = "_fraTab_5";
		GroupBox fraTab_6 = _fraTab_5;
		size = new Size(785, 605);
		((Control)fraTab_6).Size = size;
		((Control)_fraTab_5).TabIndex = 201;
		_fraTab_5.TabStop = false;
		_fraTab_5.Text = "6. Estimating Chemical Exposures";
		((Control)_fraTab_5).Visible = false;
		((Control)_fraExpTab_2).BackColor = SystemColors.Control;
		((Control)_fraExpTab_2).Controls.Add((Control)(object)lblInhClassInhMon);
		((Control)_fraExpTab_2).Controls.Add((Control)(object)lblInhClassHazRating);
		((Control)_fraExpTab_2).Controls.Add((Control)(object)lblInhClassExpLevel);
		((Control)_fraExpTab_2).Controls.Add((Control)(object)lblInhClassUncertainty);
		((Control)_fraExpTab_2).Controls.Add((Control)(object)_Label1_337);
		((Control)_fraExpTab_2).Controls.Add((Control)(object)_Label1_336);
		((Control)_fraExpTab_2).Controls.Add((Control)(object)_Label1_335);
		((Control)_fraExpTab_2).Controls.Add((Control)(object)_Label1_334);
		((Control)_fraExpTab_2).Controls.Add((Control)(object)_Label1_333);
		((Control)_fraExpTab_2).Controls.Add((Control)(object)_Label1_114);
		((Control)_fraExpTab_2).Controls.Add((Control)(object)lblInhClassNotes);
		((Control)_fraExpTab_2).Controls.Add((Control)(object)lblInhClass);
		((Control)_fraExpTab_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraExpTab_2).ForeColor = SystemColors.ControlText;
		fraExpTab.SetIndex(_fraExpTab_2, (short)2);
		GroupBox fraExpTab_ = _fraExpTab_2;
		location = new Point(12, 208);
		((Control)fraExpTab_).Location = location;
		((Control)_fraExpTab_2).Name = "_fraExpTab_2";
		((Control)_fraExpTab_2).RightToLeft = (RightToLeft)0;
		GroupBox fraExpTab_2 = _fraExpTab_2;
		size = new Size(766, 293);
		((Control)fraExpTab_2).Size = size;
		((Control)_fraExpTab_2).TabIndex = 384;
		_fraExpTab_2.TabStop = false;
		((Control)_fraExpTab_2).Visible = false;
		((Control)lblInhClassInhMon).BackColor = SystemColors.Control;
		((Control)lblInhClassInhMon).Cursor = Cursors.Default;
		((Control)lblInhClassInhMon).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInhClassInhMon).ForeColor = SystemColors.WindowText;
		Label obj77 = lblInhClassInhMon;
		location = new Point(465, 200);
		((Control)obj77).Location = location;
		((Control)lblInhClassInhMon).Name = "lblInhClassInhMon";
		((Control)lblInhClassInhMon).RightToLeft = (RightToLeft)0;
		Label obj78 = lblInhClassInhMon;
		size = new Size(121, 17);
		((Control)obj78).Size = size;
		((Control)lblInhClassInhMon).TabIndex = 396;
		lblInhClassInhMon.Text = "x";
		((Control)lblInhClassHazRating).BackColor = SystemColors.Control;
		((Control)lblInhClassHazRating).Cursor = Cursors.Default;
		((Control)lblInhClassHazRating).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInhClassHazRating).ForeColor = SystemColors.WindowText;
		Label obj79 = lblInhClassHazRating;
		location = new Point(465, 160);
		((Control)obj79).Location = location;
		((Control)lblInhClassHazRating).Name = "lblInhClassHazRating";
		((Control)lblInhClassHazRating).RightToLeft = (RightToLeft)0;
		Label obj80 = lblInhClassHazRating;
		size = new Size(33, 17);
		((Control)obj80).Size = size;
		((Control)lblInhClassHazRating).TabIndex = 395;
		lblInhClassHazRating.Text = "x";
		((Control)lblInhClassExpLevel).BackColor = SystemColors.Control;
		((Control)lblInhClassExpLevel).Cursor = Cursors.Default;
		((Control)lblInhClassExpLevel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInhClassExpLevel).ForeColor = SystemColors.WindowText;
		Label obj81 = lblInhClassExpLevel;
		location = new Point(465, 128);
		((Control)obj81).Location = location;
		((Control)lblInhClassExpLevel).Name = "lblInhClassExpLevel";
		((Control)lblInhClassExpLevel).RightToLeft = (RightToLeft)0;
		Label obj82 = lblInhClassExpLevel;
		size = new Size(33, 17);
		((Control)obj82).Size = size;
		((Control)lblInhClassExpLevel).TabIndex = 394;
		lblInhClassExpLevel.Text = "x";
		((Control)lblInhClassUncertainty).BackColor = SystemColors.Control;
		((Control)lblInhClassUncertainty).Cursor = Cursors.Default;
		((Control)lblInhClassUncertainty).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInhClassUncertainty).ForeColor = SystemColors.WindowText;
		Label obj83 = lblInhClassUncertainty;
		location = new Point(465, 104);
		((Control)obj83).Location = location;
		((Control)lblInhClassUncertainty).Name = "lblInhClassUncertainty";
		((Control)lblInhClassUncertainty).RightToLeft = (RightToLeft)0;
		Label obj84 = lblInhClassUncertainty;
		size = new Size(33, 17);
		((Control)obj84).Size = size;
		((Control)lblInhClassUncertainty).TabIndex = 393;
		lblInhClassUncertainty.Text = "x";
		((Control)_Label1_337).BackColor = SystemColors.Control;
		((Control)_Label1_337).Cursor = Cursors.Default;
		((Control)_Label1_337).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_337).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_337, (short)337);
		Label label1_9 = _Label1_337;
		location = new Point(16, 200);
		((Control)label1_9).Location = location;
		((Control)_Label1_337).Name = "_Label1_337";
		((Control)_Label1_337).RightToLeft = (RightToLeft)0;
		Label label1_10 = _Label1_337;
		size = new Size(393, 17);
		((Control)label1_10).Size = size;
		((Control)_Label1_337).TabIndex = 392;
		_Label1_337.Text = "=> Inhalation Monitoring Data Desired?";
		((Control)_Label1_336).BackColor = SystemColors.Control;
		((Control)_Label1_336).Cursor = Cursors.Default;
		((Control)_Label1_336).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_336).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_336, (short)336);
		Label label1_11 = _Label1_336;
		location = new Point(24, 160);
		((Control)label1_11).Location = location;
		((Control)_Label1_336).Name = "_Label1_336";
		((Control)_Label1_336).RightToLeft = (RightToLeft)0;
		Label label1_12 = _Label1_336;
		size = new Size(385, 17);
		((Control)label1_12).Size = size;
		((Control)_Label1_336).TabIndex = 391;
		_Label1_336.Text = "b) Hazard Rating for health of 2 or greater?";
		((Control)_Label1_335).BackColor = SystemColors.Control;
		((Control)_Label1_335).Cursor = Cursors.Default;
		((Control)_Label1_335).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_335).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_335, (short)335);
		Label label1_13 = _Label1_335;
		location = new Point(40, 144);
		((Control)label1_13).Location = location;
		((Control)_Label1_335).Name = "_Label1_335";
		((Control)_Label1_335).RightToLeft = (RightToLeft)0;
		Label label1_14 = _Label1_335;
		size = new Size(25, 17);
		((Control)label1_14).Size = size;
		((Control)_Label1_335).TabIndex = 390;
		_Label1_335.Text = "OR";
		((Control)_Label1_334).BackColor = SystemColors.Control;
		((Control)_Label1_334).Cursor = Cursors.Default;
		((Control)_Label1_334).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_334).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_334, (short)334);
		Label label1_15 = _Label1_334;
		location = new Point(16, 128);
		((Control)label1_15).Location = location;
		((Control)_Label1_334).Name = "_Label1_334";
		((Control)_Label1_334).RightToLeft = (RightToLeft)0;
		Label label1_16 = _Label1_334;
		size = new Size(353, 17);
		((Control)label1_16).Size = size;
		((Control)_Label1_334).TabIndex = 389;
		_Label1_334.Text = "2) a) Exposure level > 1 mg/day?";
		((Control)_Label1_333).BackColor = SystemColors.Control;
		((Control)_Label1_333).Cursor = Cursors.Default;
		((Control)_Label1_333).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_333).ForeColor = SystemColors.ControlText;
		Label label1_17 = _Label1_333;
		location = new Point(16, 104);
		((Control)label1_17).Location = location;
		((Control)_Label1_333).Name = "_Label1_333";
		((Control)_Label1_333).RightToLeft = (RightToLeft)0;
		Label label1_18 = _Label1_333;
		size = new Size(457, 17);
		((Control)label1_18).Size = size;
		((Control)_Label1_333).TabIndex = 388;
		_Label1_333.Text = "1) Uncertainty (estimate based on model, regulatory limit, or data not specified to industry):";
		((Control)_Label1_114).BackColor = SystemColors.Control;
		((Control)_Label1_114).Cursor = Cursors.Default;
		((Control)_Label1_114).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_114).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_114, (short)114);
		Label label1_19 = _Label1_114;
		location = new Point(16, 88);
		((Control)label1_19).Location = location;
		((Control)_Label1_114).Name = "_Label1_114";
		((Control)_Label1_114).RightToLeft = (RightToLeft)0;
		Label label1_20 = _Label1_114;
		size = new Size(601, 17);
		((Control)label1_20).Size = size;
		((Control)_Label1_114).TabIndex = 387;
		_Label1_114.Text = "INHALATION MONITORING DATA REVIEW";
		((Control)lblInhClassNotes).BackColor = SystemColors.Control;
		((Control)lblInhClassNotes).Cursor = Cursors.Default;
		((Control)lblInhClassNotes).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInhClassNotes).ForeColor = SystemColors.WindowText;
		Label obj85 = lblInhClassNotes;
		location = new Point(16, 48);
		((Control)obj85).Location = location;
		((Control)lblInhClassNotes).Name = "lblInhClassNotes";
		((Control)lblInhClassNotes).RightToLeft = (RightToLeft)0;
		Label obj86 = lblInhClassNotes;
		size = new Size(739, 33);
		((Control)obj86).Size = size;
		((Control)lblInhClassNotes).TabIndex = 386;
		lblInhClassNotes.Text = "x";
		((Control)lblInhClass).BackColor = SystemColors.Control;
		((Control)lblInhClass).Cursor = Cursors.Default;
		((Control)lblInhClass).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblInhClass).ForeColor = SystemColors.WindowText;
		Label obj87 = lblInhClass;
		location = new Point(16, 24);
		((Control)obj87).Location = location;
		((Control)lblInhClass).Name = "lblInhClass";
		((Control)lblInhClass).RightToLeft = (RightToLeft)0;
		Label obj88 = lblInhClass;
		size = new Size(721, 17);
		((Control)obj88).Size = size;
		((Control)lblInhClass).TabIndex = 385;
		lblInhClass.Text = "x";
		((Control)Label23).BackColor = SystemColors.Control;
		((Control)Label23).Cursor = Cursors.Default;
		((Control)Label23).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label23).ForeColor = SystemColors.ControlText;
		Label label17 = Label23;
		location = new Point(16, 23);
		((Control)label17).Location = location;
		((Control)Label23).Name = "Label23";
		((Control)Label23).RightToLeft = (RightToLeft)0;
		Label label18 = Label23;
		size = new Size(761, 38);
		((Control)label18).Size = size;
		((Control)Label23).TabIndex = 390;
		Label23.Text = "Select the desired operation and worker activity below. Read the \"Estimating Chemical Exposures Tab\" topic of the User Guide for more detailed information.";
		((Control)_fraExpTab_0).BackColor = SystemColors.Control;
		((Control)_fraExpTab_0).Controls.Add((Control)(object)_txtExpModelMsg_0);
		((Control)_fraExpTab_0).Controls.Add((Control)(object)_msfExpParms_0);
		((Control)_fraExpTab_0).Controls.Add((Control)(object)lblDExpModel);
		((Control)_fraExpTab_0).Controls.Add((Control)(object)_lblChemStateExp_0);
		((Control)_fraExpTab_0).Controls.Add((Control)(object)_Label3_1);
		((Control)_fraExpTab_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraExpTab_0).ForeColor = SystemColors.ControlText;
		fraExpTab.SetIndex(_fraExpTab_0, (short)0);
		GroupBox fraExpTab_3 = _fraExpTab_0;
		location = new Point(11, 208);
		((Control)fraExpTab_3).Location = location;
		((Control)_fraExpTab_0).Name = "_fraExpTab_0";
		((Control)_fraExpTab_0).RightToLeft = (RightToLeft)0;
		GroupBox fraExpTab_4 = _fraExpTab_0;
		size = new Size(766, 293);
		((Control)fraExpTab_4).Size = size;
		((Control)_fraExpTab_0).TabIndex = 202;
		_fraExpTab_0.TabStop = false;
		_txtExpModelMsg_0.AcceptsReturn = true;
		((TextBoxBase)_txtExpModelMsg_0).BackColor = SystemColors.Menu;
		((Control)_txtExpModelMsg_0).Cursor = Cursors.IBeam;
		((Control)_txtExpModelMsg_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtExpModelMsg_0).ForeColor = SystemColors.WindowText;
		txtExpModelMsg.SetIndex(_txtExpModelMsg_0, (short)0);
		TextBox txtExpModelMsg_ = _txtExpModelMsg_0;
		location = new Point(464, 16);
		((Control)txtExpModelMsg_).Location = location;
		((TextBoxBase)_txtExpModelMsg_0).MaxLength = 0;
		((Control)_txtExpModelMsg_0).Name = "_txtExpModelMsg_0";
		((TextBoxBase)_txtExpModelMsg_0).ReadOnly = true;
		((Control)_txtExpModelMsg_0).RightToLeft = (RightToLeft)0;
		TextBox txtExpModelMsg_2 = _txtExpModelMsg_0;
		size = new Size(289, 20);
		((Control)txtExpModelMsg_2).Size = size;
		((Control)_txtExpModelMsg_0).TabIndex = 325;
		AxMSFlexGrid msfExpParms_ = _msfExpParms_0;
		location = new Point(8, 56);
		((Control)msfExpParms_).Location = location;
		((Control)_msfExpParms_0).Name = "_msfExpParms_0";
		((AxHost)_msfExpParms_0).OcxState = (State)componentResourceManager.GetObject("_msfExpParms_0.OcxState");
		AxMSFlexGrid msfExpParms_2 = _msfExpParms_0;
		size = new Size(753, 230);
		((Control)msfExpParms_2).Size = size;
		((Control)_msfExpParms_0).TabIndex = 28;
		((Control)lblDExpModel).BackColor = SystemColors.Control;
		((Control)lblDExpModel).Cursor = Cursors.Default;
		((Control)lblDExpModel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblDExpModel).ForeColor = SystemColors.ControlText;
		Label obj89 = lblDExpModel;
		location = new Point(8, 40);
		((Control)obj89).Location = location;
		((Control)lblDExpModel).Name = "lblDExpModel";
		((Control)lblDExpModel).RightToLeft = (RightToLeft)0;
		Label obj90 = lblDExpModel;
		size = new Size(721, 17);
		((Control)obj90).Size = size;
		((Control)lblDExpModel).TabIndex = 319;
		lblDExpModel.Text = "n/a";
		((Control)_lblChemStateExp_0).BackColor = SystemColors.Control;
		((Control)_lblChemStateExp_0).Cursor = Cursors.Default;
		((Control)_lblChemStateExp_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblChemStateExp_0).ForeColor = SystemColors.ControlText;
		lblChemStateExp.SetIndex(_lblChemStateExp_0, (short)0);
		Label lblChemStateExp_ = _lblChemStateExp_0;
		location = new Point(156, 16);
		((Control)lblChemStateExp_).Location = location;
		((Control)_lblChemStateExp_0).Name = "_lblChemStateExp_0";
		((Control)_lblChemStateExp_0).RightToLeft = (RightToLeft)0;
		Label lblChemStateExp_2 = _lblChemStateExp_0;
		size = new Size(65, 17);
		((Control)lblChemStateExp_2).Size = size;
		((Control)_lblChemStateExp_0).TabIndex = 318;
		_lblChemStateExp_0.Text = "n/a";
		((Control)_Label3_1).BackColor = SystemColors.Control;
		((Control)_Label3_1).Cursor = Cursors.Default;
		((Control)_Label3_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label3_1).ForeColor = SystemColors.ControlText;
		Label3.SetIndex(_Label3_1, (short)1);
		Label label3_ = _Label3_1;
		location = new Point(8, 16);
		((Control)label3_).Location = location;
		((Control)_Label3_1).Name = "_Label3_1";
		((Control)_Label3_1).RightToLeft = (RightToLeft)0;
		Label label3_2 = _Label3_1;
		size = new Size(129, 17);
		((Control)label3_2).Size = size;
		((Control)_Label3_1).TabIndex = 317;
		_Label3_1.Text = "Chemical State:";
		((Control)_fraExpTab_1).BackColor = SystemColors.Control;
		((Control)_fraExpTab_1).Controls.Add((Control)(object)_txtExpModelMsg_1);
		((Control)_fraExpTab_1).Controls.Add((Control)(object)_msfExpParms_1);
		((Control)_fraExpTab_1).Controls.Add((Control)(object)lblIExpModel);
		((Control)_fraExpTab_1).Controls.Add((Control)(object)_lblChemStateExp_1);
		((Control)_fraExpTab_1).Controls.Add((Control)(object)_Label3_2);
		((Control)_fraExpTab_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraExpTab_1).ForeColor = SystemColors.ControlText;
		fraExpTab.SetIndex(_fraExpTab_1, (short)1);
		GroupBox fraExpTab_5 = _fraExpTab_1;
		location = new Point(11, 208);
		((Control)fraExpTab_5).Location = location;
		((Control)_fraExpTab_1).Name = "_fraExpTab_1";
		((Control)_fraExpTab_1).RightToLeft = (RightToLeft)0;
		GroupBox fraExpTab_6 = _fraExpTab_1;
		size = new Size(766, 293);
		((Control)fraExpTab_6).Size = size;
		((Control)_fraExpTab_1).TabIndex = 246;
		_fraExpTab_1.TabStop = false;
		((Control)_fraExpTab_1).Visible = false;
		_txtExpModelMsg_1.AcceptsReturn = true;
		((TextBoxBase)_txtExpModelMsg_1).BackColor = SystemColors.Menu;
		((Control)_txtExpModelMsg_1).Cursor = Cursors.IBeam;
		((Control)_txtExpModelMsg_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtExpModelMsg_1).ForeColor = SystemColors.WindowText;
		txtExpModelMsg.SetIndex(_txtExpModelMsg_1, (short)1);
		TextBox txtExpModelMsg_3 = _txtExpModelMsg_1;
		location = new Point(464, 16);
		((Control)txtExpModelMsg_3).Location = location;
		((TextBoxBase)_txtExpModelMsg_1).MaxLength = 0;
		((Control)_txtExpModelMsg_1).Name = "_txtExpModelMsg_1";
		((TextBoxBase)_txtExpModelMsg_1).ReadOnly = true;
		((Control)_txtExpModelMsg_1).RightToLeft = (RightToLeft)0;
		TextBox txtExpModelMsg_4 = _txtExpModelMsg_1;
		size = new Size(289, 20);
		((Control)txtExpModelMsg_4).Size = size;
		((Control)_txtExpModelMsg_1).TabIndex = 326;
		AxMSFlexGrid msfExpParms_3 = _msfExpParms_1;
		location = new Point(8, 56);
		((Control)msfExpParms_3).Location = location;
		((Control)_msfExpParms_1).Name = "_msfExpParms_1";
		((AxHost)_msfExpParms_1).OcxState = (State)componentResourceManager.GetObject("_msfExpParms_1.OcxState");
		AxMSFlexGrid msfExpParms_4 = _msfExpParms_1;
		size = new Size(753, 230);
		((Control)msfExpParms_4).Size = size;
		((Control)_msfExpParms_1).TabIndex = 27;
		((Control)lblIExpModel).BackColor = SystemColors.Control;
		((Control)lblIExpModel).Cursor = Cursors.Default;
		((Control)lblIExpModel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblIExpModel).ForeColor = SystemColors.ControlText;
		Label obj91 = lblIExpModel;
		location = new Point(8, 40);
		((Control)obj91).Location = location;
		((Control)lblIExpModel).Name = "lblIExpModel";
		((Control)lblIExpModel).RightToLeft = (RightToLeft)0;
		Label obj92 = lblIExpModel;
		size = new Size(721, 17);
		((Control)obj92).Size = size;
		((Control)lblIExpModel).TabIndex = 316;
		lblIExpModel.Text = "n/a";
		((Control)_lblChemStateExp_1).BackColor = SystemColors.Control;
		((Control)_lblChemStateExp_1).Cursor = Cursors.Default;
		((Control)_lblChemStateExp_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblChemStateExp_1).ForeColor = SystemColors.ControlText;
		lblChemStateExp.SetIndex(_lblChemStateExp_1, (short)1);
		Label lblChemStateExp_3 = _lblChemStateExp_1;
		location = new Point(159, 16);
		((Control)lblChemStateExp_3).Location = location;
		((Control)_lblChemStateExp_1).Name = "_lblChemStateExp_1";
		((Control)_lblChemStateExp_1).RightToLeft = (RightToLeft)0;
		Label lblChemStateExp_4 = _lblChemStateExp_1;
		size = new Size(65, 17);
		((Control)lblChemStateExp_4).Size = size;
		((Control)_lblChemStateExp_1).TabIndex = 315;
		_lblChemStateExp_1.Text = "n/a";
		((Control)_Label3_2).BackColor = SystemColors.Control;
		((Control)_Label3_2).Cursor = Cursors.Default;
		((Control)_Label3_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label3_2).ForeColor = SystemColors.ControlText;
		Label3.SetIndex(_Label3_2, (short)2);
		Label label3_3 = _Label3_2;
		location = new Point(8, 16);
		((Control)label3_3).Location = location;
		((Control)_Label3_2).Name = "_Label3_2";
		((Control)_Label3_2).RightToLeft = (RightToLeft)0;
		Label label3_4 = _Label3_2;
		size = new Size(129, 16);
		((Control)label3_4).Size = size;
		((Control)_Label3_2).TabIndex = 314;
		_Label3_2.Text = "Chemical State:";
		((Control)_fraExpTab_3).BackColor = SystemColors.Control;
		((Control)_fraExpTab_3).Controls.Add((Control)(object)msfExpEst);
		((Control)_fraExpTab_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraExpTab_3).ForeColor = SystemColors.ControlText;
		fraExpTab.SetIndex(_fraExpTab_3, (short)3);
		GroupBox fraExpTab_7 = _fraExpTab_3;
		location = new Point(11, 208);
		((Control)fraExpTab_7).Location = location;
		((Control)_fraExpTab_3).Name = "_fraExpTab_3";
		((Control)_fraExpTab_3).RightToLeft = (RightToLeft)0;
		GroupBox fraExpTab_8 = _fraExpTab_3;
		size = new Size(766, 293);
		((Control)fraExpTab_8).Size = size;
		((Control)_fraExpTab_3).TabIndex = 203;
		_fraExpTab_3.TabStop = false;
		((Control)_fraExpTab_3).Visible = false;
		AxMSFlexGrid obj93 = msfExpEst;
		location = new Point(8, 16);
		((Control)obj93).Location = location;
		((Control)msfExpEst).Name = "msfExpEst";
		((AxHost)msfExpEst).OcxState = (State)componentResourceManager.GetObject("msfExpEst.OcxState");
		AxMSFlexGrid obj94 = msfExpEst;
		size = new Size(753, 270);
		((Control)obj94).Size = size;
		((Control)msfExpEst).TabIndex = 353;
		((ButtonBase)cmdDermal).BackColor = Color.DimGray;
		((Control)cmdDermal).Cursor = Cursors.Default;
		((Control)cmdDermal).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdDermal).ForeColor = Color.White;
		Button obj95 = cmdDermal;
		location = new Point(15, 130);
		((Control)obj95).Location = location;
		((Control)cmdDermal).Name = "cmdDermal";
		((Control)cmdDermal).RightToLeft = (RightToLeft)0;
		Button obj96 = cmdDermal;
		size = new Size(170, 32);
		((Control)obj96).Size = size;
		((Control)cmdDermal).TabIndex = 385;
		((ButtonBase)cmdDermal).Text = "6a. &Dermal Model Params";
		((ButtonBase)cmdDermal).UseVisualStyleBackColor = false;
		Label6.AutoSize = true;
		Label label19 = Label6;
		location = new Point(23, 524);
		((Control)label19).Location = location;
		((Control)Label6).Name = "Label6";
		Label label20 = Label6;
		size = new Size(141, 14);
		((Control)label20).Size = size;
		((Control)Label6).TabIndex = 389;
		Label6.Text = "Exposure Model Actions";
		((ButtonBase)cmdRespirator).BackColor = SystemColors.Control;
		((Control)cmdRespirator).Cursor = Cursors.Default;
		((Control)cmdRespirator).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdRespirator).ForeColor = SystemColors.ControlText;
		Button obj97 = cmdRespirator;
		location = new Point(381, 130);
		((Control)obj97).Location = location;
		((Control)cmdRespirator).Name = "cmdRespirator";
		((Control)cmdRespirator).RightToLeft = (RightToLeft)0;
		Button obj98 = cmdRespirator;
		size = new Size(208, 32);
		((Control)obj98).Size = size;
		((Control)cmdRespirator).TabIndex = 387;
		((ButtonBase)cmdRespirator).Text = "6c. &Resp Class && Monitor Review";
		((ButtonBase)cmdRespirator).UseVisualStyleBackColor = false;
		((ButtonBase)cmdInhalation).BackColor = SystemColors.Control;
		((Control)cmdInhalation).Cursor = Cursors.Default;
		((Control)cmdInhalation).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdInhalation).ForeColor = SystemColors.ControlText;
		Button obj99 = cmdInhalation;
		location = new Point(185, 130);
		((Control)obj99).Location = location;
		((Control)cmdInhalation).Name = "cmdInhalation";
		((Control)cmdInhalation).RightToLeft = (RightToLeft)0;
		Button obj100 = cmdInhalation;
		size = new Size(196, 32);
		((Control)obj100).Size = size;
		((Control)cmdInhalation).TabIndex = 386;
		((ButtonBase)cmdInhalation).Text = "6b. &Inhalation Model Params";
		((ButtonBase)cmdInhalation).UseVisualStyleBackColor = false;
		((ButtonBase)cmdActivity).BackColor = SystemColors.Control;
		((Control)cmdActivity).Cursor = Cursors.Default;
		((Control)cmdActivity).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdActivity).ForeColor = SystemColors.ControlText;
		Button obj101 = cmdActivity;
		location = new Point(589, 130);
		((Control)obj101).Location = location;
		((Control)cmdActivity).Name = "cmdActivity";
		((Control)cmdActivity).RightToLeft = (RightToLeft)0;
		Button obj102 = cmdActivity;
		size = new Size(186, 32);
		((Control)obj102).Size = size;
		((Control)cmdActivity).TabIndex = 388;
		((ButtonBase)cmdActivity).Text = "6d. &Activity Exposure Est";
		((ButtonBase)cmdActivity).UseVisualStyleBackColor = false;
		cmbExpActs.BackColor = SystemColors.Window;
		((Control)cmbExpActs).Cursor = Cursors.Default;
		cmbExpActs.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbExpActs).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbExpActs.ForeColor = SystemColors.WindowText;
		ComboBox obj103 = cmbExpActs;
		location = new Point(77, 93);
		((Control)obj103).Location = location;
		((Control)cmbExpActs).Name = "cmbExpActs";
		((Control)cmbExpActs).RightToLeft = (RightToLeft)0;
		ComboBox obj104 = cmbExpActs;
		size = new Size(372, 22);
		((Control)obj104).Size = size;
		cmbExpActs.Sorted = true;
		((Control)cmbExpActs).TabIndex = 376;
		((ButtonBase)cmdUpdateExpNw).BackColor = SystemColors.Control;
		((Control)cmdUpdateExpNw).Cursor = Cursors.Default;
		((Control)cmdUpdateExpNw).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdateExpNw).ForeColor = SystemColors.ControlText;
		Button obj105 = cmdUpdateExpNw;
		location = new Point(566, 549);
		((Control)obj105).Location = location;
		((Control)cmdUpdateExpNw).Name = "cmdUpdateExpNw";
		((Control)cmdUpdateExpNw).RightToLeft = (RightToLeft)0;
		Button obj106 = cmdUpdateExpNw;
		size = new Size(153, 37);
		((Control)obj106).Size = size;
		((Control)cmdUpdateExpNw).TabIndex = 13;
		((ButtonBase)cmdUpdateExpNw).Text = "&Update Operation Total Number of Workers Exposed";
		((ButtonBase)cmdUpdateExpNw).UseVisualStyleBackColor = false;
		((ButtonBase)cmdInhBasis).BackColor = SystemColors.Control;
		((Control)cmdInhBasis).Cursor = Cursors.Default;
		((Control)cmdInhBasis).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdInhBasis).ForeColor = SystemColors.ControlText;
		Button obj107 = cmdInhBasis;
		location = new Point(294, 549);
		((Control)obj107).Location = location;
		((Control)cmdInhBasis).Name = "cmdInhBasis";
		((Control)cmdInhBasis).RightToLeft = (RightToLeft)0;
		Button obj108 = cmdInhBasis;
		size = new Size(129, 37);
		((Control)obj108).Size = size;
		((Control)cmdInhBasis).TabIndex = 11;
		((ButtonBase)cmdInhBasis).Text = "Introductory &Notes for the Dermal Summary";
		((ButtonBase)cmdInhBasis).UseVisualStyleBackColor = false;
		cmbExpOps.BackColor = SystemColors.Window;
		((Control)cmbExpOps).Cursor = Cursors.Default;
		cmbExpOps.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbExpOps).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbExpOps.ForeColor = SystemColors.WindowText;
		ComboBox obj109 = cmbExpOps;
		location = new Point(77, 65);
		((Control)obj109).Location = location;
		((Control)cmbExpOps).Name = "cmbExpOps";
		((Control)cmbExpOps).RightToLeft = (RightToLeft)0;
		ComboBox obj110 = cmbExpOps;
		size = new Size(345, 22);
		((Control)obj110).Size = size;
		((Control)cmbExpOps).TabIndex = 25;
		((ButtonBase)cmdRunExpModel).BackColor = SystemColors.Control;
		((Control)cmdRunExpModel).Cursor = Cursors.Default;
		((Control)cmdRunExpModel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdRunExpModel).ForeColor = SystemColors.ControlText;
		Button obj111 = cmdRunExpModel;
		location = new Point(430, 549);
		((Control)obj111).Location = location;
		((Control)cmdRunExpModel).Name = "cmdRunExpModel";
		((Control)cmdRunExpModel).RightToLeft = (RightToLeft)0;
		Button obj112 = cmdRunExpModel;
		size = new Size(129, 37);
		((Control)obj112).Size = size;
		((Control)cmdRunExpModel).TabIndex = 12;
		((ButtonBase)cmdRunExpModel).Text = "&Run Model(s)";
		((ButtonBase)cmdRunExpModel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdAddExpModel).BackColor = SystemColors.Control;
		((Control)cmdAddExpModel).Cursor = Cursors.Default;
		((Control)cmdAddExpModel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdAddExpModel).ForeColor = SystemColors.ControlText;
		Button obj113 = cmdAddExpModel;
		location = new Point(22, 549);
		((Control)obj113).Location = location;
		((Control)cmdAddExpModel).Name = "cmdAddExpModel";
		((Control)cmdAddExpModel).RightToLeft = (RightToLeft)0;
		Button obj114 = cmdAddExpModel;
		size = new Size(129, 37);
		((Control)obj114).Size = size;
		((Control)cmdAddExpModel).TabIndex = 9;
		((ButtonBase)cmdAddExpModel).Text = "&Add or Remove an Exposure model";
		((ButtonBase)cmdAddExpModel).UseVisualStyleBackColor = false;
		((ButtonBase)cmdViewExpModel).BackColor = SystemColors.Control;
		((Control)cmdViewExpModel).Cursor = Cursors.Default;
		((Control)cmdViewExpModel).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdViewExpModel).ForeColor = SystemColors.ControlText;
		Button obj115 = cmdViewExpModel;
		location = new Point(158, 549);
		((Control)obj115).Location = location;
		((Control)cmdViewExpModel).Name = "cmdViewExpModel";
		((Control)cmdViewExpModel).RightToLeft = (RightToLeft)0;
		Button obj116 = cmdViewExpModel;
		size = new Size(129, 37);
		((Control)obj116).Size = size;
		((Control)cmdViewExpModel).TabIndex = 10;
		((ButtonBase)cmdViewExpModel).Text = "View/Update Dermal Model &Information";
		((ButtonBase)cmdViewExpModel).UseVisualStyleBackColor = false;
		((Control)_Label1_74).BackColor = SystemColors.Control;
		((Control)_Label1_74).Cursor = Cursors.Default;
		((Control)_Label1_74).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_74).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_74, (short)74);
		Label label1_21 = _Label1_74;
		location = new Point(77, 93);
		((Control)label1_21).Location = location;
		((Control)_Label1_74).Name = "_Label1_74";
		((Control)_Label1_74).RightToLeft = (RightToLeft)0;
		Label label1_22 = _Label1_74;
		size = new Size(321, 17);
		((Control)label1_22).Size = size;
		((Control)_Label1_74).TabIndex = 245;
		_Label1_74.Text = "No exposure sources";
		((Control)_Label1_74).Visible = false;
		((Control)_Label1_73).BackColor = SystemColors.Control;
		((Control)_Label1_73).Cursor = Cursors.Default;
		((Control)_Label1_73).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_73).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_73, (short)73);
		Label label1_23 = _Label1_73;
		location = new Point(16, 93);
		((Control)label1_23).Location = location;
		((Control)_Label1_73).Name = "_Label1_73";
		((Control)_Label1_73).RightToLeft = (RightToLeft)0;
		Label label1_24 = _Label1_73;
		size = new Size(49, 17);
		((Control)label1_24).Size = size;
		((Control)_Label1_73).TabIndex = 244;
		_Label1_73.Text = "Source:";
		((Control)_Label1_72).BackColor = SystemColors.Control;
		((Control)_Label1_72).Cursor = Cursors.Default;
		((Control)_Label1_72).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_72).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_72, (short)72);
		Label label1_25 = _Label1_72;
		location = new Point(16, 65);
		((Control)label1_25).Location = location;
		((Control)_Label1_72).Name = "_Label1_72";
		((Control)_Label1_72).RightToLeft = (RightToLeft)0;
		Label label1_26 = _Label1_72;
		size = new Size(64, 19);
		((Control)label1_26).Size = size;
		((Control)_Label1_72).TabIndex = 243;
		_Label1_72.Text = "Operation:";
		((Control)lblExpSubtab).BackColor = SystemColors.Control;
		((Control)lblExpSubtab).Cursor = Cursors.Default;
		((Control)lblExpSubtab).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblExpSubtab).ForeColor = SystemColors.ControlText;
		Label3.SetIndex(lblExpSubtab, (short)5);
		Label obj117 = lblExpSubtab;
		location = new Point(17, 171);
		((Control)obj117).Location = location;
		((Control)lblExpSubtab).Name = "lblExpSubtab";
		((Control)lblExpSubtab).RightToLeft = (RightToLeft)0;
		Label obj118 = lblExpSubtab;
		size = new Size(761, 38);
		((Control)obj118).Size = size;
		((Control)lblExpSubtab).TabIndex = 211;
		lblExpSubtab.Text = componentResourceManager.GetString("lblExpSubtab.Text");
		AxTabStrip obj119 = tabExp;
		location = new Point(56, 208);
		((Control)obj119).Location = location;
		((Control)tabExp).Name = "tabExp";
		((AxHost)tabExp).OcxState = (State)componentResourceManager.GetObject("tabExp.OcxState");
		AxTabStrip obj120 = tabExp;
		size = new Size(685, 187);
		((Control)obj120).Size = size;
		((Control)tabExp).TabIndex = 26;
		((ButtonBase)cmdExpComb).BackColor = SystemColors.InactiveCaption;
		((Control)cmdExpComb).Cursor = Cursors.Default;
		((Control)cmdExpComb).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdExpComb).ForeColor = SystemColors.ControlText;
		Button obj121 = cmdExpComb;
		location = new Point(850, 605);
		((Control)obj121).Location = location;
		((Control)cmdExpComb).Name = "cmdExpComb";
		((Control)cmdExpComb).RightToLeft = (RightToLeft)0;
		Button obj122 = cmdExpComb;
		size = new Size(129, 21);
		((Control)obj122).Size = size;
		((Control)cmdExpComb).TabIndex = 29;
		((ButtonBase)cmdExpComb).Text = "View/Update &Combinations";
		((ButtonBase)cmdExpComb).UseVisualStyleBackColor = false;
		((Control)cmdExpComb).Visible = false;
		((Control)_fraTab_6).BackColor = SystemColors.Control;
		((Control)_fraTab_6).Controls.Add((Control)(object)Label20);
		((Control)_fraTab_6).Controls.Add((Control)(object)_fraOpInfo_0);
		((Control)_fraTab_6).Controls.Add((Control)(object)_fraOpInfo_2);
		((Control)_fraTab_6).Controls.Add((Control)(object)cmdUpdOptInfo);
		((Control)_fraTab_6).Controls.Add((Control)(object)_fraOpInfo_1);
		((Control)_fraTab_6).Controls.Add((Control)(object)cmbOptInfo);
		((Control)_fraTab_6).Controls.Add((Control)(object)_Label1_50);
		((Control)_fraTab_6).Controls.Add((Control)(object)_fraOpInfo_5);
		((Control)_fraTab_6).Controls.Add((Control)(object)_fraOpInfo_3);
		((Control)_fraTab_6).Controls.Add((Control)(object)_fraOpInfo_6);
		((Control)_fraTab_6).Controls.Add((Control)(object)_fraOpInfo_4);
		((Control)_fraTab_6).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraTab_6).ForeColor = SystemColors.ControlText;
		fraTab.SetIndex(_fraTab_6, (short)6);
		GroupBox fraTab_7 = _fraTab_6;
		location = new Point(124, 15);
		((Control)fraTab_7).Location = location;
		((Control)_fraTab_6).Name = "_fraTab_6";
		((Control)_fraTab_6).RightToLeft = (RightToLeft)0;
		GroupBox fraTab_8 = _fraTab_6;
		size = new Size(785, 605);
		((Control)fraTab_8).Size = size;
		((Control)_fraTab_6).TabIndex = 78;
		_fraTab_6.TabStop = false;
		_fraTab_6.Text = "7. Optional Information";
		((Control)_fraTab_6).Visible = false;
		Label20.AutoSize = true;
		Label label21 = Label20;
		location = new Point(23, 524);
		((Control)label21).Location = location;
		((Control)Label20).Name = "Label20";
		Label label22 = Label20;
		size = new Size(164, 14);
		((Control)label22).Size = size;
		((Control)Label20).TabIndex = 391;
		Label20.Text = "Optional Information Actions";
		((Control)_fraOpInfo_0).BackColor = SystemColors.Control;
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)txtSatAddPBTinfo);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)txtSatRelatedCases);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Line2_3);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatEReq_8);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatHReq_8);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)lblCC);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Line2_1);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_95);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatEReq_7);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatEReq_5);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_94);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatHReq_5);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatHReq_7);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)lblSATdate);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_92);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_91);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_60);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_90);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)lblSatM2GOther);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatEReq_6);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_66);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatEReq_4);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_65);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatEReq_2);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_64);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatEReq_1);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_63);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatEReq_0);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatHReq_6);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatHReq_4);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_62);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatHReq_3);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_61);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatEReq_3);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatHReq_2);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_59);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatHReq_1);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_58);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_lblSatHReq_0);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_99);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_57);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_53);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)lblSATER);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)lblSatM2G);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)lblSatTR);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)lblSatPR);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)lblSatBR);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)lblSATHR);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_35);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_34);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_33);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Line2_2);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_31);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Label1_21);
		((Control)_fraOpInfo_0).Controls.Add((Control)(object)_Line2_0);
		((Control)_fraOpInfo_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraOpInfo_0).ForeColor = SystemColors.ControlText;
		fraOpInfo.SetIndex(_fraOpInfo_0, (short)0);
		GroupBox fraOpInfo_ = _fraOpInfo_0;
		location = new Point(17, 81);
		((Control)fraOpInfo_).Location = location;
		((Control)_fraOpInfo_0).Name = "_fraOpInfo_0";
		((Control)_fraOpInfo_0).RightToLeft = (RightToLeft)0;
		GroupBox fraOpInfo_2 = _fraOpInfo_0;
		size = new Size(721, 409);
		((Control)fraOpInfo_2).Size = size;
		((Control)_fraOpInfo_0).TabIndex = 110;
		_fraOpInfo_0.TabStop = false;
		txtSatAddPBTinfo.AcceptsReturn = true;
		((TextBoxBase)txtSatAddPBTinfo).BackColor = SystemColors.Control;
		((Control)txtSatAddPBTinfo).Cursor = Cursors.IBeam;
		((Control)txtSatAddPBTinfo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtSatAddPBTinfo).ForeColor = SystemColors.WindowText;
		TextBox obj123 = txtSatAddPBTinfo;
		location = new Point(368, 56);
		((Control)obj123).Location = location;
		((TextBoxBase)txtSatAddPBTinfo).MaxLength = 0;
		txtSatAddPBTinfo.Multiline = true;
		((Control)txtSatAddPBTinfo).Name = "txtSatAddPBTinfo";
		((TextBoxBase)txtSatAddPBTinfo).ReadOnly = true;
		((Control)txtSatAddPBTinfo).RightToLeft = (RightToLeft)0;
		txtSatAddPBTinfo.ScrollBars = (ScrollBars)2;
		TextBox obj124 = txtSatAddPBTinfo;
		size = new Size(321, 49);
		((Control)obj124).Size = size;
		((Control)txtSatAddPBTinfo).TabIndex = 307;
		txtSatRelatedCases.AcceptsReturn = true;
		((TextBoxBase)txtSatRelatedCases).BackColor = SystemColors.Control;
		((Control)txtSatRelatedCases).Cursor = Cursors.IBeam;
		((Control)txtSatRelatedCases).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtSatRelatedCases).ForeColor = SystemColors.WindowText;
		TextBox obj125 = txtSatRelatedCases;
		location = new Point(24, 56);
		((Control)obj125).Location = location;
		((TextBoxBase)txtSatRelatedCases).MaxLength = 0;
		txtSatRelatedCases.Multiline = true;
		((Control)txtSatRelatedCases).Name = "txtSatRelatedCases";
		((TextBoxBase)txtSatRelatedCases).ReadOnly = true;
		((Control)txtSatRelatedCases).RightToLeft = (RightToLeft)0;
		txtSatRelatedCases.ScrollBars = (ScrollBars)2;
		TextBox obj126 = txtSatRelatedCases;
		size = new Size(321, 49);
		((Control)obj126).Size = size;
		((Control)txtSatRelatedCases).TabIndex = 306;
		((Control)_Line2_3).BackColor = SystemColors.WindowText;
		Line2.SetIndex(_Line2_3, (short)3);
		Label line2_ = _Line2_3;
		location = new Point(360, 120);
		((Control)line2_).Location = location;
		((Control)_Line2_3).Name = "_Line2_3";
		Label line2_2 = _Line2_3;
		size = new Size(1, 240);
		((Control)line2_2).Size = size;
		((Control)_Line2_3).TabIndex = 308;
		((Control)_lblSatEReq_8).BackColor = SystemColors.Control;
		_lblSatEReq_8.BorderStyle = (BorderStyle)2;
		((Control)_lblSatEReq_8).Cursor = Cursors.Default;
		((Control)_lblSatEReq_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatEReq_8).ForeColor = SystemColors.ControlText;
		lblSatEReq.SetIndex(_lblSatEReq_8, (short)8);
		Label lblSatEReq_ = _lblSatEReq_8;
		location = new Point(504, 272);
		((Control)lblSatEReq_).Location = location;
		((Control)_lblSatEReq_8).Name = "_lblSatEReq_8";
		((Control)_lblSatEReq_8).RightToLeft = (RightToLeft)0;
		Label lblSatEReq_2 = _lblSatEReq_8;
		size = new Size(33, 19);
		((Control)lblSatEReq_2).Size = size;
		((Control)_lblSatEReq_8).TabIndex = 370;
		((Control)_lblSatHReq_8).BackColor = SystemColors.Control;
		_lblSatHReq_8.BorderStyle = (BorderStyle)2;
		((Control)_lblSatHReq_8).Cursor = Cursors.Default;
		((Control)_lblSatHReq_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatHReq_8).ForeColor = SystemColors.ControlText;
		lblSatHReq.SetIndex(_lblSatHReq_8, (short)8);
		Label lblSatHReq_ = _lblSatHReq_8;
		location = new Point(144, 272);
		((Control)lblSatHReq_).Location = location;
		((Control)_lblSatHReq_8).Name = "_lblSatHReq_8";
		((Control)_lblSatHReq_8).RightToLeft = (RightToLeft)0;
		Label lblSatHReq_2 = _lblSatHReq_8;
		size = new Size(33, 19);
		((Control)lblSatHReq_2).Size = size;
		((Control)_lblSatHReq_8).TabIndex = 369;
		((Control)lblCC).BackColor = SystemColors.Control;
		lblCC.BorderStyle = (BorderStyle)2;
		((Control)lblCC).Cursor = Cursors.Default;
		((Control)lblCC).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCC).ForeColor = SystemColors.ControlText;
		Label obj127 = lblCC;
		location = new Point(505, 152);
		((Control)obj127).Location = location;
		((Control)lblCC).Name = "lblCC";
		((Control)lblCC).RightToLeft = (RightToLeft)0;
		Label obj128 = lblCC;
		size = new Size(198, 43);
		((Control)obj128).Size = size;
		((Control)lblCC).TabIndex = 337;
		((Control)_Line2_1).BackColor = SystemColors.WindowText;
		Line2.SetIndex(_Line2_1, (short)1);
		Label line2_3 = _Line2_1;
		location = new Point(24, 360);
		((Control)line2_3).Location = location;
		((Control)_Line2_1).Name = "_Line2_1";
		Label line2_4 = _Line2_1;
		size = new Size(664, 1);
		((Control)line2_4).Size = size;
		((Control)_Line2_1).TabIndex = 371;
		((Control)_Label1_95).BackColor = SystemColors.Control;
		((Control)_Label1_95).Cursor = Cursors.Default;
		((Control)_Label1_95).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_95).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_95, (short)95);
		Label label1_27 = _Label1_95;
		location = new Point(368, 272);
		((Control)label1_27).Location = location;
		((Control)_Label1_95).Name = "_Label1_95";
		((Control)_Label1_95).RightToLeft = (RightToLeft)0;
		Label label1_28 = _Label1_95;
		size = new Size(89, 17);
		((Control)label1_28).Size = size;
		((Control)_Label1_95).TabIndex = 336;
		_Label1_95.Text = "XB testing:";
		_Label1_95.TextAlign = (ContentAlignment)4;
		((Control)_lblSatEReq_7).BackColor = SystemColors.Control;
		_lblSatEReq_7.BorderStyle = (BorderStyle)2;
		((Control)_lblSatEReq_7).Cursor = Cursors.Default;
		((Control)_lblSatEReq_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatEReq_7).ForeColor = SystemColors.ControlText;
		lblSatEReq.SetIndex(_lblSatEReq_7, (short)7);
		Label lblSatEReq_3 = _lblSatEReq_7;
		location = new Point(544, 272);
		((Control)lblSatEReq_3).Location = location;
		((Control)_lblSatEReq_7).Name = "_lblSatEReq_7";
		((Control)_lblSatEReq_7).RightToLeft = (RightToLeft)0;
		Label lblSatEReq_4 = _lblSatEReq_7;
		size = new Size(161, 19);
		((Control)lblSatEReq_4).Size = size;
		((Control)_lblSatEReq_7).TabIndex = 335;
		((Control)_lblSatEReq_5).BackColor = SystemColors.Control;
		_lblSatEReq_5.BorderStyle = (BorderStyle)2;
		((Control)_lblSatEReq_5).Cursor = Cursors.Default;
		((Control)_lblSatEReq_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatEReq_5).ForeColor = SystemColors.ControlText;
		lblSatEReq.SetIndex(_lblSatEReq_5, (short)5);
		Label lblSatEReq_5 = _lblSatEReq_5;
		location = new Point(464, 272);
		((Control)lblSatEReq_5).Location = location;
		((Control)_lblSatEReq_5).Name = "_lblSatEReq_5";
		((Control)_lblSatEReq_5).RightToLeft = (RightToLeft)0;
		Label lblSatEReq_6 = _lblSatEReq_5;
		size = new Size(33, 19);
		((Control)lblSatEReq_6).Size = size;
		((Control)_lblSatEReq_5).TabIndex = 334;
		((Control)_Label1_94).BackColor = SystemColors.Control;
		((Control)_Label1_94).Cursor = Cursors.Default;
		((Control)_Label1_94).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_94).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_94, (short)94);
		Label label1_29 = _Label1_94;
		location = new Point(8, 272);
		((Control)label1_29).Location = location;
		((Control)_Label1_94).Name = "_Label1_94";
		((Control)_Label1_94).RightToLeft = (RightToLeft)0;
		Label label1_30 = _Label1_94;
		size = new Size(89, 17);
		((Control)label1_30).Size = size;
		((Control)_Label1_94).TabIndex = 333;
		_Label1_94.Text = "XB testing:";
		_Label1_94.TextAlign = (ContentAlignment)4;
		((Control)_lblSatHReq_5).BackColor = SystemColors.Control;
		_lblSatHReq_5.BorderStyle = (BorderStyle)2;
		((Control)_lblSatHReq_5).Cursor = Cursors.Default;
		((Control)_lblSatHReq_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatHReq_5).ForeColor = SystemColors.ControlText;
		lblSatHReq.SetIndex(_lblSatHReq_5, (short)5);
		Label lblSatHReq_3 = _lblSatHReq_5;
		location = new Point(104, 272);
		((Control)lblSatHReq_3).Location = location;
		((Control)_lblSatHReq_5).Name = "_lblSatHReq_5";
		((Control)_lblSatHReq_5).RightToLeft = (RightToLeft)0;
		Label lblSatHReq_4 = _lblSatHReq_5;
		size = new Size(33, 19);
		((Control)lblSatHReq_4).Size = size;
		((Control)_lblSatHReq_5).TabIndex = 332;
		((Control)_lblSatHReq_7).BackColor = SystemColors.Control;
		_lblSatHReq_7.BorderStyle = (BorderStyle)2;
		((Control)_lblSatHReq_7).Cursor = Cursors.Default;
		((Control)_lblSatHReq_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatHReq_7).ForeColor = SystemColors.ControlText;
		lblSatHReq.SetIndex(_lblSatHReq_7, (short)7);
		Label lblSatHReq_5 = _lblSatHReq_7;
		location = new Point(184, 272);
		((Control)lblSatHReq_5).Location = location;
		((Control)_lblSatHReq_7).Name = "_lblSatHReq_7";
		((Control)_lblSatHReq_7).RightToLeft = (RightToLeft)0;
		Label lblSatHReq_6 = _lblSatHReq_7;
		size = new Size(161, 19);
		((Control)lblSatHReq_6).Size = size;
		((Control)_lblSatHReq_7).TabIndex = 331;
		((Control)lblSATdate).BackColor = SystemColors.Control;
		lblSATdate.BorderStyle = (BorderStyle)2;
		((Control)lblSATdate).Cursor = Cursors.Default;
		((Control)lblSATdate).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSATdate).ForeColor = SystemColors.ControlText;
		Label obj129 = lblSATdate;
		location = new Point(280, 16);
		((Control)obj129).Location = location;
		((Control)lblSATdate).Name = "lblSATdate";
		((Control)lblSATdate).RightToLeft = (RightToLeft)0;
		Label obj130 = lblSATdate;
		size = new Size(73, 19);
		((Control)obj130).Size = size;
		((Control)lblSATdate).TabIndex = 308;
		((Control)_Label1_92).BackColor = SystemColors.Control;
		((Control)_Label1_92).Cursor = Cursors.Default;
		((Control)_Label1_92).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_92).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_92, (short)92);
		Label label1_31 = _Label1_92;
		location = new Point(368, 40);
		((Control)label1_31).Location = location;
		((Control)_Label1_92).Name = "_Label1_92";
		((Control)_Label1_92).RightToLeft = (RightToLeft)0;
		Label label1_32 = _Label1_92;
		size = new Size(176, 17);
		((Control)label1_32).Size = size;
		((Control)_Label1_92).TabIndex = 305;
		_Label1_92.Text = "Additional PBT Information:";
		((Control)_Label1_91).BackColor = SystemColors.Control;
		((Control)_Label1_91).Cursor = Cursors.Default;
		((Control)_Label1_91).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_91).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_91, (short)91);
		Label label1_33 = _Label1_91;
		location = new Point(24, 40);
		((Control)label1_33).Location = location;
		((Control)_Label1_91).Name = "_Label1_91";
		((Control)_Label1_91).RightToLeft = (RightToLeft)0;
		Label label1_34 = _Label1_91;
		size = new Size(306, 17);
		((Control)label1_34).Size = size;
		((Control)_Label1_91).TabIndex = 304;
		_Label1_91.Text = "Related Cases and Miscellaneous SAT Information:";
		((Control)_Label1_60).BackColor = SystemColors.Control;
		((Control)_Label1_60).Cursor = Cursors.Default;
		((Control)_Label1_60).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_60).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_60, (short)60);
		Label label1_35 = _Label1_60;
		location = new Point(184, 16);
		((Control)label1_35).Location = location;
		((Control)_Label1_60).Name = "_Label1_60";
		((Control)_Label1_60).RightToLeft = (RightToLeft)0;
		Label label1_36 = _Label1_60;
		size = new Size(81, 17);
		((Control)label1_36).Size = size;
		((Control)_Label1_60).TabIndex = 303;
		_Label1_60.Text = "SAT Date:";
		_Label1_60.TextAlign = (ContentAlignment)4;
		((Control)_Label1_90).BackColor = SystemColors.Control;
		((Control)_Label1_90).Cursor = Cursors.Default;
		((Control)_Label1_90).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_90).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_90, (short)90);
		Label label1_37 = _Label1_90;
		location = new Point(376, 224);
		((Control)label1_37).Location = location;
		((Control)_Label1_90).Name = "_Label1_90";
		((Control)_Label1_90).RightToLeft = (RightToLeft)0;
		Label label1_38 = _Label1_90;
		size = new Size(81, 17);
		((Control)label1_38).Size = size;
		((Control)_Label1_90).TabIndex = 302;
		_Label1_90.Text = "Not Required:";
		_Label1_90.TextAlign = (ContentAlignment)4;
		((Control)lblSatM2GOther).BackColor = SystemColors.Control;
		lblSatM2GOther.BorderStyle = (BorderStyle)2;
		((Control)lblSatM2GOther).Cursor = Cursors.Default;
		((Control)lblSatM2GOther).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSatM2GOther).ForeColor = SystemColors.ControlText;
		Label obj131 = lblSatM2GOther;
		location = new Point(88, 336);
		((Control)obj131).Location = location;
		((Control)lblSatM2GOther).Name = "lblSatM2GOther";
		((Control)lblSatM2GOther).RightToLeft = (RightToLeft)0;
		Label obj132 = lblSatM2GOther;
		size = new Size(263, 19);
		((Control)obj132).Size = size;
		((Control)lblSatM2GOther).TabIndex = 240;
		((Control)_lblSatEReq_6).BackColor = SystemColors.Control;
		_lblSatEReq_6.BorderStyle = (BorderStyle)2;
		((Control)_lblSatEReq_6).Cursor = Cursors.Default;
		((Control)_lblSatEReq_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatEReq_6).ForeColor = SystemColors.ControlText;
		lblSatEReq.SetIndex(_lblSatEReq_6, (short)6);
		Label lblSatEReq_7 = _lblSatEReq_6;
		location = new Point(504, 248);
		((Control)lblSatEReq_7).Location = location;
		((Control)_lblSatEReq_6).Name = "_lblSatEReq_6";
		((Control)_lblSatEReq_6).RightToLeft = (RightToLeft)0;
		Label lblSatEReq_8 = _lblSatEReq_6;
		size = new Size(201, 19);
		((Control)lblSatEReq_8).Size = size;
		((Control)_lblSatEReq_6).TabIndex = 239;
		((Control)_Label1_66).BackColor = SystemColors.Control;
		((Control)_Label1_66).Cursor = Cursors.Default;
		((Control)_Label1_66).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_66).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_66, (short)66);
		Label label1_39 = _Label1_66;
		location = new Point(368, 248);
		((Control)label1_39).Location = location;
		((Control)_Label1_66).Name = "_Label1_66";
		((Control)_Label1_66).RightToLeft = (RightToLeft)0;
		Label label1_40 = _Label1_66;
		size = new Size(89, 17);
		((Control)label1_40).Size = size;
		((Control)_Label1_66).TabIndex = 238;
		_Label1_66.Text = "Other:";
		_Label1_66.TextAlign = (ContentAlignment)4;
		((Control)_lblSatEReq_4).BackColor = SystemColors.Control;
		_lblSatEReq_4.BorderStyle = (BorderStyle)2;
		((Control)_lblSatEReq_4).Cursor = Cursors.Default;
		((Control)_lblSatEReq_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatEReq_4).ForeColor = SystemColors.ControlText;
		lblSatEReq.SetIndex(_lblSatEReq_4, (short)4);
		Label lblSatEReq_9 = _lblSatEReq_4;
		location = new Point(464, 248);
		((Control)lblSatEReq_9).Location = location;
		((Control)_lblSatEReq_4).Name = "_lblSatEReq_4";
		((Control)_lblSatEReq_4).RightToLeft = (RightToLeft)0;
		Label lblSatEReq_10 = _lblSatEReq_4;
		size = new Size(33, 19);
		((Control)lblSatEReq_10).Size = size;
		((Control)_lblSatEReq_4).TabIndex = 237;
		((Control)_Label1_65).BackColor = SystemColors.Control;
		((Control)_Label1_65).Cursor = Cursors.Default;
		((Control)_Label1_65).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_65).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_65, (short)65);
		Label label1_41 = _Label1_65;
		location = new Point(368, 200);
		((Control)label1_41).Location = location;
		((Control)_Label1_65).Name = "_Label1_65";
		((Control)_Label1_65).RightToLeft = (RightToLeft)0;
		Label label1_42 = _Label1_65;
		size = new Size(89, 17);
		((Control)label1_42).Size = size;
		((Control)_Label1_65).TabIndex = 236;
		_Label1_65.Text = "Land Releases:";
		_Label1_65.TextAlign = (ContentAlignment)4;
		((Control)_lblSatEReq_2).BackColor = SystemColors.Control;
		_lblSatEReq_2.BorderStyle = (BorderStyle)2;
		((Control)_lblSatEReq_2).Cursor = Cursors.Default;
		((Control)_lblSatEReq_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatEReq_2).ForeColor = SystemColors.ControlText;
		lblSatEReq.SetIndex(_lblSatEReq_2, (short)2);
		Label lblSatEReq_11 = _lblSatEReq_2;
		location = new Point(464, 200);
		((Control)lblSatEReq_11).Location = location;
		((Control)_lblSatEReq_2).Name = "_lblSatEReq_2";
		((Control)_lblSatEReq_2).RightToLeft = (RightToLeft)0;
		Label lblSatEReq_12 = _lblSatEReq_2;
		size = new Size(33, 19);
		((Control)lblSatEReq_12).Size = size;
		((Control)_lblSatEReq_2).TabIndex = 235;
		((Control)_Label1_64).BackColor = SystemColors.Control;
		((Control)_Label1_64).Cursor = Cursors.Default;
		((Control)_Label1_64).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_64).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_64, (short)64);
		Label label1_43 = _Label1_64;
		location = new Point(368, 176);
		((Control)label1_43).Location = location;
		((Control)_Label1_64).Name = "_Label1_64";
		((Control)_Label1_64).RightToLeft = (RightToLeft)0;
		Label label1_44 = _Label1_64;
		size = new Size(89, 17);
		((Control)label1_44).Size = size;
		((Control)_Label1_64).TabIndex = 234;
		_Label1_64.Text = "Air Releases:";
		_Label1_64.TextAlign = (ContentAlignment)4;
		((Control)_lblSatEReq_1).BackColor = SystemColors.Control;
		_lblSatEReq_1.BorderStyle = (BorderStyle)2;
		((Control)_lblSatEReq_1).Cursor = Cursors.Default;
		((Control)_lblSatEReq_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatEReq_1).ForeColor = SystemColors.ControlText;
		lblSatEReq.SetIndex(_lblSatEReq_1, (short)1);
		Label lblSatEReq_13 = _lblSatEReq_1;
		location = new Point(464, 176);
		((Control)lblSatEReq_13).Location = location;
		((Control)_lblSatEReq_1).Name = "_lblSatEReq_1";
		((Control)_lblSatEReq_1).RightToLeft = (RightToLeft)0;
		Label lblSatEReq_14 = _lblSatEReq_1;
		size = new Size(33, 19);
		((Control)lblSatEReq_14).Size = size;
		((Control)_lblSatEReq_1).TabIndex = 233;
		((Control)_Label1_63).BackColor = SystemColors.Control;
		((Control)_Label1_63).Cursor = Cursors.Default;
		((Control)_Label1_63).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_63).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_63, (short)63);
		Label label1_45 = _Label1_63;
		location = new Point(368, 152);
		((Control)label1_45).Location = location;
		((Control)_Label1_63).Name = "_Label1_63";
		((Control)_Label1_63).RightToLeft = (RightToLeft)0;
		Label label1_46 = _Label1_63;
		size = new Size(89, 17);
		((Control)label1_46).Size = size;
		((Control)_Label1_63).TabIndex = 232;
		_Label1_63.Text = "Water Releases:";
		_Label1_63.TextAlign = (ContentAlignment)4;
		((Control)_lblSatEReq_0).BackColor = SystemColors.Control;
		_lblSatEReq_0.BorderStyle = (BorderStyle)2;
		((Control)_lblSatEReq_0).Cursor = Cursors.Default;
		((Control)_lblSatEReq_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatEReq_0).ForeColor = SystemColors.ControlText;
		lblSatEReq.SetIndex(_lblSatEReq_0, (short)0);
		Label lblSatEReq_15 = _lblSatEReq_0;
		location = new Point(464, 152);
		((Control)lblSatEReq_15).Location = location;
		((Control)_lblSatEReq_0).Name = "_lblSatEReq_0";
		((Control)_lblSatEReq_0).RightToLeft = (RightToLeft)0;
		Label lblSatEReq_16 = _lblSatEReq_0;
		size = new Size(33, 19);
		((Control)lblSatEReq_16).Size = size;
		((Control)_lblSatEReq_0).TabIndex = 231;
		((Control)_lblSatHReq_6).BackColor = SystemColors.Control;
		_lblSatHReq_6.BorderStyle = (BorderStyle)2;
		((Control)_lblSatHReq_6).Cursor = Cursors.Default;
		((Control)_lblSatHReq_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatHReq_6).ForeColor = SystemColors.ControlText;
		lblSatHReq.SetIndex(_lblSatHReq_6, (short)6);
		Label lblSatHReq_7 = _lblSatHReq_6;
		location = new Point(144, 248);
		((Control)lblSatHReq_7).Location = location;
		((Control)_lblSatHReq_6).Name = "_lblSatHReq_6";
		((Control)_lblSatHReq_6).RightToLeft = (RightToLeft)0;
		Label lblSatHReq_8 = _lblSatHReq_6;
		size = new Size(201, 19);
		((Control)lblSatHReq_8).Size = size;
		((Control)_lblSatHReq_6).TabIndex = 230;
		((Control)_lblSatHReq_4).BackColor = SystemColors.Control;
		_lblSatHReq_4.BorderStyle = (BorderStyle)2;
		((Control)_lblSatHReq_4).Cursor = Cursors.Default;
		((Control)_lblSatHReq_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatHReq_4).ForeColor = SystemColors.ControlText;
		lblSatHReq.SetIndex(_lblSatHReq_4, (short)4);
		Label lblSatHReq_9 = _lblSatHReq_4;
		location = new Point(104, 248);
		((Control)lblSatHReq_9).Location = location;
		((Control)_lblSatHReq_4).Name = "_lblSatHReq_4";
		((Control)_lblSatHReq_4).RightToLeft = (RightToLeft)0;
		Label lblSatHReq_10 = _lblSatHReq_4;
		size = new Size(33, 19);
		((Control)lblSatHReq_10).Size = size;
		((Control)_lblSatHReq_4).TabIndex = 229;
		((Control)_Label1_62).BackColor = SystemColors.Control;
		((Control)_Label1_62).Cursor = Cursors.Default;
		((Control)_Label1_62).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_62).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_62, (short)62);
		Label label1_47 = _Label1_62;
		location = new Point(24, 248);
		((Control)label1_47).Location = location;
		((Control)_Label1_62).Name = "_Label1_62";
		((Control)_Label1_62).RightToLeft = (RightToLeft)0;
		Label label1_48 = _Label1_62;
		size = new Size(73, 17);
		((Control)label1_48).Size = size;
		((Control)_Label1_62).TabIndex = 228;
		_Label1_62.Text = "Other:";
		_Label1_62.TextAlign = (ContentAlignment)4;
		((Control)_lblSatHReq_3).BackColor = SystemColors.Control;
		_lblSatHReq_3.BorderStyle = (BorderStyle)2;
		((Control)_lblSatHReq_3).Cursor = Cursors.Default;
		((Control)_lblSatHReq_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatHReq_3).ForeColor = SystemColors.ControlText;
		lblSatHReq.SetIndex(_lblSatHReq_3, (short)3);
		Label lblSatHReq_11 = _lblSatHReq_3;
		location = new Point(104, 224);
		((Control)lblSatHReq_11).Location = location;
		((Control)_lblSatHReq_3).Name = "_lblSatHReq_3";
		((Control)_lblSatHReq_3).RightToLeft = (RightToLeft)0;
		Label lblSatHReq_12 = _lblSatHReq_3;
		size = new Size(33, 19);
		((Control)lblSatHReq_12).Size = size;
		((Control)_lblSatHReq_3).TabIndex = 227;
		((Control)_Label1_61).BackColor = SystemColors.Control;
		((Control)_Label1_61).Cursor = Cursors.Default;
		((Control)_Label1_61).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_61).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_61, (short)61);
		Label label1_49 = _Label1_61;
		location = new Point(16, 224);
		((Control)label1_49).Location = location;
		((Control)_Label1_61).Name = "_Label1_61";
		((Control)_Label1_61).RightToLeft = (RightToLeft)0;
		Label label1_50 = _Label1_61;
		size = new Size(81, 17);
		((Control)label1_50).Size = size;
		((Control)_Label1_61).TabIndex = 226;
		_Label1_61.Text = "Not Required:";
		_Label1_61.TextAlign = (ContentAlignment)4;
		((Control)_lblSatEReq_3).BackColor = SystemColors.Control;
		_lblSatEReq_3.BorderStyle = (BorderStyle)2;
		((Control)_lblSatEReq_3).Cursor = Cursors.Default;
		((Control)_lblSatEReq_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatEReq_3).ForeColor = SystemColors.ControlText;
		lblSatEReq.SetIndex(_lblSatEReq_3, (short)3);
		Label lblSatEReq_17 = _lblSatEReq_3;
		location = new Point(464, 224);
		((Control)lblSatEReq_17).Location = location;
		((Control)_lblSatEReq_3).Name = "_lblSatEReq_3";
		((Control)_lblSatEReq_3).RightToLeft = (RightToLeft)0;
		Label lblSatEReq_18 = _lblSatEReq_3;
		size = new Size(33, 19);
		((Control)lblSatEReq_18).Size = size;
		((Control)_lblSatEReq_3).TabIndex = 225;
		((Control)_lblSatHReq_2).BackColor = SystemColors.Control;
		_lblSatHReq_2.BorderStyle = (BorderStyle)2;
		((Control)_lblSatHReq_2).Cursor = Cursors.Default;
		((Control)_lblSatHReq_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatHReq_2).ForeColor = SystemColors.ControlText;
		lblSatHReq.SetIndex(_lblSatHReq_2, (short)2);
		Label lblSatHReq_13 = _lblSatHReq_2;
		location = new Point(104, 200);
		((Control)lblSatHReq_13).Location = location;
		((Control)_lblSatHReq_2).Name = "_lblSatHReq_2";
		((Control)_lblSatHReq_2).RightToLeft = (RightToLeft)0;
		Label lblSatHReq_14 = _lblSatHReq_2;
		size = new Size(33, 19);
		((Control)lblSatHReq_14).Size = size;
		((Control)_lblSatHReq_2).TabIndex = 224;
		((Control)_Label1_59).BackColor = SystemColors.Control;
		((Control)_Label1_59).Cursor = Cursors.Default;
		((Control)_Label1_59).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_59).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_59, (short)59);
		Label label1_51 = _Label1_59;
		location = new Point(16, 200);
		((Control)label1_51).Location = location;
		((Control)_Label1_59).Name = "_Label1_59";
		((Control)_Label1_59).RightToLeft = (RightToLeft)0;
		Label label1_52 = _Label1_59;
		size = new Size(81, 17);
		((Control)label1_52).Size = size;
		((Control)_Label1_59).TabIndex = 223;
		_Label1_59.Text = "Inhalation:";
		_Label1_59.TextAlign = (ContentAlignment)4;
		((Control)_lblSatHReq_1).BackColor = SystemColors.Control;
		_lblSatHReq_1.BorderStyle = (BorderStyle)2;
		((Control)_lblSatHReq_1).Cursor = Cursors.Default;
		((Control)_lblSatHReq_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatHReq_1).ForeColor = SystemColors.ControlText;
		lblSatHReq.SetIndex(_lblSatHReq_1, (short)1);
		Label lblSatHReq_15 = _lblSatHReq_1;
		location = new Point(104, 176);
		((Control)lblSatHReq_15).Location = location;
		((Control)_lblSatHReq_1).Name = "_lblSatHReq_1";
		((Control)_lblSatHReq_1).RightToLeft = (RightToLeft)0;
		Label lblSatHReq_16 = _lblSatHReq_1;
		size = new Size(33, 19);
		((Control)lblSatHReq_16).Size = size;
		((Control)_lblSatHReq_1).TabIndex = 222;
		((Control)_Label1_58).BackColor = SystemColors.Control;
		((Control)_Label1_58).Cursor = Cursors.Default;
		((Control)_Label1_58).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_58).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_58, (short)58);
		Label label1_53 = _Label1_58;
		location = new Point(16, 176);
		((Control)label1_53).Location = location;
		((Control)_Label1_58).Name = "_Label1_58";
		((Control)_Label1_58).RightToLeft = (RightToLeft)0;
		Label label1_54 = _Label1_58;
		size = new Size(81, 17);
		((Control)label1_54).Size = size;
		((Control)_Label1_58).TabIndex = 221;
		_Label1_58.Text = "Drinking Water:";
		_Label1_58.TextAlign = (ContentAlignment)4;
		((Control)_lblSatHReq_0).BackColor = SystemColors.Control;
		_lblSatHReq_0.BorderStyle = (BorderStyle)2;
		((Control)_lblSatHReq_0).Cursor = Cursors.Default;
		((Control)_lblSatHReq_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblSatHReq_0).ForeColor = SystemColors.ControlText;
		lblSatHReq.SetIndex(_lblSatHReq_0, (short)0);
		Label lblSatHReq_17 = _lblSatHReq_0;
		location = new Point(104, 152);
		((Control)lblSatHReq_17).Location = location;
		((Control)_lblSatHReq_0).Name = "_lblSatHReq_0";
		((Control)_lblSatHReq_0).RightToLeft = (RightToLeft)0;
		Label lblSatHReq_18 = _lblSatHReq_0;
		size = new Size(33, 19);
		((Control)lblSatHReq_18).Size = size;
		((Control)_lblSatHReq_0).TabIndex = 220;
		((Control)_Label1_99).BackColor = SystemColors.Control;
		((Control)_Label1_99).Cursor = Cursors.Default;
		((Control)_Label1_99).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_99).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_99, (short)99);
		Label label1_55 = _Label1_99;
		location = new Point(40, 152);
		((Control)label1_55).Location = location;
		((Control)_Label1_99).Name = "_Label1_99";
		((Control)_Label1_99).RightToLeft = (RightToLeft)0;
		Label label1_56 = _Label1_99;
		size = new Size(57, 17);
		((Control)label1_56).Size = size;
		((Control)_Label1_99).TabIndex = 219;
		_Label1_99.Text = "Dermal:";
		_Label1_99.TextAlign = (ContentAlignment)4;
		((Control)_Label1_57).BackColor = SystemColors.Control;
		((Control)_Label1_57).Cursor = Cursors.Default;
		((Control)_Label1_57).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_57).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_57, (short)57);
		Label label1_57 = _Label1_57;
		location = new Point(8, 8);
		((Control)label1_57).Location = location;
		((Control)_Label1_57).Name = "_Label1_57";
		((Control)_Label1_57).RightToLeft = (RightToLeft)0;
		Label label1_58 = _Label1_57;
		size = new Size(89, 17);
		((Control)label1_58).Size = size;
		((Control)_Label1_57).TabIndex = 218;
		_Label1_57.Text = "fyi: SAT frame";
		((Control)_Label1_57).Visible = false;
		((Control)_Label1_53).BackColor = SystemColors.Control;
		((Control)_Label1_53).Cursor = Cursors.Default;
		((Control)_Label1_53).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_53).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_53, (short)53);
		Label label1_59 = _Label1_53;
		location = new Point(392, 128);
		((Control)label1_59).Location = location;
		((Control)_Label1_53).Name = "_Label1_53";
		((Control)_Label1_53).RightToLeft = (RightToLeft)0;
		Label label1_60 = _Label1_53;
		size = new Size(177, 17);
		((Control)label1_60).Size = size;
		((Control)_Label1_53).TabIndex = 194;
		_Label1_53.Text = "Eco Requirements and Rating:";
		((Control)lblSATER).BackColor = SystemColors.Control;
		lblSATER.BorderStyle = (BorderStyle)2;
		((Control)lblSATER).Cursor = Cursors.Default;
		((Control)lblSATER).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSATER).ForeColor = SystemColors.ControlText;
		Label obj133 = lblSATER;
		location = new Point(576, 128);
		((Control)obj133).Location = location;
		((Control)lblSATER).Name = "lblSATER";
		((Control)lblSATER).RightToLeft = (RightToLeft)0;
		Label obj134 = lblSATER;
		size = new Size(33, 19);
		((Control)obj134).Size = size;
		((Control)lblSATER).TabIndex = 193;
		((Control)lblSatM2G).BackColor = SystemColors.Control;
		lblSatM2G.BorderStyle = (BorderStyle)2;
		((Control)lblSatM2G).Cursor = Cursors.Default;
		((Control)lblSatM2G).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSatM2G).ForeColor = SystemColors.ControlText;
		Label obj135 = lblSatM2G;
		location = new Point(87, 312);
		((Control)obj135).Location = location;
		((Control)lblSatM2G).Name = "lblSatM2G";
		((Control)lblSatM2G).RightToLeft = (RightToLeft)0;
		Label obj136 = lblSatM2G;
		size = new Size(121, 19);
		((Control)obj136).Size = size;
		((Control)lblSatM2G).TabIndex = 171;
		((Control)lblSatTR).BackColor = SystemColors.Control;
		lblSatTR.BorderStyle = (BorderStyle)2;
		((Control)lblSatTR).Cursor = Cursors.Default;
		((Control)lblSatTR).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSatTR).ForeColor = SystemColors.ControlText;
		Label obj137 = lblSatTR;
		location = new Point(656, 312);
		((Control)obj137).Location = location;
		((Control)lblSatTR).Name = "lblSatTR";
		((Control)lblSatTR).RightToLeft = (RightToLeft)0;
		Label obj138 = lblSatTR;
		size = new Size(17, 19);
		((Control)obj138).Size = size;
		((Control)lblSatTR).TabIndex = 170;
		lblSatTR.TextAlign = (ContentAlignment)2;
		((Control)lblSatPR).BackColor = SystemColors.Control;
		lblSatPR.BorderStyle = (BorderStyle)2;
		((Control)lblSatPR).Cursor = Cursors.Default;
		((Control)lblSatPR).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSatPR).ForeColor = SystemColors.ControlText;
		Label obj139 = lblSatPR;
		location = new Point(440, 312);
		((Control)obj139).Location = location;
		((Control)lblSatPR).Name = "lblSatPR";
		((Control)lblSatPR).RightToLeft = (RightToLeft)0;
		Label obj140 = lblSatPR;
		size = new Size(17, 19);
		((Control)obj140).Size = size;
		((Control)lblSatPR).TabIndex = 169;
		lblSatPR.TextAlign = (ContentAlignment)2;
		((Control)lblSatBR).BackColor = SystemColors.Control;
		lblSatBR.BorderStyle = (BorderStyle)2;
		((Control)lblSatBR).Cursor = Cursors.Default;
		((Control)lblSatBR).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSatBR).ForeColor = SystemColors.ControlText;
		Label obj141 = lblSatBR;
		location = new Point(552, 312);
		((Control)obj141).Location = location;
		((Control)lblSatBR).Name = "lblSatBR";
		((Control)lblSatBR).RightToLeft = (RightToLeft)0;
		Label obj142 = lblSatBR;
		size = new Size(17, 19);
		((Control)obj142).Size = size;
		((Control)lblSatBR).TabIndex = 168;
		lblSatBR.TextAlign = (ContentAlignment)2;
		((Control)lblSATHR).BackColor = SystemColors.Control;
		lblSATHR.BorderStyle = (BorderStyle)2;
		((Control)lblSATHR).Cursor = Cursors.Default;
		((Control)lblSATHR).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSATHR).ForeColor = SystemColors.ControlText;
		Label obj143 = lblSATHR;
		location = new Point(256, 128);
		((Control)obj143).Location = location;
		((Control)lblSATHR).Name = "lblSATHR";
		((Control)lblSATHR).RightToLeft = (RightToLeft)0;
		Label obj144 = lblSATHR;
		size = new Size(33, 19);
		((Control)obj144).Size = size;
		((Control)lblSATHR).TabIndex = 167;
		((Control)_Label1_35).BackColor = SystemColors.Control;
		((Control)_Label1_35).Cursor = Cursors.Default;
		((Control)_Label1_35).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_35).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_35, (short)35);
		Label label1_61 = _Label1_35;
		location = new Point(592, 312);
		((Control)label1_61).Location = location;
		((Control)_Label1_35).Name = "_Label1_35";
		((Control)_Label1_35).RightToLeft = (RightToLeft)0;
		Label label1_62 = _Label1_35;
		size = new Size(57, 17);
		((Control)label1_62).Size = size;
		((Control)_Label1_35).TabIndex = 115;
		_Label1_35.Text = "T Rating:";
		_Label1_35.TextAlign = (ContentAlignment)4;
		((Control)_Label1_34).BackColor = SystemColors.Control;
		((Control)_Label1_34).Cursor = Cursors.Default;
		((Control)_Label1_34).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_34).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_34, (short)34);
		Label label1_63 = _Label1_34;
		location = new Point(488, 312);
		((Control)label1_63).Location = location;
		((Control)_Label1_34).Name = "_Label1_34";
		((Control)_Label1_34).RightToLeft = (RightToLeft)0;
		Label label1_64 = _Label1_34;
		size = new Size(57, 17);
		((Control)label1_64).Size = size;
		((Control)_Label1_34).TabIndex = 114;
		_Label1_34.Text = "B Rating:";
		_Label1_34.TextAlign = (ContentAlignment)4;
		((Control)_Label1_33).BackColor = SystemColors.Control;
		((Control)_Label1_33).Cursor = Cursors.Default;
		((Control)_Label1_33).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_33).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_33, (short)33);
		Label label1_65 = _Label1_33;
		location = new Point(376, 312);
		((Control)label1_65).Location = location;
		((Control)_Label1_33).Name = "_Label1_33";
		((Control)_Label1_33).RightToLeft = (RightToLeft)0;
		Label label1_66 = _Label1_33;
		size = new Size(57, 17);
		((Control)label1_66).Size = size;
		((Control)_Label1_33).TabIndex = 113;
		_Label1_33.Text = "P Rating:";
		_Label1_33.TextAlign = (ContentAlignment)4;
		((Control)_Line2_2).BackColor = SystemColors.WindowText;
		Line2.SetIndex(_Line2_2, (short)2);
		Label line2_5 = _Line2_2;
		location = new Point(24, 304);
		((Control)line2_5).Location = location;
		((Control)_Line2_2).Name = "_Line2_2";
		Label line2_6 = _Line2_2;
		size = new Size(664, 1);
		((Control)line2_6).Size = size;
		((Control)_Line2_2).TabIndex = 372;
		((Control)_Label1_31).BackColor = SystemColors.Control;
		((Control)_Label1_31).Cursor = Cursors.Default;
		((Control)_Label1_31).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_31).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_31, (short)31);
		Label label1_67 = _Label1_31;
		location = new Point(5, 312);
		((Control)label1_67).Location = location;
		((Control)_Label1_31).Name = "_Label1_31";
		((Control)_Label1_31).RightToLeft = (RightToLeft)0;
		Label label1_68 = _Label1_31;
		size = new Size(73, 33);
		((Control)label1_68).Size = size;
		((Control)_Label1_31).TabIndex = 112;
		_Label1_31.Text = "Migration to Groundwater:";
		_Label1_31.TextAlign = (ContentAlignment)4;
		((Control)_Label1_21).BackColor = SystemColors.Control;
		((Control)_Label1_21).Cursor = Cursors.Default;
		((Control)_Label1_21).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_21).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_21, (short)21);
		Label label1_69 = _Label1_21;
		location = new Point(56, 128);
		((Control)label1_69).Location = location;
		((Control)_Label1_21).Name = "_Label1_21";
		((Control)_Label1_21).RightToLeft = (RightToLeft)0;
		Label label1_70 = _Label1_21;
		size = new Size(201, 17);
		((Control)label1_70).Size = size;
		((Control)_Label1_21).TabIndex = 111;
		_Label1_21.Text = "Health Requirements and Rating:";
		((Control)_Line2_0).BackColor = SystemColors.WindowText;
		Line2.SetIndex(_Line2_0, (short)0);
		Label line2_7 = _Line2_0;
		location = new Point(24, 120);
		((Control)line2_7).Location = location;
		((Control)_Line2_0).Name = "_Line2_0";
		Label line2_8 = _Line2_0;
		size = new Size(672, 1);
		((Control)line2_8).Size = size;
		((Control)_Line2_0).TabIndex = 373;
		((Control)_fraOpInfo_2).BackColor = SystemColors.Control;
		((Control)_fraOpInfo_2).Controls.Add((Control)(object)_fraSubOI_2);
		((Control)_fraOpInfo_2).Controls.Add((Control)(object)_fraSubOI_1);
		((Control)_fraOpInfo_2).Controls.Add((Control)(object)_fraSubOI_0);
		((Control)_fraOpInfo_2).Controls.Add((Control)(object)tabSubOI);
		((Control)_fraOpInfo_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraOpInfo_2).ForeColor = SystemColors.ControlText;
		fraOpInfo.SetIndex(_fraOpInfo_2, (short)2);
		GroupBox fraOpInfo_3 = _fraOpInfo_2;
		location = new Point(17, 81);
		((Control)fraOpInfo_3).Location = location;
		((Control)_fraOpInfo_2).Name = "_fraOpInfo_2";
		((Control)_fraOpInfo_2).RightToLeft = (RightToLeft)0;
		GroupBox fraOpInfo_4 = _fraOpInfo_2;
		size = new Size(721, 409);
		((Control)fraOpInfo_4).Size = size;
		((Control)_fraOpInfo_2).TabIndex = 117;
		_fraOpInfo_2.TabStop = false;
		((Control)_fraOpInfo_2).Visible = false;
		((Control)_fraSubOI_2).BackColor = SystemColors.Control;
		((Control)_fraSubOI_2).Controls.Add((Control)(object)lblOILvePpe);
		((Control)_fraSubOI_2).Controls.Add((Control)(object)txtLVEPPE);
		((Control)_fraSubOI_2).Controls.Add((Control)(object)lblLVEPPE);
		((Control)_fraSubOI_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraSubOI_2).ForeColor = SystemColors.ControlText;
		fraSubOI.SetIndex(_fraSubOI_2, (short)2);
		GroupBox fraSubOI_ = _fraSubOI_2;
		location = new Point(16, 40);
		((Control)fraSubOI_).Location = location;
		((Control)_fraSubOI_2).Name = "_fraSubOI_2";
		((Control)_fraSubOI_2).RightToLeft = (RightToLeft)0;
		GroupBox fraSubOI_2 = _fraSubOI_2;
		size = new Size(689, 313);
		((Control)fraSubOI_2).Size = size;
		((Control)_fraSubOI_2).TabIndex = 329;
		_fraSubOI_2.TabStop = false;
		((Control)_fraSubOI_2).Visible = false;
		((Control)lblOILvePpe).BackColor = SystemColors.Control;
		((Control)lblOILvePpe).Cursor = Cursors.Default;
		((Control)lblOILvePpe).Font = new Font("Arial", 12f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)lblOILvePpe).ForeColor = SystemColors.ControlText;
		Label obj145 = lblOILvePpe;
		location = new Point(39, 72);
		((Control)obj145).Location = location;
		((Control)lblOILvePpe).Name = "lblOILvePpe";
		((Control)lblOILvePpe).RightToLeft = (RightToLeft)0;
		Label obj146 = lblOILvePpe;
		size = new Size(603, 53);
		((Control)obj146).Size = size;
		((Control)lblOILvePpe).TabIndex = 330;
		lblOILvePpe.Text = "This tab is only available for Assessments that are type LVE or LVE-MOD";
		txtLVEPPE.AcceptsReturn = true;
		((TextBoxBase)txtLVEPPE).BackColor = SystemColors.Control;
		((Control)txtLVEPPE).Cursor = Cursors.IBeam;
		((Control)txtLVEPPE).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtLVEPPE).ForeColor = SystemColors.WindowText;
		TextBox obj147 = txtLVEPPE;
		location = new Point(232, 80);
		((Control)obj147).Location = location;
		((TextBoxBase)txtLVEPPE).MaxLength = 0;
		txtLVEPPE.Multiline = true;
		((Control)txtLVEPPE).Name = "txtLVEPPE";
		((TextBoxBase)txtLVEPPE).ReadOnly = true;
		((Control)txtLVEPPE).RightToLeft = (RightToLeft)0;
		txtLVEPPE.ScrollBars = (ScrollBars)2;
		TextBox obj148 = txtLVEPPE;
		size = new Size(393, 41);
		((Control)obj148).Size = size;
		((Control)txtLVEPPE).TabIndex = 349;
		((Control)txtLVEPPE).Visible = false;
		((Control)lblLVEPPE).BackColor = SystemColors.Control;
		((Control)lblLVEPPE).Cursor = Cursors.Default;
		((Control)lblLVEPPE).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblLVEPPE).ForeColor = SystemColors.ControlText;
		Label obj149 = lblLVEPPE;
		location = new Point(24, 80);
		((Control)obj149).Location = location;
		((Control)lblLVEPPE).Name = "lblLVEPPE";
		((Control)lblLVEPPE).RightToLeft = (RightToLeft)0;
		Label obj150 = lblLVEPPE;
		size = new Size(209, 21);
		((Control)obj150).Size = size;
		((Control)lblLVEPPE).TabIndex = 350;
		lblLVEPPE.Text = "LVE Personal Protective Equipment:   ";
		lblLVEPPE.TextAlign = (ContentAlignment)4;
		((Control)lblLVEPPE).Visible = false;
		((Control)_fraSubOI_1).BackColor = SystemColors.Control;
		((Control)_fraSubOI_1).Controls.Add((Control)(object)msfTlv);
		((Control)_fraSubOI_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraSubOI_1).ForeColor = SystemColors.ControlText;
		fraSubOI.SetIndex(_fraSubOI_1, (short)1);
		GroupBox fraSubOI_3 = _fraSubOI_1;
		location = new Point(16, 40);
		((Control)fraSubOI_3).Location = location;
		((Control)_fraSubOI_1).Name = "_fraSubOI_1";
		((Control)_fraSubOI_1).RightToLeft = (RightToLeft)0;
		GroupBox fraSubOI_4 = _fraSubOI_1;
		size = new Size(689, 313);
		((Control)fraSubOI_4).Size = size;
		((Control)_fraSubOI_1).TabIndex = 196;
		_fraSubOI_1.TabStop = false;
		((Control)_fraSubOI_1).Visible = false;
		AxMSFlexGrid obj151 = msfTlv;
		location = new Point(8, 16);
		((Control)obj151).Location = location;
		((Control)msfTlv).Name = "msfTlv";
		((AxHost)msfTlv).OcxState = (State)componentResourceManager.GetObject("msfTlv.OcxState");
		AxMSFlexGrid obj152 = msfTlv;
		size = new Size(673, 289);
		((Control)obj152).Size = size;
		((Control)msfTlv).TabIndex = 197;
		((Control)_fraSubOI_0).BackColor = SystemColors.Control;
		((Control)_fraSubOI_0).Controls.Add((Control)(object)_txtMsds_2);
		((Control)_fraSubOI_0).Controls.Add((Control)(object)_txtMsds_1);
		((Control)_fraSubOI_0).Controls.Add((Control)(object)_txtMsds_0);
		((Control)_fraSubOI_0).Controls.Add((Control)(object)lblMsdsLab);
		((Control)_fraSubOI_0).Controls.Add((Control)(object)lblMsdsInc);
		((Control)_fraSubOI_0).Controls.Add((Control)(object)_Label1_78);
		((Control)_fraSubOI_0).Controls.Add((Control)(object)_Label1_77);
		((Control)_fraSubOI_0).Controls.Add((Control)(object)_Label1_76);
		((Control)_fraSubOI_0).Controls.Add((Control)(object)_Label1_75);
		((Control)_fraSubOI_0).Controls.Add((Control)(object)_Label1_98);
		((Control)_fraSubOI_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraSubOI_0).ForeColor = SystemColors.ControlText;
		fraSubOI.SetIndex(_fraSubOI_0, (short)0);
		GroupBox fraSubOI_5 = _fraSubOI_0;
		location = new Point(16, 40);
		((Control)fraSubOI_5).Location = location;
		((Control)_fraSubOI_0).Name = "_fraSubOI_0";
		((Control)_fraSubOI_0).RightToLeft = (RightToLeft)0;
		GroupBox fraSubOI_6 = _fraSubOI_0;
		size = new Size(689, 313);
		((Control)fraSubOI_6).Size = size;
		((Control)_fraSubOI_0).TabIndex = 198;
		_fraSubOI_0.TabStop = false;
		_txtMsds_2.AcceptsReturn = true;
		((TextBoxBase)_txtMsds_2).BackColor = SystemColors.Control;
		((Control)_txtMsds_2).Cursor = Cursors.IBeam;
		((Control)_txtMsds_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMsds_2).ForeColor = SystemColors.WindowText;
		txtMsds.SetIndex(_txtMsds_2, (short)2);
		TextBox txtMsds_ = _txtMsds_2;
		location = new Point(136, 152);
		((Control)txtMsds_).Location = location;
		((TextBoxBase)_txtMsds_2).MaxLength = 0;
		_txtMsds_2.Multiline = true;
		((Control)_txtMsds_2).Name = "_txtMsds_2";
		((TextBoxBase)_txtMsds_2).ReadOnly = true;
		((Control)_txtMsds_2).RightToLeft = (RightToLeft)0;
		_txtMsds_2.ScrollBars = (ScrollBars)2;
		TextBox txtMsds_2 = _txtMsds_2;
		size = new Size(393, 41);
		((Control)txtMsds_2).Size = size;
		((Control)_txtMsds_2).TabIndex = 256;
		_txtMsds_1.AcceptsReturn = true;
		((TextBoxBase)_txtMsds_1).BackColor = SystemColors.Control;
		((Control)_txtMsds_1).Cursor = Cursors.IBeam;
		((Control)_txtMsds_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMsds_1).ForeColor = SystemColors.WindowText;
		txtMsds.SetIndex(_txtMsds_1, (short)1);
		TextBox txtMsds_3 = _txtMsds_1;
		location = new Point(136, 104);
		((Control)txtMsds_3).Location = location;
		((TextBoxBase)_txtMsds_1).MaxLength = 0;
		_txtMsds_1.Multiline = true;
		((Control)_txtMsds_1).Name = "_txtMsds_1";
		((TextBoxBase)_txtMsds_1).ReadOnly = true;
		((Control)_txtMsds_1).RightToLeft = (RightToLeft)0;
		_txtMsds_1.ScrollBars = (ScrollBars)2;
		TextBox txtMsds_4 = _txtMsds_1;
		size = new Size(393, 41);
		((Control)txtMsds_4).Size = size;
		((Control)_txtMsds_1).TabIndex = 255;
		_txtMsds_0.AcceptsReturn = true;
		((TextBoxBase)_txtMsds_0).BackColor = SystemColors.Control;
		((Control)_txtMsds_0).Cursor = Cursors.IBeam;
		((Control)_txtMsds_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)_txtMsds_0).ForeColor = SystemColors.WindowText;
		txtMsds.SetIndex(_txtMsds_0, (short)0);
		TextBox txtMsds_5 = _txtMsds_0;
		location = new Point(136, 56);
		((Control)txtMsds_5).Location = location;
		((TextBoxBase)_txtMsds_0).MaxLength = 0;
		_txtMsds_0.Multiline = true;
		((Control)_txtMsds_0).Name = "_txtMsds_0";
		((TextBoxBase)_txtMsds_0).ReadOnly = true;
		((Control)_txtMsds_0).RightToLeft = (RightToLeft)0;
		_txtMsds_0.ScrollBars = (ScrollBars)2;
		TextBox txtMsds_6 = _txtMsds_0;
		size = new Size(393, 41);
		((Control)txtMsds_6).Size = size;
		((Control)_txtMsds_0).TabIndex = 254;
		((Control)lblMsdsLab).BackColor = SystemColors.Control;
		lblMsdsLab.BorderStyle = (BorderStyle)2;
		((Control)lblMsdsLab).Cursor = Cursors.Default;
		((Control)lblMsdsLab).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMsdsLab).ForeColor = SystemColors.ControlText;
		Label obj153 = lblMsdsLab;
		location = new Point(416, 24);
		((Control)obj153).Location = location;
		((Control)lblMsdsLab).Name = "lblMsdsLab";
		((Control)lblMsdsLab).RightToLeft = (RightToLeft)0;
		Label obj154 = lblMsdsLab;
		size = new Size(41, 17);
		((Control)obj154).Size = size;
		((Control)lblMsdsLab).TabIndex = 260;
		lblMsdsLab.Text = "No";
		lblMsdsLab.TextAlign = (ContentAlignment)2;
		((Control)lblMsdsInc).BackColor = SystemColors.Control;
		lblMsdsInc.BorderStyle = (BorderStyle)2;
		((Control)lblMsdsInc).Cursor = Cursors.Default;
		((Control)lblMsdsInc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMsdsInc).ForeColor = SystemColors.ControlText;
		Label obj155 = lblMsdsInc;
		location = new Point(232, 24);
		((Control)obj155).Location = location;
		((Control)lblMsdsInc).Name = "lblMsdsInc";
		((Control)lblMsdsInc).RightToLeft = (RightToLeft)0;
		Label obj156 = lblMsdsInc;
		size = new Size(41, 17);
		((Control)obj156).Size = size;
		((Control)lblMsdsInc).TabIndex = 259;
		lblMsdsInc.Text = "No";
		lblMsdsInc.TextAlign = (ContentAlignment)2;
		((Control)_Label1_78).BackColor = SystemColors.Control;
		((Control)_Label1_78).Cursor = Cursors.Default;
		((Control)_Label1_78).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_78).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_78, (short)78);
		Label label1_71 = _Label1_78;
		location = new Point(296, 24);
		((Control)label1_71).Location = location;
		((Control)_Label1_78).Name = "_Label1_78";
		((Control)_Label1_78).RightToLeft = (RightToLeft)0;
		Label label1_72 = _Label1_78;
		size = new Size(113, 17);
		((Control)label1_72).Size = size;
		((Control)_Label1_78).TabIndex = 258;
		_Label1_78.Text = "Label Included:";
		_Label1_78.TextAlign = (ContentAlignment)4;
		((Control)_Label1_77).BackColor = SystemColors.Control;
		((Control)_Label1_77).Cursor = Cursors.Default;
		((Control)_Label1_77).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_77).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_77, (short)77);
		Label label1_73 = _Label1_77;
		location = new Point(136, 24);
		((Control)label1_73).Location = location;
		((Control)_Label1_77).Name = "_Label1_77";
		((Control)_Label1_77).RightToLeft = (RightToLeft)0;
		Label label1_74 = _Label1_77;
		size = new Size(89, 17);
		((Control)label1_74).Size = size;
		((Control)_Label1_77).TabIndex = 257;
		_Label1_77.Text = "MSDS Included:";
		_Label1_77.TextAlign = (ContentAlignment)4;
		((Control)_Label1_76).BackColor = SystemColors.Control;
		((Control)_Label1_76).Cursor = Cursors.Default;
		((Control)_Label1_76).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_76).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_76, (short)76);
		Label label1_75 = _Label1_76;
		location = new Point(16, 152);
		((Control)label1_75).Location = location;
		((Control)_Label1_76).Name = "_Label1_76";
		((Control)_Label1_76).RightToLeft = (RightToLeft)0;
		Label label1_76 = _Label1_76;
		size = new Size(113, 17);
		((Control)label1_76).Size = size;
		((Control)_Label1_76).TabIndex = 253;
		_Label1_76.Text = "Health Effects:";
		_Label1_76.TextAlign = (ContentAlignment)4;
		((Control)_Label1_75).BackColor = SystemColors.Control;
		((Control)_Label1_75).Cursor = Cursors.Default;
		((Control)_Label1_75).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_75).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_75, (short)75);
		Label label1_77 = _Label1_75;
		location = new Point(16, 104);
		((Control)label1_77).Location = location;
		((Control)_Label1_75).Name = "_Label1_75";
		((Control)_Label1_75).RightToLeft = (RightToLeft)0;
		Label label1_78 = _Label1_75;
		size = new Size(113, 17);
		((Control)label1_78).Size = size;
		((Control)_Label1_75).TabIndex = 252;
		_Label1_75.Text = "Respirator:";
		_Label1_75.TextAlign = (ContentAlignment)4;
		((Control)_Label1_98).BackColor = SystemColors.Control;
		((Control)_Label1_98).Cursor = Cursors.Default;
		((Control)_Label1_98).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_98).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_98, (short)98);
		Label label1_79 = _Label1_98;
		location = new Point(16, 56);
		((Control)label1_79).Location = location;
		((Control)_Label1_98).Name = "_Label1_98";
		((Control)_Label1_98).RightToLeft = (RightToLeft)0;
		Label label1_80 = _Label1_98;
		size = new Size(113, 17);
		((Control)label1_80).Size = size;
		((Control)_Label1_98).TabIndex = 251;
		_Label1_98.Text = "General Equipment:";
		_Label1_98.TextAlign = (ContentAlignment)4;
		AxTabStrip obj157 = tabSubOI;
		location = new Point(8, 16);
		((Control)obj157).Location = location;
		((Control)tabSubOI).Name = "tabSubOI";
		((AxHost)tabSubOI).OcxState = (State)componentResourceManager.GetObject("tabSubOI.OcxState");
		AxTabStrip obj158 = tabSubOI;
		size = new Size(705, 345);
		((Control)obj158).Size = size;
		((Control)tabSubOI).TabIndex = 195;
		((ButtonBase)cmdUpdOptInfo).BackColor = SystemColors.Control;
		((Control)cmdUpdOptInfo).Cursor = Cursors.Default;
		((Control)cmdUpdOptInfo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdOptInfo).ForeColor = SystemColors.ControlText;
		Button obj159 = cmdUpdOptInfo;
		location = new Point(22, 549);
		((Control)obj159).Location = location;
		((Control)cmdUpdOptInfo).Name = "cmdUpdOptInfo";
		((Control)cmdUpdOptInfo).RightToLeft = (RightToLeft)0;
		Button obj160 = cmdUpdOptInfo;
		size = new Size(177, 41);
		((Control)obj160).Size = size;
		((Control)cmdUpdOptInfo).TabIndex = 8;
		((ButtonBase)cmdUpdOptInfo).Text = "Update Optional Information";
		((ButtonBase)cmdUpdOptInfo).UseVisualStyleBackColor = false;
		((Control)_fraOpInfo_1).BackColor = SystemColors.Control;
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)txtNumExpEstBasis);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)lblExpBasedCriteria);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_Label1_113);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_Label1_112);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)lblNumExpEst);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_Label1_111);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_Label1_79);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_lblNumWMet_4);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_lblNumWMet_3);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_lblNumWMet_2);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_lblNumWMet_1);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_Label1_54);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_Label1_49);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_lblGT100WorkersW1to10_48);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_lblNumWMet_0);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)lblNumExp);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_Label1_47);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_Label1_46);
		((Control)_fraOpInfo_1).Controls.Add((Control)(object)_Label1_45);
		((Control)_fraOpInfo_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraOpInfo_1).ForeColor = SystemColors.ControlText;
		fraOpInfo.SetIndex(_fraOpInfo_1, (short)1);
		GroupBox fraOpInfo_5 = _fraOpInfo_1;
		location = new Point(17, 81);
		((Control)fraOpInfo_5).Location = location;
		((Control)_fraOpInfo_1).Name = "_fraOpInfo_1";
		((Control)_fraOpInfo_1).RightToLeft = (RightToLeft)0;
		GroupBox fraOpInfo_6 = _fraOpInfo_1;
		size = new Size(721, 409);
		((Control)fraOpInfo_6).Size = size;
		((Control)_fraOpInfo_1).TabIndex = 116;
		_fraOpInfo_1.TabStop = false;
		((Control)_fraOpInfo_1).Visible = false;
		txtNumExpEstBasis.AcceptsReturn = true;
		((TextBoxBase)txtNumExpEstBasis).BackColor = SystemColors.Control;
		((Control)txtNumExpEstBasis).Cursor = Cursors.IBeam;
		((Control)txtNumExpEstBasis).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtNumExpEstBasis).ForeColor = SystemColors.WindowText;
		TextBox obj161 = txtNumExpEstBasis;
		location = new Point(384, 128);
		((Control)obj161).Location = location;
		((TextBoxBase)txtNumExpEstBasis).MaxLength = 0;
		txtNumExpEstBasis.Multiline = true;
		((Control)txtNumExpEstBasis).Name = "txtNumExpEstBasis";
		((TextBoxBase)txtNumExpEstBasis).ReadOnly = true;
		((Control)txtNumExpEstBasis).RightToLeft = (RightToLeft)0;
		txtNumExpEstBasis.ScrollBars = (ScrollBars)2;
		TextBox obj162 = txtNumExpEstBasis;
		size = new Size(321, 59);
		((Control)obj162).Size = size;
		((Control)txtNumExpEstBasis).TabIndex = 380;
		((Control)lblExpBasedCriteria).BackColor = SystemColors.Control;
		lblExpBasedCriteria.BorderStyle = (BorderStyle)2;
		((Control)lblExpBasedCriteria).Cursor = Cursors.Default;
		((Control)lblExpBasedCriteria).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblExpBasedCriteria).ForeColor = SystemColors.ControlText;
		Label obj163 = lblExpBasedCriteria;
		location = new Point(384, 320);
		((Control)obj163).Location = location;
		((Control)lblExpBasedCriteria).Name = "lblExpBasedCriteria";
		((Control)lblExpBasedCriteria).RightToLeft = (RightToLeft)0;
		Label obj164 = lblExpBasedCriteria;
		size = new Size(33, 19);
		((Control)obj164).Size = size;
		((Control)lblExpBasedCriteria).TabIndex = 383;
		lblExpBasedCriteria.TextAlign = (ContentAlignment)2;
		((Control)_Label1_113).BackColor = SystemColors.Control;
		((Control)_Label1_113).Cursor = Cursors.Default;
		((Control)_Label1_113).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_113).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_113, (short)113);
		Label label1_81 = _Label1_113;
		location = new Point(32, 320);
		((Control)label1_81).Location = location;
		((Control)_Label1_113).Name = "_Label1_113";
		((Control)_Label1_113).RightToLeft = (RightToLeft)0;
		Label label1_82 = _Label1_113;
		size = new Size(345, 19);
		((Control)label1_82).Size = size;
		((Control)_Label1_113).TabIndex = 382;
		_Label1_113.Text = "Number of criteria met: ";
		_Label1_113.TextAlign = (ContentAlignment)4;
		((Control)_Label1_112).BackColor = SystemColors.Control;
		((Control)_Label1_112).Cursor = Cursors.Default;
		((Control)_Label1_112).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_112).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_112, (short)112);
		Label label1_83 = _Label1_112;
		location = new Point(288, 128);
		((Control)label1_83).Location = location;
		((Control)_Label1_112).Name = "_Label1_112";
		((Control)_Label1_112).RightToLeft = (RightToLeft)0;
		Label label1_84 = _Label1_112;
		size = new Size(81, 19);
		((Control)label1_84).Size = size;
		((Control)_Label1_112).TabIndex = 381;
		_Label1_112.Text = "Basis:";
		_Label1_112.TextAlign = (ContentAlignment)4;
		((Control)lblNumExpEst).BackColor = SystemColors.Control;
		lblNumExpEst.BorderStyle = (BorderStyle)2;
		((Control)lblNumExpEst).Cursor = Cursors.Default;
		((Control)lblNumExpEst).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblNumExpEst).ForeColor = SystemColors.ControlText;
		Label obj165 = lblNumExpEst;
		location = new Point(384, 96);
		((Control)obj165).Location = location;
		((Control)lblNumExpEst).Name = "lblNumExpEst";
		((Control)lblNumExpEst).RightToLeft = (RightToLeft)0;
		Label obj166 = lblNumExpEst;
		size = new Size(57, 19);
		((Control)obj166).Size = size;
		((Control)lblNumExpEst).TabIndex = 379;
		lblNumExpEst.TextAlign = (ContentAlignment)2;
		((Control)_Label1_111).BackColor = SystemColors.Control;
		((Control)_Label1_111).Cursor = Cursors.Default;
		((Control)_Label1_111).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_111).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_111, (short)111);
		Label label1_85 = _Label1_111;
		location = new Point(144, 96);
		((Control)label1_85).Location = location;
		((Control)_Label1_111).Name = "_Label1_111";
		((Control)_Label1_111).RightToLeft = (RightToLeft)0;
		Label label1_86 = _Label1_111;
		size = new Size(233, 19);
		((Control)label1_86).Size = size;
		((Control)_Label1_111).TabIndex = 378;
		_Label1_111.Text = "Number of Workers Exposed (estimated): ";
		_Label1_111.TextAlign = (ContentAlignment)4;
		((Control)_Label1_79).BackColor = SystemColors.Control;
		((Control)_Label1_79).Cursor = Cursors.Default;
		((Control)_Label1_79).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_79).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_79, (short)79);
		Label label1_87 = _Label1_79;
		location = new Point(144, 32);
		((Control)label1_87).Location = location;
		((Control)_Label1_79).Name = "_Label1_79";
		((Control)_Label1_79).RightToLeft = (RightToLeft)0;
		Label label1_88 = _Label1_79;
		size = new Size(233, 19);
		((Control)label1_88).Size = size;
		((Control)_Label1_79).TabIndex = 262;
		_Label1_79.Text = "Exposure-based: ";
		_Label1_79.TextAlign = (ContentAlignment)4;
		((Control)_lblNumWMet_4).BackColor = SystemColors.Control;
		_lblNumWMet_4.BorderStyle = (BorderStyle)2;
		((Control)_lblNumWMet_4).Cursor = Cursors.Default;
		((Control)_lblNumWMet_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblNumWMet_4).ForeColor = SystemColors.ControlText;
		lblNumWMet.SetIndex(_lblNumWMet_4, (short)4);
		Label lblNumWMet_ = _lblNumWMet_4;
		location = new Point(384, 32);
		((Control)lblNumWMet_).Location = location;
		((Control)_lblNumWMet_4).Name = "_lblNumWMet_4";
		((Control)_lblNumWMet_4).RightToLeft = (RightToLeft)0;
		Label lblNumWMet_2 = _lblNumWMet_4;
		size = new Size(33, 19);
		((Control)lblNumWMet_2).Size = size;
		((Control)_lblNumWMet_4).TabIndex = 261;
		_lblNumWMet_4.TextAlign = (ContentAlignment)2;
		((Control)_lblNumWMet_3).BackColor = SystemColors.Control;
		_lblNumWMet_3.BorderStyle = (BorderStyle)2;
		((Control)_lblNumWMet_3).Cursor = Cursors.Default;
		((Control)_lblNumWMet_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblNumWMet_3).ForeColor = SystemColors.ControlText;
		lblNumWMet.SetIndex(_lblNumWMet_3, (short)3);
		Label lblNumWMet_3 = _lblNumWMet_3;
		location = new Point(384, 288);
		((Control)lblNumWMet_3).Location = location;
		((Control)_lblNumWMet_3).Name = "_lblNumWMet_3";
		((Control)_lblNumWMet_3).RightToLeft = (RightToLeft)0;
		Label lblNumWMet_4 = _lblNumWMet_3;
		size = new Size(33, 19);
		((Control)lblNumWMet_4).Size = size;
		((Control)_lblNumWMet_3).TabIndex = 215;
		_lblNumWMet_3.TextAlign = (ContentAlignment)2;
		((Control)_lblNumWMet_2).BackColor = SystemColors.Control;
		_lblNumWMet_2.BorderStyle = (BorderStyle)2;
		((Control)_lblNumWMet_2).Cursor = Cursors.Default;
		((Control)_lblNumWMet_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblNumWMet_2).ForeColor = SystemColors.ControlText;
		lblNumWMet.SetIndex(_lblNumWMet_2, (short)2);
		Label lblNumWMet_5 = _lblNumWMet_2;
		location = new Point(384, 256);
		((Control)lblNumWMet_5).Location = location;
		((Control)_lblNumWMet_2).Name = "_lblNumWMet_2";
		((Control)_lblNumWMet_2).RightToLeft = (RightToLeft)0;
		Label lblNumWMet_6 = _lblNumWMet_2;
		size = new Size(33, 19);
		((Control)lblNumWMet_6).Size = size;
		((Control)_lblNumWMet_2).TabIndex = 214;
		_lblNumWMet_2.TextAlign = (ContentAlignment)2;
		((Control)_lblNumWMet_1).BackColor = SystemColors.Control;
		_lblNumWMet_1.BorderStyle = (BorderStyle)2;
		((Control)_lblNumWMet_1).Cursor = Cursors.Default;
		((Control)_lblNumWMet_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblNumWMet_1).ForeColor = SystemColors.ControlText;
		lblNumWMet.SetIndex(_lblNumWMet_1, (short)1);
		Label lblNumWMet_7 = _lblNumWMet_1;
		location = new Point(384, 224);
		((Control)lblNumWMet_7).Location = location;
		((Control)_lblNumWMet_1).Name = "_lblNumWMet_1";
		((Control)_lblNumWMet_1).RightToLeft = (RightToLeft)0;
		Label lblNumWMet_8 = _lblNumWMet_1;
		size = new Size(33, 19);
		((Control)lblNumWMet_8).Size = size;
		((Control)_lblNumWMet_1).TabIndex = 213;
		_lblNumWMet_1.TextAlign = (ContentAlignment)2;
		((Control)_Label1_54).BackColor = SystemColors.ScrollBar;
		((Control)_Label1_54).Cursor = Cursors.Default;
		((Control)_Label1_54).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_54).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_54, (short)54);
		Label label1_89 = _Label1_54;
		location = new Point(8, 16);
		((Control)label1_89).Location = location;
		((Control)_Label1_54).Name = "_Label1_54";
		((Control)_Label1_54).RightToLeft = (RightToLeft)0;
		Label label1_90 = _Label1_54;
		size = new Size(185, 19);
		((Control)label1_90).Size = size;
		((Control)_Label1_54).TabIndex = 212;
		_Label1_54.Text = "fyi - exposure based frame";
		((Control)_Label1_54).Visible = false;
		((Control)_Label1_49).BackColor = SystemColors.Control;
		((Control)_Label1_49).Cursor = Cursors.Default;
		((Control)_Label1_49).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_49).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_49, (short)49);
		Label label1_91 = _Label1_49;
		location = new Point(32, 288);
		((Control)label1_91).Location = location;
		((Control)_Label1_49).Name = "_Label1_49";
		((Control)_Label1_49).RightToLeft = (RightToLeft)0;
		Label label1_92 = _Label1_49;
		size = new Size(345, 19);
		((Control)label1_92).Size = size;
		((Control)_Label1_49).TabIndex = 164;
		_Label1_49.Text = "Routine Dermal Contact for >250 workers over > 100 days/yr: ";
		_Label1_49.TextAlign = (ContentAlignment)4;
		((Control)_lblGT100WorkersW1to10_48).BackColor = SystemColors.Control;
		((Control)_lblGT100WorkersW1to10_48).Cursor = Cursors.Default;
		((Control)_lblGT100WorkersW1to10_48).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblGT100WorkersW1to10_48).ForeColor = SystemColors.WindowText;
		lblGT100WorkersW1to10.SetIndex(_lblGT100WorkersW1to10_48, (short)48);
		Label lblGT100WorkersW1to10_ = _lblGT100WorkersW1to10_48;
		location = new Point(8, 256);
		((Control)lblGT100WorkersW1to10_).Location = location;
		((Control)_lblGT100WorkersW1to10_48).Name = "_lblGT100WorkersW1to10_48";
		((Control)_lblGT100WorkersW1to10_48).RightToLeft = (RightToLeft)0;
		Label lblGT100WorkersW1to10_2 = _lblGT100WorkersW1to10_48;
		size = new Size(369, 19);
		((Control)lblGT100WorkersW1to10_2).Size = size;
		((Control)_lblGT100WorkersW1to10_48).TabIndex = 163;
		_lblGT100WorkersW1to10_48.Text = ">100 Workers with 1-10 mg/day inhalation exposure for over >100 days/yr: ";
		_lblGT100WorkersW1to10_48.TextAlign = (ContentAlignment)4;
		((Control)_lblNumWMet_0).BackColor = SystemColors.Control;
		_lblNumWMet_0.BorderStyle = (BorderStyle)2;
		((Control)_lblNumWMet_0).Cursor = Cursors.Default;
		((Control)_lblNumWMet_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblNumWMet_0).ForeColor = SystemColors.ControlText;
		lblNumWMet.SetIndex(_lblNumWMet_0, (short)0);
		Label lblNumWMet_9 = _lblNumWMet_0;
		location = new Point(384, 192);
		((Control)lblNumWMet_9).Location = location;
		((Control)_lblNumWMet_0).Name = "_lblNumWMet_0";
		((Control)_lblNumWMet_0).RightToLeft = (RightToLeft)0;
		Label lblNumWMet_10 = _lblNumWMet_0;
		size = new Size(33, 19);
		((Control)lblNumWMet_10).Size = size;
		((Control)_lblNumWMet_0).TabIndex = 162;
		_lblNumWMet_0.TextAlign = (ContentAlignment)2;
		((Control)lblNumExp).BackColor = SystemColors.Control;
		lblNumExp.BorderStyle = (BorderStyle)2;
		((Control)lblNumExp).Cursor = Cursors.Default;
		((Control)lblNumExp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblNumExp).ForeColor = SystemColors.ControlText;
		Label obj167 = lblNumExp;
		location = new Point(384, 64);
		((Control)obj167).Location = location;
		((Control)lblNumExp).Name = "lblNumExp";
		((Control)lblNumExp).RightToLeft = (RightToLeft)0;
		Label obj168 = lblNumExp;
		size = new Size(57, 19);
		((Control)obj168).Size = size;
		((Control)lblNumExp).TabIndex = 161;
		lblNumExp.TextAlign = (ContentAlignment)2;
		((Control)_Label1_47).BackColor = SystemColors.Control;
		((Control)_Label1_47).Cursor = Cursors.Default;
		((Control)_Label1_47).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_47).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_47, (short)47);
		Label label1_93 = _Label1_47;
		location = new Point(32, 224);
		((Control)label1_93).Location = location;
		((Control)_Label1_47).Name = "_Label1_47";
		((Control)_Label1_47).RightToLeft = (RightToLeft)0;
		Label label1_94 = _Label1_47;
		size = new Size(345, 19);
		((Control)label1_94).Size = size;
		((Control)_Label1_47).TabIndex = 160;
		_Label1_47.Text = ">100 Workers with >10 mg/day inhalation exposure: ";
		_Label1_47.TextAlign = (ContentAlignment)4;
		((Control)_Label1_46).BackColor = SystemColors.Control;
		((Control)_Label1_46).Cursor = Cursors.Default;
		((Control)_Label1_46).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_46).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_46, (short)46);
		Label label1_95 = _Label1_46;
		location = new Point(144, 192);
		((Control)label1_95).Location = location;
		((Control)_Label1_46).Name = "_Label1_46";
		((Control)_Label1_46).RightToLeft = (RightToLeft)0;
		Label label1_96 = _Label1_46;
		size = new Size(233, 19);
		((Control)label1_96).Size = size;
		((Control)_Label1_46).TabIndex = 159;
		_Label1_46.Text = "> 1000 Workers: ";
		_Label1_46.TextAlign = (ContentAlignment)4;
		((Control)_Label1_45).BackColor = SystemColors.Control;
		((Control)_Label1_45).Cursor = Cursors.Default;
		((Control)_Label1_45).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_45).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_45, (short)45);
		Label label1_97 = _Label1_45;
		location = new Point(144, 64);
		((Control)label1_97).Location = location;
		((Control)_Label1_45).Name = "_Label1_45";
		((Control)_Label1_45).RightToLeft = (RightToLeft)0;
		Label label1_98 = _Label1_45;
		size = new Size(233, 19);
		((Control)label1_98).Size = size;
		((Control)_Label1_45).TabIndex = 158;
		_Label1_45.Text = "Number of Workers Exposed (default): ";
		_Label1_45.TextAlign = (ContentAlignment)4;
		cmbOptInfo.BackColor = SystemColors.Window;
		((Control)cmbOptInfo).Cursor = Cursors.Default;
		cmbOptInfo.DropDownStyle = (ComboBoxStyle)2;
		((Control)cmbOptInfo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		cmbOptInfo.ForeColor = SystemColors.WindowText;
		ComboBox obj169 = cmbOptInfo;
		location = new Point(16, 52);
		((Control)obj169).Location = location;
		((Control)cmbOptInfo).Name = "cmbOptInfo";
		((Control)cmbOptInfo).RightToLeft = (RightToLeft)0;
		ComboBox obj170 = cmbOptInfo;
		size = new Size(673, 22);
		((Control)obj170).Size = size;
		((Control)cmbOptInfo).TabIndex = 5;
		((Control)_Label1_50).BackColor = SystemColors.Control;
		((Control)_Label1_50).Cursor = Cursors.Default;
		((Control)_Label1_50).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_50).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_50, (short)50);
		Label label1_99 = _Label1_50;
		location = new Point(16, 26);
		((Control)label1_99).Location = location;
		((Control)_Label1_50).Name = "_Label1_50";
		((Control)_Label1_50).RightToLeft = (RightToLeft)0;
		Label label1_100 = _Label1_50;
		size = new Size(585, 19);
		((Control)label1_100).Size = size;
		((Control)_Label1_50).TabIndex = 79;
		_Label1_50.Text = "Use the drop down combo box to select the optional information you would like to see below.";
		((Control)_fraOpInfo_5).BackColor = SystemColors.Control;
		((Control)_fraOpInfo_5).Controls.Add((Control)(object)txtMiscCRSSinfo);
		((Control)_fraOpInfo_5).Controls.Add((Control)(object)txtOtherUses);
		((Control)_fraOpInfo_5).Controls.Add((Control)(object)_Label1_43);
		((Control)_fraOpInfo_5).Controls.Add((Control)(object)lblCRSSdate);
		((Control)_fraOpInfo_5).Controls.Add((Control)(object)_Label1_89);
		((Control)_fraOpInfo_5).Controls.Add((Control)(object)_Label1_88);
		((Control)_fraOpInfo_5).Controls.Add((Control)(object)lblConsUse);
		((Control)_fraOpInfo_5).Controls.Add((Control)(object)lblOccExpRating);
		((Control)_fraOpInfo_5).Controls.Add((Control)(object)_Label1_22);
		((Control)_fraOpInfo_5).Controls.Add((Control)(object)_Label1_44);
		((Control)_fraOpInfo_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraOpInfo_5).ForeColor = SystemColors.ControlText;
		fraOpInfo.SetIndex(_fraOpInfo_5, (short)5);
		GroupBox fraOpInfo_7 = _fraOpInfo_5;
		location = new Point(17, 81);
		((Control)fraOpInfo_7).Location = location;
		((Control)_fraOpInfo_5).Name = "_fraOpInfo_5";
		((Control)_fraOpInfo_5).RightToLeft = (RightToLeft)0;
		GroupBox fraOpInfo_8 = _fraOpInfo_5;
		size = new Size(721, 409);
		((Control)fraOpInfo_8).Size = size;
		((Control)_fraOpInfo_5).TabIndex = 154;
		_fraOpInfo_5.TabStop = false;
		((Control)_fraOpInfo_5).Visible = false;
		txtMiscCRSSinfo.AcceptsReturn = true;
		((TextBoxBase)txtMiscCRSSinfo).BackColor = SystemColors.Control;
		((Control)txtMiscCRSSinfo).Cursor = Cursors.IBeam;
		((Control)txtMiscCRSSinfo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtMiscCRSSinfo).ForeColor = SystemColors.WindowText;
		TextBox obj171 = txtMiscCRSSinfo;
		location = new Point(16, 72);
		((Control)obj171).Location = location;
		((TextBoxBase)txtMiscCRSSinfo).MaxLength = 0;
		txtMiscCRSSinfo.Multiline = true;
		((Control)txtMiscCRSSinfo).Name = "txtMiscCRSSinfo";
		((TextBoxBase)txtMiscCRSSinfo).ReadOnly = true;
		((Control)txtMiscCRSSinfo).RightToLeft = (RightToLeft)0;
		txtMiscCRSSinfo.ScrollBars = (ScrollBars)2;
		TextBox obj172 = txtMiscCRSSinfo;
		size = new Size(689, 67);
		((Control)obj172).Size = size;
		((Control)txtMiscCRSSinfo).TabIndex = 300;
		txtOtherUses.AcceptsReturn = true;
		((TextBoxBase)txtOtherUses).BackColor = SystemColors.Control;
		((Control)txtOtherUses).Cursor = Cursors.IBeam;
		((Control)txtOtherUses).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtOtherUses).ForeColor = SystemColors.WindowText;
		TextBox obj173 = txtOtherUses;
		location = new Point(16, 168);
		((Control)obj173).Location = location;
		((TextBoxBase)txtOtherUses).MaxLength = 0;
		txtOtherUses.Multiline = true;
		((Control)txtOtherUses).Name = "txtOtherUses";
		((TextBoxBase)txtOtherUses).ReadOnly = true;
		((Control)txtOtherUses).RightToLeft = (RightToLeft)0;
		txtOtherUses.ScrollBars = (ScrollBars)2;
		TextBox obj174 = txtOtherUses;
		size = new Size(689, 67);
		((Control)obj174).Size = size;
		((Control)txtOtherUses).TabIndex = 155;
		((Control)_Label1_43).BackColor = SystemColors.Control;
		((Control)_Label1_43).Cursor = Cursors.Default;
		((Control)_Label1_43).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_43).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_43, (short)43);
		Label label1_101 = _Label1_43;
		location = new Point(80, 264);
		((Control)label1_101).Location = location;
		((Control)_Label1_43).Name = "_Label1_43";
		((Control)_Label1_43).RightToLeft = (RightToLeft)0;
		Label label1_102 = _Label1_43;
		size = new Size(241, 17);
		((Control)label1_102).Size = size;
		((Control)_Label1_43).TabIndex = 397;
		_Label1_43.Text = "Occupational Exposure Rating:";
		_Label1_43.TextAlign = (ContentAlignment)4;
		((Control)lblCRSSdate).BackColor = SystemColors.Control;
		lblCRSSdate.BorderStyle = (BorderStyle)2;
		((Control)lblCRSSdate).Cursor = Cursors.Default;
		((Control)lblCRSSdate).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCRSSdate).ForeColor = SystemColors.ControlText;
		Label obj175 = lblCRSSdate;
		location = new Point(80, 24);
		((Control)obj175).Location = location;
		((Control)lblCRSSdate).Name = "lblCRSSdate";
		((Control)lblCRSSdate).RightToLeft = (RightToLeft)0;
		Label obj176 = lblCRSSdate;
		size = new Size(89, 19);
		((Control)obj176).Size = size;
		((Control)lblCRSSdate).TabIndex = 301;
		((Control)_Label1_89).BackColor = SystemColors.Control;
		((Control)_Label1_89).Cursor = Cursors.Default;
		((Control)_Label1_89).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_89).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_89, (short)89);
		Label label1_103 = _Label1_89;
		location = new Point(16, 56);
		((Control)label1_103).Location = location;
		((Control)_Label1_89).Name = "_Label1_89";
		((Control)_Label1_89).RightToLeft = (RightToLeft)0;
		Label label1_104 = _Label1_89;
		size = new Size(297, 17);
		((Control)label1_104).Size = size;
		((Control)_Label1_89).TabIndex = 299;
		_Label1_89.Text = "Physical State and Misc CRSS Info:";
		((Control)_Label1_88).BackColor = SystemColors.Control;
		((Control)_Label1_88).Cursor = Cursors.Default;
		((Control)_Label1_88).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_88).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_88, (short)88);
		Label label1_105 = _Label1_88;
		location = new Point(16, 24);
		((Control)label1_105).Location = location;
		((Control)_Label1_88).Name = "_Label1_88";
		((Control)_Label1_88).RightToLeft = (RightToLeft)0;
		Label label1_106 = _Label1_88;
		size = new Size(73, 17);
		((Control)label1_106).Size = size;
		((Control)_Label1_88).TabIndex = 298;
		_Label1_88.Text = "CRSS Date:";
		((Control)lblConsUse).BackColor = SystemColors.Control;
		lblConsUse.BorderStyle = (BorderStyle)2;
		((Control)lblConsUse).Cursor = Cursors.Default;
		((Control)lblConsUse).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblConsUse).ForeColor = SystemColors.ControlText;
		Label obj177 = lblConsUse;
		location = new Point(328, 304);
		((Control)obj177).Location = location;
		((Control)lblConsUse).Name = "lblConsUse";
		((Control)lblConsUse).RightToLeft = (RightToLeft)0;
		Label obj178 = lblConsUse;
		size = new Size(33, 19);
		((Control)obj178).Size = size;
		((Control)lblConsUse).TabIndex = 166;
		((Control)lblOccExpRating).BackColor = SystemColors.Control;
		lblOccExpRating.BorderStyle = (BorderStyle)2;
		((Control)lblOccExpRating).Cursor = Cursors.Default;
		((Control)lblOccExpRating).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblOccExpRating).ForeColor = SystemColors.ControlText;
		Label obj179 = lblOccExpRating;
		location = new Point(328, 264);
		((Control)obj179).Location = location;
		((Control)lblOccExpRating).Name = "lblOccExpRating";
		((Control)lblOccExpRating).RightToLeft = (RightToLeft)0;
		Label obj180 = lblOccExpRating;
		size = new Size(33, 19);
		((Control)obj180).Size = size;
		((Control)lblOccExpRating).TabIndex = 165;
		lblOccExpRating.Text = "NR";
		((Control)_Label1_22).BackColor = SystemColors.Control;
		((Control)_Label1_22).Cursor = Cursors.Default;
		((Control)_Label1_22).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_22).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_22, (short)22);
		Label label1_107 = _Label1_22;
		location = new Point(16, 152);
		((Control)label1_107).Location = location;
		((Control)_Label1_22).Name = "_Label1_22";
		((Control)_Label1_22).RightToLeft = (RightToLeft)0;
		Label label1_108 = _Label1_22;
		size = new Size(73, 17);
		((Control)label1_108).Size = size;
		((Control)_Label1_22).TabIndex = 157;
		_Label1_22.Text = "Other Uses: ";
		((Control)_Label1_44).BackColor = SystemColors.Control;
		((Control)_Label1_44).Cursor = Cursors.Default;
		((Control)_Label1_44).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_44).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_44, (short)44);
		Label label1_109 = _Label1_44;
		location = new Point(112, 304);
		((Control)label1_109).Location = location;
		((Control)_Label1_44).Name = "_Label1_44";
		((Control)_Label1_44).RightToLeft = (RightToLeft)0;
		Label label1_110 = _Label1_44;
		size = new Size(209, 17);
		((Control)label1_110).Size = size;
		((Control)_Label1_44).TabIndex = 156;
		_Label1_44.Text = "Consumer Use:";
		_Label1_44.TextAlign = (ContentAlignment)4;
		((Control)_fraOpInfo_3).BackColor = SystemColors.Control;
		((Control)_fraOpInfo_3).Controls.Add((Control)(object)chkp2rec);
		((Control)_fraOpInfo_3).Controls.Add((Control)(object)txtP2Rec);
		((Control)_fraOpInfo_3).Controls.Add((Control)(object)txtP2Cons);
		((Control)_fraOpInfo_3).Controls.Add((Control)(object)_Label1_109);
		((Control)_fraOpInfo_3).Controls.Add((Control)(object)_Label1_108);
		((Control)_fraOpInfo_3).Controls.Add((Control)(object)_Label1_56);
		((Control)_fraOpInfo_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraOpInfo_3).ForeColor = SystemColors.ControlText;
		fraOpInfo.SetIndex(_fraOpInfo_3, (short)3);
		GroupBox fraOpInfo_9 = _fraOpInfo_3;
		location = new Point(17, 81);
		((Control)fraOpInfo_9).Location = location;
		((Control)_fraOpInfo_3).Name = "_fraOpInfo_3";
		((Control)_fraOpInfo_3).RightToLeft = (RightToLeft)0;
		GroupBox fraOpInfo_10 = _fraOpInfo_3;
		size = new Size(721, 409);
		((Control)fraOpInfo_10).Size = size;
		((Control)_fraOpInfo_3).TabIndex = 118;
		_fraOpInfo_3.TabStop = false;
		((Control)_fraOpInfo_3).Visible = false;
		((ButtonBase)chkp2rec).BackColor = SystemColors.Control;
		((Control)chkp2rec).Cursor = Cursors.Default;
		((Control)chkp2rec).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)chkp2rec).ForeColor = SystemColors.ControlText;
		CheckBox obj181 = chkp2rec;
		location = new Point(216, 200);
		((Control)obj181).Location = location;
		((Control)chkp2rec).Name = "chkp2rec";
		((Control)chkp2rec).RightToLeft = (RightToLeft)0;
		CheckBox obj182 = chkp2rec;
		size = new Size(121, 17);
		((Control)obj182).Size = size;
		((Control)chkp2rec).TabIndex = 371;
		((ButtonBase)chkp2rec).Text = "p2Rec (hidden)";
		((ButtonBase)chkp2rec).UseVisualStyleBackColor = false;
		((Control)chkp2rec).Visible = false;
		txtP2Rec.AcceptsReturn = true;
		((TextBoxBase)txtP2Rec).BackColor = SystemColors.Control;
		((Control)txtP2Rec).Cursor = Cursors.IBeam;
		((Control)txtP2Rec).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtP2Rec).ForeColor = SystemColors.WindowText;
		TextBox obj183 = txtP2Rec;
		location = new Point(16, 216);
		((Control)obj183).Location = location;
		((TextBoxBase)txtP2Rec).MaxLength = 0;
		txtP2Rec.Multiline = true;
		((Control)txtP2Rec).Name = "txtP2Rec";
		((TextBoxBase)txtP2Rec).ReadOnly = true;
		((Control)txtP2Rec).RightToLeft = (RightToLeft)0;
		txtP2Rec.ScrollBars = (ScrollBars)2;
		TextBox obj184 = txtP2Rec;
		size = new Size(681, 123);
		((Control)obj184).Size = size;
		((Control)txtP2Rec).TabIndex = 7;
		txtP2Cons.AcceptsReturn = true;
		((TextBoxBase)txtP2Cons).BackColor = SystemColors.Control;
		((Control)txtP2Cons).Cursor = Cursors.IBeam;
		((Control)txtP2Cons).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtP2Cons).ForeColor = SystemColors.WindowText;
		TextBox obj185 = txtP2Cons;
		location = new Point(16, 48);
		((Control)obj185).Location = location;
		((TextBoxBase)txtP2Cons).MaxLength = 0;
		txtP2Cons.Multiline = true;
		((Control)txtP2Cons).Name = "txtP2Cons";
		((TextBoxBase)txtP2Cons).ReadOnly = true;
		((Control)txtP2Cons).RightToLeft = (RightToLeft)0;
		txtP2Cons.ScrollBars = (ScrollBars)2;
		TextBox obj186 = txtP2Cons;
		size = new Size(681, 139);
		((Control)obj186).Size = size;
		((Control)txtP2Cons).TabIndex = 6;
		((Control)_Label1_109).BackColor = SystemColors.Control;
		((Control)_Label1_109).Cursor = Cursors.Default;
		((Control)_Label1_109).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_109).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_109, (short)109);
		Label label1_111 = _Label1_109;
		location = new Point(16, 200);
		((Control)label1_111).Location = location;
		((Control)_Label1_109).Name = "_Label1_109";
		((Control)_Label1_109).RightToLeft = (RightToLeft)0;
		Label label1_112 = _Label1_109;
		size = new Size(233, 19);
		((Control)label1_112).Size = size;
		((Control)_Label1_109).TabIndex = 364;
		_Label1_109.Text = "P2 Rec:";
		((Control)_Label1_108).BackColor = SystemColors.Control;
		((Control)_Label1_108).Cursor = Cursors.Default;
		((Control)_Label1_108).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_108).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_108, (short)108);
		Label label1_113 = _Label1_108;
		location = new Point(16, 32);
		((Control)label1_113).Location = location;
		((Control)_Label1_108).Name = "_Label1_108";
		((Control)_Label1_108).RightToLeft = (RightToLeft)0;
		Label label1_114 = _Label1_108;
		size = new Size(409, 19);
		((Control)label1_114).Size = size;
		((Control)_Label1_108).TabIndex = 363;
		_Label1_108.Text = "Optional P2 information from the submission:";
		((Control)_Label1_56).BackColor = SystemColors.ScrollBar;
		((Control)_Label1_56).Cursor = Cursors.Default;
		((Control)_Label1_56).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_56).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_56, (short)56);
		Label label1_115 = _Label1_56;
		location = new Point(240, 8);
		((Control)label1_115).Location = location;
		((Control)_Label1_56).Name = "_Label1_56";
		((Control)_Label1_56).RightToLeft = (RightToLeft)0;
		Label label1_116 = _Label1_56;
		size = new Size(177, 19);
		((Control)label1_116).Size = size;
		((Control)_Label1_56).TabIndex = 217;
		_Label1_56.Text = "p2 considerations frame";
		((Control)_Label1_56).Visible = false;
		((Control)_fraOpInfo_6).BackColor = SystemColors.Control;
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)_Label1_96);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)lblCOS);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)_Label1_102);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)lblBindingPV);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)_Label1_106);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)_Label2_13);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)_Label1_105);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)_Label1_40);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)lblDomesticSubPV);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)lblImportedSubPV);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)lblTotalSubPV);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)_Label2_12);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)_Label2_11);
		((Control)_fraOpInfo_6).Controls.Add((Control)(object)_LVE_40);
		((Control)_fraOpInfo_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraOpInfo_6).ForeColor = SystemColors.ControlText;
		fraOpInfo.SetIndex(_fraOpInfo_6, (short)6);
		GroupBox fraOpInfo_11 = _fraOpInfo_6;
		location = new Point(17, 81);
		((Control)fraOpInfo_11).Location = location;
		((Control)_fraOpInfo_6).Name = "_fraOpInfo_6";
		((Control)_fraOpInfo_6).RightToLeft = (RightToLeft)0;
		GroupBox fraOpInfo_12 = _fraOpInfo_6;
		size = new Size(721, 409);
		((Control)fraOpInfo_12).Size = size;
		((Control)_fraOpInfo_6).TabIndex = 199;
		_fraOpInfo_6.TabStop = false;
		((Control)_fraOpInfo_6).Visible = false;
		((Control)_Label1_96).BackColor = SystemColors.Control;
		((Control)_Label1_96).Cursor = Cursors.Default;
		((Control)_Label1_96).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_96).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_96, (short)96);
		Label label1_117 = _Label1_96;
		location = new Point(168, 176);
		((Control)label1_117).Location = location;
		((Control)_Label1_96).Name = "_Label1_96";
		((Control)_Label1_96).RightToLeft = (RightToLeft)0;
		Label label1_118 = _Label1_96;
		size = new Size(105, 19);
		((Control)label1_118).Size = size;
		((Control)_Label1_96).TabIndex = 368;
		_Label1_96.Text = "C.O.S.: ";
		_Label1_96.TextAlign = (ContentAlignment)4;
		((Control)lblCOS).BackColor = SystemColors.Control;
		lblCOS.BorderStyle = (BorderStyle)2;
		((Control)lblCOS).Cursor = Cursors.Default;
		((Control)lblCOS).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCOS).ForeColor = SystemColors.ControlText;
		Label obj187 = lblCOS;
		location = new Point(280, 176);
		((Control)obj187).Location = location;
		((Control)lblCOS).Name = "lblCOS";
		((Control)lblCOS).RightToLeft = (RightToLeft)0;
		Label obj188 = lblCOS;
		size = new Size(33, 19);
		((Control)obj188).Size = size;
		((Control)lblCOS).TabIndex = 367;
		((Control)_Label1_102).BackColor = SystemColors.Control;
		((Control)_Label1_102).Cursor = Cursors.Default;
		((Control)_Label1_102).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_102).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_102, (short)102);
		Label label1_119 = _Label1_102;
		location = new Point(168, 48);
		((Control)label1_119).Location = location;
		((Control)_Label1_102).Name = "_Label1_102";
		((Control)_Label1_102).RightToLeft = (RightToLeft)0;
		Label label1_120 = _Label1_102;
		size = new Size(105, 19);
		((Control)label1_120).Size = size;
		((Control)_Label1_102).TabIndex = 366;
		_Label1_102.Text = "Binding PV: ";
		_Label1_102.TextAlign = (ContentAlignment)4;
		((Control)lblBindingPV).BackColor = SystemColors.Control;
		lblBindingPV.BorderStyle = (BorderStyle)2;
		((Control)lblBindingPV).Cursor = Cursors.Default;
		((Control)lblBindingPV).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblBindingPV).ForeColor = SystemColors.ControlText;
		Label obj189 = lblBindingPV;
		location = new Point(280, 48);
		((Control)obj189).Location = location;
		((Control)lblBindingPV).Name = "lblBindingPV";
		((Control)lblBindingPV).RightToLeft = (RightToLeft)0;
		Label obj190 = lblBindingPV;
		size = new Size(33, 19);
		((Control)obj190).Size = size;
		((Control)lblBindingPV).TabIndex = 365;
		((Control)_Label1_106).BackColor = SystemColors.Control;
		((Control)_Label1_106).Cursor = Cursors.Default;
		((Control)_Label1_106).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_106).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_106, (short)106);
		Label label1_121 = _Label1_106;
		location = new Point(80, 136);
		((Control)label1_121).Location = location;
		((Control)_Label1_106).Name = "_Label1_106";
		((Control)_Label1_106).RightToLeft = (RightToLeft)0;
		Label label1_122 = _Label1_106;
		size = new Size(193, 19);
		((Control)label1_122).Size = size;
		((Control)_Label1_106).TabIndex = 362;
		_Label1_106.Text = "Total Submission Volume (SubPV):";
		_Label1_106.TextAlign = (ContentAlignment)4;
		((Control)_Label2_13).BackColor = SystemColors.Control;
		((Control)_Label2_13).Cursor = Cursors.Default;
		((Control)_Label2_13).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_13).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_13, (short)13);
		Label label2_ = _Label2_13;
		location = new Point(384, 136);
		((Control)label2_).Location = location;
		((Control)_Label2_13).Name = "_Label2_13";
		((Control)_Label2_13).RightToLeft = (RightToLeft)0;
		Label label2_2 = _Label2_13;
		size = new Size(49, 19);
		((Control)label2_2).Size = size;
		((Control)_Label2_13).TabIndex = 361;
		_Label2_13.Text = " kg/yr";
		((Control)_Label1_105).BackColor = SystemColors.Control;
		((Control)_Label1_105).Cursor = Cursors.Default;
		((Control)_Label1_105).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_105).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_105, (short)105);
		Label label1_123 = _Label1_105;
		location = new Point(40, 88);
		((Control)label1_123).Location = location;
		((Control)_Label1_105).Name = "_Label1_105";
		((Control)_Label1_105).RightToLeft = (RightToLeft)0;
		Label label1_124 = _Label1_105;
		size = new Size(233, 19);
		((Control)label1_124).Size = size;
		((Control)_Label1_105).TabIndex = 360;
		_Label1_105.Text = "Domestic Submission Volume (SubPVd):";
		_Label1_105.TextAlign = (ContentAlignment)4;
		((Control)_Label1_40).BackColor = SystemColors.Control;
		((Control)_Label1_40).Cursor = Cursors.Default;
		((Control)_Label1_40).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_40).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_40, (short)40);
		Label label1_125 = _Label1_40;
		location = new Point(19, 112);
		((Control)label1_125).Location = location;
		((Control)_Label1_40).Name = "_Label1_40";
		((Control)_Label1_40).RightToLeft = (RightToLeft)0;
		Label label1_126 = _Label1_40;
		size = new Size(254, 19);
		((Control)label1_126).Size = size;
		((Control)_Label1_40).TabIndex = 359;
		_Label1_40.Text = "Imported Submission Volume  (SubPVi):";
		_Label1_40.TextAlign = (ContentAlignment)4;
		((Control)lblDomesticSubPV).BackColor = SystemColors.Control;
		lblDomesticSubPV.BorderStyle = (BorderStyle)2;
		((Control)lblDomesticSubPV).Cursor = Cursors.Default;
		((Control)lblDomesticSubPV).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblDomesticSubPV).ForeColor = SystemColors.ControlText;
		Label obj191 = lblDomesticSubPV;
		location = new Point(280, 88);
		((Control)obj191).Location = location;
		((Control)lblDomesticSubPV).Name = "lblDomesticSubPV";
		((Control)lblDomesticSubPV).RightToLeft = (RightToLeft)0;
		Label obj192 = lblDomesticSubPV;
		size = new Size(97, 19);
		((Control)obj192).Size = size;
		((Control)lblDomesticSubPV).TabIndex = 358;
		((Control)lblImportedSubPV).BackColor = SystemColors.Control;
		lblImportedSubPV.BorderStyle = (BorderStyle)2;
		((Control)lblImportedSubPV).Cursor = Cursors.Default;
		((Control)lblImportedSubPV).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblImportedSubPV).ForeColor = SystemColors.ControlText;
		Label obj193 = lblImportedSubPV;
		location = new Point(280, 112);
		((Control)obj193).Location = location;
		((Control)lblImportedSubPV).Name = "lblImportedSubPV";
		((Control)lblImportedSubPV).RightToLeft = (RightToLeft)0;
		Label obj194 = lblImportedSubPV;
		size = new Size(97, 19);
		((Control)obj194).Size = size;
		((Control)lblImportedSubPV).TabIndex = 357;
		((Control)lblTotalSubPV).BackColor = SystemColors.Control;
		lblTotalSubPV.BorderStyle = (BorderStyle)2;
		((Control)lblTotalSubPV).Cursor = Cursors.Default;
		((Control)lblTotalSubPV).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblTotalSubPV).ForeColor = SystemColors.ControlText;
		Label obj195 = lblTotalSubPV;
		location = new Point(280, 136);
		((Control)obj195).Location = location;
		((Control)lblTotalSubPV).Name = "lblTotalSubPV";
		((Control)lblTotalSubPV).RightToLeft = (RightToLeft)0;
		Label obj196 = lblTotalSubPV;
		size = new Size(97, 19);
		((Control)obj196).Size = size;
		((Control)lblTotalSubPV).TabIndex = 356;
		((Control)_Label2_12).BackColor = SystemColors.Control;
		((Control)_Label2_12).Cursor = Cursors.Default;
		((Control)_Label2_12).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_12).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_12, (short)12);
		Label label2_3 = _Label2_12;
		location = new Point(384, 88);
		((Control)label2_3).Location = location;
		((Control)_Label2_12).Name = "_Label2_12";
		((Control)_Label2_12).RightToLeft = (RightToLeft)0;
		Label label2_4 = _Label2_12;
		size = new Size(49, 19);
		((Control)label2_4).Size = size;
		((Control)_Label2_12).TabIndex = 355;
		_Label2_12.Text = " kg/yr";
		((Control)_Label2_11).BackColor = SystemColors.Control;
		((Control)_Label2_11).Cursor = Cursors.Default;
		((Control)_Label2_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_11).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_11, (short)11);
		Label label2_5 = _Label2_11;
		location = new Point(384, 112);
		((Control)label2_5).Location = location;
		((Control)_Label2_11).Name = "_Label2_11";
		((Control)_Label2_11).RightToLeft = (RightToLeft)0;
		Label label2_6 = _Label2_11;
		size = new Size(41, 19);
		((Control)label2_6).Size = size;
		((Control)_Label2_11).TabIndex = 354;
		_Label2_11.Text = " kg/yr";
		((Control)_LVE_40).BackColor = SystemColors.Control;
		((Control)_LVE_40).Cursor = Cursors.Default;
		((Control)_LVE_40).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_LVE_40).ForeColor = SystemColors.ControlText;
		LVE.SetIndex(_LVE_40, (short)40);
		Label lVE_ = _LVE_40;
		location = new Point(176, 8);
		((Control)lVE_).Location = location;
		((Control)_LVE_40).Name = "_LVE_40";
		((Control)_LVE_40).RightToLeft = (RightToLeft)0;
		Label lVE_2 = _LVE_40;
		size = new Size(345, 17);
		((Control)lVE_2).Size = size;
		((Control)_LVE_40).TabIndex = 200;
		_LVE_40.Text = "LVE Considerations";
		_LVE_40.TextAlign = (ContentAlignment)2;
		((Control)_LVE_40).Visible = false;
		((Control)_fraOpInfo_4).BackColor = SystemColors.Control;
		((Control)_fraOpInfo_4).Controls.Add((Control)(object)txtAssumps);
		((Control)_fraOpInfo_4).Controls.Add((Control)(object)_Label1_55);
		((Control)_fraOpInfo_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraOpInfo_4).ForeColor = SystemColors.ControlText;
		fraOpInfo.SetIndex(_fraOpInfo_4, (short)4);
		GroupBox fraOpInfo_13 = _fraOpInfo_4;
		location = new Point(17, 81);
		((Control)fraOpInfo_13).Location = location;
		((Control)_fraOpInfo_4).Name = "_fraOpInfo_4";
		((Control)_fraOpInfo_4).RightToLeft = (RightToLeft)0;
		GroupBox fraOpInfo_14 = _fraOpInfo_4;
		size = new Size(721, 409);
		((Control)fraOpInfo_14).Size = size;
		((Control)_fraOpInfo_4).TabIndex = 119;
		_fraOpInfo_4.TabStop = false;
		((Control)_fraOpInfo_4).Visible = false;
		txtAssumps.AcceptsReturn = true;
		((TextBoxBase)txtAssumps).BackColor = SystemColors.Control;
		((Control)txtAssumps).Cursor = Cursors.IBeam;
		((Control)txtAssumps).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtAssumps).ForeColor = SystemColors.WindowText;
		TextBox obj197 = txtAssumps;
		location = new Point(32, 24);
		((Control)obj197).Location = location;
		((TextBoxBase)txtAssumps).MaxLength = 0;
		txtAssumps.Multiline = true;
		((Control)txtAssumps).Name = "txtAssumps";
		((TextBoxBase)txtAssumps).ReadOnly = true;
		((Control)txtAssumps).RightToLeft = (RightToLeft)0;
		txtAssumps.ScrollBars = (ScrollBars)2;
		TextBox obj198 = txtAssumps;
		size = new Size(673, 331);
		((Control)obj198).Size = size;
		((Control)txtAssumps).TabIndex = 120;
		((Control)_Label1_55).BackColor = SystemColors.ScrollBar;
		((Control)_Label1_55).Cursor = Cursors.Default;
		((Control)_Label1_55).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_55).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_55, (short)55);
		Label label1_127 = _Label1_55;
		location = new Point(232, 8);
		((Control)label1_127).Location = location;
		((Control)_Label1_55).Name = "_Label1_55";
		((Control)_Label1_55).RightToLeft = (RightToLeft)0;
		Label label1_128 = _Label1_55;
		size = new Size(177, 19);
		((Control)label1_128).Size = size;
		((Control)_Label1_55).TabIndex = 216;
		_Label1_55.Text = "assumptions frame";
		((Control)_Label1_55).Visible = false;
		((Control)_fraTab_1).BackColor = SystemColors.Control;
		((Control)_fraTab_1).Controls.Add((Control)(object)txtChemGenUse);
		((Control)_fraTab_1).Controls.Add((Control)(object)Label12);
		((Control)_fraTab_1).Controls.Add((Control)(object)Label11);
		((Control)_fraTab_1).Controls.Add((Control)(object)Label8);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_17);
		((Control)_fraTab_1).Controls.Add((Control)(object)cmdViewExpLimits);
		((Control)_fraTab_1).Controls.Add((Control)(object)cmdUpdChem);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Line3_4);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblChemQualOtherDesc);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblChemQualP2RecDR);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblChemQualP2Rec);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_101);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblChemQualOther);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblChemQualNX);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblChemQualYX);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_100);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Line3_3);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_97);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_27);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Line3_2);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Line3_1);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_19);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblMF);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_41);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblLT1000);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblLT500);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_38);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_37);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_52);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_51);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblTradeNames);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblChemCat);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_48);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label2_10);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label2_9);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblNoticeType);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblSolTemp);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblDchemTemp);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblVPTemp);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblBP);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblMP);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblSol);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblDchem);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblMW);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblVP);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblPV);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblPVi);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblPVd);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblCas);
		((Control)_fraTab_1).Controls.Add((Control)(object)lblChemName);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_42);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_39);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_16);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label2_8);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label2_7);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_28);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_23);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label2_6);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label2_2);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label2_5);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label2_4);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label2_3);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label2_1);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label2_0);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label2_22);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_20);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_18);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_15);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_14);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_3);
		((Control)_fraTab_1).Controls.Add((Control)(object)_Label1_2);
		((Control)_fraTab_1).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraTab_1).ForeColor = SystemColors.ControlText;
		fraTab.SetIndex(_fraTab_1, (short)1);
		GroupBox fraTab_9 = _fraTab_1;
		location = new Point(124, 15);
		((Control)fraTab_9).Location = location;
		((Control)_fraTab_1).Name = "_fraTab_1";
		((Control)_fraTab_1).RightToLeft = (RightToLeft)0;
		GroupBox fraTab_10 = _fraTab_1;
		size = new Size(785, 605);
		((Control)fraTab_10).Size = size;
		((Control)_fraTab_1).TabIndex = 52;
		_fraTab_1.TabStop = false;
		_fraTab_1.Text = "2. Chemical Properties";
		((Control)_fraTab_1).Visible = false;
		((Control)Label12).BackColor = SystemColors.Control;
		((Control)Label12).Cursor = Cursors.Default;
		((Control)Label12).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label12).ForeColor = Color.Red;
		Label label23 = Label12;
		location = new Point(110, 38);
		((Control)label23).Location = location;
		((Control)Label12).Name = "Label12";
		((Control)Label12).RightToLeft = (RightToLeft)0;
		Label label24 = Label12;
		size = new Size(73, 19);
		((Control)label24).Size = size;
		((Control)Label12).TabIndex = 393;
		Label12.Text = "red labeling";
		((Control)Label11).BackColor = SystemColors.Control;
		((Control)Label11).Cursor = Cursors.Default;
		((Control)Label11).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label11).ForeColor = SystemColors.ControlText;
		Label label25 = Label11;
		location = new Point(16, 23);
		((Control)label25).Location = location;
		((Control)Label11).Name = "Label11";
		((Control)Label11).RightToLeft = (RightToLeft)0;
		Label label26 = Label11;
		size = new Size(745, 34);
		((Control)label26).Size = size;
		((Control)Label11).TabIndex = 392;
		Label11.Text = componentResourceManager.GetString("Label11.Text");
		Label8.AutoSize = true;
		Label label27 = Label8;
		location = new Point(20, 530);
		((Control)label27).Location = location;
		((Control)Label8).Name = "Label8";
		Label label28 = Label8;
		size = new Size(170, 14);
		((Control)label28).Size = size;
		((Control)Label8).TabIndex = 391;
		Label8.Text = "Chemical Information Actions";
		((Control)_Label1_17).BackColor = SystemColors.Control;
		((Control)_Label1_17).Cursor = Cursors.Default;
		((Control)_Label1_17).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_17).ForeColor = Color.Red;
		Label1.SetIndex(_Label1_17, (short)17);
		Label label1_129 = _Label1_17;
		location = new Point(26, 345);
		((Control)label1_129).Location = location;
		((Control)_Label1_17).Name = "_Label1_17";
		((Control)_Label1_17).RightToLeft = (RightToLeft)0;
		Label label1_130 = _Label1_17;
		size = new Size(145, 19);
		((Control)label1_130).Size = size;
		((Control)_Label1_17).TabIndex = 57;
		_Label1_17.Text = "Molecular Weight (MW):";
		_Label1_17.TextAlign = (ContentAlignment)4;
		((ButtonBase)cmdViewExpLimits).BackColor = SystemColors.Control;
		((Control)cmdViewExpLimits).Cursor = Cursors.Default;
		((Control)cmdViewExpLimits).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdViewExpLimits).ForeColor = SystemColors.ControlText;
		Button obj199 = cmdViewExpLimits;
		location = new Point(215, 555);
		((Control)obj199).Location = location;
		((Control)cmdViewExpLimits).Name = "cmdViewExpLimits";
		((Control)cmdViewExpLimits).RightToLeft = (RightToLeft)0;
		Button obj200 = cmdViewExpLimits;
		size = new Size(177, 41);
		((Control)obj200).Size = size;
		((Control)cmdViewExpLimits).TabIndex = 30;
		((ButtonBase)cmdViewExpLimits).Text = "View &Exposure Limits";
		((ButtonBase)cmdViewExpLimits).UseVisualStyleBackColor = false;
		((ButtonBase)cmdUpdChem).BackColor = SystemColors.Control;
		((Control)cmdUpdChem).Cursor = Cursors.Default;
		((Control)cmdUpdChem).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdChem).ForeColor = SystemColors.ControlText;
		Button obj201 = cmdUpdChem;
		location = new Point(20, 555);
		((Control)obj201).Location = location;
		((Control)cmdUpdChem).Name = "cmdUpdChem";
		((Control)cmdUpdChem).RightToLeft = (RightToLeft)0;
		Button obj202 = cmdUpdChem;
		size = new Size(177, 41);
		((Control)obj202).Size = size;
		((Control)cmdUpdChem).TabIndex = 31;
		((ButtonBase)cmdUpdChem).Text = "&Update Chemical Information";
		((ButtonBase)cmdUpdChem).UseVisualStyleBackColor = false;
		((Control)_Line3_4).BackColor = SystemColors.WindowText;
		Line3.SetIndex(_Line3_4, (short)4);
		Label line3_ = _Line3_4;
		location = new Point(18, 297);
		((Control)line3_).Location = location;
		((Control)_Line3_4).Name = "_Line3_4";
		Label line3_2 = _Line3_4;
		size = new Size(744, 1);
		((Control)line3_2).Size = size;
		((Control)_Line3_4).TabIndex = 353;
		((Control)lblChemQualOtherDesc).BackColor = SystemColors.Control;
		lblChemQualOtherDesc.BorderStyle = (BorderStyle)2;
		((Control)lblChemQualOtherDesc).Cursor = Cursors.Default;
		((Control)lblChemQualOtherDesc).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblChemQualOtherDesc).ForeColor = SystemColors.ControlText;
		Label obj203 = lblChemQualOtherDesc;
		location = new Point(530, 265);
		((Control)obj203).Location = location;
		((Control)lblChemQualOtherDesc).Name = "lblChemQualOtherDesc";
		((Control)lblChemQualOtherDesc).RightToLeft = (RightToLeft)0;
		Label obj204 = lblChemQualOtherDesc;
		size = new Size(57, 19);
		((Control)obj204).Size = size;
		((Control)lblChemQualOtherDesc).TabIndex = 348;
		((Control)lblChemQualOtherDesc).Visible = false;
		((Control)lblChemQualP2RecDR).BackColor = SystemColors.Control;
		lblChemQualP2RecDR.BorderStyle = (BorderStyle)2;
		((Control)lblChemQualP2RecDR).Cursor = Cursors.Default;
		((Control)lblChemQualP2RecDR).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblChemQualP2RecDR).ForeColor = SystemColors.ControlText;
		Label obj205 = lblChemQualP2RecDR;
		location = new Point(746, 257);
		((Control)obj205).Location = location;
		((Control)lblChemQualP2RecDR).Name = "lblChemQualP2RecDR";
		((Control)lblChemQualP2RecDR).RightToLeft = (RightToLeft)0;
		Label obj206 = lblChemQualP2RecDR;
		size = new Size(33, 19);
		((Control)obj206).Size = size;
		((Control)lblChemQualP2RecDR).TabIndex = 347;
		((Control)lblChemQualP2RecDR).Visible = false;
		((Control)lblChemQualP2Rec).BackColor = SystemColors.Control;
		lblChemQualP2Rec.BorderStyle = (BorderStyle)2;
		((Control)lblChemQualP2Rec).Cursor = Cursors.Default;
		((Control)lblChemQualP2Rec).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblChemQualP2Rec).ForeColor = SystemColors.ControlText;
		Label obj207 = lblChemQualP2Rec;
		location = new Point(746, 233);
		((Control)obj207).Location = location;
		((Control)lblChemQualP2Rec).Name = "lblChemQualP2Rec";
		((Control)lblChemQualP2Rec).RightToLeft = (RightToLeft)0;
		Label obj208 = lblChemQualP2Rec;
		size = new Size(33, 19);
		((Control)obj208).Size = size;
		((Control)lblChemQualP2Rec).TabIndex = 346;
		((Control)lblChemQualP2Rec).Visible = false;
		((Control)_Label1_101).BackColor = SystemColors.Control;
		((Control)_Label1_101).Cursor = Cursors.Default;
		((Control)_Label1_101).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_101).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_101, (short)101);
		Label label1_131 = _Label1_101;
		location = new Point(682, 257);
		((Control)label1_131).Location = location;
		((Control)_Label1_101).Name = "_Label1_101";
		((Control)_Label1_101).RightToLeft = (RightToLeft)0;
		Label label1_132 = _Label1_101;
		size = new Size(65, 19);
		((Control)label1_132).Size = size;
		((Control)_Label1_101).TabIndex = 345;
		_Label1_101.Text = "P2REC-DR:";
		_Label1_101.TextAlign = (ContentAlignment)4;
		((Control)_Label1_101).Visible = false;
		((Control)lblChemQualOther).BackColor = SystemColors.Control;
		lblChemQualOther.BorderStyle = (BorderStyle)2;
		((Control)lblChemQualOther).Cursor = Cursors.Default;
		((Control)lblChemQualOther).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblChemQualOther).ForeColor = SystemColors.ControlText;
		Label obj209 = lblChemQualOther;
		location = new Point(490, 265);
		((Control)obj209).Location = location;
		((Control)lblChemQualOther).Name = "lblChemQualOther";
		((Control)lblChemQualOther).RightToLeft = (RightToLeft)0;
		Label obj210 = lblChemQualOther;
		size = new Size(33, 19);
		((Control)obj210).Size = size;
		((Control)lblChemQualOther).TabIndex = 344;
		((Control)lblChemQualOther).Visible = false;
		((Control)lblChemQualNX).BackColor = SystemColors.Control;
		lblChemQualNX.BorderStyle = (BorderStyle)2;
		((Control)lblChemQualNX).Cursor = Cursors.Default;
		((Control)lblChemQualNX).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblChemQualNX).ForeColor = SystemColors.ControlText;
		Label obj211 = lblChemQualNX;
		location = new Point(746, 209);
		((Control)obj211).Location = location;
		((Control)lblChemQualNX).Name = "lblChemQualNX";
		((Control)lblChemQualNX).RightToLeft = (RightToLeft)0;
		Label obj212 = lblChemQualNX;
		size = new Size(33, 19);
		((Control)obj212).Size = size;
		((Control)lblChemQualNX).TabIndex = 343;
		((Control)lblChemQualNX).Visible = false;
		((Control)lblChemQualYX).BackColor = SystemColors.Control;
		lblChemQualYX.BorderStyle = (BorderStyle)2;
		((Control)lblChemQualYX).Cursor = Cursors.Default;
		((Control)lblChemQualYX).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblChemQualYX).ForeColor = SystemColors.ControlText;
		Label obj213 = lblChemQualYX;
		location = new Point(746, 193);
		((Control)obj213).Location = location;
		((Control)lblChemQualYX).Name = "lblChemQualYX";
		((Control)lblChemQualYX).RightToLeft = (RightToLeft)0;
		Label obj214 = lblChemQualYX;
		size = new Size(33, 19);
		((Control)obj214).Size = size;
		((Control)lblChemQualYX).TabIndex = 342;
		((Control)lblChemQualYX).Visible = false;
		((Control)_Label1_100).BackColor = SystemColors.Control;
		((Control)_Label1_100).Cursor = Cursors.Default;
		((Control)_Label1_100).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_100).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_100, (short)100);
		Label label1_133 = _Label1_100;
		location = new Point(690, 233);
		((Control)label1_133).Location = location;
		((Control)_Label1_100).Name = "_Label1_100";
		((Control)_Label1_100).RightToLeft = (RightToLeft)0;
		Label label1_134 = _Label1_100;
		size = new Size(57, 19);
		((Control)label1_134).Size = size;
		((Control)_Label1_100).TabIndex = 341;
		_Label1_100.Text = "P2REC:";
		_Label1_100.TextAlign = (ContentAlignment)4;
		((Control)_Label1_100).Visible = false;
		((Control)_Line3_3).BackColor = SystemColors.WindowText;
		Line3.SetIndex(_Line3_3, (short)3);
		Label line3_3 = _Line3_3;
		location = new Point(18, 497);
		((Control)line3_3).Location = location;
		((Control)_Line3_3).Name = "_Line3_3";
		Label line3_4 = _Line3_3;
		size = new Size(752, 1);
		((Control)line3_4).Size = size;
		((Control)_Line3_3).TabIndex = 354;
		((Control)_Label1_97).BackColor = SystemColors.Control;
		((Control)_Label1_97).Cursor = Cursors.Default;
		((Control)_Label1_97).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_97).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_97, (short)97);
		Label label1_135 = _Label1_97;
		location = new Point(442, 265);
		((Control)label1_135).Location = location;
		((Control)_Label1_97).Name = "_Label1_97";
		((Control)_Label1_97).RightToLeft = (RightToLeft)0;
		Label label1_136 = _Label1_97;
		size = new Size(41, 19);
		((Control)label1_136).Size = size;
		((Control)_Label1_97).TabIndex = 340;
		_Label1_97.Text = "Other:";
		_Label1_97.TextAlign = (ContentAlignment)4;
		((Control)_Label1_97).Visible = false;
		((Control)_Label1_27).BackColor = SystemColors.Control;
		((Control)_Label1_27).Cursor = Cursors.Default;
		((Control)_Label1_27).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_27).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_27, (short)27);
		Label label1_137 = _Label1_27;
		location = new Point(722, 209);
		((Control)label1_137).Location = location;
		((Control)_Label1_27).Name = "_Label1_27";
		((Control)_Label1_27).RightToLeft = (RightToLeft)0;
		Label label1_138 = _Label1_27;
		size = new Size(25, 19);
		((Control)label1_138).Size = size;
		((Control)_Label1_27).TabIndex = 339;
		_Label1_27.Text = "NX:";
		_Label1_27.TextAlign = (ContentAlignment)4;
		((Control)_Label1_27).Visible = false;
		((Control)_Line3_2).BackColor = SystemColors.WindowText;
		Line3.SetIndex(_Line3_2, (short)2);
		Label line3_5 = _Line3_2;
		location = new Point(18, 185);
		((Control)line3_5).Location = location;
		((Control)_Line3_2).Name = "_Line3_2";
		Label line3_6 = _Line3_2;
		size = new Size(752, 1);
		((Control)line3_6).Size = size;
		((Control)_Line3_2).TabIndex = 355;
		((Control)_Line3_1).BackColor = SystemColors.WindowText;
		Line3.SetIndex(_Line3_1, (short)1);
		Label line3_7 = _Line3_1;
		location = new Point(18, 425);
		((Control)line3_7).Location = location;
		((Control)_Line3_1).Name = "_Line3_1";
		Label line3_8 = _Line3_1;
		size = new Size(752, 1);
		((Control)line3_8).Size = size;
		((Control)_Line3_1).TabIndex = 356;
		((Control)_Label1_19).BackColor = SystemColors.Control;
		((Control)_Label1_19).Cursor = Cursors.Default;
		((Control)_Label1_19).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_19).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_19, (short)19);
		Label label1_139 = _Label1_19;
		location = new Point(722, 192);
		((Control)label1_139).Location = location;
		((Control)_Label1_19).Name = "_Label1_19";
		((Control)_Label1_19).RightToLeft = (RightToLeft)0;
		Label label1_140 = _Label1_19;
		size = new Size(25, 19);
		((Control)label1_140).Size = size;
		((Control)_Label1_19).TabIndex = 338;
		_Label1_19.Text = "YX:";
		_Label1_19.TextAlign = (ContentAlignment)4;
		((Control)_Label1_19).Visible = false;
		((Control)lblMF).BackColor = SystemColors.Control;
		lblMF.BorderStyle = (BorderStyle)2;
		((Control)lblMF).Cursor = Cursors.Default;
		((Control)lblMF).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMF).ForeColor = SystemColors.ControlText;
		Label obj215 = lblMF;
		location = new Point(378, 161);
		((Control)obj215).Location = location;
		((Control)lblMF).Name = "lblMF";
		((Control)lblMF).RightToLeft = (RightToLeft)0;
		Label obj216 = lblMF;
		size = new Size(393, 17);
		((Control)obj216).Size = size;
		((Control)lblMF).TabIndex = 209;
		((Control)_Label1_41).BackColor = SystemColors.Control;
		((Control)_Label1_41).Cursor = Cursors.Default;
		((Control)_Label1_41).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_41).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_41, (short)41);
		Label label1_141 = _Label1_41;
		location = new Point(250, 161);
		((Control)label1_141).Location = location;
		((Control)_Label1_41).Name = "_Label1_41";
		((Control)_Label1_41).RightToLeft = (RightToLeft)0;
		Label label1_142 = _Label1_41;
		size = new Size(121, 19);
		((Control)label1_142).Size = size;
		((Control)_Label1_41).TabIndex = 208;
		_Label1_41.Text = "Molecular Formula:";
		_Label1_41.TextAlign = (ContentAlignment)4;
		((Control)lblLT1000).BackColor = SystemColors.Control;
		lblLT1000.BorderStyle = (BorderStyle)2;
		((Control)lblLT1000).Cursor = Cursors.Default;
		((Control)lblLT1000).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblLT1000).ForeColor = SystemColors.ControlText;
		Label obj217 = lblLT1000;
		location = new Point(522, 345);
		((Control)obj217).Location = location;
		((Control)lblLT1000).Name = "lblLT1000";
		((Control)lblLT1000).RightToLeft = (RightToLeft)0;
		Label obj218 = lblLT1000;
		size = new Size(49, 19);
		((Control)obj218).Size = size;
		((Control)lblLT1000).TabIndex = 207;
		((Control)lblLT500).BackColor = SystemColors.Control;
		lblLT500.BorderStyle = (BorderStyle)2;
		((Control)lblLT500).Cursor = Cursors.Default;
		((Control)lblLT500).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblLT500).ForeColor = SystemColors.ControlText;
		Label obj219 = lblLT500;
		location = new Point(394, 345);
		((Control)obj219).Location = location;
		((Control)lblLT500).Name = "lblLT500";
		((Control)lblLT500).RightToLeft = (RightToLeft)0;
		Label obj220 = lblLT500;
		size = new Size(49, 19);
		((Control)obj220).Size = size;
		((Control)lblLT500).TabIndex = 206;
		((Control)_Label1_38).BackColor = SystemColors.Control;
		((Control)_Label1_38).Cursor = Cursors.Default;
		((Control)_Label1_38).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_38).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_38, (short)38);
		Label label1_143 = _Label1_38;
		location = new Point(458, 345);
		((Control)label1_143).Location = location;
		((Control)_Label1_38).Name = "_Label1_38";
		((Control)_Label1_38).RightToLeft = (RightToLeft)0;
		Label label1_144 = _Label1_38;
		size = new Size(57, 19);
		((Control)label1_144).Size = size;
		((Control)_Label1_38).TabIndex = 205;
		_Label1_38.Text = "% < 1000:";
		_Label1_38.TextAlign = (ContentAlignment)4;
		((Control)_Label1_37).BackColor = SystemColors.Control;
		((Control)_Label1_37).Cursor = Cursors.Default;
		((Control)_Label1_37).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_37).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_37, (short)37);
		Label label1_145 = _Label1_37;
		location = new Point(330, 345);
		((Control)label1_145).Location = location;
		((Control)_Label1_37).Name = "_Label1_37";
		((Control)_Label1_37).RightToLeft = (RightToLeft)0;
		Label label1_146 = _Label1_37;
		size = new Size(57, 19);
		((Control)label1_146).Size = size;
		((Control)_Label1_37).TabIndex = 204;
		_Label1_37.Text = "% < 500:";
		_Label1_37.TextAlign = (ContentAlignment)4;
		((Control)_Label1_52).BackColor = SystemColors.Control;
		((Control)_Label1_52).Cursor = Cursors.Default;
		((Control)_Label1_52).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_52).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_52, (short)52);
		Label label1_147 = _Label1_52;
		location = new Point(18, 433);
		((Control)label1_147).Location = location;
		((Control)_Label1_52).Name = "_Label1_52";
		((Control)_Label1_52).RightToLeft = (RightToLeft)0;
		Label label1_148 = _Label1_52;
		size = new Size(81, 51);
		((Control)label1_148).Size = size;
		((Control)_Label1_52).TabIndex = 192;
		_Label1_52.Text = "General Description of End Use(s):";
		_Label1_52.TextAlign = (ContentAlignment)4;
		((Control)_Label1_51).BackColor = SystemColors.Control;
		((Control)_Label1_51).Cursor = Cursors.Default;
		((Control)_Label1_51).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_51).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_51, (short)51);
		Label label1_149 = _Label1_51;
		location = new Point(23, 137);
		((Control)label1_149).Location = location;
		((Control)_Label1_51).Name = "_Label1_51";
		((Control)_Label1_51).RightToLeft = (RightToLeft)0;
		Label label1_150 = _Label1_51;
		size = new Size(113, 19);
		((Control)label1_150).Size = size;
		((Control)_Label1_51).TabIndex = 177;
		_Label1_51.Text = "Trade Name(s):";
		_Label1_51.TextAlign = (ContentAlignment)4;
		((Control)lblTradeNames).BackColor = SystemColors.Control;
		lblTradeNames.BorderStyle = (BorderStyle)2;
		((Control)lblTradeNames).Cursor = Cursors.Default;
		((Control)lblTradeNames).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblTradeNames).ForeColor = SystemColors.ControlText;
		Label obj221 = lblTradeNames;
		location = new Point(144, 137);
		((Control)obj221).Location = location;
		((Control)lblTradeNames).Name = "lblTradeNames";
		((Control)lblTradeNames).RightToLeft = (RightToLeft)0;
		Label obj222 = lblTradeNames;
		size = new Size(627, 17);
		((Control)obj222).Size = size;
		((Control)lblTradeNames).TabIndex = 176;
		((Control)lblChemCat).BackColor = SystemColors.Control;
		lblChemCat.BorderStyle = (BorderStyle)2;
		((Control)lblChemCat).Cursor = Cursors.Default;
		((Control)lblChemCat).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblChemCat).ForeColor = SystemColors.ControlText;
		Label obj223 = lblChemCat;
		location = new Point(144, 113);
		((Control)obj223).Location = location;
		((Control)lblChemCat).Name = "lblChemCat";
		((Control)lblChemCat).RightToLeft = (RightToLeft)0;
		Label obj224 = lblChemCat;
		size = new Size(627, 17);
		((Control)obj224).Size = size;
		((Control)lblChemCat).TabIndex = 175;
		((Control)_Label1_48).BackColor = SystemColors.Control;
		((Control)_Label1_48).Cursor = Cursors.Default;
		((Control)_Label1_48).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_48).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_48, (short)48);
		Label label1_151 = _Label1_48;
		location = new Point(23, 113);
		((Control)label1_151).Location = location;
		((Control)_Label1_48).Name = "_Label1_48";
		((Control)_Label1_48).RightToLeft = (RightToLeft)0;
		Label label1_152 = _Label1_48;
		size = new Size(113, 19);
		((Control)label1_152).Size = size;
		((Control)_Label1_48).TabIndex = 174;
		_Label1_48.Text = "Chemical Category:";
		_Label1_48.TextAlign = (ContentAlignment)4;
		((Control)_Label2_10).BackColor = SystemColors.Control;
		((Control)_Label2_10).Cursor = Cursors.Default;
		((Control)_Label2_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_10).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_10, (short)10);
		Label label2_7 = _Label2_10;
		location = new Point(338, 216);
		((Control)label2_7).Location = location;
		((Control)_Label2_10).Name = "_Label2_10";
		((Control)_Label2_10).RightToLeft = (RightToLeft)0;
		Label label2_8 = _Label2_10;
		size = new Size(41, 19);
		((Control)label2_8).Size = size;
		((Control)_Label2_10).TabIndex = 173;
		_Label2_10.Text = " kg/yr";
		((Control)_Label2_9).BackColor = SystemColors.Control;
		((Control)_Label2_9).Cursor = Cursors.Default;
		((Control)_Label2_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_9).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_9, (short)9);
		Label label2_9 = _Label2_9;
		location = new Point(338, 240);
		((Control)label2_9).Location = location;
		((Control)_Label2_9).Name = "_Label2_9";
		((Control)_Label2_9).RightToLeft = (RightToLeft)0;
		Label label2_10 = _Label2_9;
		size = new Size(49, 19);
		((Control)label2_10).Size = size;
		((Control)_Label2_9).TabIndex = 172;
		_Label2_9.Text = " kg/yr";
		((Control)lblNoticeType).BackColor = SystemColors.Control;
		lblNoticeType.BorderStyle = (BorderStyle)2;
		((Control)lblNoticeType).Cursor = Cursors.Default;
		((Control)lblNoticeType).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblNoticeType).ForeColor = SystemColors.ControlText;
		Label obj225 = lblNoticeType;
		location = new Point(234, 264);
		((Control)obj225).Location = location;
		((Control)lblNoticeType).Name = "lblNoticeType";
		((Control)lblNoticeType).RightToLeft = (RightToLeft)0;
		Label obj226 = lblNoticeType;
		size = new Size(169, 19);
		((Control)obj226).Size = size;
		((Control)lblNoticeType).TabIndex = 153;
		((Control)lblSolTemp).BackColor = SystemColors.Control;
		lblSolTemp.BorderStyle = (BorderStyle)2;
		((Control)lblSolTemp).Cursor = Cursors.Default;
		((Control)lblSolTemp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSolTemp).ForeColor = SystemColors.ControlText;
		Label obj227 = lblSolTemp;
		location = new Point(322, 393);
		((Control)obj227).Location = location;
		((Control)lblSolTemp).Name = "lblSolTemp";
		((Control)lblSolTemp).RightToLeft = (RightToLeft)0;
		Label obj228 = lblSolTemp;
		size = new Size(41, 19);
		((Control)obj228).Size = size;
		((Control)lblSolTemp).TabIndex = 152;
		((Control)lblDchemTemp).BackColor = SystemColors.Control;
		lblDchemTemp.BorderStyle = (BorderStyle)2;
		((Control)lblDchemTemp).Cursor = Cursors.Default;
		((Control)lblDchemTemp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblDchemTemp).ForeColor = SystemColors.ControlText;
		Label obj229 = lblDchemTemp;
		location = new Point(338, 369);
		((Control)obj229).Location = location;
		((Control)lblDchemTemp).Name = "lblDchemTemp";
		((Control)lblDchemTemp).RightToLeft = (RightToLeft)0;
		Label obj230 = lblDchemTemp;
		size = new Size(41, 19);
		((Control)obj230).Size = size;
		((Control)lblDchemTemp).TabIndex = 151;
		((Control)lblVPTemp).BackColor = SystemColors.Control;
		lblVPTemp.BorderStyle = (BorderStyle)2;
		((Control)lblVPTemp).Cursor = Cursors.Default;
		((Control)lblVPTemp).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblVPTemp).ForeColor = SystemColors.ControlText;
		Label obj231 = lblVPTemp;
		location = new Point(322, 321);
		((Control)obj231).Location = location;
		((Control)lblVPTemp).Name = "lblVPTemp";
		((Control)lblVPTemp).RightToLeft = (RightToLeft)0;
		Label obj232 = lblVPTemp;
		size = new Size(41, 19);
		((Control)obj232).Size = size;
		((Control)lblVPTemp).TabIndex = 150;
		((Control)lblBP).BackColor = SystemColors.Control;
		lblBP.BorderStyle = (BorderStyle)2;
		((Control)lblBP).Cursor = Cursors.Default;
		((Control)lblBP).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblBP).ForeColor = SystemColors.ControlText;
		Label obj233 = lblBP;
		location = new Point(698, 329);
		((Control)obj233).Location = location;
		((Control)lblBP).Name = "lblBP";
		((Control)lblBP).RightToLeft = (RightToLeft)0;
		Label obj234 = lblBP;
		size = new Size(57, 19);
		((Control)obj234).Size = size;
		((Control)lblBP).TabIndex = 149;
		((Control)lblBP).Visible = false;
		((Control)lblMP).BackColor = SystemColors.Control;
		lblMP.BorderStyle = (BorderStyle)2;
		((Control)lblMP).Cursor = Cursors.Default;
		((Control)lblMP).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMP).ForeColor = SystemColors.ControlText;
		Label obj235 = lblMP;
		location = new Point(698, 305);
		((Control)obj235).Location = location;
		((Control)lblMP).Name = "lblMP";
		((Control)lblMP).RightToLeft = (RightToLeft)0;
		Label obj236 = lblMP;
		size = new Size(57, 19);
		((Control)obj236).Size = size;
		((Control)lblMP).TabIndex = 148;
		((Control)lblMP).Visible = false;
		((Control)lblSol).BackColor = SystemColors.Control;
		lblSol.BorderStyle = (BorderStyle)2;
		((Control)lblSol).Cursor = Cursors.Default;
		((Control)lblSol).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblSol).ForeColor = SystemColors.ControlText;
		Label obj237 = lblSol;
		location = new Point(178, 393);
		((Control)obj237).Location = location;
		((Control)lblSol).Name = "lblSol";
		((Control)lblSol).RightToLeft = (RightToLeft)0;
		Label obj238 = lblSol;
		size = new Size(97, 19);
		((Control)obj238).Size = size;
		((Control)lblSol).TabIndex = 147;
		((Control)lblDchem).BackColor = SystemColors.Control;
		lblDchem.BorderStyle = (BorderStyle)2;
		((Control)lblDchem).Cursor = Cursors.Default;
		((Control)lblDchem).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblDchem).ForeColor = SystemColors.ControlText;
		Label obj239 = lblDchem;
		location = new Point(178, 369);
		((Control)obj239).Location = location;
		((Control)lblDchem).Name = "lblDchem";
		((Control)lblDchem).RightToLeft = (RightToLeft)0;
		Label obj240 = lblDchem;
		size = new Size(97, 19);
		((Control)obj240).Size = size;
		((Control)lblDchem).TabIndex = 146;
		((Control)lblMW).BackColor = SystemColors.Control;
		lblMW.BorderStyle = (BorderStyle)2;
		((Control)lblMW).Cursor = Cursors.Default;
		((Control)lblMW).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblMW).ForeColor = SystemColors.ControlText;
		Label obj241 = lblMW;
		location = new Point(178, 345);
		((Control)obj241).Location = location;
		((Control)lblMW).Name = "lblMW";
		((Control)lblMW).RightToLeft = (RightToLeft)0;
		Label obj242 = lblMW;
		size = new Size(97, 19);
		((Control)obj242).Size = size;
		((Control)lblMW).TabIndex = 145;
		((Control)lblVP).BackColor = SystemColors.Control;
		lblVP.BorderStyle = (BorderStyle)2;
		((Control)lblVP).Cursor = Cursors.Default;
		((Control)lblVP).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblVP).ForeColor = SystemColors.ControlText;
		Label obj243 = lblVP;
		location = new Point(178, 321);
		((Control)obj243).Location = location;
		((Control)lblVP).Name = "lblVP";
		((Control)lblVP).RightToLeft = (RightToLeft)0;
		Label obj244 = lblVP;
		size = new Size(97, 19);
		((Control)obj244).Size = size;
		((Control)lblVP).TabIndex = 144;
		((Control)lblPV).BackColor = SystemColors.Control;
		lblPV.BorderStyle = (BorderStyle)2;
		((Control)lblPV).Cursor = Cursors.Default;
		((Control)lblPV).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblPV).ForeColor = SystemColors.ControlText;
		Label obj245 = lblPV;
		location = new Point(226, 192);
		((Control)obj245).Location = location;
		((Control)lblPV).Name = "lblPV";
		((Control)lblPV).RightToLeft = (RightToLeft)0;
		Label obj246 = lblPV;
		size = new Size(97, 19);
		((Control)obj246).Size = size;
		((Control)lblPV).TabIndex = 143;
		((Control)lblPVi).BackColor = SystemColors.Control;
		lblPVi.BorderStyle = (BorderStyle)2;
		((Control)lblPVi).Cursor = Cursors.Default;
		((Control)lblPVi).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblPVi).ForeColor = SystemColors.ControlText;
		Label obj247 = lblPVi;
		location = new Point(234, 216);
		((Control)obj247).Location = location;
		((Control)lblPVi).Name = "lblPVi";
		((Control)lblPVi).RightToLeft = (RightToLeft)0;
		Label obj248 = lblPVi;
		size = new Size(97, 19);
		((Control)obj248).Size = size;
		((Control)lblPVi).TabIndex = 142;
		((Control)lblPVd).BackColor = SystemColors.Control;
		lblPVd.BorderStyle = (BorderStyle)2;
		((Control)lblPVd).Cursor = Cursors.Default;
		((Control)lblPVd).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblPVd).ForeColor = SystemColors.ControlText;
		Label obj249 = lblPVd;
		location = new Point(234, 240);
		((Control)obj249).Location = location;
		((Control)lblPVd).Name = "lblPVd";
		((Control)lblPVd).RightToLeft = (RightToLeft)0;
		Label obj250 = lblPVd;
		size = new Size(97, 19);
		((Control)obj250).Size = size;
		((Control)lblPVd).TabIndex = 141;
		((Control)lblCas).BackColor = SystemColors.Control;
		lblCas.BorderStyle = (BorderStyle)2;
		((Control)lblCas).Cursor = Cursors.Default;
		((Control)lblCas).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCas).ForeColor = SystemColors.ControlText;
		Label obj251 = lblCas;
		location = new Point(144, 161);
		((Control)obj251).Location = location;
		((Control)lblCas).Name = "lblCas";
		((Control)lblCas).RightToLeft = (RightToLeft)0;
		Label obj252 = lblCas;
		size = new Size(97, 17);
		((Control)obj252).Size = size;
		((Control)lblCas).TabIndex = 140;
		((Control)lblChemName).BackColor = SystemColors.Control;
		lblChemName.BorderStyle = (BorderStyle)2;
		((Control)lblChemName).Cursor = Cursors.Default;
		((Control)lblChemName).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblChemName).ForeColor = SystemColors.ControlText;
		Label obj253 = lblChemName;
		location = new Point(144, 89);
		((Control)obj253).Location = location;
		((Control)lblChemName).Name = "lblChemName";
		((Control)lblChemName).RightToLeft = (RightToLeft)0;
		Label obj254 = lblChemName;
		size = new Size(627, 17);
		((Control)obj254).Size = size;
		((Control)lblChemName).TabIndex = 139;
		((Control)_Label1_42).BackColor = SystemColors.Control;
		((Control)_Label1_42).Cursor = Cursors.Default;
		((Control)_Label1_42).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_42).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_42, (short)42);
		Label label1_153 = _Label1_42;
		location = new Point(10, 217);
		((Control)label1_153).Location = location;
		((Control)_Label1_42).Name = "_Label1_42";
		((Control)_Label1_42).RightToLeft = (RightToLeft)0;
		Label label1_154 = _Label1_42;
		size = new Size(225, 19);
		((Control)label1_154).Size = size;
		((Control)_Label1_42).TabIndex = 138;
		_Label1_42.Text = "Imported Production Volume  (PVi):";
		_Label1_42.TextAlign = (ContentAlignment)4;
		((Control)_Label1_39).BackColor = SystemColors.Control;
		((Control)_Label1_39).Cursor = Cursors.Default;
		((Control)_Label1_39).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_39).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_39, (short)39);
		Label label1_155 = _Label1_39;
		location = new Point(21, 241);
		((Control)label1_155).Location = location;
		((Control)_Label1_39).Name = "_Label1_39";
		((Control)_Label1_39).RightToLeft = (RightToLeft)0;
		Label label1_156 = _Label1_39;
		size = new Size(214, 19);
		((Control)label1_156).Size = size;
		((Control)_Label1_39).TabIndex = 137;
		_Label1_39.Text = "Domestic Production Volume (PVd):";
		_Label1_39.TextAlign = (ContentAlignment)4;
		((Control)_Label1_16).BackColor = SystemColors.Control;
		((Control)_Label1_16).Cursor = Cursors.Default;
		((Control)_Label1_16).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_16).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_16, (short)16);
		Label label1_157 = _Label1_16;
		location = new Point(138, 265);
		((Control)label1_157).Location = location;
		((Control)_Label1_16).Name = "_Label1_16";
		((Control)_Label1_16).RightToLeft = (RightToLeft)0;
		Label label1_158 = _Label1_16;
		size = new Size(97, 19);
		((Control)label1_158).Size = size;
		((Control)_Label1_16).TabIndex = 104;
		_Label1_16.Text = "Type of Notice:";
		_Label1_16.TextAlign = (ContentAlignment)4;
		((Control)_Label2_8).BackColor = SystemColors.Control;
		((Control)_Label2_8).Cursor = Cursors.Default;
		((Control)_Label2_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_8).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_8, (short)8);
		Label label2_11 = _Label2_8;
		location = new Point(754, 323);
		((Control)label2_11).Location = location;
		((Control)_Label2_8).Name = "_Label2_8";
		((Control)_Label2_8).RightToLeft = (RightToLeft)0;
		Label label2_12 = _Label2_8;
		size = new Size(17, 19);
		((Control)label2_12).Size = size;
		((Control)_Label2_8).TabIndex = 90;
		_Label2_8.Text = " C";
		((Control)_Label2_8).Visible = false;
		((Control)_Label2_7).BackColor = SystemColors.Control;
		((Control)_Label2_7).Cursor = Cursors.Default;
		((Control)_Label2_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_7).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_7, (short)7);
		Label label2_13 = _Label2_7;
		location = new Point(754, 298);
		((Control)label2_13).Location = location;
		((Control)_Label2_7).Name = "_Label2_7";
		((Control)_Label2_7).RightToLeft = (RightToLeft)0;
		Label label2_14 = _Label2_7;
		size = new Size(17, 19);
		((Control)label2_14).Size = size;
		((Control)_Label2_7).TabIndex = 89;
		_Label2_7.Text = " C";
		((Control)_Label2_7).Visible = false;
		((Control)_Label1_28).BackColor = SystemColors.Control;
		((Control)_Label1_28).Cursor = Cursors.Default;
		((Control)_Label1_28).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_28).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_28, (short)28);
		Label label1_159 = _Label1_28;
		location = new Point(602, 329);
		((Control)label1_159).Location = location;
		((Control)_Label1_28).Name = "_Label1_28";
		((Control)_Label1_28).RightToLeft = (RightToLeft)0;
		Label label1_160 = _Label1_28;
		size = new Size(97, 19);
		((Control)label1_160).Size = size;
		((Control)_Label1_28).TabIndex = 88;
		_Label1_28.Text = "Boiling Point (BP): ";
		_Label1_28.TextAlign = (ContentAlignment)4;
		((Control)_Label1_28).Visible = false;
		((Control)_Label1_23).BackColor = SystemColors.Control;
		((Control)_Label1_23).Cursor = Cursors.Default;
		((Control)_Label1_23).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_23).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_23, (short)23);
		Label label1_161 = _Label1_23;
		location = new Point(594, 305);
		((Control)label1_161).Location = location;
		((Control)_Label1_23).Name = "_Label1_23";
		((Control)_Label1_23).RightToLeft = (RightToLeft)0;
		Label label1_162 = _Label1_23;
		size = new Size(105, 19);
		((Control)label1_162).Size = size;
		((Control)_Label1_23).TabIndex = 87;
		_Label1_23.Text = "Melting Point (MP): ";
		_Label1_23.TextAlign = (ContentAlignment)4;
		((Control)_Label1_23).Visible = false;
		((Control)_Label2_6).BackColor = SystemColors.Control;
		((Control)_Label2_6).Cursor = Cursors.Default;
		((Control)_Label2_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_6).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_6, (short)6);
		Label label2_15 = _Label2_6;
		location = new Point(362, 321);
		((Control)label2_15).Location = location;
		((Control)_Label2_6).Name = "_Label2_6";
		((Control)_Label2_6).RightToLeft = (RightToLeft)0;
		Label label2_16 = _Label2_6;
		size = new Size(17, 19);
		((Control)label2_16).Size = size;
		((Control)_Label2_6).TabIndex = 75;
		_Label2_6.Text = " C";
		((Control)_Label2_2).BackColor = SystemColors.Control;
		((Control)_Label2_2).Cursor = Cursors.Default;
		((Control)_Label2_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_2).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_2, (short)2);
		Label label2_17 = _Label2_2;
		location = new Point(378, 369);
		((Control)label2_17).Location = location;
		((Control)_Label2_2).Name = "_Label2_2";
		((Control)_Label2_2).RightToLeft = (RightToLeft)0;
		Label label2_18 = _Label2_2;
		size = new Size(17, 19);
		((Control)label2_18).Size = size;
		((Control)_Label2_2).TabIndex = 74;
		_Label2_2.Text = " C";
		((Control)_Label2_5).BackColor = SystemColors.Control;
		((Control)_Label2_5).Cursor = Cursors.Default;
		((Control)_Label2_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_5).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_5, (short)5);
		Label label2_19 = _Label2_5;
		location = new Point(282, 393);
		((Control)label2_19).Location = location;
		((Control)_Label2_5).Name = "_Label2_5";
		((Control)_Label2_5).RightToLeft = (RightToLeft)0;
		Label label2_20 = _Label2_5;
		size = new Size(41, 19);
		((Control)label2_20).Size = size;
		((Control)_Label2_5).TabIndex = 65;
		_Label2_5.Text = " g/L at";
		((Control)_Label2_4).BackColor = SystemColors.Control;
		((Control)_Label2_4).Cursor = Cursors.Default;
		((Control)_Label2_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_4).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_4, (short)4);
		Label label2_21 = _Label2_4;
		location = new Point(282, 369);
		((Control)label2_21).Location = location;
		((Control)_Label2_4).Name = "_Label2_4";
		((Control)_Label2_4).RightToLeft = (RightToLeft)0;
		Label label2_22 = _Label2_4;
		size = new Size(49, 19);
		((Control)label2_22).Size = size;
		((Control)_Label2_4).TabIndex = 64;
		_Label2_4.Text = " g/cm3 at";
		((Control)_Label2_3).BackColor = SystemColors.Control;
		((Control)_Label2_3).Cursor = Cursors.Default;
		((Control)_Label2_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_3).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_3, (short)3);
		Label label2_23 = _Label2_3;
		location = new Point(362, 391);
		((Control)label2_23).Location = location;
		((Control)_Label2_3).Name = "_Label2_3";
		((Control)_Label2_3).RightToLeft = (RightToLeft)0;
		Label label2_24 = _Label2_3;
		size = new Size(17, 19);
		((Control)label2_24).Size = size;
		((Control)_Label2_3).TabIndex = 63;
		_Label2_3.Text = " C";
		((Control)_Label2_1).BackColor = SystemColors.Control;
		((Control)_Label2_1).Cursor = Cursors.Default;
		((Control)_Label2_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_1).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_1, (short)1);
		Label label2_25 = _Label2_1;
		location = new Point(282, 345);
		((Control)label2_25).Location = location;
		((Control)_Label2_1).Name = "_Label2_1";
		((Control)_Label2_1).RightToLeft = (RightToLeft)0;
		Label label2_26 = _Label2_1;
		size = new Size(41, 19);
		((Control)label2_26).Size = size;
		((Control)_Label2_1).TabIndex = 62;
		_Label2_1.Text = " g/mol";
		((Control)_Label2_0).BackColor = SystemColors.Control;
		((Control)_Label2_0).Cursor = Cursors.Default;
		((Control)_Label2_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_0).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_0, (short)0);
		Label label2_27 = _Label2_0;
		location = new Point(282, 321);
		((Control)label2_27).Location = location;
		((Control)_Label2_0).Name = "_Label2_0";
		((Control)_Label2_0).RightToLeft = (RightToLeft)0;
		Label label2_28 = _Label2_0;
		size = new Size(41, 19);
		((Control)label2_28).Size = size;
		((Control)_Label2_0).TabIndex = 61;
		_Label2_0.Text = " torr at";
		((Control)_Label2_22).BackColor = SystemColors.Control;
		((Control)_Label2_22).Cursor = Cursors.Default;
		((Control)_Label2_22).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label2_22).ForeColor = SystemColors.WindowText;
		Label2.SetIndex(_Label2_22, (short)22);
		Label label2_29 = _Label2_22;
		location = new Point(322, 192);
		((Control)label2_29).Location = location;
		((Control)_Label2_22).Name = "_Label2_22";
		((Control)_Label2_22).RightToLeft = (RightToLeft)0;
		Label label2_30 = _Label2_22;
		size = new Size(49, 19);
		((Control)label2_30).Size = size;
		((Control)_Label2_22).TabIndex = 60;
		_Label2_22.Text = " kg/yr";
		((Control)_Label1_20).BackColor = SystemColors.Control;
		((Control)_Label1_20).Cursor = Cursors.Default;
		((Control)_Label1_20).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_20).ForeColor = Color.Red;
		Label1.SetIndex(_Label1_20, (short)20);
		Label label1_163 = _Label1_20;
		location = new Point(18, 393);
		((Control)label1_163).Location = location;
		((Control)_Label1_20).Name = "_Label1_20";
		((Control)_Label1_20).RightToLeft = (RightToLeft)0;
		Label label1_164 = _Label1_20;
		size = new Size(153, 19);
		((Control)label1_164).Size = size;
		((Control)_Label1_20).TabIndex = 59;
		_Label1_20.Text = "Solubility in Water (WSchem):";
		_Label1_20.TextAlign = (ContentAlignment)4;
		((Control)_Label1_18).BackColor = SystemColors.Control;
		((Control)_Label1_18).Cursor = Cursors.Default;
		((Control)_Label1_18).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_18).ForeColor = Color.Red;
		Label1.SetIndex(_Label1_18, (short)18);
		Label label1_165 = _Label1_18;
		location = new Point(18, 369);
		((Control)label1_165).Location = location;
		((Control)_Label1_18).Name = "_Label1_18";
		((Control)_Label1_18).RightToLeft = (RightToLeft)0;
		Label label1_166 = _Label1_18;
		size = new Size(153, 19);
		((Control)label1_166).Size = size;
		((Control)_Label1_18).TabIndex = 58;
		_Label1_18.Text = "Density (Dchem):";
		_Label1_18.TextAlign = (ContentAlignment)4;
		((Control)_Label1_15).BackColor = SystemColors.Control;
		((Control)_Label1_15).Cursor = Cursors.Default;
		((Control)_Label1_15).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_15).ForeColor = Color.Red;
		Label1.SetIndex(_Label1_15, (short)15);
		Label label1_167 = _Label1_15;
		location = new Point(26, 321);
		((Control)label1_167).Location = location;
		((Control)_Label1_15).Name = "_Label1_15";
		((Control)_Label1_15).RightToLeft = (RightToLeft)0;
		Label label1_168 = _Label1_15;
		size = new Size(145, 19);
		((Control)label1_168).Size = size;
		((Control)_Label1_15).TabIndex = 56;
		_Label1_15.Text = "Vapor Pressure (VPchem):";
		_Label1_15.TextAlign = (ContentAlignment)4;
		((Control)_Label1_14).BackColor = SystemColors.Control;
		((Control)_Label1_14).Cursor = Cursors.Default;
		((Control)_Label1_14).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_14).ForeColor = Color.Red;
		Label1.SetIndex(_Label1_14, (short)14);
		Label label1_169 = _Label1_14;
		location = new Point(5, 193);
		((Control)label1_169).Location = location;
		((Control)_Label1_14).Name = "_Label1_14";
		((Control)_Label1_14).RightToLeft = (RightToLeft)0;
		Label label1_170 = _Label1_14;
		size = new Size(222, 19);
		((Control)label1_170).Size = size;
		((Control)_Label1_14).TabIndex = 55;
		_Label1_14.Text = "Total Assessed Production Volume (PV):";
		_Label1_14.TextAlign = (ContentAlignment)4;
		((Control)_Label1_3).BackColor = SystemColors.Control;
		((Control)_Label1_3).Cursor = Cursors.Default;
		((Control)_Label1_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_3).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_3, (short)3);
		Label label1_171 = _Label1_3;
		location = new Point(16, 161);
		((Control)label1_171).Location = location;
		((Control)_Label1_3).Name = "_Label1_3";
		((Control)_Label1_3).RightToLeft = (RightToLeft)0;
		Label label1_172 = _Label1_3;
		size = new Size(121, 19);
		((Control)label1_172).Size = size;
		((Control)_Label1_3).TabIndex = 54;
		_Label1_3.Text = "Chemical CAS Number:";
		_Label1_3.TextAlign = (ContentAlignment)4;
		((Control)_Label1_2).BackColor = SystemColors.Control;
		((Control)_Label1_2).Cursor = Cursors.Default;
		((Control)_Label1_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_2).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_2, (short)2);
		Label label1_173 = _Label1_2;
		location = new Point(39, 89);
		((Control)label1_173).Location = location;
		((Control)_Label1_2).Name = "_Label1_2";
		((Control)_Label1_2).RightToLeft = (RightToLeft)0;
		Label label1_174 = _Label1_2;
		size = new Size(97, 19);
		((Control)label1_174).Size = size;
		((Control)_Label1_2).TabIndex = 53;
		_Label1_2.Text = "Chemical Name:";
		_Label1_2.TextAlign = (ContentAlignment)4;
		((ButtonBase)cmdChemRegLimits).BackColor = SystemColors.InactiveCaption;
		((Control)cmdChemRegLimits).Cursor = Cursors.Default;
		((Control)cmdChemRegLimits).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdChemRegLimits).ForeColor = SystemColors.ControlText;
		Button obj255 = cmdChemRegLimits;
		location = new Point(807, 580);
		((Control)obj255).Location = location;
		((Control)cmdChemRegLimits).Name = "cmdChemRegLimits";
		((Control)cmdChemRegLimits).RightToLeft = (RightToLeft)0;
		Button obj256 = cmdChemRegLimits;
		size = new Size(177, 21);
		((Control)obj256).Size = size;
		((Control)cmdChemRegLimits).TabIndex = 32;
		((ButtonBase)cmdChemRegLimits).Text = "View/Update Regulatory Limits";
		((ButtonBase)cmdChemRegLimits).UseVisualStyleBackColor = false;
		((Control)cmdChemRegLimits).Visible = false;
		((Control)_fraTab_0).BackColor = SystemColors.Control;
		((Control)_fraTab_0).Controls.Add((Control)(object)Label10);
		((Control)_fraTab_0).Controls.Add((Control)(object)Label7);
		((Control)_fraTab_0).Controls.Add((Control)(object)txtConsCase);
		((Control)_fraTab_0).Controls.Add((Control)(object)txtRevNotes);
		((Control)_fraTab_0).Controls.Add((Control)(object)cmdUpdGen);
		((Control)_fraTab_0).Controls.Add((Control)(object)cmdComments);
		((Control)_fraTab_0).Controls.Add((Control)(object)cmdContRpt);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_110);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblCurrentVersion);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblAssessmentVersion);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_107);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblLastSaved);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_93);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_24);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblConsCase);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblFiscalYear);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_26);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblNumCR);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_12);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_36);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblState);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblZip);
		((Control)_fraTab_0).Controls.Add((Control)(object)_lblAddr_1);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblCity);
		((Control)_fraTab_0).Controls.Add((Control)(object)_lblAddr_0);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblCoName);
		((Control)_fraTab_0).Controls.Add((Control)(object)_lblEmail_1);
		((Control)_fraTab_0).Controls.Add((Control)(object)_lblEmail_0);
		((Control)_fraTab_0).Controls.Add((Control)(object)_lblPhone_1);
		((Control)_fraTab_0).Controls.Add((Control)(object)_lblPhone_0);
		((Control)_fraTab_0).Controls.Add((Control)(object)_lblAff_1);
		((Control)_fraTab_0).Controls.Add((Control)(object)_lblAff_0);
		((Control)_fraTab_0).Controls.Add((Control)(object)_lblName_1);
		((Control)_fraTab_0).Controls.Add((Control)(object)_lblName_0);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblCBI);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblDate);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblID);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblStatus);
		((Control)_fraTab_0).Controls.Add((Control)(object)lblAssessType);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_11);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Line1_2);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Line1_1);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_10);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_32);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_25);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_7);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Line1_0);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_9);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_5);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_4);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_30);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_29);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_13);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_8);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_6);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_1);
		((Control)_fraTab_0).Controls.Add((Control)(object)_Label1_0);
		_fraTab_0.FlatStyle = (FlatStyle)0;
		((Control)_fraTab_0).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraTab_0).ForeColor = SystemColors.ControlText;
		fraTab.SetIndex(_fraTab_0, (short)0);
		GroupBox fraTab_11 = _fraTab_0;
		location = new Point(124, 15);
		((Control)fraTab_11).Location = location;
		((Control)_fraTab_0).Name = "_fraTab_0";
		((Control)_fraTab_0).RightToLeft = (RightToLeft)0;
		GroupBox fraTab_12 = _fraTab_0;
		size = new Size(785, 605);
		((Control)fraTab_12).Size = size;
		((Control)_fraTab_0).TabIndex = 45;
		_fraTab_0.TabStop = false;
		_fraTab_0.Text = "1. General Information";
		((Control)Label10).BackColor = SystemColors.Control;
		((Control)Label10).Cursor = Cursors.Default;
		((Control)Label10).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label10).ForeColor = SystemColors.ControlText;
		Label label29 = Label10;
		location = new Point(16, 23);
		((Control)label29).Location = location;
		((Control)Label10).Name = "Label10";
		((Control)Label10).RightToLeft = (RightToLeft)0;
		Label label30 = Label10;
		size = new Size(745, 50);
		((Control)label30).Size = size;
		((Control)Label10).TabIndex = 391;
		Label10.Text = componentResourceManager.GetString("Label10.Text");
		Label7.AutoSize = true;
		Label label31 = Label7;
		location = new Point(20, 530);
		((Control)label31).Location = location;
		((Control)Label7).Name = "Label7";
		Label label32 = Label7;
		size = new Size(162, 14);
		((Control)label32).Size = size;
		((Control)Label7).TabIndex = 390;
		Label7.Text = "General Information Actions";
		txtConsCase.AcceptsReturn = true;
		((TextBoxBase)txtConsCase).BackColor = SystemColors.Control;
		((Control)txtConsCase).Cursor = Cursors.IBeam;
		((Control)txtConsCase).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtConsCase).ForeColor = SystemColors.WindowText;
		TextBox obj257 = txtConsCase;
		location = new Point(371, 114);
		((Control)obj257).Location = location;
		((TextBoxBase)txtConsCase).MaxLength = 100;
		txtConsCase.Multiline = true;
		((Control)txtConsCase).Name = "txtConsCase";
		((TextBoxBase)txtConsCase).ReadOnly = true;
		((Control)txtConsCase).RightToLeft = (RightToLeft)0;
		txtConsCase.ScrollBars = (ScrollBars)2;
		TextBox obj258 = txtConsCase;
		size = new Size(129, 46);
		((Control)obj258).Size = size;
		((Control)txtConsCase).TabIndex = 313;
		((Control)txtConsCase).TabStop = false;
		txtRevNotes.AcceptsReturn = true;
		((TextBoxBase)txtRevNotes).BackColor = SystemColors.Control;
		((Control)txtRevNotes).Cursor = Cursors.IBeam;
		((Control)txtRevNotes).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtRevNotes).ForeColor = SystemColors.WindowText;
		TextBox obj259 = txtRevNotes;
		location = new Point(371, 338);
		((Control)obj259).Location = location;
		((TextBoxBase)txtRevNotes).MaxLength = 0;
		txtRevNotes.Multiline = true;
		((Control)txtRevNotes).Name = "txtRevNotes";
		((TextBoxBase)txtRevNotes).ReadOnly = true;
		((Control)txtRevNotes).RightToLeft = (RightToLeft)0;
		txtRevNotes.ScrollBars = (ScrollBars)2;
		TextBox obj260 = txtRevNotes;
		size = new Size(393, 100);
		((Control)obj260).Size = size;
		((Control)txtRevNotes).TabIndex = 39;
		((Control)txtRevNotes).TabStop = false;
		((ButtonBase)cmdUpdGen).BackColor = SystemColors.Control;
		((Control)cmdUpdGen).Cursor = Cursors.Default;
		((Control)cmdUpdGen).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdGen).ForeColor = SystemColors.ControlText;
		Button obj261 = cmdUpdGen;
		location = new Point(20, 555);
		((Control)obj261).Location = location;
		((Control)cmdUpdGen).Name = "cmdUpdGen";
		((Control)cmdUpdGen).RightToLeft = (RightToLeft)0;
		Button obj262 = cmdUpdGen;
		size = new Size(177, 41);
		((Control)obj262).Size = size;
		((Control)cmdUpdGen).TabIndex = 40;
		((ButtonBase)cmdUpdGen).Text = "Update General Information";
		((ButtonBase)cmdUpdGen).UseVisualStyleBackColor = false;
		((ButtonBase)cmdComments).BackColor = SystemColors.Control;
		((Control)cmdComments).Cursor = Cursors.Default;
		((Control)cmdComments).Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdComments).ForeColor = SystemColors.ControlText;
		Button obj263 = cmdComments;
		location = new Point(398, 555);
		((Control)obj263).Location = location;
		((Control)cmdComments).Name = "cmdComments";
		((Control)cmdComments).RightToLeft = (RightToLeft)0;
		Button obj264 = cmdComments;
		size = new Size(177, 41);
		((Control)obj264).Size = size;
		((Control)cmdComments).TabIndex = 42;
		((ButtonBase)cmdComments).Text = "Update Revision Notes / Assessment Overview";
		((ButtonBase)cmdComments).UseVisualStyleBackColor = false;
		((ButtonBase)cmdContRpt).BackColor = SystemColors.Control;
		((Control)cmdContRpt).Cursor = Cursors.Default;
		((Control)cmdContRpt).Font = new Font("Arial", 8.25f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdContRpt).ForeColor = SystemColors.ControlText;
		Button obj265 = cmdContRpt;
		location = new Point(210, 555);
		((Control)obj265).Location = location;
		((Control)cmdContRpt).Name = "cmdContRpt";
		((Control)cmdContRpt).RightToLeft = (RightToLeft)0;
		Button obj266 = cmdContRpt;
		size = new Size(177, 41);
		((Control)obj266).Size = size;
		((Control)cmdContRpt).TabIndex = 41;
		((ButtonBase)cmdContRpt).Text = "View/Update Contact Report(s)";
		((ButtonBase)cmdContRpt).UseVisualStyleBackColor = false;
		((Control)_Label1_110).BackColor = SystemColors.Control;
		((Control)_Label1_110).Cursor = Cursors.Default;
		((Control)_Label1_110).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_110).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_110, (short)110);
		Label label1_175 = _Label1_110;
		location = new Point(528, 138);
		((Control)label1_175).Location = location;
		((Control)_Label1_110).Name = "_Label1_110";
		((Control)_Label1_110).RightToLeft = (RightToLeft)0;
		Label label1_176 = _Label1_110;
		size = new Size(97, 19);
		((Control)label1_176).Size = size;
		((Control)_Label1_110).TabIndex = 375;
		_Label1_110.Text = "Current Version:";
		_Label1_110.TextAlign = (ContentAlignment)4;
		((Control)lblCurrentVersion).BackColor = SystemColors.Control;
		lblCurrentVersion.BorderStyle = (BorderStyle)1;
		((Control)lblCurrentVersion).Cursor = Cursors.Default;
		((Control)lblCurrentVersion).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCurrentVersion).ForeColor = SystemColors.WindowText;
		Label obj267 = lblCurrentVersion;
		location = new Point(627, 138);
		((Control)obj267).Location = location;
		((Control)lblCurrentVersion).Name = "lblCurrentVersion";
		((Control)lblCurrentVersion).RightToLeft = (RightToLeft)0;
		Label obj268 = lblCurrentVersion;
		size = new Size(137, 19);
		((Control)obj268).Size = size;
		((Control)lblCurrentVersion).TabIndex = 374;
		lblCurrentVersion.TextAlign = (ContentAlignment)2;
		((Control)lblAssessmentVersion).BackColor = SystemColors.Control;
		lblAssessmentVersion.BorderStyle = (BorderStyle)1;
		((Control)lblAssessmentVersion).Cursor = Cursors.Default;
		((Control)lblAssessmentVersion).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblAssessmentVersion).ForeColor = SystemColors.WindowText;
		Label obj269 = lblAssessmentVersion;
		location = new Point(627, 114);
		((Control)obj269).Location = location;
		((Control)lblAssessmentVersion).Name = "lblAssessmentVersion";
		((Control)lblAssessmentVersion).RightToLeft = (RightToLeft)0;
		Label obj270 = lblAssessmentVersion;
		size = new Size(137, 19);
		((Control)obj270).Size = size;
		((Control)lblAssessmentVersion).TabIndex = 373;
		lblAssessmentVersion.Text = "Never Saved";
		lblAssessmentVersion.TextAlign = (ContentAlignment)2;
		((Control)_Label1_107).BackColor = SystemColors.Control;
		((Control)_Label1_107).Cursor = Cursors.Default;
		((Control)_Label1_107).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_107).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_107, (short)107);
		Label label1_177 = _Label1_107;
		location = new Point(555, 114);
		((Control)label1_177).Location = location;
		((Control)_Label1_107).Name = "_Label1_107";
		((Control)_Label1_107).RightToLeft = (RightToLeft)0;
		Label label1_178 = _Label1_107;
		size = new Size(73, 19);
		((Control)label1_178).Size = size;
		((Control)_Label1_107).TabIndex = 372;
		_Label1_107.Text = "Saved With: ";
		_Label1_107.TextAlign = (ContentAlignment)4;
		((Control)lblLastSaved).BackColor = SystemColors.Control;
		lblLastSaved.BorderStyle = (BorderStyle)1;
		((Control)lblLastSaved).Cursor = Cursors.Default;
		((Control)lblLastSaved).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblLastSaved).ForeColor = SystemColors.WindowText;
		Label obj271 = lblLastSaved;
		location = new Point(627, 89);
		((Control)obj271).Location = location;
		((Control)lblLastSaved).Name = "lblLastSaved";
		((Control)lblLastSaved).RightToLeft = (RightToLeft)0;
		Label obj272 = lblLastSaved;
		size = new Size(137, 19);
		((Control)obj272).Size = size;
		((Control)lblLastSaved).TabIndex = 328;
		lblLastSaved.Text = "Never Saved";
		lblLastSaved.TextAlign = (ContentAlignment)2;
		((Control)_Label1_93).BackColor = SystemColors.Control;
		((Control)_Label1_93).Cursor = Cursors.Default;
		((Control)_Label1_93).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_93).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_93, (short)93);
		Label label1_179 = _Label1_93;
		location = new Point(555, 89);
		((Control)label1_179).Location = location;
		((Control)_Label1_93).Name = "_Label1_93";
		((Control)_Label1_93).RightToLeft = (RightToLeft)0;
		Label label1_180 = _Label1_93;
		size = new Size(73, 19);
		((Control)label1_180).Size = size;
		((Control)_Label1_93).TabIndex = 327;
		_Label1_93.Text = "Last Saved: ";
		_Label1_93.TextAlign = (ContentAlignment)4;
		((Control)_Label1_24).BackColor = SystemColors.Control;
		((Control)_Label1_24).Cursor = Cursors.Default;
		((Control)_Label1_24).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_24).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_24, (short)24);
		Label label1_181 = _Label1_24;
		location = new Point(348, 89);
		((Control)label1_181).Location = location;
		((Control)_Label1_24).Name = "_Label1_24";
		((Control)_Label1_24).RightToLeft = (RightToLeft)0;
		Label label1_182 = _Label1_24;
		size = new Size(113, 19);
		((Control)label1_182).Size = size;
		((Control)_Label1_24).TabIndex = 312;
		_Label1_24.Text = "Consolidated Case:";
		_Label1_24.TextAlign = (ContentAlignment)4;
		((Control)lblConsCase).BackColor = SystemColors.Control;
		lblConsCase.BorderStyle = (BorderStyle)2;
		((Control)lblConsCase).Cursor = Cursors.Default;
		((Control)lblConsCase).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblConsCase).ForeColor = SystemColors.ControlText;
		Label obj273 = lblConsCase;
		location = new Point(467, 89);
		((Control)obj273).Location = location;
		((Control)lblConsCase).Name = "lblConsCase";
		((Control)lblConsCase).RightToLeft = (RightToLeft)0;
		Label obj274 = lblConsCase;
		size = new Size(33, 17);
		((Control)obj274).Size = size;
		((Control)lblConsCase).TabIndex = 311;
		((Control)lblFiscalYear).BackColor = SystemColors.Control;
		lblFiscalYear.BorderStyle = (BorderStyle)2;
		((Control)lblFiscalYear).Cursor = Cursors.Default;
		((Control)lblFiscalYear).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblFiscalYear).ForeColor = SystemColors.ControlText;
		Label obj275 = lblFiscalYear;
		location = new Point(131, 138);
		((Control)obj275).Location = location;
		((Control)lblFiscalYear).Name = "lblFiscalYear";
		((Control)lblFiscalYear).RightToLeft = (RightToLeft)0;
		Label obj276 = lblFiscalYear;
		size = new Size(33, 17);
		((Control)obj276).Size = size;
		((Control)lblFiscalYear).TabIndex = 310;
		((Control)_Label1_26).BackColor = SystemColors.Control;
		((Control)_Label1_26).Cursor = Cursors.Default;
		((Control)_Label1_26).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_26).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_26, (short)26);
		Label label1_183 = _Label1_26;
		location = new Point(65, 138);
		((Control)label1_183).Location = location;
		((Control)_Label1_26).Name = "_Label1_26";
		((Control)_Label1_26).RightToLeft = (RightToLeft)0;
		Label label1_184 = _Label1_26;
		size = new Size(65, 19);
		((Control)label1_184).Size = size;
		((Control)_Label1_26).TabIndex = 309;
		_Label1_26.Text = "Fiscal Year:";
		_Label1_26.TextAlign = (ContentAlignment)4;
		((Control)lblNumCR).BackColor = SystemColors.Control;
		lblNumCR.BorderStyle = (BorderStyle)2;
		((Control)lblNumCR).Cursor = Cursors.Default;
		((Control)lblNumCR).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblNumCR).ForeColor = SystemColors.ControlText;
		Label obj277 = lblNumCR;
		location = new Point(731, 170);
		((Control)obj277).Location = location;
		((Control)lblNumCR).Name = "lblNumCR";
		((Control)lblNumCR).RightToLeft = (RightToLeft)0;
		Label obj278 = lblNumCR;
		size = new Size(33, 19);
		((Control)obj278).Size = size;
		((Control)lblNumCR).TabIndex = 181;
		lblNumCR.Text = "0";
		lblNumCR.TextAlign = (ContentAlignment)2;
		((Control)_Label1_12).BackColor = SystemColors.Control;
		((Control)_Label1_12).Cursor = Cursors.Default;
		((Control)_Label1_12).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_12).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_12, (short)12);
		Label label1_185 = _Label1_12;
		location = new Point(577, 170);
		((Control)label1_185).Location = location;
		((Control)_Label1_12).Name = "_Label1_12";
		((Control)_Label1_12).RightToLeft = (RightToLeft)0;
		Label label1_186 = _Label1_12;
		size = new Size(153, 19);
		((Control)label1_186).Size = size;
		((Control)_Label1_12).TabIndex = 180;
		_Label1_12.Text = "Number of Contact Reports:";
		_Label1_12.TextAlign = (ContentAlignment)4;
		((Control)_Label1_36).BackColor = Color.FromArgb(255, 128, 128);
		((Control)_Label1_36).Cursor = Cursors.Default;
		((Control)_Label1_36).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_36).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_36, (short)36);
		Label label1_187 = _Label1_36;
		location = new Point(491, 170);
		((Control)label1_187).Location = location;
		((Control)_Label1_36).Name = "_Label1_36";
		((Control)_Label1_36).RightToLeft = (RightToLeft)0;
		Label label1_188 = _Label1_36;
		size = new Size(33, 18);
		((Control)label1_188).Size = size;
		((Control)_Label1_36).TabIndex = 136;
		_Label1_36.Text = "CBI: ";
		_Label1_36.TextAlign = (ContentAlignment)4;
		((Control)lblState).BackColor = SystemColors.Control;
		lblState.BorderStyle = (BorderStyle)2;
		((Control)lblState).Cursor = Cursors.Default;
		((Control)lblState).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblState).ForeColor = SystemColors.ControlText;
		Label obj279 = lblState;
		location = new Point(139, 418);
		((Control)obj279).Location = location;
		((Control)lblState).Name = "lblState";
		((Control)lblState).RightToLeft = (RightToLeft)0;
		Label obj280 = lblState;
		size = new Size(41, 17);
		((Control)obj280).Size = size;
		((Control)lblState).TabIndex = 37;
		((Control)lblZip).BackColor = SystemColors.Control;
		lblZip.BorderStyle = (BorderStyle)2;
		((Control)lblZip).Cursor = Cursors.Default;
		((Control)lblZip).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblZip).ForeColor = SystemColors.ControlText;
		Label obj281 = lblZip;
		location = new Point(243, 418);
		((Control)obj281).Location = location;
		((Control)lblZip).Name = "lblZip";
		((Control)lblZip).RightToLeft = (RightToLeft)0;
		Label obj282 = lblZip;
		size = new Size(89, 17);
		((Control)obj282).Size = size;
		((Control)lblZip).TabIndex = 38;
		((Control)_lblAddr_1).BackColor = SystemColors.Control;
		_lblAddr_1.BorderStyle = (BorderStyle)2;
		((Control)_lblAddr_1).Cursor = Cursors.Default;
		((Control)_lblAddr_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblAddr_1).ForeColor = SystemColors.ControlText;
		lblAddr.SetIndex(_lblAddr_1, (short)1);
		Label lblAddr_ = _lblAddr_1;
		location = new Point(139, 370);
		((Control)lblAddr_).Location = location;
		((Control)_lblAddr_1).Name = "_lblAddr_1";
		((Control)_lblAddr_1).RightToLeft = (RightToLeft)0;
		Label lblAddr_2 = _lblAddr_1;
		size = new Size(209, 17);
		((Control)lblAddr_2).Size = size;
		((Control)_lblAddr_1).TabIndex = 35;
		((Control)lblCity).BackColor = SystemColors.Control;
		lblCity.BorderStyle = (BorderStyle)2;
		((Control)lblCity).Cursor = Cursors.Default;
		((Control)lblCity).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCity).ForeColor = SystemColors.ControlText;
		Label obj283 = lblCity;
		location = new Point(139, 394);
		((Control)obj283).Location = location;
		((Control)lblCity).Name = "lblCity";
		((Control)lblCity).RightToLeft = (RightToLeft)0;
		Label obj284 = lblCity;
		size = new Size(209, 17);
		((Control)obj284).Size = size;
		((Control)lblCity).TabIndex = 36;
		((Control)_lblAddr_0).BackColor = SystemColors.Control;
		_lblAddr_0.BorderStyle = (BorderStyle)2;
		((Control)_lblAddr_0).Cursor = Cursors.Default;
		((Control)_lblAddr_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblAddr_0).ForeColor = SystemColors.ControlText;
		lblAddr.SetIndex(_lblAddr_0, (short)0);
		Label lblAddr_3 = _lblAddr_0;
		location = new Point(139, 346);
		((Control)lblAddr_3).Location = location;
		((Control)_lblAddr_0).Name = "_lblAddr_0";
		((Control)_lblAddr_0).RightToLeft = (RightToLeft)0;
		Label lblAddr_4 = _lblAddr_0;
		size = new Size(209, 17);
		((Control)lblAddr_4).Size = size;
		((Control)_lblAddr_0).TabIndex = 34;
		((Control)lblCoName).BackColor = SystemColors.Control;
		lblCoName.BorderStyle = (BorderStyle)2;
		((Control)lblCoName).Cursor = Cursors.Default;
		((Control)lblCoName).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCoName).ForeColor = SystemColors.ControlText;
		Label obj285 = lblCoName;
		location = new Point(139, 322);
		((Control)obj285).Location = location;
		((Control)lblCoName).Name = "lblCoName";
		((Control)lblCoName).RightToLeft = (RightToLeft)0;
		Label obj286 = lblCoName;
		size = new Size(209, 17);
		((Control)obj286).Size = size;
		((Control)lblCoName).TabIndex = 33;
		((Control)_lblEmail_1).BackColor = SystemColors.Control;
		_lblEmail_1.BorderStyle = (BorderStyle)2;
		((Control)_lblEmail_1).Cursor = Cursors.Default;
		((Control)_lblEmail_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblEmail_1).ForeColor = SystemColors.ControlText;
		lblEmail.SetIndex(_lblEmail_1, (short)1);
		Label lblEmail_ = _lblEmail_1;
		location = new Point(379, 282);
		((Control)lblEmail_).Location = location;
		((Control)_lblEmail_1).Name = "_lblEmail_1";
		((Control)_lblEmail_1).RightToLeft = (RightToLeft)0;
		Label lblEmail_2 = _lblEmail_1;
		size = new Size(289, 17);
		((Control)lblEmail_2).Size = size;
		((Control)_lblEmail_1).TabIndex = 135;
		((Control)_lblEmail_0).BackColor = SystemColors.Control;
		_lblEmail_0.BorderStyle = (BorderStyle)2;
		((Control)_lblEmail_0).Cursor = Cursors.Default;
		((Control)_lblEmail_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblEmail_0).ForeColor = SystemColors.ControlText;
		lblEmail.SetIndex(_lblEmail_0, (short)0);
		Label lblEmail_3 = _lblEmail_0;
		location = new Point(99, 282);
		((Control)lblEmail_3).Location = location;
		((Control)_lblEmail_0).Name = "_lblEmail_0";
		((Control)_lblEmail_0).RightToLeft = (RightToLeft)0;
		Label lblEmail_4 = _lblEmail_0;
		size = new Size(249, 17);
		((Control)lblEmail_4).Size = size;
		((Control)_lblEmail_0).TabIndex = 134;
		((Control)_lblPhone_1).BackColor = SystemColors.Control;
		_lblPhone_1.BorderStyle = (BorderStyle)2;
		((Control)_lblPhone_1).Cursor = Cursors.Default;
		((Control)_lblPhone_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblPhone_1).ForeColor = SystemColors.ControlText;
		lblPhone.SetIndex(_lblPhone_1, (short)1);
		Label lblPhone_ = _lblPhone_1;
		location = new Point(379, 258);
		((Control)lblPhone_).Location = location;
		((Control)_lblPhone_1).Name = "_lblPhone_1";
		((Control)_lblPhone_1).RightToLeft = (RightToLeft)0;
		Label lblPhone_2 = _lblPhone_1;
		size = new Size(145, 17);
		((Control)lblPhone_2).Size = size;
		((Control)_lblPhone_1).TabIndex = 133;
		((Control)_lblPhone_0).BackColor = SystemColors.Control;
		_lblPhone_0.BorderStyle = (BorderStyle)2;
		((Control)_lblPhone_0).Cursor = Cursors.Default;
		((Control)_lblPhone_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblPhone_0).ForeColor = SystemColors.ControlText;
		lblPhone.SetIndex(_lblPhone_0, (short)0);
		Label lblPhone_3 = _lblPhone_0;
		location = new Point(99, 258);
		((Control)lblPhone_3).Location = location;
		((Control)_lblPhone_0).Name = "_lblPhone_0";
		((Control)_lblPhone_0).RightToLeft = (RightToLeft)0;
		Label lblPhone_4 = _lblPhone_0;
		size = new Size(145, 19);
		((Control)lblPhone_4).Size = size;
		((Control)_lblPhone_0).TabIndex = 132;
		((Control)_lblAff_1).BackColor = SystemColors.Control;
		_lblAff_1.BorderStyle = (BorderStyle)2;
		((Control)_lblAff_1).Cursor = Cursors.Default;
		((Control)_lblAff_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblAff_1).ForeColor = SystemColors.ControlText;
		lblAff.SetIndex(_lblAff_1, (short)1);
		Label lblAff_ = _lblAff_1;
		location = new Point(379, 234);
		((Control)lblAff_).Location = location;
		((Control)_lblAff_1).Name = "_lblAff_1";
		((Control)_lblAff_1).RightToLeft = (RightToLeft)0;
		Label lblAff_2 = _lblAff_1;
		size = new Size(289, 17);
		((Control)lblAff_2).Size = size;
		((Control)_lblAff_1).TabIndex = 131;
		((Control)_lblAff_0).BackColor = SystemColors.Control;
		_lblAff_0.BorderStyle = (BorderStyle)2;
		((Control)_lblAff_0).Cursor = Cursors.Default;
		((Control)_lblAff_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblAff_0).ForeColor = SystemColors.ControlText;
		lblAff.SetIndex(_lblAff_0, (short)0);
		Label lblAff_3 = _lblAff_0;
		location = new Point(99, 234);
		((Control)lblAff_3).Location = location;
		((Control)_lblAff_0).Name = "_lblAff_0";
		((Control)_lblAff_0).RightToLeft = (RightToLeft)0;
		Label lblAff_4 = _lblAff_0;
		size = new Size(249, 17);
		((Control)lblAff_4).Size = size;
		((Control)_lblAff_0).TabIndex = 130;
		((Control)_lblName_1).BackColor = SystemColors.Control;
		_lblName_1.BorderStyle = (BorderStyle)2;
		((Control)_lblName_1).Cursor = Cursors.Default;
		((Control)_lblName_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblName_1).ForeColor = SystemColors.ControlText;
		lblName.SetIndex(_lblName_1, (short)1);
		Label lblName_ = _lblName_1;
		location = new Point(379, 210);
		((Control)lblName_).Location = location;
		((Control)_lblName_1).Name = "_lblName_1";
		((Control)_lblName_1).RightToLeft = (RightToLeft)0;
		Label lblName_2 = _lblName_1;
		size = new Size(289, 17);
		((Control)lblName_2).Size = size;
		((Control)_lblName_1).TabIndex = 129;
		((Control)_lblName_0).BackColor = SystemColors.Control;
		_lblName_0.BorderStyle = (BorderStyle)2;
		((Control)_lblName_0).Cursor = Cursors.Default;
		((Control)_lblName_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblName_0).ForeColor = SystemColors.ControlText;
		lblName.SetIndex(_lblName_0, (short)0);
		Label lblName_3 = _lblName_0;
		location = new Point(99, 210);
		((Control)lblName_3).Location = location;
		((Control)_lblName_0).Name = "_lblName_0";
		((Control)_lblName_0).RightToLeft = (RightToLeft)0;
		Label lblName_4 = _lblName_0;
		size = new Size(249, 17);
		((Control)lblName_4).Size = size;
		((Control)_lblName_0).TabIndex = 128;
		((Control)lblCBI).BackColor = SystemColors.Control;
		lblCBI.BorderStyle = (BorderStyle)2;
		((Control)lblCBI).Cursor = Cursors.Default;
		((Control)lblCBI).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblCBI).ForeColor = SystemColors.ControlText;
		Label obj287 = lblCBI;
		location = new Point(531, 170);
		((Control)obj287).Location = location;
		((Control)lblCBI).Name = "lblCBI";
		((Control)lblCBI).RightToLeft = (RightToLeft)0;
		Label obj288 = lblCBI;
		size = new Size(33, 19);
		((Control)obj288).Size = size;
		((Control)lblCBI).TabIndex = 127;
		lblCBI.Text = "Yes";
		((Control)lblDate).BackColor = SystemColors.Control;
		lblDate.BorderStyle = (BorderStyle)2;
		((Control)lblDate).Cursor = Cursors.Default;
		((Control)lblDate).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblDate).ForeColor = SystemColors.ControlText;
		Label obj289 = lblDate;
		location = new Point(403, 170);
		((Control)obj289).Location = location;
		((Control)lblDate).Name = "lblDate";
		((Control)lblDate).RightToLeft = (RightToLeft)0;
		Label obj290 = lblDate;
		size = new Size(65, 17);
		((Control)obj290).Size = size;
		((Control)lblDate).TabIndex = 126;
		((Control)lblID).BackColor = SystemColors.Control;
		lblID.BorderStyle = (BorderStyle)2;
		((Control)lblID).Cursor = Cursors.Default;
		((Control)lblID).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblID).ForeColor = SystemColors.ControlText;
		Label obj291 = lblID;
		location = new Point(131, 162);
		((Control)obj291).Location = location;
		((Control)lblID).Name = "lblID";
		((Control)lblID).RightToLeft = (RightToLeft)0;
		Label obj292 = lblID;
		size = new Size(217, 17);
		((Control)obj292).Size = size;
		((Control)lblID).TabIndex = 125;
		((Control)lblStatus).BackColor = SystemColors.Control;
		lblStatus.BorderStyle = (BorderStyle)2;
		((Control)lblStatus).Cursor = Cursors.Default;
		((Control)lblStatus).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblStatus).ForeColor = SystemColors.ControlText;
		Label obj293 = lblStatus;
		location = new Point(131, 114);
		((Control)obj293).Location = location;
		((Control)lblStatus).Name = "lblStatus";
		((Control)lblStatus).RightToLeft = (RightToLeft)0;
		Label obj294 = lblStatus;
		size = new Size(217, 17);
		((Control)obj294).Size = size;
		((Control)lblStatus).TabIndex = 124;
		((Control)lblAssessType).BackColor = SystemColors.Control;
		lblAssessType.BorderStyle = (BorderStyle)2;
		((Control)lblAssessType).Cursor = Cursors.Default;
		((Control)lblAssessType).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblAssessType).ForeColor = SystemColors.ControlText;
		Label obj295 = lblAssessType;
		location = new Point(131, 89);
		((Control)obj295).Location = location;
		((Control)lblAssessType).Name = "lblAssessType";
		((Control)lblAssessType).RightToLeft = (RightToLeft)0;
		Label obj296 = lblAssessType;
		size = new Size(217, 17);
		((Control)obj296).Size = size;
		((Control)lblAssessType).TabIndex = 123;
		((Control)_Label1_11).BackColor = SystemColors.Control;
		((Control)_Label1_11).Cursor = Cursors.Default;
		((Control)_Label1_11).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_11).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_11, (short)11);
		Label label1_189 = _Label1_11;
		location = new Point(371, 322);
		((Control)label1_189).Location = location;
		((Control)_Label1_11).Name = "_Label1_11";
		((Control)_Label1_11).RightToLeft = (RightToLeft)0;
		Label label1_190 = _Label1_11;
		size = new Size(209, 19);
		((Control)label1_190).Size = size;
		((Control)_Label1_11).TabIndex = 93;
		_Label1_11.Text = "Revision Notes / Assessment Overview: ";
		((Control)_Line1_2).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_2, (short)2);
		Label line1_ = _Line1_2;
		location = new Point(363, 202);
		((Control)line1_).Location = location;
		((Control)_Line1_2).Name = "_Line1_2";
		Label line1_2 = _Line1_2;
		size = new Size(1, 112);
		((Control)line1_2).Size = size;
		((Control)_Line1_2).TabIndex = 376;
		((Control)_Line1_1).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_1, (short)1);
		Label line1_3 = _Line1_1;
		location = new Point(43, 202);
		((Control)line1_3).Location = location;
		((Control)_Line1_1).Name = "_Line1_1";
		Label line1_4 = _Line1_1;
		size = new Size(672, 1);
		((Control)line1_4).Size = size;
		((Control)_Line1_1).TabIndex = 377;
		((Control)_Label1_10).BackColor = SystemColors.Control;
		((Control)_Label1_10).Cursor = Cursors.Default;
		((Control)_Label1_10).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_10).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_10, (short)10);
		Label label1_191 = _Label1_10;
		location = new Point(51, 282);
		((Control)label1_191).Location = location;
		((Control)_Label1_10).Name = "_Label1_10";
		((Control)_Label1_10).RightToLeft = (RightToLeft)0;
		Label label1_192 = _Label1_10;
		size = new Size(41, 19);
		((Control)label1_192).Size = size;
		((Control)_Label1_10).TabIndex = 83;
		_Label1_10.Text = "Email:";
		_Label1_10.TextAlign = (ContentAlignment)4;
		((Control)_Label1_32).BackColor = SystemColors.Control;
		((Control)_Label1_32).Cursor = Cursors.Default;
		((Control)_Label1_32).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_32).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_32, (short)32);
		Label label1_193 = _Label1_32;
		location = new Point(43, 210);
		((Control)label1_193).Location = location;
		((Control)_Label1_32).Name = "_Label1_32";
		((Control)_Label1_32).RightToLeft = (RightToLeft)0;
		Label label1_194 = _Label1_32;
		size = new Size(49, 19);
		((Control)label1_194).Size = size;
		((Control)_Label1_32).TabIndex = 82;
		_Label1_32.Text = "Name:";
		_Label1_32.TextAlign = (ContentAlignment)4;
		((Control)_Label1_25).BackColor = SystemColors.Control;
		((Control)_Label1_25).Cursor = Cursors.Default;
		((Control)_Label1_25).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_25).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_25, (short)25);
		Label label1_195 = _Label1_25;
		location = new Point(43, 186);
		((Control)label1_195).Location = location;
		((Control)_Label1_25).Name = "_Label1_25";
		((Control)_Label1_25).RightToLeft = (RightToLeft)0;
		Label label1_196 = _Label1_25;
		size = new Size(81, 19);
		((Control)label1_196).Size = size;
		((Control)_Label1_25).TabIndex = 81;
		_Label1_25.Text = "Assessors: ";
		((Control)_Label1_7).BackColor = SystemColors.Control;
		((Control)_Label1_7).Cursor = Cursors.Default;
		((Control)_Label1_7).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_7).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_7, (short)7);
		Label label1_197 = _Label1_7;
		location = new Point(371, 170);
		((Control)label1_197).Location = location;
		((Control)_Label1_7).Name = "_Label1_7";
		((Control)_Label1_7).RightToLeft = (RightToLeft)0;
		Label label1_198 = _Label1_7;
		size = new Size(33, 19);
		((Control)label1_198).Size = size;
		((Control)_Label1_7).TabIndex = 76;
		_Label1_7.Text = "Date:";
		((Control)_Line1_0).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_0, (short)0);
		Label line1_5 = _Line1_0;
		location = new Point(43, 314);
		((Control)line1_5).Location = location;
		((Control)_Line1_0).Name = "_Line1_0";
		Label line1_6 = _Line1_0;
		size = new Size(672, 1);
		((Control)line1_6).Size = size;
		((Control)_Line1_0).TabIndex = 378;
		((Control)_Label1_9).BackColor = SystemColors.Control;
		((Control)_Label1_9).Cursor = Cursors.Default;
		((Control)_Label1_9).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_9).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_9, (short)9);
		Label label1_199 = _Label1_9;
		location = new Point(51, 258);
		((Control)label1_199).Location = location;
		((Control)_Label1_9).Name = "_Label1_9";
		((Control)_Label1_9).RightToLeft = (RightToLeft)0;
		Label label1_200 = _Label1_9;
		size = new Size(41, 19);
		((Control)label1_200).Size = size;
		((Control)_Label1_9).TabIndex = 73;
		_Label1_9.Text = "Phone:";
		_Label1_9.TextAlign = (ContentAlignment)4;
		((Control)_Label1_5).BackColor = SystemColors.Control;
		((Control)_Label1_5).Cursor = Cursors.Default;
		((Control)_Label1_5).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_5).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_5, (short)5);
		Label label1_201 = _Label1_5;
		location = new Point(9, 234);
		((Control)label1_201).Location = location;
		((Control)_Label1_5).Name = "_Label1_5";
		((Control)_Label1_5).RightToLeft = (RightToLeft)0;
		Label label1_202 = _Label1_5;
		size = new Size(83, 19);
		((Control)label1_202).Size = size;
		((Control)_Label1_5).TabIndex = 72;
		_Label1_5.Text = "Affiliation:";
		_Label1_5.TextAlign = (ContentAlignment)4;
		((Control)_Label1_4).BackColor = SystemColors.Control;
		((Control)_Label1_4).Cursor = Cursors.Default;
		((Control)_Label1_4).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_4).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_4, (short)4);
		Label label1_203 = _Label1_4;
		location = new Point(73, 114);
		((Control)label1_203).Location = location;
		((Control)_Label1_4).Name = "_Label1_4";
		((Control)_Label1_4).RightToLeft = (RightToLeft)0;
		Label label1_204 = _Label1_4;
		size = new Size(57, 19);
		((Control)label1_204).Size = size;
		((Control)_Label1_4).TabIndex = 71;
		_Label1_4.Text = "Status:";
		_Label1_4.TextAlign = (ContentAlignment)4;
		((Control)_Label1_30).BackColor = SystemColors.Control;
		((Control)_Label1_30).Cursor = Cursors.Default;
		((Control)_Label1_30).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_30).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_30, (short)30);
		Label label1_205 = _Label1_30;
		location = new Point(211, 418);
		((Control)label1_205).Location = location;
		((Control)_Label1_30).Name = "_Label1_30";
		((Control)_Label1_30).RightToLeft = (RightToLeft)0;
		Label label1_206 = _Label1_30;
		size = new Size(33, 19);
		((Control)label1_206).Size = size;
		((Control)_Label1_30).TabIndex = 70;
		_Label1_30.Text = "Zip: ";
		_Label1_30.TextAlign = (ContentAlignment)4;
		((Control)_Label1_29).BackColor = SystemColors.Control;
		((Control)_Label1_29).Cursor = Cursors.Default;
		((Control)_Label1_29).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_29).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_29, (short)29);
		Label label1_207 = _Label1_29;
		location = new Point(75, 418);
		((Control)label1_207).Location = location;
		((Control)_Label1_29).Name = "_Label1_29";
		((Control)_Label1_29).RightToLeft = (RightToLeft)0;
		Label label1_208 = _Label1_29;
		size = new Size(57, 19);
		((Control)label1_208).Size = size;
		((Control)_Label1_29).TabIndex = 69;
		_Label1_29.Text = "State: ";
		_Label1_29.TextAlign = (ContentAlignment)4;
		((Control)_Label1_13).BackColor = SystemColors.Control;
		((Control)_Label1_13).Cursor = Cursors.Default;
		((Control)_Label1_13).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_13).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_13, (short)13);
		Label label1_209 = _Label1_13;
		location = new Point(7, 89);
		((Control)label1_209).Location = location;
		((Control)_Label1_13).Name = "_Label1_13";
		((Control)_Label1_13).RightToLeft = (RightToLeft)0;
		Label label1_210 = _Label1_13;
		size = new Size(123, 19);
		((Control)label1_210).Size = size;
		((Control)_Label1_13).TabIndex = 50;
		_Label1_13.Text = "Assessment Type:";
		_Label1_13.TextAlign = (ContentAlignment)4;
		((Control)_Label1_8).BackColor = SystemColors.Control;
		((Control)_Label1_8).Cursor = Cursors.Default;
		((Control)_Label1_8).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_8).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_8, (short)8);
		Label label1_211 = _Label1_8;
		location = new Point(59, 394);
		((Control)label1_211).Location = location;
		((Control)_Label1_8).Name = "_Label1_8";
		((Control)_Label1_8).RightToLeft = (RightToLeft)0;
		Label label1_212 = _Label1_8;
		size = new Size(73, 19);
		((Control)label1_212).Size = size;
		((Control)_Label1_8).TabIndex = 49;
		_Label1_8.Text = "City: ";
		_Label1_8.TextAlign = (ContentAlignment)4;
		((Control)_Label1_6).BackColor = SystemColors.Control;
		((Control)_Label1_6).Cursor = Cursors.Default;
		((Control)_Label1_6).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_6).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_6, (short)6);
		Label label1_213 = _Label1_6;
		location = new Point(43, 346);
		((Control)label1_213).Location = location;
		((Control)_Label1_6).Name = "_Label1_6";
		((Control)_Label1_6).RightToLeft = (RightToLeft)0;
		Label label1_214 = _Label1_6;
		size = new Size(89, 19);
		((Control)label1_214).Size = size;
		((Control)_Label1_6).TabIndex = 48;
		_Label1_6.Text = "Street Address: ";
		_Label1_6.TextAlign = (ContentAlignment)4;
		((Control)_Label1_1).BackColor = SystemColors.Control;
		((Control)_Label1_1).Cursor = Cursors.Default;
		((Control)_Label1_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_1).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_1, (short)1);
		Label label1_215 = _Label1_1;
		location = new Point(43, 322);
		((Control)label1_215).Location = location;
		((Control)_Label1_1).Name = "_Label1_1";
		((Control)_Label1_1).RightToLeft = (RightToLeft)0;
		Label label1_216 = _Label1_1;
		size = new Size(89, 19);
		((Control)label1_216).Size = size;
		((Control)_Label1_1).TabIndex = 47;
		_Label1_1.Text = "Company Name: ";
		_Label1_1.TextAlign = (ContentAlignment)4;
		((Control)_Label1_0).BackColor = SystemColors.Control;
		((Control)_Label1_0).Cursor = Cursors.Default;
		((Control)_Label1_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_0).ForeColor = SystemColors.WindowText;
		Label1.SetIndex(_Label1_0, (short)0);
		Label label1_217 = _Label1_0;
		location = new Point(7, 162);
		((Control)label1_217).Location = location;
		((Control)_Label1_0).Name = "_Label1_0";
		((Control)_Label1_0).RightToLeft = (RightToLeft)0;
		Label label1_218 = _Label1_0;
		size = new Size(123, 19);
		((Control)label1_218).Size = size;
		((Control)_Label1_0).TabIndex = 46;
		_Label1_0.Text = "Assessment Identifier:";
		_Label1_0.TextAlign = (ContentAlignment)4;
		((Control)_fraTab_3).BackColor = SystemColors.Control;
		((Control)_fraTab_3).Controls.Add((Control)(object)Label21);
		((Control)_fraTab_3).Controls.Add((Control)(object)_fraIP_1);
		((Control)_fraTab_3).Controls.Add((Control)(object)_fraIP_0);
		((Control)_fraTab_3).Controls.Add((Control)(object)_fraIP_2);
		((Control)_fraTab_3).Controls.Add((Control)(object)Label13);
		((Control)_fraTab_3).Controls.Add((Control)(object)cmdUpdOpIP);
		((Control)_fraTab_3).Controls.Add((Control)(object)lblOpParmSubtabs);
		((Control)_fraTab_3).Controls.Add((Control)(object)cmdSharedParms);
		((Control)_fraTab_3).Controls.Add((Control)(object)cmdContainerParms);
		((Control)_fraTab_3).Controls.Add((Control)(object)cmdMassBalParms);
		((Control)_fraTab_3).Controls.Add((Control)(object)_lstSelOps_1);
		((Control)_fraTab_3).Controls.Add((Control)(object)tabIP);
		((Control)_fraTab_3).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)_fraTab_3).ForeColor = SystemColors.ControlText;
		fraTab.SetIndex(_fraTab_3, (short)3);
		GroupBox fraTab_13 = _fraTab_3;
		location = new Point(124, 15);
		((Control)fraTab_13).Location = location;
		((Control)_fraTab_3).Name = "_fraTab_3";
		((Control)_fraTab_3).RightToLeft = (RightToLeft)0;
		GroupBox fraTab_14 = _fraTab_3;
		size = new Size(785, 606);
		((Control)fraTab_14).Size = size;
		((Control)_fraTab_3).TabIndex = 92;
		_fraTab_3.TabStop = false;
		_fraTab_3.Text = "4. Operation Parameters";
		((Control)_fraTab_3).Visible = false;
		((Control)Label21).BackColor = SystemColors.Control;
		((Control)Label21).Cursor = Cursors.Default;
		((Control)Label21).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label21).ForeColor = SystemColors.ControlText;
		Label label33 = Label21;
		location = new Point(16, 23);
		((Control)label33).Location = location;
		((Control)Label21).Name = "Label21";
		((Control)Label21).RightToLeft = (RightToLeft)0;
		Label label34 = Label21;
		size = new Size(753, 27);
		((Control)label34).Size = size;
		((Control)Label21).TabIndex = 393;
		Label21.Text = "Select an operation below to change/update the mass balance parameters, container parameters, or shared parameters/factors.";
		((Control)_fraIP_1).BackColor = SystemColors.Control;
		((Control)_fraIP_1).Controls.Add((Control)(object)_fraConts_3);
		((Control)_fraIP_1).Controls.Add((Control)(object)_fraConts_2);
		((Control)_fraIP_1).Controls.Add((Control)(object)_fraConts_1);
		((Control)_fraIP_1).Controls.Add((Control)(object)_fraConts_0);
		((Control)_fraIP_1).Controls.Add((Control)(object)tabConts);
		((Control)_fraIP_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraIP_1).ForeColor = SystemColors.ControlText;
		fraIP.SetIndex(_fraIP_1, (short)1);
		GroupBox fraIP_ = _fraIP_1;
		location = new Point(19, 254);
		((Control)fraIP_).Location = location;
		((Control)_fraIP_1).Name = "_fraIP_1";
		((Control)_fraIP_1).RightToLeft = (RightToLeft)0;
		GroupBox fraIP_2 = _fraIP_1;
		size = new Size(753, 267);
		((Control)fraIP_2).Size = size;
		((Control)_fraIP_1).TabIndex = 122;
		_fraIP_1.TabStop = false;
		((Control)_fraIP_1).Visible = false;
		((Control)_fraConts_3).BackColor = SystemColors.Control;
		((Control)_fraConts_3).Controls.Add((Control)(object)_msfCont_3);
		((Control)_fraConts_3).Controls.Add((Control)(object)lblContOD);
		((Control)_fraConts_3).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraConts_3).ForeColor = SystemColors.ControlText;
		fraConts.SetIndex(_fraConts_3, (short)3);
		GroupBox fraConts_ = _fraConts_3;
		location = new Point(16, 42);
		((Control)fraConts_).Location = location;
		((Control)_fraConts_3).Name = "_fraConts_3";
		((Control)_fraConts_3).RightToLeft = (RightToLeft)0;
		GroupBox fraConts_2 = _fraConts_3;
		size = new Size(721, 219);
		((Control)fraConts_2).Size = size;
		((Control)_fraConts_3).TabIndex = 264;
		_fraConts_3.TabStop = false;
		((Control)_fraConts_3).Visible = false;
		AxMSFlexGrid msfCont_ = _msfCont_3;
		location = new Point(8, 40);
		((Control)msfCont_).Location = location;
		((Control)_msfCont_3).Name = "_msfCont_3";
		((AxHost)_msfCont_3).OcxState = (State)componentResourceManager.GetObject("_msfCont_3.OcxState");
		AxMSFlexGrid msfCont_2 = _msfCont_3;
		size = new Size(705, 165);
		((Control)msfCont_2).Size = size;
		((Control)_msfCont_3).TabIndex = 265;
		((Control)lblContOD).BackColor = SystemColors.Control;
		((Control)lblContOD).Cursor = Cursors.Default;
		((Control)lblContOD).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblContOD).ForeColor = SystemColors.ControlText;
		Label obj297 = lblContOD;
		location = new Point(16, 16);
		((Control)obj297).Location = location;
		((Control)lblContOD).Name = "lblContOD";
		((Control)lblContOD).RightToLeft = (RightToLeft)0;
		Label obj298 = lblContOD;
		size = new Size(417, 17);
		((Control)obj298).Size = size;
		((Control)lblContOD).TabIndex = 282;
		lblContOD.Text = "OD (days/year) = xxxx";
		((Control)_fraConts_2).BackColor = SystemColors.Control;
		((Control)_fraConts_2).Controls.Add((Control)(object)_msfCont_2);
		((Control)_fraConts_2).Controls.Add((Control)(object)_lblContYprod_0);
		((Control)_fraConts_2).Controls.Add((Control)(object)_lblContYrm_1);
		((Control)_fraConts_2).Controls.Add((Control)(object)_lblContSumFC_2);
		((Control)_fraConts_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraConts_2).ForeColor = SystemColors.ControlText;
		fraConts.SetIndex(_fraConts_2, (short)2);
		GroupBox fraConts_3 = _fraConts_2;
		location = new Point(16, 42);
		((Control)fraConts_3).Location = location;
		((Control)_fraConts_2).Name = "_fraConts_2";
		((Control)_fraConts_2).RightToLeft = (RightToLeft)0;
		GroupBox fraConts_4 = _fraConts_2;
		size = new Size(721, 219);
		((Control)fraConts_4).Size = size;
		((Control)_fraConts_2).TabIndex = 276;
		_fraConts_2.TabStop = false;
		((Control)_fraConts_2).Visible = false;
		AxMSFlexGrid msfCont_3 = _msfCont_2;
		location = new Point(8, 40);
		((Control)msfCont_3).Location = location;
		((Control)_msfCont_2).Name = "_msfCont_2";
		((AxHost)_msfCont_2).OcxState = (State)componentResourceManager.GetObject("_msfCont_2.OcxState");
		AxMSFlexGrid msfCont_4 = _msfCont_2;
		size = new Size(705, 165);
		((Control)msfCont_4).Size = size;
		((Control)_msfCont_2).TabIndex = 277;
		((Control)_lblContYprod_0).BackColor = SystemColors.Control;
		((Control)_lblContYprod_0).Cursor = Cursors.Default;
		((Control)_lblContYprod_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblContYprod_0).ForeColor = SystemColors.ControlText;
		lblContYprod.SetIndex(_lblContYprod_0, (short)0);
		Label lblContYprod_ = _lblContYprod_0;
		location = new Point(224, 16);
		((Control)lblContYprod_).Location = location;
		((Control)_lblContYprod_0).Name = "_lblContYprod_0";
		((Control)_lblContYprod_0).RightToLeft = (RightToLeft)0;
		Label lblContYprod_2 = _lblContYprod_0;
		size = new Size(209, 17);
		((Control)lblContYprod_2).Size = size;
		((Control)_lblContYprod_0).TabIndex = 280;
		_lblContYprod_0.Text = "Yprod = xxx";
		((Control)_lblContYrm_1).BackColor = SystemColors.Control;
		((Control)_lblContYrm_1).Cursor = Cursors.Default;
		((Control)_lblContYrm_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblContYrm_1).ForeColor = SystemColors.ControlText;
		lblContYrm.SetIndex(_lblContYrm_1, (short)1);
		Label lblContYrm_ = _lblContYrm_1;
		location = new Point(16, 16);
		((Control)lblContYrm_).Location = location;
		((Control)_lblContYrm_1).Name = "_lblContYrm_1";
		((Control)_lblContYrm_1).RightToLeft = (RightToLeft)0;
		Label lblContYrm_2 = _lblContYrm_1;
		size = new Size(201, 17);
		((Control)lblContYrm_2).Size = size;
		((Control)_lblContYrm_1).TabIndex = 279;
		_lblContYrm_1.Text = "Yrm = xxx";
		((Control)_lblContSumFC_2).BackColor = SystemColors.Control;
		((Control)_lblContSumFC_2).Cursor = Cursors.Default;
		((Control)_lblContSumFC_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblContSumFC_2).ForeColor = SystemColors.ControlText;
		lblContSumFC.SetIndex(_lblContSumFC_2, (short)2);
		Label lblContSumFC_ = _lblContSumFC_2;
		location = new Point(440, 16);
		((Control)lblContSumFC_).Location = location;
		((Control)_lblContSumFC_2).Name = "_lblContSumFC_2";
		((Control)_lblContSumFC_2).RightToLeft = (RightToLeft)0;
		Label lblContSumFC_2 = _lblContSumFC_2;
		size = new Size(209, 17);
		((Control)lblContSumFC_2).Size = size;
		((Control)_lblContSumFC_2).TabIndex = 278;
		_lblContSumFC_2.Text = "Sum of fc = xxx";
		((Control)_fraConts_1).BackColor = SystemColors.Control;
		((Control)_fraConts_1).Controls.Add((Control)(object)_msfCont_1);
		((Control)_fraConts_1).Controls.Add((Control)(object)txtContDprod);
		((Control)_fraConts_1).Controls.Add((Control)(object)lblDprodType);
		((Control)_fraConts_1).Controls.Add((Control)(object)_lblContYprod_1);
		((Control)_fraConts_1).Controls.Add((Control)(object)_lblContSumFC_1);
		((Control)_fraConts_1).Controls.Add((Control)(object)_Label1_80);
		((Control)_fraConts_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraConts_1).ForeColor = SystemColors.ControlText;
		fraConts.SetIndex(_fraConts_1, (short)1);
		GroupBox fraConts_5 = _fraConts_1;
		location = new Point(16, 42);
		((Control)fraConts_5).Location = location;
		((Control)_fraConts_1).Name = "_fraConts_1";
		((Control)_fraConts_1).RightToLeft = (RightToLeft)0;
		GroupBox fraConts_6 = _fraConts_1;
		size = new Size(721, 219);
		((Control)fraConts_6).Size = size;
		((Control)_fraConts_1).TabIndex = 271;
		_fraConts_1.TabStop = false;
		((Control)_fraConts_1).Visible = false;
		AxMSFlexGrid msfCont_5 = _msfCont_1;
		location = new Point(8, 40);
		((Control)msfCont_5).Location = location;
		((Control)_msfCont_1).Name = "_msfCont_1";
		((AxHost)_msfCont_1).OcxState = (State)componentResourceManager.GetObject("_msfCont_1.OcxState");
		AxMSFlexGrid msfCont_6 = _msfCont_1;
		size = new Size(705, 165);
		((Control)msfCont_6).Size = size;
		((Control)_msfCont_1).TabIndex = 272;
		txtContDprod.AcceptsReturn = true;
		((TextBoxBase)txtContDprod).BackColor = SystemColors.Window;
		((Control)txtContDprod).Cursor = Cursors.IBeam;
		((Control)txtContDprod).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtContDprod).ForeColor = SystemColors.WindowText;
		TextBox obj299 = txtContDprod;
		location = new Point(480, 16);
		((Control)obj299).Location = location;
		((TextBoxBase)txtContDprod).MaxLength = 0;
		((Control)txtContDprod).Name = "txtContDprod";
		((Control)txtContDprod).RightToLeft = (RightToLeft)0;
		TextBox obj300 = txtContDprod;
		size = new Size(41, 20);
		((Control)obj300).Size = size;
		((Control)txtContDprod).TabIndex = 321;
		((Control)lblDprodType).BackColor = SystemColors.Control;
		((Control)lblDprodType).Cursor = Cursors.Default;
		((Control)lblDprodType).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblDprodType).ForeColor = SystemColors.ControlText;
		Label obj301 = lblDprodType;
		location = new Point(536, 16);
		((Control)obj301).Location = location;
		((Control)lblDprodType).Name = "lblDprodType";
		((Control)lblDprodType).RightToLeft = (RightToLeft)0;
		Label obj302 = lblDprodType;
		size = new Size(105, 17);
		((Control)obj302).Size = size;
		((Control)lblDprodType).TabIndex = 320;
		lblDprodType.Text = "x";
		((Control)_lblContYprod_1).BackColor = SystemColors.Control;
		((Control)_lblContYprod_1).Cursor = Cursors.Default;
		((Control)_lblContYprod_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblContYprod_1).ForeColor = SystemColors.ControlText;
		lblContYprod.SetIndex(_lblContYprod_1, (short)1);
		Label lblContYprod_3 = _lblContYprod_1;
		location = new Point(16, 16);
		((Control)lblContYprod_3).Location = location;
		((Control)_lblContYprod_1).Name = "_lblContYprod_1";
		((Control)_lblContYprod_1).RightToLeft = (RightToLeft)0;
		Label lblContYprod_4 = _lblContYprod_1;
		size = new Size(209, 17);
		((Control)lblContYprod_4).Size = size;
		((Control)_lblContYprod_1).TabIndex = 275;
		_lblContYprod_1.Text = "Yprod = xxx";
		((Control)_lblContSumFC_1).BackColor = SystemColors.Control;
		((Control)_lblContSumFC_1).Cursor = Cursors.Default;
		((Control)_lblContSumFC_1).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblContSumFC_1).ForeColor = SystemColors.ControlText;
		lblContSumFC.SetIndex(_lblContSumFC_1, (short)1);
		Label lblContSumFC_3 = _lblContSumFC_1;
		location = new Point(232, 16);
		((Control)lblContSumFC_3).Location = location;
		((Control)_lblContSumFC_1).Name = "_lblContSumFC_1";
		((Control)_lblContSumFC_1).RightToLeft = (RightToLeft)0;
		Label lblContSumFC_4 = _lblContSumFC_1;
		size = new Size(201, 17);
		((Control)lblContSumFC_4).Size = size;
		((Control)_lblContSumFC_1).TabIndex = 274;
		_lblContSumFC_1.Text = "Sum of fc = xxx";
		((Control)_Label1_80).BackColor = SystemColors.Control;
		((Control)_Label1_80).Cursor = Cursors.Default;
		((Control)_Label1_80).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_80).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_80, (short)80);
		Label label1_219 = _Label1_80;
		location = new Point(432, 16);
		((Control)label1_219).Location = location;
		((Control)_Label1_80).Name = "_Label1_80";
		((Control)_Label1_80).RightToLeft = (RightToLeft)0;
		Label label1_220 = _Label1_80;
		size = new Size(41, 17);
		((Control)label1_220).Size = size;
		((Control)_Label1_80).TabIndex = 273;
		_Label1_80.Text = "Dprod = ";
		((Control)_fraConts_0).BackColor = SystemColors.Control;
		((Control)_fraConts_0).Controls.Add((Control)(object)_msfCont_0);
		((Control)_fraConts_0).Controls.Add((Control)(object)txtContDrm);
		((Control)_fraConts_0).Controls.Add((Control)(object)lblDrmType);
		((Control)_fraConts_0).Controls.Add((Control)(object)_lblContYrm_0);
		((Control)_fraConts_0).Controls.Add((Control)(object)_lblContSumFC_0);
		((Control)_fraConts_0).Controls.Add((Control)(object)_Label1_81);
		((Control)_fraConts_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraConts_0).ForeColor = SystemColors.ControlText;
		fraConts.SetIndex(_fraConts_0, (short)0);
		GroupBox fraConts_7 = _fraConts_0;
		location = new Point(16, 42);
		((Control)fraConts_7).Location = location;
		((Control)_fraConts_0).Name = "_fraConts_0";
		((Control)_fraConts_0).RightToLeft = (RightToLeft)0;
		GroupBox fraConts_8 = _fraConts_0;
		size = new Size(721, 219);
		((Control)fraConts_8).Size = size;
		((Control)_fraConts_0).TabIndex = 266;
		_fraConts_0.TabStop = false;
		AxMSFlexGrid msfCont_7 = _msfCont_0;
		location = new Point(8, 40);
		((Control)msfCont_7).Location = location;
		((Control)_msfCont_0).Name = "_msfCont_0";
		((AxHost)_msfCont_0).OcxState = (State)componentResourceManager.GetObject("_msfCont_0.OcxState");
		AxMSFlexGrid msfCont_8 = _msfCont_0;
		size = new Size(705, 165);
		((Control)msfCont_8).Size = size;
		((Control)_msfCont_0).TabIndex = 267;
		txtContDrm.AcceptsReturn = true;
		((TextBoxBase)txtContDrm).BackColor = SystemColors.Window;
		((Control)txtContDrm).Cursor = Cursors.IBeam;
		((Control)txtContDrm).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtContDrm).ForeColor = SystemColors.WindowText;
		TextBox obj303 = txtContDrm;
		location = new Point(480, 16);
		((Control)obj303).Location = location;
		((TextBoxBase)txtContDrm).MaxLength = 0;
		((Control)txtContDrm).Name = "txtContDrm";
		((Control)txtContDrm).RightToLeft = (RightToLeft)0;
		TextBox obj304 = txtContDrm;
		size = new Size(49, 20);
		((Control)obj304).Size = size;
		((Control)txtContDrm).TabIndex = 322;
		((Control)lblDrmType).BackColor = SystemColors.Control;
		((Control)lblDrmType).Cursor = Cursors.Default;
		((Control)lblDrmType).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblDrmType).ForeColor = SystemColors.ControlText;
		Label obj305 = lblDrmType;
		location = new Point(536, 16);
		((Control)obj305).Location = location;
		((Control)lblDrmType).Name = "lblDrmType";
		((Control)lblDrmType).RightToLeft = (RightToLeft)0;
		Label obj306 = lblDrmType;
		size = new Size(105, 17);
		((Control)obj306).Size = size;
		((Control)lblDrmType).TabIndex = 323;
		lblDrmType.Text = "x";
		((Control)_lblContYrm_0).BackColor = SystemColors.Control;
		((Control)_lblContYrm_0).Cursor = Cursors.Default;
		((Control)_lblContYrm_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblContYrm_0).ForeColor = SystemColors.ControlText;
		lblContYrm.SetIndex(_lblContYrm_0, (short)0);
		Label lblContYrm_3 = _lblContYrm_0;
		location = new Point(16, 16);
		((Control)lblContYrm_3).Location = location;
		((Control)_lblContYrm_0).Name = "_lblContYrm_0";
		((Control)_lblContYrm_0).RightToLeft = (RightToLeft)0;
		Label lblContYrm_4 = _lblContYrm_0;
		size = new Size(209, 17);
		((Control)lblContYrm_4).Size = size;
		((Control)_lblContYrm_0).TabIndex = 270;
		_lblContYrm_0.Text = "Yrm = xxx";
		((Control)_lblContSumFC_0).BackColor = SystemColors.Control;
		((Control)_lblContSumFC_0).Cursor = Cursors.Default;
		((Control)_lblContSumFC_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_lblContSumFC_0).ForeColor = SystemColors.ControlText;
		lblContSumFC.SetIndex(_lblContSumFC_0, (short)0);
		Label lblContSumFC_5 = _lblContSumFC_0;
		location = new Point(232, 16);
		((Control)lblContSumFC_5).Location = location;
		((Control)_lblContSumFC_0).Name = "_lblContSumFC_0";
		((Control)_lblContSumFC_0).RightToLeft = (RightToLeft)0;
		Label lblContSumFC_6 = _lblContSumFC_0;
		size = new Size(201, 17);
		((Control)lblContSumFC_6).Size = size;
		((Control)_lblContSumFC_0).TabIndex = 269;
		_lblContSumFC_0.Text = "Sum of fc = xxx";
		((Control)_Label1_81).BackColor = SystemColors.Control;
		((Control)_Label1_81).Cursor = Cursors.Default;
		((Control)_Label1_81).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_81).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_81, (short)81);
		Label label1_221 = _Label1_81;
		location = new Point(448, 16);
		((Control)label1_221).Location = location;
		((Control)_Label1_81).Name = "_Label1_81";
		((Control)_Label1_81).RightToLeft = (RightToLeft)0;
		Label label1_222 = _Label1_81;
		size = new Size(33, 17);
		((Control)label1_222).Size = size;
		((Control)_Label1_81).TabIndex = 268;
		_Label1_81.Text = "Drm =";
		AxTabStrip obj307 = tabConts;
		location = new Point(17, 18);
		((Control)obj307).Location = location;
		((Control)tabConts).Name = "tabConts";
		((AxHost)tabConts).OcxState = (State)componentResourceManager.GetObject("tabConts.OcxState");
		AxTabStrip obj308 = tabConts;
		size = new Size(715, 243);
		((Control)obj308).Size = size;
		((Control)tabConts).TabIndex = 263;
		((Control)_fraIP_0).BackColor = SystemColors.Control;
		((Control)_fraIP_0).Controls.Add((Control)(object)msfOpIP);
		((Control)_fraIP_0).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraIP_0).ForeColor = SystemColors.ControlText;
		fraIP.SetIndex(_fraIP_0, (short)0);
		GroupBox fraIP_3 = _fraIP_0;
		location = new Point(19, 254);
		((Control)fraIP_3).Location = location;
		((Control)_fraIP_0).Name = "_fraIP_0";
		((Control)_fraIP_0).RightToLeft = (RightToLeft)0;
		GroupBox fraIP_4 = _fraIP_0;
		size = new Size(753, 258);
		((Control)fraIP_4).Size = size;
		((Control)_fraIP_0).TabIndex = 105;
		_fraIP_0.TabStop = false;
		AxMSFlexGrid obj309 = msfOpIP;
		location = new Point(16, 16);
		((Control)obj309).Location = location;
		((Control)msfOpIP).Name = "msfOpIP";
		((AxHost)msfOpIP).OcxState = (State)componentResourceManager.GetObject("msfOpIP.OcxState");
		AxMSFlexGrid obj310 = msfOpIP;
		size = new Size(729, 221);
		((Control)obj310).Size = size;
		((Control)msfOpIP).TabIndex = 106;
		((Control)_fraIP_2).BackColor = SystemColors.Control;
		((Control)_fraIP_2).Controls.Add((Control)(object)cmdUpdAVP);
		((Control)_fraIP_2).Controls.Add((Control)(object)msfSP);
		((Control)_fraIP_2).Controls.Add((Control)(object)_Line1_3);
		((Control)_fraIP_2).Controls.Add((Control)(object)lblAVPhigh);
		((Control)_fraIP_2).Controls.Add((Control)(object)lblAVPlow);
		((Control)_fraIP_2).Controls.Add((Control)(object)_Label1_86);
		((Control)_fraIP_2).Controls.Add((Control)(object)_Label1_85);
		((Control)_fraIP_2).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_fraIP_2).ForeColor = SystemColors.ControlText;
		fraIP.SetIndex(_fraIP_2, (short)2);
		GroupBox fraIP_5 = _fraIP_2;
		location = new Point(19, 254);
		((Control)fraIP_5).Location = location;
		((Control)_fraIP_2).Name = "_fraIP_2";
		((Control)_fraIP_2).RightToLeft = (RightToLeft)0;
		GroupBox fraIP_6 = _fraIP_2;
		size = new Size(753, 258);
		((Control)fraIP_6).Size = size;
		((Control)_fraIP_2).TabIndex = 287;
		_fraIP_2.TabStop = false;
		((Control)_fraIP_2).Visible = false;
		((ButtonBase)cmdUpdAVP).BackColor = SystemColors.Control;
		((Control)cmdUpdAVP).Cursor = Cursors.Default;
		((Control)cmdUpdAVP).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdAVP).ForeColor = SystemColors.ControlText;
		Button obj311 = cmdUpdAVP;
		location = new Point(315, 16);
		((Control)obj311).Location = location;
		((Control)cmdUpdAVP).Name = "cmdUpdAVP";
		((Control)cmdUpdAVP).RightToLeft = (RightToLeft)0;
		Button obj312 = cmdUpdAVP;
		size = new Size(129, 25);
		((Control)obj312).Size = size;
		((Control)cmdUpdAVP).TabIndex = 296;
		((ButtonBase)cmdUpdAVP).Text = "Update AVPrange";
		((ButtonBase)cmdUpdAVP).UseVisualStyleBackColor = false;
		AxMSFlexGrid obj313 = msfSP;
		location = new Point(20, 52);
		((Control)obj313).Location = location;
		((Control)msfSP).Name = "msfSP";
		((AxHost)msfSP).OcxState = (State)componentResourceManager.GetObject("msfSP.OcxState");
		AxMSFlexGrid obj314 = msfSP;
		size = new Size(729, 189);
		((Control)obj314).Size = size;
		((Control)msfSP).TabIndex = 288;
		((Control)_Line1_3).BackColor = SystemColors.WindowText;
		Line1.SetIndex(_Line1_3, (short)3);
		Label line1_7 = _Line1_3;
		location = new Point(11, 45);
		((Control)line1_7).Location = location;
		((Control)_Line1_3).Name = "_Line1_3";
		Label line1_8 = _Line1_3;
		size = new Size(736, 1);
		((Control)line1_8).Size = size;
		((Control)_Line1_3).TabIndex = 298;
		((Control)lblAVPhigh).BackColor = SystemColors.Control;
		((Control)lblAVPhigh).Cursor = Cursors.Default;
		((Control)lblAVPhigh).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblAVPhigh).ForeColor = SystemColors.ControlText;
		Label obj315 = lblAVPhigh;
		location = new Point(83, 32);
		((Control)obj315).Location = location;
		((Control)lblAVPhigh).Name = "lblAVPhigh";
		((Control)lblAVPhigh).RightToLeft = (RightToLeft)0;
		Label obj316 = lblAVPhigh;
		size = new Size(49, 17);
		((Control)obj316).Size = size;
		((Control)lblAVPhigh).TabIndex = 295;
		lblAVPhigh.Text = "X";
		((Control)lblAVPlow).BackColor = SystemColors.Control;
		((Control)lblAVPlow).Cursor = Cursors.Default;
		((Control)lblAVPlow).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblAVPlow).ForeColor = SystemColors.ControlText;
		Label obj317 = lblAVPlow;
		location = new Point(83, 16);
		((Control)obj317).Location = location;
		((Control)lblAVPlow).Name = "lblAVPlow";
		((Control)lblAVPlow).RightToLeft = (RightToLeft)0;
		Label obj318 = lblAVPlow;
		size = new Size(49, 17);
		((Control)obj318).Size = size;
		((Control)lblAVPlow).TabIndex = 294;
		lblAVPlow.Text = "X";
		((Control)_Label1_86).BackColor = SystemColors.Control;
		((Control)_Label1_86).Cursor = Cursors.Default;
		((Control)_Label1_86).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_86).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_86, (short)86);
		Label label1_223 = _Label1_86;
		location = new Point(27, 32);
		((Control)label1_223).Location = location;
		((Control)_Label1_86).Name = "_Label1_86";
		((Control)_Label1_86).RightToLeft = (RightToLeft)0;
		Label label1_224 = _Label1_86;
		size = new Size(49, 17);
		((Control)label1_224).Size = size;
		((Control)_Label1_86).TabIndex = 293;
		_Label1_86.Text = "AVPhigh:";
		((Control)_Label1_85).BackColor = SystemColors.Control;
		((Control)_Label1_85).Cursor = Cursors.Default;
		((Control)_Label1_85).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)_Label1_85).ForeColor = SystemColors.ControlText;
		Label1.SetIndex(_Label1_85, (short)85);
		Label label1_225 = _Label1_85;
		location = new Point(27, 16);
		((Control)label1_225).Location = location;
		((Control)_Label1_85).Name = "_Label1_85";
		((Control)_Label1_85).RightToLeft = (RightToLeft)0;
		Label label1_226 = _Label1_85;
		size = new Size(57, 17);
		((Control)label1_226).Size = size;
		((Control)_Label1_85).TabIndex = 292;
		_Label1_85.Text = "AVPlow:";
		Label13.AutoSize = true;
		Label label35 = Label13;
		location = new Point(20, 524);
		((Control)label35).Location = location;
		((Control)Label13).Name = "Label13";
		Label label36 = Label13;
		size = new Size(167, 14);
		((Control)label36).Size = size;
		((Control)Label13).TabIndex = 392;
		Label13.Text = "Operation Parameter Actions";
		((ButtonBase)cmdUpdOpIP).BackColor = SystemColors.Control;
		((Control)cmdUpdOpIP).Cursor = Cursors.Default;
		((Control)cmdUpdOpIP).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdUpdOpIP).ForeColor = SystemColors.ControlText;
		Button obj319 = cmdUpdOpIP;
		location = new Point(20, 549);
		((Control)obj319).Location = location;
		((Control)cmdUpdOpIP).Name = "cmdUpdOpIP";
		((Control)cmdUpdOpIP).RightToLeft = (RightToLeft)0;
		Button obj320 = cmdUpdOpIP;
		size = new Size(177, 41);
		((Control)obj320).Size = size;
		((Control)cmdUpdOpIP).TabIndex = 295;
		((ButtonBase)cmdUpdOpIP).Text = "Update Parameters";
		((ButtonBase)cmdUpdOpIP).UseVisualStyleBackColor = false;
		((Control)lblOpParmSubtabs).BackColor = SystemColors.Control;
		((Control)lblOpParmSubtabs).Cursor = Cursors.Default;
		((Control)lblOpParmSubtabs).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)lblOpParmSubtabs).ForeColor = SystemColors.ControlText;
		Label obj321 = lblOpParmSubtabs;
		location = new Point(14, 177);
		((Control)obj321).Location = location;
		((Control)lblOpParmSubtabs).Name = "lblOpParmSubtabs";
		((Control)lblOpParmSubtabs).RightToLeft = (RightToLeft)0;
		Label obj322 = lblOpParmSubtabs;
		size = new Size(753, 76);
		((Control)obj322).Size = size;
		((Control)lblOpParmSubtabs).TabIndex = 294;
		lblOpParmSubtabs.Text = "lblOpParmSubtabs";
		((ButtonBase)cmdSharedParms).BackColor = SystemColors.Control;
		((Control)cmdSharedParms).Cursor = Cursors.Default;
		((Control)cmdSharedParms).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdSharedParms).ForeColor = SystemColors.ControlText;
		Button obj323 = cmdSharedParms;
		location = new Point(387, 133);
		((Control)obj323).Location = location;
		((Control)cmdSharedParms).Name = "cmdSharedParms";
		((Control)cmdSharedParms).RightToLeft = (RightToLeft)0;
		Button obj324 = cmdSharedParms;
		size = new Size(198, 32);
		((Control)obj324).Size = size;
		((Control)cmdSharedParms).TabIndex = 293;
		((ButtonBase)cmdSharedParms).Text = "4c. Shared Parameters / Factors";
		((ButtonBase)cmdSharedParms).UseVisualStyleBackColor = false;
		((ButtonBase)cmdContainerParms).BackColor = SystemColors.Control;
		((Control)cmdContainerParms).Cursor = Cursors.Default;
		((Control)cmdContainerParms).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdContainerParms).ForeColor = SystemColors.ControlText;
		Button obj325 = cmdContainerParms;
		location = new Point(201, 133);
		((Control)obj325).Location = location;
		((Control)cmdContainerParms).Name = "cmdContainerParms";
		((Control)cmdContainerParms).RightToLeft = (RightToLeft)0;
		Button obj326 = cmdContainerParms;
		size = new Size(186, 32);
		((Control)obj326).Size = size;
		((Control)cmdContainerParms).TabIndex = 292;
		((ButtonBase)cmdContainerParms).Text = "4b. Container Parameters";
		((ButtonBase)cmdContainerParms).UseVisualStyleBackColor = false;
		((ButtonBase)cmdMassBalParms).BackColor = Color.DimGray;
		((Control)cmdMassBalParms).Cursor = Cursors.Default;
		((Control)cmdMassBalParms).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Control)cmdMassBalParms).ForeColor = Color.White;
		Button obj327 = cmdMassBalParms;
		location = new Point(16, 133);
		((Control)obj327).Location = location;
		((Control)cmdMassBalParms).Name = "cmdMassBalParms";
		((Control)cmdMassBalParms).RightToLeft = (RightToLeft)0;
		Button obj328 = cmdMassBalParms;
		size = new Size(186, 32);
		((Control)obj328).Size = size;
		((Control)cmdMassBalParms).TabIndex = 291;
		((ButtonBase)cmdMassBalParms).Text = "4a. Mass Balance Parameters";
		((ButtonBase)cmdMassBalParms).UseVisualStyleBackColor = false;
		_lstSelOps_1.BackColor = SystemColors.Window;
		((Control)_lstSelOps_1).Cursor = Cursors.Default;
		_lstSelOps_1.Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		_lstSelOps_1.ForeColor = SystemColors.WindowText;
		_lstSelOps_1.ItemHeight = 14;
		ListBox lstSelOps_3 = _lstSelOps_1;
		location = new Point(19, 57);
		((Control)lstSelOps_3).Location = location;
		((Control)_lstSelOps_1).Name = "_lstSelOps_1";
		_lstSelOps_1.RightToLeft = (RightToLeft)0;
		ListBox lstSelOps_4 = _lstSelOps_1;
		size = new Size(569, 60);
		((Control)lstSelOps_4).Size = size;
		((Control)_lstSelOps_1).TabIndex = 103;
		AxTabStrip obj329 = tabIP;
		location = new Point(23, 268);
		((Control)obj329).Location = location;
		((Control)tabIP).Name = "tabIP";
		((AxHost)tabIP).OcxState = (State)componentResourceManager.GetObject("tabIP.OcxState");
		AxTabStrip obj330 = tabIP;
		size = new Size(744, 177);
		((Control)obj330).Size = size;
		((Control)tabIP).TabIndex = 121;
		AxTabStrip obj331 = tabMain;
		location = new Point(124, 15);
		((Control)obj331).Location = location;
		((Control)tabMain).Name = "tabMain";
		((AxHost)tabMain).OcxState = (State)componentResourceManager.GetObject("tabMain.OcxState");
		AxTabStrip obj332 = tabMain;
		size = new Size(829, 469);
		((Control)obj332).Size = size;
		((Control)tabMain).TabIndex = 44;
		((Control)tabMain).UseWaitCursor = true;
		mnuPreferences.SetIndex(_mnuPreferences_0, (short)0);
		_mnuPreferences_0.Index = 0;
		_mnuPreferences_0.Text = "&Default Database";
		mnuPreferences.SetIndex(_mnuPreferences_1, (short)1);
		_mnuPreferences_1.Index = 1;
		_mnuPreferences_1.Text = "&Vapor Model Activation";
		mnuPreferences.SetIndex(_mnuPreferences_2, (short)2);
		_mnuPreferences_2.Index = 2;
		_mnuPreferences_2.Text = "&Specify CRSS Database";
		_mnuReportCR_0.Index = 3;
		_mnuReportCR_0.Text = "View &Contact Report";
		_mnuReportIRER_0.Index = 0;
		_mnuReportIRER_0.Text = "View &IRER Report";
		((Menu)MainMenu1).MenuItems.AddRange((MenuItem[])(object)new MenuItem[5] { mnuFile, mnuEdit, mnuPref, mnuReportS, mnuHelp });
		mnuFile.Index = 0;
		((Menu)mnuFile).MenuItems.AddRange((MenuItem[])(object)new MenuItem[22]
		{
			mnuFileNew, mnuFileOpen, mnuFileClose, mnuFileSep1, mnuFileSave, mnuFileSaveAs, mnuFileSep2, mnuFileUpdateGSS, mnuFileSaveGSS, mnuFileRenameGSS,
			mnuFileDeleteGSS, mnuFileSep7, mnuFileRevHistory, mnuFileSep3, mnuFileDelete, mnuFileSep4, mnuFileImportCRSS, mnuFileViewCRSS, mnuFileSep5, mnuFileEasyModels,
			mnuFileSep6, mnuFileExit
		});
		mnuFile.Text = "&File";
		mnuFileNew.Index = 0;
		mnuFileNew.Text = "&New Assessment";
		mnuFileOpen.Index = 1;
		mnuFileOpen.Text = "&Open Assessment";
		mnuFileClose.Index = 2;
		mnuFileClose.Text = "&Close Assessment";
		mnuFileSep1.Index = 3;
		mnuFileSep1.Text = "-";
		mnuFileSave.Index = 4;
		mnuFileSave.Text = "&Save Assessment";
		mnuFileSaveAs.Index = 5;
		mnuFileSaveAs.Text = "Save Assessment &As";
		mnuFileSep2.Index = 6;
		mnuFileSep2.Text = "-";
		mnuFileUpdateGSS.Index = 7;
		mnuFileUpdateGSS.Text = "&Replace Generic Scenario Database";
		mnuFileSaveGSS.Index = 8;
		mnuFileSaveGSS.Text = "Save &Generic Scenario Operation";
		mnuFileRenameGSS.Index = 9;
		mnuFileRenameGSS.Text = "Rename Generic Scenario Operation";
		mnuFileDeleteGSS.Index = 10;
		mnuFileDeleteGSS.Text = "Dele&te Generic Scenario Operation";
		mnuFileSep7.Index = 11;
		mnuFileSep7.Text = "-";
		mnuFileRevHistory.Enabled = false;
		mnuFileRevHistory.Index = 12;
		mnuFileRevHistory.Text = "&Revision History";
		mnuFileSep3.Index = 13;
		mnuFileSep3.Text = "-";
		mnuFileDelete.Index = 14;
		mnuFileDelete.Text = "&Delete Assessment";
		mnuFileSep4.Index = 15;
		mnuFileSep4.Text = "-";
		mnuFileImportCRSS.Index = 16;
		mnuFileImportCRSS.Text = "&Import CRSS Report";
		mnuFileViewCRSS.Index = 17;
		mnuFileViewCRSS.Text = "&View CRSS Report";
		mnuFileSep5.Index = 18;
		mnuFileSep5.Text = "-";
		mnuFileEasyModels.Index = 19;
		mnuFileEasyModels.Text = "Run Models (Advanced Users)";
		mnuFileSep6.Index = 20;
		mnuFileSep6.Text = "-";
		mnuFileExit.Index = 21;
		mnuFileExit.Text = "E&xit";
		mnuEdit.Index = 1;
		((Menu)mnuEdit).MenuItems.AddRange((MenuItem[])(object)new MenuItem[3] { mnuEditCut, mnuEditCopy, mnuEditPaste });
		mnuEdit.Text = "&Edit";
		mnuEditCut.Index = 0;
		mnuEditCut.Text = "Cu&t";
		mnuEditCopy.Index = 1;
		mnuEditCopy.Text = "&Copy";
		mnuEditPaste.Index = 2;
		mnuEditPaste.Text = "&Paste";
		mnuPref.Index = 2;
		((Menu)mnuPref).MenuItems.AddRange((MenuItem[])(object)new MenuItem[3] { _mnuPreferences_0, _mnuPreferences_1, _mnuPreferences_2 });
		mnuPref.Text = "&Preferences";
		mnuReportS.Index = 3;
		((Menu)mnuReportS).MenuItems.AddRange((MenuItem[])(object)new MenuItem[8] { _mnuReportIRER_0, _mnuReportIRER_1, mnuReportSep1, _mnuReportCR_0, _mnuReportCR_1, mnuReportSep2, _mnuReportIRER_2, _mnuReportIRER_3 });
		mnuReportS.Text = "&Reports";
		_mnuReportIRER_1.Index = 1;
		_mnuReportIRER_1.Text = "Save IRER Report";
		mnuReportSep1.Index = 2;
		mnuReportSep1.Text = "-";
		_mnuReportCR_1.Index = 4;
		_mnuReportCR_1.Text = "Save Contact Report";
		mnuReportSep2.Index = 5;
		mnuReportSep2.Text = "-";
		_mnuReportIRER_2.Index = 6;
		_mnuReportIRER_2.Text = "View Combined IRER and Contact Report";
		_mnuReportIRER_3.Index = 7;
		_mnuReportIRER_3.Text = "Save Combined IRER &and Contact Report";
		mnuHelp.Index = 4;
		((Menu)mnuHelp).MenuItems.AddRange((MenuItem[])(object)new MenuItem[3] { mnuHelpViewQuickStartGuide, mnuHelpViewUserGuide, mnuHelpAbout });
		mnuHelp.Text = "&Help";
		mnuHelpViewQuickStartGuide.Index = 0;
		mnuHelpViewQuickStartGuide.Text = "View ChemSTEER Quick Start Guide";
		mnuHelpViewUserGuide.Index = 1;
		mnuHelpViewUserGuide.Text = "View ChemSTEER User Guide";
		mnuHelpAbout.Index = 2;
		mnuHelpAbout.Text = "&About";
		((Control)cmdGeneral).AllowDrop = true;
		((ButtonBase)cmdGeneral).BackColor = Color.DimGray;
		((Control)cmdGeneral).Cursor = Cursors.Default;
		((Control)cmdGeneral).Font = new Font("Arial", 8f, (FontStyle)1);
		((Control)cmdGeneral).ForeColor = Color.White;
		Button obj333 = cmdGeneral;
		location = new Point(12, 21);
		((Control)obj333).Location = location;
		((Control)cmdGeneral).Name = "cmdGeneral";
		((Control)cmdGeneral).RightToLeft = (RightToLeft)0;
		Button obj334 = cmdGeneral;
		size = new Size(103, 54);
		((Control)obj334).Size = size;
		((Control)cmdGeneral).TabIndex = 385;
		((ButtonBase)cmdGeneral).Text = "1. &General Information";
		((ButtonBase)cmdGeneral).UseVisualStyleBackColor = false;
		((Control)cmdChemical).AllowDrop = true;
		((ButtonBase)cmdChemical).AutoEllipsis = true;
		((ButtonBase)cmdChemical).BackColor = SystemColors.Control;
		((Control)cmdChemical).Cursor = Cursors.Default;
		((Control)cmdChemical).Font = new Font("Arial", 8f, (FontStyle)1);
		((Control)cmdChemical).ForeColor = SystemColors.ControlText;
		Button obj335 = cmdChemical;
		location = new Point(12, 86);
		((Control)obj335).Location = location;
		((Control)cmdChemical).Name = "cmdChemical";
		((Control)cmdChemical).RightToLeft = (RightToLeft)0;
		Button obj336 = cmdChemical;
		size = new Size(103, 54);
		((Control)obj336).Size = size;
		((Control)cmdChemical).TabIndex = 386;
		((ButtonBase)cmdChemical).Text = "2. &Chemical Properties";
		((ButtonBase)cmdChemical).UseVisualStyleBackColor = false;
		((Control)cmdOpParms).AllowDrop = true;
		((ButtonBase)cmdOpParms).AutoEllipsis = true;
		((ButtonBase)cmdOpParms).BackColor = SystemColors.Control;
		((Control)cmdOpParms).Cursor = Cursors.Default;
		((Control)cmdOpParms).Font = new Font("Arial", 8f, (FontStyle)1);
		((Control)cmdOpParms).ForeColor = SystemColors.ControlText;
		Button obj337 = cmdOpParms;
		location = new Point(12, 218);
		((Control)obj337).Location = location;
		((Control)cmdOpParms).Name = "cmdOpParms";
		((Control)cmdOpParms).RightToLeft = (RightToLeft)0;
		Button obj338 = cmdOpParms;
		size = new Size(103, 54);
		((Control)obj338).Size = size;
		((Control)cmdOpParms).TabIndex = 388;
		((ButtonBase)cmdOpParms).Text = "4. Operation &Parameters";
		((ButtonBase)cmdOpParms).UseVisualStyleBackColor = false;
		((Control)cmdOperations).AllowDrop = true;
		((ButtonBase)cmdOperations).BackColor = SystemColors.Control;
		((Control)cmdOperations).Cursor = Cursors.Default;
		((Control)cmdOperations).Font = new Font("Arial", 8f, (FontStyle)1);
		((Control)cmdOperations).ForeColor = SystemColors.ControlText;
		Button obj339 = cmdOperations;
		location = new Point(12, 152);
		((Control)obj339).Location = location;
		((Control)cmdOperations).Name = "cmdOperations";
		((Control)cmdOperations).RightToLeft = (RightToLeft)0;
		Button obj340 = cmdOperations;
		size = new Size(103, 54);
		((Control)obj340).Size = size;
		((Control)cmdOperations).TabIndex = 387;
		((ButtonBase)cmdOperations).Text = "3. &Operations";
		((ButtonBase)cmdOperations).UseVisualStyleBackColor = false;
		((Control)cmdExposures).AllowDrop = true;
		((ButtonBase)cmdExposures).AutoEllipsis = true;
		((ButtonBase)cmdExposures).BackColor = SystemColors.Control;
		((Control)cmdExposures).Cursor = Cursors.Default;
		((Control)cmdExposures).Font = new Font("Arial", 8f, (FontStyle)1);
		((Control)cmdExposures).ForeColor = SystemColors.ControlText;
		Button obj341 = cmdExposures;
		location = new Point(12, 349);
		((Control)obj341).Location = location;
		((Control)cmdExposures).Name = "cmdExposures";
		((Control)cmdExposures).RightToLeft = (RightToLeft)0;
		Button obj342 = cmdExposures;
		size = new Size(103, 54);
		((Control)obj342).Size = size;
		((Control)cmdExposures).TabIndex = 390;
		((ButtonBase)cmdExposures).Text = "6. &Estimating Chemical Exposures";
		((ButtonBase)cmdExposures).UseVisualStyleBackColor = false;
		((Control)cmdReleases).AllowDrop = true;
		((ButtonBase)cmdReleases).BackColor = SystemColors.Control;
		((Control)cmdReleases).Cursor = Cursors.Default;
		((Control)cmdReleases).Font = new Font("Arial", 8f, (FontStyle)1);
		((Control)cmdReleases).ForeColor = SystemColors.ControlText;
		Button obj343 = cmdReleases;
		location = new Point(12, 284);
		((Control)obj343).Location = location;
		((Control)cmdReleases).Name = "cmdReleases";
		((Control)cmdReleases).RightToLeft = (RightToLeft)0;
		Button obj344 = cmdReleases;
		size = new Size(103, 54);
		((Control)obj344).Size = size;
		((Control)cmdReleases).TabIndex = 389;
		((ButtonBase)cmdReleases).Text = "5. &Estimating Chemical Releases";
		((ButtonBase)cmdReleases).UseVisualStyleBackColor = false;
		((Control)cmdOptionalInfo).AllowDrop = true;
		((ButtonBase)cmdOptionalInfo).AutoEllipsis = true;
		((ButtonBase)cmdOptionalInfo).BackColor = SystemColors.Control;
		((Control)cmdOptionalInfo).Cursor = Cursors.Default;
		((Control)cmdOptionalInfo).Font = new Font("Arial", 8f, (FontStyle)1);
		((Control)cmdOptionalInfo).ForeColor = SystemColors.ControlText;
		Button obj345 = cmdOptionalInfo;
		location = new Point(12, 416);
		((Control)obj345).Location = location;
		((Control)cmdOptionalInfo).Name = "cmdOptionalInfo";
		((Control)cmdOptionalInfo).RightToLeft = (RightToLeft)0;
		Button obj346 = cmdOptionalInfo;
		size = new Size(103, 54);
		((Control)obj346).Size = size;
		((Control)cmdOptionalInfo).TabIndex = 391;
		((ButtonBase)cmdOptionalInfo).Text = "7. Optional &Information";
		((ButtonBase)cmdOptionalInfo).UseVisualStyleBackColor = false;
		((Control)cmdReports).AllowDrop = true;
		((ButtonBase)cmdReports).AutoEllipsis = true;
		((ButtonBase)cmdReports).BackColor = SystemColors.Control;
		((Control)cmdReports).Cursor = Cursors.Default;
		((Control)cmdReports).Font = new Font("Arial", 8f, (FontStyle)1);
		((Control)cmdReports).ForeColor = SystemColors.ControlText;
		Button obj347 = cmdReports;
		location = new Point(12, 486);
		((Control)obj347).Location = location;
		((Control)cmdReports).Name = "cmdReports";
		((Control)cmdReports).RightToLeft = (RightToLeft)0;
		Button obj348 = cmdReports;
		size = new Size(103, 54);
		((Control)obj348).Size = size;
		((Control)cmdReports).TabIndex = 392;
		((ButtonBase)cmdReports).Text = "8. &Reports";
		((ButtonBase)cmdReports).UseVisualStyleBackColor = false;
		((Control)_fraTab_7).Controls.Add((Control)(object)Label19);
		((Control)_fraTab_7).Controls.Add((Control)(object)cmdSaveCombo);
		((Control)_fraTab_7).Controls.Add((Control)(object)cmdViewCombo);
		((Control)_fraTab_7).Controls.Add((Control)(object)cmdSaveContact);
		((Control)_fraTab_7).Controls.Add((Control)(object)cmdViewContact);
		((Control)_fraTab_7).Controls.Add((Control)(object)cmdSaveIRER);
		((Control)_fraTab_7).Controls.Add((Control)(object)cmdViewIRER);
		((Control)_fraTab_7).Font = new Font("Arial", 8.25f, (FontStyle)1);
		GroupBox fraTab_15 = _fraTab_7;
		location = new Point(124, 15);
		((Control)fraTab_15).Location = location;
		((Control)_fraTab_7).Name = "_fraTab_7";
		GroupBox fraTab_16 = _fraTab_7;
		size = new Size(785, 605);
		((Control)fraTab_16).Size = size;
		((Control)_fraTab_7).TabIndex = 393;
		_fraTab_7.TabStop = false;
		_fraTab_7.Text = "8. Reports";
		((Control)Label19).BackColor = SystemColors.Control;
		((Control)Label19).Cursor = Cursors.Default;
		((Control)Label19).Font = new Font("Arial", 9f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)Label19).ForeColor = SystemColors.ControlText;
		Label label37 = Label19;
		location = new Point(16, 26);
		((Control)label37).Location = location;
		((Control)Label19).Name = "Label19";
		((Control)Label19).RightToLeft = (RightToLeft)0;
		Label label38 = Label19;
		size = new Size(745, 34);
		((Control)label38).Size = size;
		((Control)Label19).TabIndex = 393;
		Label19.Text = "Click one of the buttons below to view or save a report.";
		((ButtonBase)cmdSaveCombo).BackColor = SystemColors.Control;
		((Control)cmdSaveCombo).Cursor = Cursors.Default;
		((Control)cmdSaveCombo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdSaveCombo).ForeColor = SystemColors.ControlText;
		Button obj349 = cmdSaveCombo;
		location = new Point(265, 411);
		((Control)obj349).Location = location;
		((Control)cmdSaveCombo).Name = "cmdSaveCombo";
		((Control)cmdSaveCombo).RightToLeft = (RightToLeft)0;
		Button obj350 = cmdSaveCombo;
		size = new Size(239, 41);
		((Control)obj350).Size = size;
		((Control)cmdSaveCombo).TabIndex = 9;
		((ButtonBase)cmdSaveCombo).Text = "&Save Combined IRER && Contact Report";
		((ButtonBase)cmdSaveCombo).UseVisualStyleBackColor = false;
		((ButtonBase)cmdViewCombo).BackColor = SystemColors.Control;
		((Control)cmdViewCombo).Cursor = Cursors.Default;
		((Control)cmdViewCombo).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdViewCombo).ForeColor = SystemColors.ControlText;
		Button obj351 = cmdViewCombo;
		location = new Point(265, 361);
		((Control)obj351).Location = location;
		((Control)cmdViewCombo).Name = "cmdViewCombo";
		((Control)cmdViewCombo).RightToLeft = (RightToLeft)0;
		Button obj352 = cmdViewCombo;
		size = new Size(239, 41);
		((Control)obj352).Size = size;
		((Control)cmdViewCombo).TabIndex = 8;
		((ButtonBase)cmdViewCombo).Text = "&View Combined IRER && Contact Report";
		((ButtonBase)cmdViewCombo).UseVisualStyleBackColor = false;
		((ButtonBase)cmdSaveContact).BackColor = SystemColors.Control;
		((Control)cmdSaveContact).Cursor = Cursors.Default;
		((Control)cmdSaveContact).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdSaveContact).ForeColor = SystemColors.ControlText;
		Button obj353 = cmdSaveContact;
		location = new Point(265, 276);
		((Control)obj353).Location = location;
		((Control)cmdSaveContact).Name = "cmdSaveContact";
		((Control)cmdSaveContact).RightToLeft = (RightToLeft)0;
		Button obj354 = cmdSaveContact;
		size = new Size(239, 41);
		((Control)obj354).Size = size;
		((Control)cmdSaveContact).TabIndex = 7;
		((ButtonBase)cmdSaveContact).Text = "Save C&ontact Report";
		((ButtonBase)cmdSaveContact).UseVisualStyleBackColor = false;
		((ButtonBase)cmdViewContact).BackColor = SystemColors.Control;
		((Control)cmdViewContact).Cursor = Cursors.Default;
		((Control)cmdViewContact).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdViewContact).ForeColor = SystemColors.ControlText;
		Button obj355 = cmdViewContact;
		location = new Point(265, 226);
		((Control)obj355).Location = location;
		((Control)cmdViewContact).Name = "cmdViewContact";
		((Control)cmdViewContact).RightToLeft = (RightToLeft)0;
		Button obj356 = cmdViewContact;
		size = new Size(239, 41);
		((Control)obj356).Size = size;
		((Control)cmdViewContact).TabIndex = 6;
		((ButtonBase)cmdViewContact).Text = "View &Contact Report";
		((ButtonBase)cmdViewContact).UseVisualStyleBackColor = false;
		((ButtonBase)cmdSaveIRER).BackColor = SystemColors.Control;
		((Control)cmdSaveIRER).Cursor = Cursors.Default;
		((Control)cmdSaveIRER).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdSaveIRER).ForeColor = SystemColors.ControlText;
		Button obj357 = cmdSaveIRER;
		location = new Point(265, 154);
		((Control)obj357).Location = location;
		((Control)cmdSaveIRER).Name = "cmdSaveIRER";
		((Control)cmdSaveIRER).RightToLeft = (RightToLeft)0;
		Button obj358 = cmdSaveIRER;
		size = new Size(239, 41);
		((Control)obj358).Size = size;
		((Control)cmdSaveIRER).TabIndex = 5;
		((ButtonBase)cmdSaveIRER).Text = "Save I&RER Report";
		((ButtonBase)cmdSaveIRER).UseVisualStyleBackColor = false;
		((ButtonBase)cmdViewIRER).BackColor = SystemColors.Control;
		((Control)cmdViewIRER).Cursor = Cursors.Default;
		((Control)cmdViewIRER).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((Control)cmdViewIRER).ForeColor = SystemColors.ControlText;
		Button obj359 = cmdViewIRER;
		location = new Point(265, 104);
		((Control)obj359).Location = location;
		((Control)cmdViewIRER).Name = "cmdViewIRER";
		((Control)cmdViewIRER).RightToLeft = (RightToLeft)0;
		Button obj360 = cmdViewIRER;
		size = new Size(239, 41);
		((Control)obj360).Size = size;
		((Control)cmdViewIRER).TabIndex = 4;
		((ButtonBase)cmdViewIRER).Text = "View &IRER Report";
		((ButtonBase)cmdViewIRER).UseVisualStyleBackColor = false;
		txtChemGenUse.AcceptsReturn = true;
		((TextBoxBase)txtChemGenUse).BackColor = SystemColors.Control;
		((Control)txtChemGenUse).Cursor = Cursors.IBeam;
		((Control)txtChemGenUse).Font = new Font("Arial", 8f, (FontStyle)0, (GraphicsUnit)3, (byte)0);
		((TextBoxBase)txtChemGenUse).ForeColor = SystemColors.WindowText;
		TextBox obj361 = txtChemGenUse;
		location = new Point(107, 435);
		((Control)obj361).Location = location;
		((TextBoxBase)txtChemGenUse).MaxLength = 0;
		txtChemGenUse.Multiline = true;
		((Control)txtChemGenUse).Name = "txtChemGenUse";
		((TextBoxBase)txtChemGenUse).ReadOnly = true;
		((Control)txtChemGenUse).RightToLeft = (RightToLeft)0;
		txtChemGenUse.ScrollBars = (ScrollBars)2;
		TextBox obj362 = txtChemGenUse;
		size = new Size(660, 55);
		((Control)obj362).Size = size;
		((Control)txtChemGenUse).TabIndex = 394;
		((Control)txtChemGenUse).TabStop = false;
		size = new Size(6, 13);
		((Form)this).AutoScaleBaseSize = size;
		((Form)this).BackColor = SystemColors.Control;
		size = new Size(991, 631);
		((Form)this).ClientSize = size;
		((Control)this).Controls.Add((Control)(object)cmdReports);
		((Control)this).Controls.Add((Control)(object)cmdChemRegLimits);
		((Control)this).Controls.Add((Control)(object)cmdOptionalInfo);
		((Control)this).Controls.Add((Control)(object)cmdExposures);
		((Control)this).Controls.Add((Control)(object)cmdReleases);
		((Control)this).Controls.Add((Control)(object)cmdExpComb);
		((Control)this).Controls.Add((Control)(object)cmdOpParms);
		((Control)this).Controls.Add((Control)(object)cmdOperations);
		((Control)this).Controls.Add((Control)(object)cmdRelComb);
		((Control)this).Controls.Add((Control)(object)cmdChemical);
		((Control)this).Controls.Add((Control)(object)cmdGeneral);
		((Control)this).Controls.Add((Control)(object)msfContacts);
		((Control)this).Controls.Add((Control)(object)_fraTab_2);
		((Control)this).Controls.Add((Control)(object)_fraTab_5);
		((Control)this).Controls.Add((Control)(object)_fraTab_3);
		((Control)this).Controls.Add((Control)(object)_fraTab_4);
		((Control)this).Controls.Add((Control)(object)_fraTab_6);
		((Control)this).Controls.Add((Control)(object)_fraTab_0);
		((Control)this).Controls.Add((Control)(object)_fraTab_1);
		((Control)this).Controls.Add((Control)(object)_fraTab_7);
		((Control)this).Controls.Add((Control)(object)tabMain);
		((Control)this).Font = new Font("Arial", 8.25f, (FontStyle)1, (GraphicsUnit)3, (byte)0);
		((Form)this).Icon = (Icon)componentResourceManager.GetObject("$this.Icon");
		location = new Point(11, 57);
		((Form)this).Location = location;
		((Form)this).MaximizeBox = false;
		((Form)this).Menu = MainMenu1;
		((Control)this).Name = "frmMain";
		((Form)this).StartPosition = (FormStartPosition)1;
		((ISupportInitialize)msfContacts).EndInit();
		((Control)_fraTab_2).ResumeLayout(false);
		((Control)_fraOpTab_1).ResumeLayout(false);
		((Control)_fraOpTab_1).PerformLayout();
		((ISupportInitialize)msfNaics).EndInit();
		((Control)_fraOpTab_2).ResumeLayout(false);
		((Control)_fraOpTab_2).PerformLayout();
		((Control)_fraOpTab_0).ResumeLayout(false);
		((Control)_fraOpTab_0).PerformLayout();
		((ISupportInitialize)msfSubOps).EndInit();
		((Control)_fraOpTab_4).ResumeLayout(false);
		((Control)_fraOpTab_4).PerformLayout();
		((ISupportInitialize)msfSites).EndInit();
		((Control)_fraOpTab_3).ResumeLayout(false);
		((Control)_fraOpTab_3).PerformLayout();
		((ISupportInitialize)msfSelActs).EndInit();
		((ISupportInitialize)tabOps).EndInit();
		((Control)_fraTab_4).ResumeLayout(false);
		((Control)_fraTab_4).PerformLayout();
		((ISupportInitialize)msfRelParms).EndInit();
		((ISupportInitialize)msfRelEst).EndInit();
		((ISupportInitialize)tabRelSubTab).EndInit();
		((Control)_fraTab_5).ResumeLayout(false);
		((Control)_fraTab_5).PerformLayout();
		((Control)_fraExpTab_2).ResumeLayout(false);
		((Control)_fraExpTab_0).ResumeLayout(false);
		((Control)_fraExpTab_0).PerformLayout();
		((ISupportInitialize)_msfExpParms_0).EndInit();
		((Control)_fraExpTab_1).ResumeLayout(false);
		((Control)_fraExpTab_1).PerformLayout();
		((ISupportInitialize)_msfExpParms_1).EndInit();
		((Control)_fraExpTab_3).ResumeLayout(false);
		((ISupportInitialize)msfExpEst).EndInit();
		((ISupportInitialize)tabExp).EndInit();
		((Control)_fraTab_6).ResumeLayout(false);
		((Control)_fraTab_6).PerformLayout();
		((Control)_fraOpInfo_0).ResumeLayout(false);
		((Control)_fraOpInfo_0).PerformLayout();
		((Control)_fraOpInfo_2).ResumeLayout(false);
		((Control)_fraSubOI_2).ResumeLayout(false);
		((Control)_fraSubOI_2).PerformLayout();
		((Control)_fraSubOI_1).ResumeLayout(false);
		((ISupportInitialize)msfTlv).EndInit();
		((Control)_fraSubOI_0).ResumeLayout(false);
		((Control)_fraSubOI_0).PerformLayout();
		((ISupportInitialize)tabSubOI).EndInit();
		((Control)_fraOpInfo_1).ResumeLayout(false);
		((Control)_fraOpInfo_1).PerformLayout();
		((Control)_fraOpInfo_5).ResumeLayout(false);
		((Control)_fraOpInfo_5).PerformLayout();
		((Control)_fraOpInfo_3).ResumeLayout(false);
		((Control)_fraOpInfo_3).PerformLayout();
		((Control)_fraOpInfo_6).ResumeLayout(false);
		((Control)_fraOpInfo_4).ResumeLayout(false);
		((Control)_fraOpInfo_4).PerformLayout();
		((Control)_fraTab_1).ResumeLayout(false);
		((Control)_fraTab_1).PerformLayout();
		((Control)_fraTab_0).ResumeLayout(false);
		((Control)_fraTab_0).PerformLayout();
		((Control)_fraTab_3).ResumeLayout(false);
		((Control)_fraTab_3).PerformLayout();
		((Control)_fraIP_1).ResumeLayout(false);
		((Control)_fraConts_3).ResumeLayout(false);
		((ISupportInitialize)_msfCont_3).EndInit();
		((Control)_fraConts_2).ResumeLayout(false);
		((ISupportInitialize)_msfCont_2).EndInit();
		((Control)_fraConts_1).ResumeLayout(false);
		((Control)_fraConts_1).PerformLayout();
		((ISupportInitialize)_msfCont_1).EndInit();
		((Control)_fraConts_0).ResumeLayout(false);
		((Control)_fraConts_0).PerformLayout();
		((ISupportInitialize)_msfCont_0).EndInit();
		((ISupportInitialize)tabConts).EndInit();
		((Control)_fraIP_0).ResumeLayout(false);
		((ISupportInitialize)msfOpIP).EndInit();
		((Control)_fraIP_2).ResumeLayout(false);
		((ISupportInitialize)msfSP).EndInit();
		((ISupportInitialize)tabIP).EndInit();
		((ISupportInitialize)tabMain).EndInit();
		((ISupportInitialize)LVE).EndInit();
		((ISupportInitialize)Label1).EndInit();
		((ISupportInitialize)Label2).EndInit();
		((ISupportInitialize)Label3).EndInit();
		((ISupportInitialize)Label4).EndInit();
		((ISupportInitialize)Line1).EndInit();
		((ISupportInitialize)Line2).EndInit();
		((ISupportInitialize)Line3).EndInit();
		((ISupportInitialize)fraConts).EndInit();
		((ISupportInitialize)fraExpTab).EndInit();
		((ISupportInitialize)fraIP).EndInit();
		((ISupportInitialize)fraOpInfo).EndInit();
		((ISupportInitialize)fraOpTab).EndInit();
		((ISupportInitialize)fraSubOI).EndInit();
		((ISupportInitialize)fraTab).EndInit();
		((ISupportInitialize)lblAddr).EndInit();
		((ISupportInitialize)lblAff).EndInit();
		((ISupportInitialize)lblChemStateExp).EndInit();
		((ISupportInitialize)lblContSumFC).EndInit();
		((ISupportInitialize)lblContYprod).EndInit();
		((ISupportInitialize)lblContYrm).EndInit();
		((ISupportInitialize)lblEmail).EndInit();
		((ISupportInitialize)lblGT100WorkersW1to10).EndInit();
		((ISupportInitialize)lblName).EndInit();
		((ISupportInitialize)lblNumWMet).EndInit();
		((ISupportInitialize)lblPhone).EndInit();
		((ISupportInitialize)lblPhyState).EndInit();
		((ISupportInitialize)lblPhyStateOtherInfo).EndInit();
		((ISupportInitialize)lblSatEReq).EndInit();
		((ISupportInitialize)lblSatHReq).EndInit();
		((ISupportInitialize)mnuPreferences).EndInit();
		((ISupportInitialize)txtExpModelMsg).EndInit();
		((ISupportInitialize)txtMsds).EndInit();
		((Control)_fraTab_7).ResumeLayout(false);
		((Control)this).ResumeLayout(false);
	}

	private void frmMain_Load(object eventSender, EventArgs eventArgs)
	{
		int try0001_dispatch = -1;
		int num = default(int);
		Connection connection = default(Connection);
		int num2 = default(int);
		int num3 = default(int);
		short num5 = default(short);
		Recordset recordset = default(Recordset);
		short num6 = default(short);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					Guid clsid;
					short num7;
					short num8;
					switch (try0001_dispatch)
					{
					default:
						num = 1;
						clsid = new Guid("00000514-0000-0010-8000-00AA006D2EA4");
						connection = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0022;
					case 6166:
						{
							num2 = num;
							switch ((num3 <= -2) ? 1 : num3)
							{
							case 1:
								break;
							default:
								goto end_IL_0001;
							}
							int num4 = unchecked(num2 + 1);
							num2 = 0;
							switch (num4)
							{
							case 1:
								break;
							case 2:
								goto IL_0022;
							case 3:
								goto IL_0043;
							case 4:
								goto IL_004e;
							case 5:
								goto IL_005d;
							case 6:
								goto IL_0067;
							case 7:
								goto IL_0071;
							case 8:
								goto IL_007b;
							case 9:
								goto IL_0085;
							case 10:
								goto IL_0090;
							case 11:
								goto IL_009b;
							case 12:
								goto IL_00a9;
							case 13:
								goto IL_00b7;
							case 14:
								goto IL_00c5;
							case 15:
								goto IL_00d3;
							case 16:
								goto IL_00df;
							case 17:
								goto IL_00fe;
							case 18:
								goto IL_0119;
							case 19:
								goto IL_0125;
							case 20:
								goto IL_0139;
							case 21:
								goto IL_0142;
							case 22:
								goto IL_0165;
							case 23:
								goto IL_0173;
							case 24:
								goto IL_0196;
							case 25:
								goto IL_01b9;
							case 26:
								goto IL_01c4;
							case 27:
								goto IL_01cf;
							case 28:
								goto IL_01d5;
							case 29:
								goto IL_01db;
							case 30:
								goto IL_020b;
							case 31:
								goto IL_0215;
							case 32:
								goto IL_021f;
							case 33:
								goto IL_0229;
							case 34:
								goto IL_0237;
							case 35:
								goto IL_0245;
							case 36:
								goto IL_0253;
							case 37:
								goto IL_026e;
							case 38:
								goto IL_0289;
							case 39:
								goto IL_02a4;
							case 40:
								goto IL_02b9;
							case 41:
								goto IL_02ce;
							case 42:
								goto IL_02e4;
							case 43:
								goto IL_02ee;
							case 44:
								goto IL_02f8;
							case 45:
								goto IL_0302;
							case 46:
								goto IL_030c;
							case 47:
								goto IL_031b;
							case 48:
								goto IL_0326;
							case 49:
								goto IL_0331;
							case 50:
								goto IL_0350;
							case 51:
								goto IL_036f;
							case 52:
								goto IL_0387;
							case 53:
								goto IL_039a;
							case 54:
							case 56:
								goto IL_03ae;
							case 57:
							case 59:
								goto IL_03c2;
							case 60:
								goto IL_03e5;
							case 62:
								goto IL_03f9;
							case 63:
								goto IL_03fe;
							case 64:
								goto IL_0433;
							case 65:
								goto IL_0468;
							case 66:
								goto IL_04f1;
							case 68:
								goto IL_04ff;
							case 69:
								goto IL_0504;
							case 61:
							case 67:
							case 70:
							case 71:
							case 72:
								goto IL_0512;
							case 73:
							case 75:
								goto IL_0527;
							case 76:
							case 78:
								goto IL_053c;
							case 79:
							case 81:
								goto IL_0553;
							case 82:
							case 84:
								goto IL_056a;
							case 85:
							case 87:
								goto IL_0581;
							case 88:
							case 90:
								goto IL_0596;
							case 91:
							case 93:
								goto IL_05ab;
							case 94:
							case 96:
								goto IL_05c0;
							case 97:
							case 99:
								goto IL_05d5;
							case 100:
							case 102:
								goto IL_05ea;
							case 103:
							case 105:
								goto IL_05ff;
							case 106:
							case 108:
								goto IL_0614;
							case 109:
							case 111:
								goto IL_062b;
							case 112:
							case 114:
								goto IL_0642;
							case 115:
							case 117:
								goto IL_0658;
							case 118:
							case 120:
								goto IL_0672;
							case 121:
							case 123:
								goto IL_068c;
							case 124:
							case 126:
								goto IL_06a1;
							case 127:
							case 129:
								goto IL_06b6;
							case 130:
							case 132:
								goto IL_06ce;
							case 133:
							case 135:
								goto IL_06e6;
							case 136:
							case 138:
								goto IL_06ff;
							case 139:
							case 141:
								goto IL_0717;
							case 142:
							case 144:
								goto IL_072f;
							case 145:
							case 147:
								goto IL_0747;
							case 148:
							case 150:
								goto IL_075f;
							case 151:
							case 153:
								goto IL_0779;
							case 154:
							case 156:
								goto IL_0793;
							case 157:
							case 159:
								goto IL_07ad;
							case 160:
							case 162:
								goto IL_07c7;
							case 163:
							case 165:
								goto IL_07e1;
							case 166:
							case 168:
								goto IL_07fb;
							case 169:
							case 171:
								goto IL_0818;
							case 172:
							case 174:
								goto IL_0835;
							case 175:
							case 177:
								goto IL_084d;
							case 178:
							case 180:
								goto IL_0865;
							case 181:
							case 183:
								goto IL_087d;
							case 184:
							case 186:
								goto IL_0895;
							case 187:
							case 189:
								goto IL_08ad;
							case 190:
							case 192:
								goto IL_08c5;
							case 193:
							case 195:
								goto IL_08de;
							case 196:
							case 198:
								goto IL_08f8;
							case 199:
							case 201:
								goto IL_0912;
							case 202:
							case 204:
								goto IL_092c;
							case 205:
							case 207:
								goto IL_0946;
							case 208:
							case 210:
								goto IL_0960;
							case 211:
							case 213:
								goto IL_097a;
							case 214:
							case 216:
								goto IL_0994;
							case 217:
							case 219:
								goto IL_09ae;
							case 220:
							case 222:
								goto IL_09c8;
							case 223:
							case 225:
								goto IL_09e3;
							case 226:
							case 228:
								goto IL_09fd;
							case 229:
							case 231:
								goto IL_0a17;
							case 232:
							case 234:
								goto IL_0a33;
							case 235:
							case 237:
								goto IL_0a4f;
							case 238:
							case 240:
								goto IL_0a67;
							case 241:
							case 243:
								goto IL_0a7f;
							case 244:
							case 246:
								goto IL_0a97;
							case 247:
							case 249:
								goto IL_0aaf;
							case 250:
							case 252:
								goto IL_0ac7;
							case 253:
							case 255:
								goto IL_0adf;
							case 256:
							case 258:
								goto IL_0af7;
							case 259:
							case 261:
								goto IL_0b0f;
							case 262:
							case 264:
								goto IL_0b27;
							case 265:
							case 267:
								goto IL_0b3f;
							case 268:
							case 270:
								goto IL_0b57;
							case 271:
							case 273:
								goto IL_0b70;
							case 274:
							case 276:
								goto IL_0b88;
							case 277:
							case 279:
								goto IL_0ba0;
							case 280:
							case 282:
								goto IL_0bb8;
							case 283:
							case 285:
								goto IL_0bd0;
							case 286:
							case 288:
								goto IL_0bea;
							case 289:
							case 291:
								goto IL_0c04;
							case 292:
							case 294:
								goto IL_0c1d;
							case 295:
							case 297:
								goto IL_0c3a;
							case 298:
							case 300:
								goto IL_0c57;
							case 301:
							case 303:
								goto IL_0c71;
							case 304:
							case 306:
								goto IL_0c8b;
							case 307:
							case 309:
								goto IL_0ca5;
							case 310:
							case 312:
								goto IL_0cbf;
							case 313:
							case 315:
								goto IL_0cd9;
							case 316:
							case 318:
								goto IL_0cf3;
							case 319:
							case 321:
								goto IL_0d0f;
							case 322:
							case 324:
								goto IL_0d27;
							case 325:
							case 327:
								goto IL_0d3f;
							case 328:
							case 330:
								goto IL_0d57;
							case 331:
							case 333:
								goto IL_0d6f;
							case 334:
							case 336:
								goto IL_0d88;
							case 337:
							case 339:
								goto IL_0da1;
							case 340:
							case 342:
								goto IL_0dbb;
							case 343:
							case 345:
								goto IL_0dd9;
							case 346:
							case 348:
								goto IL_0df7;
							case 349:
							case 351:
								goto IL_0e15;
							case 352:
							case 354:
								goto IL_0e2e;
							case 355:
							case 357:
								goto IL_0e47;
							case 358:
							case 360:
								goto IL_0e60;
							case 361:
							case 363:
								goto IL_0e7b;
							case 364:
							case 366:
								goto IL_0e93;
							case 367:
							case 369:
								goto IL_0eab;
							case 370:
							case 372:
								goto IL_0ec4;
							case 373:
							case 375:
								goto IL_0edd;
							case 376:
							case 378:
								goto IL_0ef5;
							case 379:
							case 381:
								goto IL_0f0d;
							case 382:
							case 384:
								goto IL_0f25;
							case 385:
							case 387:
								goto IL_0f43;
							case 388:
							case 390:
								goto IL_0f61;
							case 391:
							case 393:
								goto IL_0f7f;
							case 394:
							case 396:
								goto IL_0f9a;
							case 397:
							case 399:
								goto IL_0fb2;
							case 400:
							case 402:
								goto IL_0fcb;
							case 403:
								goto IL_0fd8;
							case 404:
								goto IL_1004;
							case 405:
								goto IL_1030;
							case 406:
								goto IL_1048;
							case 407:
								goto IL_1056;
							case 408:
								goto IL_106a;
							case 409:
								goto IL_107e;
							case 410:
								goto IL_1092;
							case 412:
								goto IL_10ae;
							case 413:
								goto IL_10b6;
							case 414:
								goto IL_10ca;
							case 415:
								goto IL_10de;
							case 416:
								goto IL_10f2;
							case 411:
							case 417:
							case 418:
								goto IL_110d;
							case 419:
								goto IL_1125;
							case 420:
								goto IL_113d;
							case 421:
								goto end_IL_0001_2;
							default:
								goto end_IL_0001;
							case 422:
								goto end_IL_0001_3;
							}
							goto default;
						}
						IL_1125:
						num = 419;
						mnuFileDeleteGSS.Visible = Globals_Renamed.gblAuthorizedUser;
						goto IL_113d;
						IL_113d:
						num = 420;
						mnuFileRenameGSS.Visible = Globals_Renamed.gblAuthorizedUser;
						break;
						IL_110d:
						num = 418;
						mnuFileSaveGSS.Visible = Globals_Renamed.gblAuthorizedUser;
						goto IL_1125;
						IL_0387:
						num = 52;
						num5 = (short)unchecked(num5 + 1);
						goto IL_0391;
						IL_0022:
						num = 2;
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						goto IL_0043;
						IL_0043:
						num = 3;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						goto IL_004e;
						IL_004e:
						num = 4;
						((Form)this).Text = "ChemSTEER v3.2";
						goto IL_005d;
						IL_005d:
						num = 5;
						MyCurrentTab = 1;
						goto IL_0067;
						IL_0067:
						num = 6;
						MyCurrentOpTab = 1;
						goto IL_0071;
						IL_0071:
						num = 7;
						MyCurrentIpTab = 1;
						goto IL_007b;
						IL_007b:
						num = 8;
						MyCurrentExpTab = 1;
						goto IL_0085;
						IL_0085:
						num = 9;
						MyCurrentRelTab = 1;
						goto IL_0090;
						IL_0090:
						num = 10;
						MyCurrentContSubTab = 1;
						goto IL_009b;
						IL_009b:
						num = 11;
						Globals_Renamed.gblColorOn = Color.DimGray;
						goto IL_00a9;
						IL_00a9:
						num = 12;
						Globals_Renamed.gblColorOff = SystemColors.Control;
						goto IL_00b7;
						IL_00b7:
						num = 13;
						Globals_Renamed.gblTextOn = Color.White;
						goto IL_00c5;
						IL_00c5:
						num = 14;
						Globals_Renamed.gblTextOff = SystemColors.ControlText;
						goto IL_00d3;
						IL_00d3:
						num = 15;
						switchTabs(1);
						goto IL_00df;
						IL_00df:
						num = 16;
						connection.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\mdbshell.epa";
						goto IL_00fe;
						IL_00fe:
						num = 17;
						connection.Open();
						goto IL_0119;
						IL_0119:
						num = 18;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						goto IL_0125;
						IL_0125:
						num = 19;
						recordset.Open("SELECT dataVersion, crVersion, crDate FROM Tron", connection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						goto IL_0139;
						IL_0139:
						ProjectData.ClearProjectError();
						num3 = -2;
						goto IL_0142;
						IL_0142:
						num = 21;
						Globals_Renamed.gblCurrentDV = Conversions.ToShort(recordset.Fields["dataVersion"].Value);
						goto IL_0165;
						IL_0165:
						num = 22;
						Globals_Renamed.gblDataVersion = Globals_Renamed.gblCurrentDV;
						goto IL_0173;
						IL_0173:
						num = 23;
						Globals_Renamed.gblCurrentCR = Conversions.ToShort(recordset.Fields["crVersion"].Value);
						goto IL_0196;
						IL_0196:
						num = 24;
						Globals_Renamed.gblCRdate = Conversions.ToDate(recordset.Fields["crDate"].Value);
						goto IL_01b9;
						IL_01b9:
						num = 25;
						recordset.Close();
						goto IL_01c4;
						IL_01c4:
						num = 26;
						connection.Close();
						goto IL_01cf;
						IL_01cf:
						num = 27;
						recordset = null;
						goto IL_01d5;
						IL_01d5:
						num = 28;
						connection = null;
						goto IL_01db;
						IL_01db:
						num = 29;
						lblCurrentVersion.Text = Support.Format((object)Globals_Renamed.gblCRdate, "mm/dd/yyyy", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + " version";
						goto IL_020b;
						IL_020b:
						num = 30;
						Globals_Renamed.intOpIndex = 0;
						goto IL_0215;
						IL_0215:
						num = 31;
						Globals_Renamed.intActIndex = 0;
						goto IL_021f;
						IL_021f:
						num = 32;
						Globals_Renamed.intModIndex = 0;
						goto IL_0229;
						IL_0229:
						num = 33;
						Globals_Renamed.gblMsdsGE = "gloves/ goggles/ glasses/ local exhaust ventilation/ general mechanical ventilation/ other (please specify):";
						goto IL_0237;
						IL_0237:
						num = 34;
						Globals_Renamed.gblMsdsResp = "air purifying/ organic vapor/ dust/ paint mist/ supplied air/ other (please specify):";
						goto IL_0245;
						IL_0245:
						num = 35;
						Globals_Renamed.gblMsdsHE = "corrosive/ flammable/ other (please specify): \r\nirritant to skin/ eyes/ lungs/ mucous membrane";
						goto IL_0253;
						IL_0253:
						num = 36;
						txtMsds[(short)0].Text = Globals_Renamed.gblMsdsGE;
						goto IL_026e;
						IL_026e:
						num = 37;
						txtMsds[(short)1].Text = Globals_Renamed.gblMsdsResp;
						goto IL_0289;
						IL_0289:
						num = 38;
						txtMsds[(short)2].Text = Globals_Renamed.gblMsdsHE;
						goto IL_02a4;
						IL_02a4:
						num = 39;
						txtMiscCRSSinfo.Text = "Neat:   Mfg:   Proc/Form:   End Use:   ";
						goto IL_02b9;
						IL_02b9:
						num = 40;
						lblConsUse.Text = "";
						goto IL_02ce;
						IL_02ce:
						num = 41;
						lblDchem.Text = Conversions.ToString(1);
						goto IL_02e4;
						IL_02e4:
						num = 42;
						Globals_Renamed.intNumOps = 1;
						goto IL_02ee;
						IL_02ee:
						num = 43;
						Globals_Renamed.intNumRelModels = 0;
						goto IL_02f8;
						IL_02f8:
						num = 44;
						Globals_Renamed.intNumExpModels = 0;
						goto IL_0302;
						IL_0302:
						num = 45;
						Globals_Renamed.gblIWasChanged = false;
						goto IL_030c;
						IL_030c:
						num = 46;
						sContactInfoNotepad = "";
						goto IL_031b;
						IL_031b:
						num = 47;
						LoadOptInfoCombo();
						goto IL_0326;
						IL_0326:
						num = 48;
						PrimeGrids();
						goto IL_0331;
						IL_0331:
						num = 49;
						((Control)this).Width = (int)Math.Round(Support.TwipsToPixelsX(14500.0));
						goto IL_0350;
						IL_0350:
						num = 50;
						((Control)this).Height = (int)Math.Round(Support.TwipsToPixelsY(10500.0));
						goto IL_036f;
						IL_036f:
						num = 51;
						num6 = (short)(((BaseControlArray)fraTab).Count() - 1);
						num5 = 0;
						goto IL_0391;
						IL_0391:
						num7 = num5;
						num8 = num6;
						if (num7 <= num8)
						{
							goto IL_0387;
						}
						goto IL_039a;
						IL_039a:
						num = 53;
						Globals_Renamed.arOpParms = new float[163, 2];
						goto IL_03ae;
						IL_03ae:
						num = 56;
						Globals_Renamed.arOpParmsType = new short[163, 2];
						goto IL_03c2;
						IL_03c2:
						num = 59;
						num5 = Conversions.ToShort(Interaction.GetSetting("ChemSTEER", "Options", "WinState", "99"));
						goto IL_03e5;
						IL_03e5:
						num = 60;
						if (num5 != 99)
						{
							goto IL_03f9;
						}
						goto IL_0512;
						IL_03f9:
						num = 62;
						goto IL_03fe;
						IL_03fe:
						num = 63;
						((Control)this).Left = (int)Math.Round(Support.TwipsToPixelsX((double)Conversions.ToInteger(Interaction.GetSetting("ChemSTEER", "Options", "WinLeft", "0"))));
						goto IL_0433;
						IL_0433:
						num = 64;
						((Control)this).Top = (int)Math.Round(Support.TwipsToPixelsY((double)Conversions.ToInteger(Interaction.GetSetting("ChemSTEER", "Options", "WinTop", "0"))));
						goto IL_0468;
						IL_0468:
						num = 65;
						if ((Support.PixelsToTwipsX((double)((Control)this).Left) > 0.0) & (Support.PixelsToTwipsX((double)((Control)this).Left) < Support.PixelsToTwipsX((double)Screen.PrimaryScreen.Bounds.Width)) & ((Support.PixelsToTwipsY((double)((Control)this).Top) > 0.0) & (Support.PixelsToTwipsX((double)((Control)this).Left) < Support.PixelsToTwipsY((double)Screen.PrimaryScreen.Bounds.Height))))
						{
							goto IL_04f1;
						}
						goto IL_04ff;
						IL_04f1:
						num = 66;
						((Form)this).WindowState = (FormWindowState)num5;
						goto IL_0512;
						IL_04ff:
						num = 68;
						goto IL_0504;
						IL_0504:
						num = 69;
						((Form)this).WindowState = (FormWindowState)0;
						goto IL_0512;
						IL_0512:
						num = 72;
						Globals_Renamed.arOpPv = new double[Globals_Renamed.intNumOps + 1];
						goto IL_0527;
						IL_0527:
						num = 75;
						Globals_Renamed.arNoPre = new bool[Globals_Renamed.intNumOps + 1];
						goto IL_053c;
						IL_053c:
						num = 78;
						Globals_Renamed.arSubOpID = new short[11, Globals_Renamed.intNumOps + 1];
						goto IL_0553;
						IL_0553:
						num = 81;
						Globals_Renamed.arSubPVf = new float[11, Globals_Renamed.intNumOps + 1];
						goto IL_056a;
						IL_056a:
						num = 84;
						Globals_Renamed.arSubPvOp = new double[11, Globals_Renamed.intNumOps + 1];
						goto IL_0581;
						IL_0581:
						num = 87;
						Globals_Renamed.arPSInto1 = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0596;
						IL_0596:
						num = 90;
						Globals_Renamed.arPSInto2 = new string[Globals_Renamed.intNumOps + 1];
						goto IL_05ab;
						IL_05ab:
						num = 93;
						Globals_Renamed.arPSOut1 = new string[Globals_Renamed.intNumOps + 1];
						goto IL_05c0;
						IL_05c0:
						num = 96;
						Globals_Renamed.arPSOut2 = new string[Globals_Renamed.intNumOps + 1];
						goto IL_05d5;
						IL_05d5:
						num = 99;
						Globals_Renamed.arPSIn1 = new string[Globals_Renamed.intNumOps + 1];
						goto IL_05ea;
						IL_05ea:
						num = 102;
						Globals_Renamed.arPSIn2 = new string[Globals_Renamed.intNumOps + 1];
						goto IL_05ff;
						IL_05ff:
						num = 105;
						Globals_Renamed.arPDesc = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0614;
						IL_0614:
						num = 108;
						Globals_Renamed.arNaics1 = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_062b;
						IL_062b:
						num = 111;
						Globals_Renamed.arNaics2 = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0642;
						IL_0642:
						num = 114;
						Globals_Renamed.arMiscOpParms = new float[3, Globals_Renamed.intNumOps + 1];
						goto IL_0658;
						IL_0658:
						num = 117;
						Globals_Renamed.arGssOptions = new short[163, Globals_Renamed.intNumOps + 1];
						goto IL_0672;
						IL_0672:
						num = 120;
						Globals_Renamed.arGssOther = new string[163, Globals_Renamed.intNumOps + 1];
						goto IL_068c;
						IL_068c:
						num = 123;
						Globals_Renamed.arBasis = new string[Globals_Renamed.intNumOps + 1];
						goto IL_06a1;
						IL_06a1:
						num = 126;
						Globals_Renamed.arWaterBasis = new string[Globals_Renamed.intNumOps + 1];
						goto IL_06b6;
						IL_06b6:
						num = 129;
						Globals_Renamed.arRelAddNotes = new string[Globals_Renamed.intNumOps + 1];
						goto IL_06ce;
						IL_06ce:
						num = 132;
						Globals_Renamed.arExpAddNotes = new string[Globals_Renamed.intNumOps + 1];
						goto IL_06e6;
						IL_06e6:
						num = 135;
						Globals_Renamed.arOpNumWorkers = new long[3, Globals_Renamed.intNumOps + 1];
						goto IL_06ff;
						IL_06ff:
						num = 138;
						Globals_Renamed.arOpNumWorkersBasis = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0717;
						IL_0717:
						num = 141;
						Globals_Renamed.arOpNumWorkersBasisEnabled = new short[Globals_Renamed.intNumOps + 1];
						goto IL_072f;
						IL_072f:
						num = 144;
						Globals_Renamed.arInhalationBasis = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0747;
						IL_0747:
						num = 147;
						Globals_Renamed.arDermalBasis = new string[Globals_Renamed.intNumOps + 1];
						goto IL_075f;
						IL_075f:
						num = 150;
						Globals_Renamed.arOSName = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0779;
						IL_0779:
						num = 153;
						Globals_Renamed.arOSAddr = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0793;
						IL_0793:
						num = 156;
						Globals_Renamed.arOSCity = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_07ad;
						IL_07ad:
						num = 159;
						Globals_Renamed.arOSState = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_07c7;
						IL_07c7:
						num = 162;
						Globals_Renamed.arOSZip = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_07e1;
						IL_07e1:
						num = 165;
						Globals_Renamed.arOSCty = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_07fb;
						IL_07fb:
						num = 168;
						Globals_Renamed.arOpParms = new float[163, Globals_Renamed.intNumOps + 1];
						goto IL_0818;
						IL_0818:
						num = 171;
						Globals_Renamed.arOpParmsType = new short[163, Globals_Renamed.intNumOps + 1];
						goto IL_0835;
						IL_0835:
						num = 174;
						Globals_Renamed.arOpBorC = new short[Globals_Renamed.intNumOps + 1];
						goto IL_084d;
						IL_084d:
						num = 177;
						Globals_Renamed.arOpIoE = new short[Globals_Renamed.intNumOps + 1];
						goto IL_0865;
						IL_0865:
						num = 180;
						Globals_Renamed.arOpName = new string[Globals_Renamed.intNumOps + 1];
						goto IL_087d;
						IL_087d:
						num = 183;
						Globals_Renamed.arOpNeedsMassBalance = new short[Globals_Renamed.intNumOps + 1];
						goto IL_0895;
						IL_0895:
						num = 186;
						Globals_Renamed.arOpType = new short[Globals_Renamed.intNumOps + 1];
						goto IL_08ad;
						IL_08ad:
						num = 189;
						Globals_Renamed.arOpOrder = new short[Globals_Renamed.intNumOps + 1];
						goto IL_08c5;
						IL_08c5:
						num = 192;
						Globals_Renamed.arOpMassBalDisc = new int[3, Globals_Renamed.intNumOps + 1];
						goto IL_08de;
						IL_08de:
						num = 195;
						Globals_Renamed.arOpSP = new float[49, Globals_Renamed.intNumOps + 1];
						goto IL_08f8;
						IL_08f8:
						num = 198;
						Globals_Renamed.arOpSPType = new short[49, Globals_Renamed.intNumOps + 1];
						goto IL_0912;
						IL_0912:
						num = 201;
						Globals_Renamed.arSelActs = new string[26, Globals_Renamed.intNumOps + 1];
						goto IL_092c;
						IL_092c:
						num = 204;
						Globals_Renamed.arSelActType = new short[26, Globals_Renamed.intNumOps + 1];
						goto IL_0946;
						IL_0946:
						num = 207;
						Globals_Renamed.arSelActRa = new bool[26, Globals_Renamed.intNumOps + 1];
						goto IL_0960;
						IL_0960:
						num = 210;
						Globals_Renamed.arSelActEa = new bool[26, Globals_Renamed.intNumOps + 1];
						goto IL_097a;
						IL_097a:
						num = 213;
						Globals_Renamed.arSelActRaDMP = new short[26, Globals_Renamed.intNumOps + 1];
						goto IL_0994;
						IL_0994:
						num = 216;
						Globals_Renamed.arSelActEaDMP = new short[26, Globals_Renamed.intNumOps + 1];
						goto IL_09ae;
						IL_09ae:
						num = 219;
						Globals_Renamed.arSelActVolatile = new short[26, Globals_Renamed.intNumOps + 1];
						goto IL_09c8;
						IL_09c8:
						num = 222;
						Globals_Renamed.arActNumWorkers = new long[4, 26, Globals_Renamed.intNumOps + 1];
						goto IL_09e3;
						IL_09e3:
						num = 225;
						Globals_Renamed.arActNW_Route = new string[26, Globals_Renamed.intNumOps + 1];
						goto IL_09fd;
						IL_09fd:
						num = 228;
						Globals_Renamed.arActOrder = new short[26, Globals_Renamed.intNumOps + 1];
						goto IL_0a17;
						IL_0a17:
						num = 231;
						Globals_Renamed.arContParms = new float[16, 26, Globals_Renamed.intNumOps + 1];
						goto IL_0a33;
						IL_0a33:
						num = 234;
						Globals_Renamed.arContParmTypes = new short[16, 26, Globals_Renamed.intNumOps + 1];
						goto IL_0a4f;
						IL_0a4f:
						num = 237;
						Globals_Renamed.arPSInto1 = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0a67;
						IL_0a67:
						num = 240;
						Globals_Renamed.arPSInto2 = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0a7f;
						IL_0a7f:
						num = 243;
						Globals_Renamed.arPSOut1 = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0a97;
						IL_0a97:
						num = 246;
						Globals_Renamed.arPSOut2 = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0aaf;
						IL_0aaf:
						num = 249;
						Globals_Renamed.arPSIn1 = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0ac7;
						IL_0ac7:
						num = 252;
						Globals_Renamed.arPSIn2 = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0adf;
						IL_0adf:
						num = 255;
						Globals_Renamed.arPDesc = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0af7;
						IL_0af7:
						num = 258;
						Globals_Renamed.arBasis = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0b0f;
						IL_0b0f:
						num = 261;
						Globals_Renamed.arWaterBasis = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0b27;
						IL_0b27:
						num = 264;
						Globals_Renamed.arRelAddNotes = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0b3f;
						IL_0b3f:
						num = 267;
						Globals_Renamed.arExpAddNotes = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0b57;
						IL_0b57:
						num = 270;
						Globals_Renamed.arOpNumWorkers = new long[3, Globals_Renamed.intNumOps + 1];
						goto IL_0b70;
						IL_0b70:
						num = 273;
						Globals_Renamed.arOpNumWorkersBasis = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0b88;
						IL_0b88:
						num = 276;
						Globals_Renamed.arOpNumWorkersBasisEnabled = new short[Globals_Renamed.intNumOps + 1];
						goto IL_0ba0;
						IL_0ba0:
						num = 279;
						Globals_Renamed.arInhalationBasis = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0bb8;
						IL_0bb8:
						num = 282;
						Globals_Renamed.arDermalBasis = new string[Globals_Renamed.intNumOps + 1];
						goto IL_0bd0;
						IL_0bd0:
						num = 285;
						Globals_Renamed.arNaics1 = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0bea;
						IL_0bea:
						num = 288;
						Globals_Renamed.arNaics2 = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0c04;
						IL_0c04:
						num = 291;
						Globals_Renamed.arMiscOpParms = new float[3, Globals_Renamed.intNumOps + 1];
						goto IL_0c1d;
						IL_0c1d:
						num = 294;
						Globals_Renamed.arGssOptions = new short[163, Globals_Renamed.intNumOps + 1];
						goto IL_0c3a;
						IL_0c3a:
						num = 297;
						Globals_Renamed.arGssOther = new string[163, Globals_Renamed.intNumOps + 1];
						goto IL_0c57;
						IL_0c57:
						num = 300;
						Globals_Renamed.arOSName = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0c71;
						IL_0c71:
						num = 303;
						Globals_Renamed.arOSAddr = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0c8b;
						IL_0c8b:
						num = 306;
						Globals_Renamed.arOSCity = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0ca5;
						IL_0ca5:
						num = 309;
						Globals_Renamed.arOSState = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0cbf;
						IL_0cbf:
						num = 312;
						Globals_Renamed.arOSZip = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0cd9;
						IL_0cd9:
						num = 315;
						Globals_Renamed.arOSCty = new string[100, Globals_Renamed.intNumOps + 1];
						goto IL_0cf3;
						IL_0cf3:
						num = 318;
						Globals_Renamed.arRelModels = new short[11, 26, Globals_Renamed.intNumOps + 1];
						goto IL_0d0f;
						IL_0d0f:
						num = 321;
						Globals_Renamed.arRelModType = new short[Globals_Renamed.intNumRelModels + 1];
						goto IL_0d27;
						IL_0d27:
						num = 324;
						Globals_Renamed.arRelModBasis = new string[Globals_Renamed.intNumRelModels + 1];
						goto IL_0d3f;
						IL_0d3f:
						num = 327;
						Globals_Renamed.arRelModNAICS = new string[Globals_Renamed.intNumRelModels + 1];
						goto IL_0d57;
						IL_0d57:
						num = 330;
						Globals_Renamed.arRelModStatus = new short[Globals_Renamed.intNumRelModels + 1];
						goto IL_0d6f;
						IL_0d6f:
						num = 333;
						Globals_Renamed.arRelModOutputOn = new short[3, Globals_Renamed.intNumExpModels + 1];
						goto IL_0d88;
						IL_0d88:
						num = 336;
						Globals_Renamed.arRelModChar = new string[3, Globals_Renamed.intNumExpModels + 1];
						goto IL_0da1;
						IL_0da1:
						num = 339;
						Globals_Renamed.arRelModMedia = new float[19, Globals_Renamed.intNumRelModels + 1];
						goto IL_0dbb;
						IL_0dbb:
						num = 342;
						Globals_Renamed.arRelModParmsV = new float[3, 163, Globals_Renamed.intNumRelModels + 1];
						goto IL_0dd9;
						IL_0dd9:
						num = 345;
						Globals_Renamed.arRelModParmsT = new short[3, 163, Globals_Renamed.intNumRelModels + 1];
						goto IL_0df7;
						IL_0df7:
						num = 348;
						Globals_Renamed.arRelModParmsVC = new short[3, 163, Globals_Renamed.intNumRelModels + 1];
						goto IL_0e15;
						IL_0e15:
						num = 351;
						Globals_Renamed.arRelModDRR = new float[3, Globals_Renamed.intNumRelModels + 1];
						goto IL_0e2e;
						IL_0e2e:
						num = 354;
						Globals_Renamed.arRelModARR = new float[3, Globals_Renamed.intNumRelModels + 1];
						goto IL_0e47;
						IL_0e47:
						num = 357;
						Globals_Renamed.arRelModDOR = new short[3, Globals_Renamed.intNumRelModels + 1];
						goto IL_0e60;
						IL_0e60:
						num = 360;
						Globals_Renamed.arExpModels = new short[3, 26, Globals_Renamed.intNumOps + 1];
						goto IL_0e7b;
						IL_0e7b:
						num = 363;
						Globals_Renamed.arExpModType = new short[Globals_Renamed.intNumExpModels + 1];
						goto IL_0e93;
						IL_0e93:
						num = 366;
						Globals_Renamed.arExpModBasis = new string[Globals_Renamed.intNumExpModels + 1];
						goto IL_0eab;
						IL_0eab:
						num = 369;
						Globals_Renamed.arExpModOutputOn = new short[3, Globals_Renamed.intNumExpModels + 1];
						goto IL_0ec4;
						IL_0ec4:
						num = 372;
						Globals_Renamed.arExpModChar = new string[3, Globals_Renamed.intNumExpModels + 1];
						goto IL_0edd;
						IL_0edd:
						num = 375;
						Globals_Renamed.arExpModChmSt = new short[Globals_Renamed.intNumExpModels + 1];
						goto IL_0ef5;
						IL_0ef5:
						num = 378;
						Globals_Renamed.arExpModUncertainty = new short[Globals_Renamed.intNumExpModels + 1];
						goto IL_0f0d;
						IL_0f0d:
						num = 381;
						Globals_Renamed.arExpModStatus = new short[Globals_Renamed.intNumExpModels + 1];
						goto IL_0f25;
						IL_0f25:
						num = 384;
						Globals_Renamed.arExpModParmsV = new float[3, 163, Globals_Renamed.intNumExpModels + 1];
						goto IL_0f43;
						IL_0f43:
						num = 387;
						Globals_Renamed.arExpModParmsT = new short[3, 163, Globals_Renamed.intNumExpModels + 1];
						goto IL_0f61;
						IL_0f61:
						num = 390;
						Globals_Renamed.arExpModParmsVC = new short[3, 163, Globals_Renamed.intNumExpModels + 1];
						goto IL_0f7f;
						IL_0f7f:
						num = 393;
						Globals_Renamed.arExpModEst = new float[3, 19, Globals_Renamed.intNumExpModels + 1];
						goto IL_0f9a;
						IL_0f9a:
						num = 396;
						Globals_Renamed.arExpModStatus = new short[Globals_Renamed.intNumExpModels + 1];
						goto IL_0fb2;
						IL_0fb2:
						num = 399;
						Globals_Renamed.arExpModInhRC = new string[5, Globals_Renamed.intNumExpModels + 1];
						goto IL_0fcb;
						IL_0fcb:
						num = 402;
						Globals_Renamed.intNumOps = 0;
						goto IL_0fd8;
						IL_0fd8:
						num = 403;
						lblAVPlow.Text = Interaction.GetSetting("ChemSteer", "Options", "VPlow", "0.001");
						goto IL_1004;
						IL_1004:
						num = 404;
						lblAVPhigh.Text = Interaction.GetSetting("ChemSteer", "Options", "VPhigh", "35");
						goto IL_1030;
						IL_1030:
						num = 405;
						txtAssumps.Text = "Generated by ChemSTEER v3.2 (May 12, 2016)";
						goto IL_1048;
						IL_1048:
						num = 406;
						if (true)
						{
							goto IL_1056;
						}
						goto IL_10ae;
						IL_1056:
						num = 407;
						mnuFileImportCRSS.Visible = true;
						goto IL_106a;
						IL_106a:
						num = 408;
						mnuFileViewCRSS.Visible = true;
						goto IL_107e;
						IL_107e:
						num = 409;
						mnuFileSep4.Visible = true;
						goto IL_1092;
						IL_1092:
						num = 410;
						mnuPreferences[(short)2].Visible = true;
						goto IL_110d;
						IL_10ae:
						num = 412;
						goto IL_10b6;
						IL_10b6:
						num = 413;
						mnuFileImportCRSS.Visible = false;
						goto IL_10ca;
						IL_10ca:
						num = 414;
						mnuFileViewCRSS.Visible = false;
						goto IL_10de;
						IL_10de:
						num = 415;
						mnuFileSep4.Visible = false;
						goto IL_10f2;
						IL_10f2:
						num = 416;
						mnuPreferences[(short)2].Visible = false;
						goto IL_110d;
						end_IL_0001_2:
						break;
					}
					num = 421;
					clearInhClassFields();
					break;
				}
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 6166;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_3:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void frmMain_Closing(object eventSender, CancelEventArgs eventArgs)
	{
		//IL_0048: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Expected I4, but got Unknown
		short num = (short)(0 - (eventArgs.Cancel ? 1 : 0));
		if (!ChemStrX.chkModelsRun())
		{
			num = 1;
			((Control)this).Tag = "cancel";
		}
		else if (Globals_Renamed.gblIWasChanged & !Globals_Renamed.gblDoEasyModels)
		{
			switch (Interaction.MsgBox((object)"Do you want to save your changes to the assessment?", (MsgBoxStyle)3, (object)"Assessment was changed") - 2)
			{
			case 4:
				mnuFileSave_Click(mnuFileSave, new EventArgs());
				break;
			case 0:
				num = 1;
				((Control)this).Tag = "cancel";
				break;
			case 5:
				Globals_Renamed.gblIWasChanged = false;
				break;
			}
		}
		eventArgs.Cancel = num != 0;
	}

	private void frmMain_Closed(object eventSender, EventArgs eventArgs)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Invalid comparison between Unknown and I4
		//IL_0024: Unknown result type (might be due to invalid IL or missing references)
		//IL_002e: Expected I4, but got Unknown
		if ((int)((Form)this).WindowState != 1)
		{
			Interaction.SaveSetting("ChemSTEER", "Options", "WinState", Conversions.ToString((int)((Form)this).WindowState));
			Interaction.SaveSetting("ChemSTEER", "Options", "WinLeft", Conversions.ToString(Support.PixelsToTwipsX((double)((Control)this).Left)));
			Interaction.SaveSetting("ChemSTEER", "Options", "WinTop", Conversions.ToString(Support.PixelsToTwipsY((double)((Control)this).Top)));
			Interaction.SaveSetting("ChemSTEER", "Options", "WinHeight", Conversions.ToString(Support.PixelsToTwipsY((double)((Control)this).Height)));
			Interaction.SaveSetting("ChemSTEER", "Options", "WinWidth", Conversions.ToString(Support.PixelsToTwipsX((double)((Control)this).Width)));
		}
	}

	public void LoadMsfOpIP()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					AxMSFlexGrid pmsfGrid = msfOpIP;
					ChemStrX.MyMSfClear(ref pmsfGrid);
					msfOpIP = pmsfGrid;
					if (Globals_Renamed.intNumOps <= 0)
					{
						goto end_IL_0001;
					}
					Globals_Renamed.intOpIndex = checked((short)Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex));
					if (Globals_Renamed.arOpBorC[Globals_Renamed.intOpIndex] == 0)
					{
						AxMSFlexGrid obj = msfOpIP;
						string[] array = new string[5];
						string[] array2 = array;
						ref short pOpID = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
						short pParmID = 15;
						array2[0] = ChemStrX.GetParmLabels(ref pOpID, ref pParmID);
						array[1] = "\t";
						array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[15, Globals_Renamed.intOpIndex]);
						array[3] = "\t";
						array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[15, Globals_Renamed.intOpIndex]);
						obj.AddItem(string.Concat(array));
						AxMSFlexGrid obj2 = msfOpIP;
						array = new string[5];
						string[] array3 = array;
						ref short pOpID2 = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
						pParmID = 13;
						array3[0] = ChemStrX.GetParmLabels(ref pOpID2, ref pParmID);
						array[1] = "\t";
						array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[13, Globals_Renamed.intOpIndex]);
						array[3] = "\t";
						array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[13, Globals_Renamed.intOpIndex]);
						obj2.AddItem(string.Concat(array));
						AxMSFlexGrid obj3 = msfOpIP;
						array = new string[5];
						string[] array4 = array;
						ref short pOpID3 = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
						pParmID = 14;
						array4[0] = ChemStrX.GetParmLabels(ref pOpID3, ref pParmID);
						array[1] = "\t";
						array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[14, Globals_Renamed.intOpIndex]);
						array[3] = "\t";
						array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[14, Globals_Renamed.intOpIndex]);
						obj3.AddItem(string.Concat(array));
						AxMSFlexGrid obj4 = msfOpIP;
						array = new string[5];
						string[] array5 = array;
						ref short pOpID4 = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
						pParmID = 12;
						array5[0] = ChemStrX.GetParmLabels(ref pOpID4, ref pParmID);
						array[1] = "\t";
						array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[12, Globals_Renamed.intOpIndex]);
						array[3] = "\t";
						array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[12, Globals_Renamed.intOpIndex]);
						obj4.AddItem(string.Concat(array));
						msfOpIP.AddItem(Globals_Renamed.arParmNames[1] + "\t" + ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[1, Globals_Renamed.intOpIndex]) + "\t" + Support.Format((object)Globals_Renamed.arOpParms[1, Globals_Renamed.intOpIndex], "###,##0", (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						msfOpIP.AddItem(Globals_Renamed.arParmNames[2] + "\t" + ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[2, Globals_Renamed.intOpIndex]) + "\t" + Support.Format((object)Globals_Renamed.arOpParms[2, Globals_Renamed.intOpIndex], "###,##0", (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						AxMSFlexGrid obj5 = msfOpIP;
						array = new string[5];
						string[] array6 = array;
						ref short pOpID5 = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
						pParmID = 11;
						array6[0] = ChemStrX.GetParmLabels(ref pOpID5, ref pParmID);
						array[1] = "\t";
						array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[11, Globals_Renamed.intOpIndex]);
						array[3] = "\t";
						array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
						obj5.AddItem(string.Concat(array));
						AxMSFlexGrid obj6 = msfOpIP;
						array = new string[5];
						string[] array7 = array;
						ref short pOpID6 = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
						pParmID = 10;
						array7[0] = ChemStrX.GetParmLabels(ref pOpID6, ref pParmID);
						array[1] = "\t";
						array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[10, Globals_Renamed.intOpIndex]);
						array[3] = "\t";
						array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
						obj6.AddItem(string.Concat(array));
						if (Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)] == 103)
						{
							AxMSFlexGrid obj7 = msfOpIP;
							array = new string[5];
							string[] array8 = array;
							ref short pOpID7 = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
							pParmID = 130;
							array8[0] = ChemStrX.GetParmLabels(ref pOpID7, ref pParmID);
							array[1] = "\t";
							array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[130, Globals_Renamed.intOpIndex]);
							array[3] = "\t";
							array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[130, Globals_Renamed.intOpIndex]);
							obj7.AddItem(string.Concat(array));
						}
					}
					else
					{
						AxMSFlexGrid obj8 = msfOpIP;
						string[] array = new string[5];
						string[] array9 = array;
						ref short pOpID8 = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
						short pParmID = 103;
						array9[0] = ChemStrX.GetParmLabels(ref pOpID8, ref pParmID);
						array[1] = "\t";
						array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[103, Globals_Renamed.intOpIndex]);
						array[3] = "\t";
						array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[103, Globals_Renamed.intOpIndex]);
						obj8.AddItem(string.Concat(array));
						AxMSFlexGrid obj9 = msfOpIP;
						array = new string[5];
						string[] array10 = array;
						ref short pOpID9 = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
						pParmID = 104;
						array10[0] = ChemStrX.GetParmLabels(ref pOpID9, ref pParmID);
						array[1] = "\t";
						array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[104, Globals_Renamed.intOpIndex]);
						array[3] = "\t";
						array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[104, Globals_Renamed.intOpIndex]);
						obj9.AddItem(string.Concat(array));
						AxMSFlexGrid obj10 = msfOpIP;
						array = new string[5];
						string[] array11 = array;
						ref short pOpID10 = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
						pParmID = 99;
						array11[0] = ChemStrX.GetParmLabels(ref pOpID10, ref pParmID);
						array[1] = "\t";
						array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[99, Globals_Renamed.intOpIndex]);
						array[3] = "\t";
						array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[99, Globals_Renamed.intOpIndex]);
						obj10.AddItem(string.Concat(array));
						AxMSFlexGrid obj11 = msfOpIP;
						array = new string[5];
						string[] array12 = array;
						ref short pOpID11 = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
						pParmID = 32;
						array12[0] = ChemStrX.GetParmLabels(ref pOpID11, ref pParmID);
						array[1] = "\t";
						array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[32, Globals_Renamed.intOpIndex]);
						array[3] = "\t";
						array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[32, Globals_Renamed.intOpIndex]);
						obj11.AddItem(string.Concat(array));
						msfOpIP.AddItem(Globals_Renamed.arParmNames[1] + "\t" + ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[1, Globals_Renamed.intOpIndex]) + "\t" + Support.Format((object)Globals_Renamed.arOpParms[1, Globals_Renamed.intOpIndex], "###,##0", (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						msfOpIP.AddItem(Globals_Renamed.arParmNames[16] + "\t" + ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[16, Globals_Renamed.intOpIndex]) + "\t" + Support.Format((object)Globals_Renamed.arOpParms[16, Globals_Renamed.intOpIndex], "###,##0", (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						AxMSFlexGrid obj12 = msfOpIP;
						array = new string[5];
						string[] array13 = array;
						ref short pOpID12 = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
						pParmID = 11;
						array13[0] = ChemStrX.GetParmLabels(ref pOpID12, ref pParmID);
						array[1] = "\t";
						array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[11, Globals_Renamed.intOpIndex]);
						array[3] = "\t";
						array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
						obj12.AddItem(string.Concat(array));
						AxMSFlexGrid obj13 = msfOpIP;
						array = new string[5];
						string[] array14 = array;
						ref short pOpID13 = ref Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex)];
						pParmID = 10;
						array14[0] = ChemStrX.GetParmLabels(ref pOpID13, ref pParmID);
						array[1] = "\t";
						array[2] = ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[10, Globals_Renamed.intOpIndex]);
						array[3] = "\t";
						array[4] = ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
						obj13.AddItem(string.Concat(array));
						msfOpIP.AddItem(Globals_Renamed.arParmNames[101] + "\t" + ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[101, Globals_Renamed.intOpIndex]) + "\t" + Support.Format((object)Globals_Renamed.arOpParms[101, Globals_Renamed.intOpIndex], "###,##0", (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						msfOpIP.AddItem(Globals_Renamed.arParmNames[18] + "\t" + ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[18, Globals_Renamed.intOpIndex]) + "\t" + Support.Format((object)Globals_Renamed.arOpParms[18, Globals_Renamed.intOpIndex], "###,##0", (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						msfOpIP.AddItem(Globals_Renamed.arParmNames[24] + "\t" + ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[24, Globals_Renamed.intOpIndex]) + "\t" + Support.Format((object)Globals_Renamed.arOpParms[24, Globals_Renamed.intOpIndex], "###,##0.0", (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						msfOpIP.AddItem(Globals_Renamed.arParmNames[102] + "\t" + ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[102, Globals_Renamed.intOpIndex]) + "\t" + Support.Format((object)Globals_Renamed.arOpParms[102, Globals_Renamed.intOpIndex], "###,##0", (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						msfOpIP.AddItem(Globals_Renamed.arParmNames[2] + "\t" + ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[2, Globals_Renamed.intOpIndex]) + "\t" + Support.Format((object)Globals_Renamed.arOpParms[2, Globals_Renamed.intOpIndex], "###,##0", (FirstDayOfWeek)1, (FirstWeekOfYear)1));
						msfOpIP.AddItem(Globals_Renamed.arParmNames[17] + "\t" + ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[17, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[17, Globals_Renamed.intOpIndex]));
					}
					msfOpIP.RemoveItem(1);
					goto end_IL_0001;
				}
				case 3507:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "LoadMsfOpIp";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj14) when (obj14 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj14);
				try0001_dispatch = 3507;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void PrimeContainerSubTab()
	{
		//IL_08f2: Unknown result type (might be due to invalid IL or missing references)
		Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
		Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
		Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
		float[] array = new float[4];
		recordset.CursorLocation = CursorLocationEnum.adUseClient;
		if (_lstSelOps_1.SelectedIndex == -1)
		{
			return;
		}
		checked
		{
			Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex);
			lblContYrm[(short)0].Text = "Yrm = " + Conversions.ToString(Globals_Renamed.arOpParms[11, Globals_Renamed.intOpIndex]);
			lblContYrm[(short)1].Text = lblContYrm[(short)0].Text;
			lblContYprod[(short)0].Text = "Yprod = " + Conversions.ToString(Globals_Renamed.arOpParms[10, Globals_Renamed.intOpIndex]);
			lblContYprod[(short)1].Text = lblContYprod[(short)0].Text;
			txtContDrm.Text = Conversions.ToString(Globals_Renamed.arOpParms[29, Globals_Renamed.intOpIndex]);
			lblDrmType.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"(", Interaction.IIf(Globals_Renamed.arOpParms[29, Globals_Renamed.intOpIndex] == Conversions.ToSingle(lblDchem.Text), (object)"Default", (object)"User Specified")), (object)")"));
			txtContDprod.Text = Conversions.ToString(Globals_Renamed.arOpParms[30, Globals_Renamed.intOpIndex]);
			lblDprodType.Text = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"(", Interaction.IIf(Globals_Renamed.arOpParms[30, Globals_Renamed.intOpIndex] == Conversions.ToSingle(lblDchem.Text), (object)"Default", (object)"User Specified")), (object)")"));
			lblContOD.Text = "OD = " + Conversions.ToString(Globals_Renamed.arOpParms[2, Globals_Renamed.intOpIndex]);
			_msfCont_0.Rows = 2;
			_msfCont_1.Rows = 2;
			_msfCont_2.Rows = 2;
			_msfCont_3.Rows = 2;
			if (Globals_Renamed.intNumOps > 0)
			{
				command.ActiveConnection = Common.MyConn;
				command.CommandText = "pqryGetActContTab";
				command.CommandType = CommandTypeEnum.adCmdStoredProc;
				short num = 0;
				short num2;
				short num3;
				do
				{
					unchecked
					{
						if (Globals_Renamed.arSelActType[num, Globals_Renamed.intOpIndex] > 0)
						{
							command.Parameters.Append(command.CreateParameter("pActID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arSelActType[num, Globals_Renamed.intOpIndex]));
							Command command2 = command;
							object RecordsAffected = Missing.Value;
							object Parameters = Missing.Value;
							recordset = command2.Execute(out RecordsAffected, ref Parameters);
							command.Parameters.Delete("pActId");
							if (recordset.EOF)
							{
								Interaction.Beep();
								Interaction.MsgBox((object)"An activity with an invalid Activity Identifier was encountered. This assessment may be corrupt. Please contact technical support.", (MsgBoxStyle)64, (object)"Invalid Data");
								return;
							}
							if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value)) && Operators.ConditionalCompareObjectGreater(recordset.Fields[0].Value, (object)0, false))
							{
								object value = recordset.Fields[0].Value;
								if (Operators.ConditionalCompareObjectEqual(value, (object)1, false))
								{
									_msfCont_0.AddItem(Conversions.ToString((int)num) + "\t" + Globals_Renamed.arSelActs[num, Globals_Renamed.intOpIndex] + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[4, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[3, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[5, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[6, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[2, num, Globals_Renamed.intOpIndex]));
								}
								else if (Operators.ConditionalCompareObjectEqual(value, (object)2, false))
								{
									_msfCont_1.AddItem(Conversions.ToString((int)num) + "\t" + Globals_Renamed.arSelActs[num, Globals_Renamed.intOpIndex] + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[4, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[3, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[5, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[6, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[2, num, Globals_Renamed.intOpIndex]));
								}
								else
								{
									_msfCont_2.AddItem(Conversions.ToString((int)num) + "\t" + Globals_Renamed.arSelActs[num, Globals_Renamed.intOpIndex] + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[4, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[3, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[5, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[6, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[2, num, Globals_Renamed.intOpIndex]));
								}
								_msfCont_3.AddItem(Conversions.ToString((int)num) + "\t" + Globals_Renamed.arSelActs[num, Globals_Renamed.intOpIndex] + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[8, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[9, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[10, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[1, num, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arContParms[7, num, Globals_Renamed.intOpIndex]));
								array[Conversions.ToInteger(Operators.SubtractObject(recordset.Fields[0].Value, (object)1))] = array[Conversions.ToInteger(Operators.SubtractObject(recordset.Fields[0].Value, (object)1))] + Globals_Renamed.arContParms[4, num, Globals_Renamed.intOpIndex];
							}
							recordset.Close();
						}
					}
					num = (short)unchecked(num + 1);
					num2 = num;
					num3 = 24;
				}
				while (num2 <= num3);
			}
			recordset = null;
			command = null;
			if (_msfCont_0.Rows == 2)
			{
				short num4 = (short)(_msfCont_0.Cols - 1);
				short num5 = 0;
				while (true)
				{
					short num6 = num5;
					short num3 = num4;
					if (num6 <= num3)
					{
						_msfCont_0[1, unchecked((int)num5)] = "";
						num5 = (short)unchecked(num5 + 1);
						continue;
					}
					break;
				}
			}
			else
			{
				_msfCont_0.RemoveItem(1);
			}
			if (_msfCont_1.Rows == 2)
			{
				short num7 = (short)(_msfCont_1.Cols - 1);
				short num5 = 0;
				while (true)
				{
					short num8 = num5;
					short num3 = num7;
					if (num8 <= num3)
					{
						_msfCont_1[1, unchecked((int)num5)] = "";
						num5 = (short)unchecked(num5 + 1);
						continue;
					}
					break;
				}
			}
			else
			{
				_msfCont_1.RemoveItem(1);
			}
			if (_msfCont_2.Rows == 2)
			{
				short num9 = (short)(_msfCont_2.Cols - 1);
				short num5 = 0;
				while (true)
				{
					short num10 = num5;
					short num3 = num9;
					if (num10 <= num3)
					{
						_msfCont_2[1, unchecked((int)num5)] = "";
						num5 = (short)unchecked(num5 + 1);
						continue;
					}
					break;
				}
			}
			else
			{
				_msfCont_2.RemoveItem(1);
			}
			if (_msfCont_3.Rows == 2)
			{
				short num11 = (short)(_msfCont_3.Cols - 1);
				short num5 = 0;
				while (true)
				{
					short num12 = num5;
					short num3 = num11;
					if (num12 <= num3)
					{
						_msfCont_3[1, unchecked((int)num5)] = "";
						num5 = (short)unchecked(num5 + 1);
						continue;
					}
					break;
				}
			}
			else
			{
				_msfCont_3.RemoveItem(1);
			}
			lblContSumFC[(short)0].Text = "Sum of Fc = " + Conversions.ToString(array[0]);
			lblContSumFC[(short)1].Text = "Sum of Fc = " + Conversions.ToString(array[1]);
			lblContSumFC[(short)2].Text = "Sum of Fc = " + Conversions.ToString(array[2]);
		}
	}

	private void LoadcmbSPSG()
	{
		AxMSFlexGrid obj = msfSP;
		string[] array = new string[6]
		{
			Conversions.ToString(1),
			"\tAutomotive Spray Coating Model Factors\tSpray Gun Type\t",
			ChemStrX.SetOpParmType(ref Globals_Renamed.arOpSPType[1, Globals_Renamed.intOpIndex]),
			"\t",
			null,
			null
		};
		short pParmID = 1;
		short pValue = checked((short)Math.Round(Globals_Renamed.arOpSP[1, Globals_Renamed.intOpIndex]));
		array[4] = ChemStrX.TrtOpSPValues(ref pParmID, ref pValue);
		array[5] = "\tn/a";
		obj.AddItem(string.Concat(array));
	}

	public void LoadcmbElec()
	{
		AxMSFlexGrid obj = msfSP;
		string[] array = new string[6]
		{
			Conversions.ToString(47),
			"\tElectroplating Additive Type\tWWTE\t",
			ChemStrX.SetOpParmType(ref Globals_Renamed.arOpSPType[47, Globals_Renamed.intOpIndex]),
			"\t",
			null,
			null
		};
		short pParmID = 47;
		short pValue = checked((short)Math.Round(Globals_Renamed.arOpSP[47, Globals_Renamed.intOpIndex]));
		array[4] = ChemStrX.TrtOpSPValues(ref pParmID, ref pValue);
		array[5] = "\tn/a";
		obj.AddItem(string.Concat(array));
	}

	private void LoadcmbSPVP()
	{
		checked
		{
			short num = (short)msfSP.Rows;
			short pParmID = 118;
			short num2 = (short)(num + 4);
			short num3 = num;
			while (true)
			{
				short num4 = num3;
				short num5 = num2;
				if (num4 <= num5)
				{
					msfSP.AddItem(Conversions.ToString(unchecked((int)pParmID)) + "\tVapor Model Factors\t" + ChemStrX.GetParmLabels(ref Globals_Renamed.intOpIndex, ref pParmID) + "\t" + ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[pParmID, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[pParmID, Globals_Renamed.intOpIndex]) + "\t" + Globals_Renamed.arParmUnits[pParmID]);
					pParmID++;
					num3 = (short)unchecked(num3 + 1);
					continue;
				}
				break;
			}
		}
	}

	public void LoadcmbAmt()
	{
		msfSP.AddItem(Conversions.ToString(92) + "\tRecirculating Water-Cooling Tower Additive\tAmount to Use\t" + ChemStrX.SetOpParmType(ref Globals_Renamed.arOpParmsType[92, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.ShowInSciNot(Globals_Renamed.arOpParms[92, Globals_Renamed.intOpIndex]) + "\t" + Globals_Renamed.arParmUnits[92]);
	}

	private void LoadMsfOpSP()
	{
		msfSP.Rows = 1;
		if (Globals_Renamed.arOpSP[43, Globals_Renamed.intOpIndex] == 1f)
		{
			LoadcmbSPSG();
		}
		if (Globals_Renamed.arOpSP[44, Globals_Renamed.intOpIndex] == 1f)
		{
			LoadcmbSPVP();
		}
		if (Globals_Renamed.arOpSP[45, Globals_Renamed.intOpIndex] == 1f)
		{
			LoadcmbAmt();
		}
		if (Globals_Renamed.arOpSP[46, Globals_Renamed.intOpIndex] == 1f)
		{
			LoadcmbElec();
		}
	}

	private void LoadSiteInfo()
	{
		if (Globals_Renamed.intNumOps < 1)
		{
			return;
		}
		msfSites.Rows = 2;
		short num = 0;
		checked
		{
			while (Strings.Len(Globals_Renamed.arOSName[num, Globals_Renamed.intOpIndex]) != 0)
			{
				msfSites.AddItem(Globals_Renamed.arOSName[num, Globals_Renamed.intOpIndex] + "\t" + Globals_Renamed.arOSAddr[num, Globals_Renamed.intOpIndex] + "\t" + Globals_Renamed.arOSCity[num, Globals_Renamed.intOpIndex] + "\t" + Globals_Renamed.arOSState[num, Globals_Renamed.intOpIndex] + "\t" + Globals_Renamed.arOSZip[num, Globals_Renamed.intOpIndex] + "\t" + Globals_Renamed.arOSCty[num, Globals_Renamed.intOpIndex]);
				num = (short)unchecked(num + 1);
				short num2 = num;
				short num3 = 99;
				if (num2 > num3)
				{
					break;
				}
			}
			if (msfSites.Rows == 2)
			{
				short num4 = (short)(msfSites.Cols - 1);
				num = 0;
				while (true)
				{
					short num5 = num;
					short num3 = num4;
					if (num5 <= num3)
					{
						msfSites[1, unchecked((int)num)] = "";
						num = (short)unchecked(num + 1);
						continue;
					}
					break;
				}
			}
			else
			{
				msfSites.RemoveItem(1);
			}
		}
	}

	public void LoadLstSelOps()
	{
		//IL_006c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0076: Expected O, but got Unknown
		//IL_008e: Unknown result type (might be due to invalid IL or missing references)
		//IL_0098: Expected O, but got Unknown
		DefInstance._lstSelOps_0.Items.Clear();
		DefInstance._lstSelOps_1.Items.Clear();
		checked
		{
			short num = (short)(Globals_Renamed.intNumOps - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				short num5 = (short)(Globals_Renamed.intNumOps - 1);
				short num6 = 0;
				while (true)
				{
					short num7 = num6;
					num4 = num5;
					if (num7 > num4)
					{
						break;
					}
					unchecked
					{
						if (Globals_Renamed.arOpOrder[num6] == num2)
						{
							DefInstance._lstSelOps_0.Items.Add((object)new ListBoxItem(Globals_Renamed.arOpName[num6], (int)num6));
							DefInstance._lstSelOps_1.Items.Add((object)new ListBoxItem(Globals_Renamed.arOpName[num6], (int)num6));
							break;
						}
					}
					num6 = (short)unchecked(num6 + 1);
				}
				num2 = (short)unchecked(num2 + 1);
			}
		}
	}

	public void LoadMsfSubOps()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						if (_lstSelOps_0.SelectedIndex == -1)
						{
							msfSubOps.Rows = 1;
							goto end_IL_0001;
						}
						msfSubOps.Rows = 11;
						short num3 = 0;
						while (Globals_Renamed.arSubOpID[num3, Globals_Renamed.intOpIndex] > 0)
						{
							msfSubOps[num3 + 1, 0] = Globals_Renamed.arOpName[Globals_Renamed.arSubOpID[num3, Globals_Renamed.intOpIndex] - 1];
							msfSubOps[num3 + 1, 1] = ChemStrX.ShowInSciNot(Globals_Renamed.arSubPVf[num3, Globals_Renamed.intOpIndex]);
							msfSubOps[num3 + 1, 2] = ChemStrX.ShowInSciNot(Globals_Renamed.arSubPvOp[num3, Globals_Renamed.intOpIndex]);
							num3 = (short)unchecked(num3 + 1);
							short num4 = num3;
							short num5 = 9;
							if (num4 > num5)
							{
								break;
							}
						}
						msfSubOps.Rows = num3 + 1;
						goto end_IL_0001;
					}
					case 353:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "LoadMsfSubOps";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							((Control)this).Name = Eobject;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 353;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void PopRelActs()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						short num3 = 0;
						short num4;
						short num5;
						do
						{
							Globals_Renamed.arSelActType[num3, Globals_Renamed.intOpIndex] = 0;
							Globals_Renamed.arSelActs[num3, Globals_Renamed.intOpIndex] = "";
							Globals_Renamed.arSelActRa[num3, Globals_Renamed.intOpIndex] = false;
							Globals_Renamed.arSelActEa[num3, Globals_Renamed.intOpIndex] = false;
							Globals_Renamed.arSelActRaDMP[num3, Globals_Renamed.intOpIndex] = 0;
							Globals_Renamed.arSelActEaDMP[num3, Globals_Renamed.intOpIndex] = 0;
							Globals_Renamed.arSelActVolatile[num3, Globals_Renamed.intOpIndex] = 0;
							Globals_Renamed.arActNumWorkers[0, num3, Globals_Renamed.intOpIndex] = 0L;
							Globals_Renamed.arActNumWorkers[1, num3, Globals_Renamed.intOpIndex] = 0L;
							Globals_Renamed.arActNumWorkers[2, num3, Globals_Renamed.intOpIndex] = 0L;
							Globals_Renamed.arActNW_Route[num3, Globals_Renamed.intOpIndex] = "";
							Globals_Renamed.arActOrder[num3, Globals_Renamed.intOpIndex] = 0;
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 24;
						}
						while (num4 <= num5);
						short num6 = (short)(msfSelActs.Rows - 2);
						num3 = 0;
						while (true)
						{
							short num7 = num3;
							num5 = num6;
							if (num7 > num5)
							{
								break;
							}
							if (Versioned.IsNumeric((object)msfSelActs[num3 + 1, 0]))
							{
								Globals_Renamed.arSelActType[num3, Globals_Renamed.intOpIndex] = Conversions.ToShort(msfSelActs[num3 + 1, 0]);
								Globals_Renamed.arSelActs[num3, Globals_Renamed.intOpIndex] = msfSelActs[num3 + 1, 1];
								bool flag = Operators.CompareString(msfSelActs[num3 + 1, 2], "Yes", false) == 0;
								Globals_Renamed.arSelActRa[num3, Globals_Renamed.intOpIndex] = flag;
								if (!flag)
								{
									short num8 = 0;
									short num9;
									do
									{
										Globals_Renamed.arRelModels[num8, num3, Globals_Renamed.intOpIndex] = 0;
										num8 = (short)unchecked(num8 + 1);
										num9 = num8;
										num5 = 10;
									}
									while (num9 <= num5);
								}
								flag = Operators.CompareString(msfSelActs[num3 + 1, 3], "Yes", false) == 0;
								Globals_Renamed.arSelActEa[num3, Globals_Renamed.intOpIndex] = flag;
								if (!flag)
								{
									short num8 = 0;
									short num10;
									do
									{
										Globals_Renamed.arExpModels[num8, num3, Globals_Renamed.intOpIndex] = 0;
										num8 = (short)unchecked(num8 + 1);
										num10 = num8;
										num5 = 1;
									}
									while (num10 <= num5);
								}
								switch (msfSelActs[num3 + 1, 4])
								{
								case "Pending":
									Globals_Renamed.arSelActRaDMP[num3, Globals_Renamed.intOpIndex] = 0;
									break;
								case "Cond Models Added":
									Globals_Renamed.arSelActRaDMP[num3, Globals_Renamed.intOpIndex] = 1;
									break;
								case "No Cond Models Added":
									Globals_Renamed.arSelActRaDMP[num3, Globals_Renamed.intOpIndex] = 2;
									break;
								case "No Conditional Models":
									Globals_Renamed.arSelActRaDMP[num3, Globals_Renamed.intOpIndex] = 9;
									break;
								}
								switch (msfSelActs[num3 + 1, 5])
								{
								case "Pending":
									Globals_Renamed.arSelActEaDMP[num3, Globals_Renamed.intOpIndex] = 0;
									break;
								case "Cond Models Added":
									Globals_Renamed.arSelActEaDMP[num3, Globals_Renamed.intOpIndex] = 1;
									break;
								case "No Cond Models Added":
									Globals_Renamed.arSelActEaDMP[num3, Globals_Renamed.intOpIndex] = 2;
									break;
								case "No Conditional Models":
									Globals_Renamed.arSelActEaDMP[num3, Globals_Renamed.intOpIndex] = 9;
									break;
								}
								Globals_Renamed.arActOrder[num3, Globals_Renamed.intOpIndex] = Conversions.ToShort(msfSelActs[num3 + 1, 6]);
							}
							num3 = (short)unchecked(num3 + 1);
						}
						goto end_IL_0001;
					}
					case 1095:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "PopRelActs";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							((Control)this).Name = Eobject;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1095;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void LoadMsfSelActs()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						if (_lstSelOps_0.SelectedIndex == -1)
						{
							goto end_IL_0001;
						}
						msfSelActs.Rows = 2;
						short num3 = 0;
						while (Strings.Len(Globals_Renamed.arSelActs[num3, Globals_Renamed.intOpIndex]) != 0)
						{
							msfSelActs.AddItem(unchecked(Conversions.ToString((int)Globals_Renamed.arSelActType[num3, Globals_Renamed.intOpIndex]) + "\t" + Globals_Renamed.arSelActs[num3, Globals_Renamed.intOpIndex] + "\t" + Common.Cvt2YesNo(Globals_Renamed.arSelActRa[num3, Globals_Renamed.intOpIndex]) + "\t" + Common.Cvt2YesNo(Globals_Renamed.arSelActEa[num3, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.Cvt2DMPLabels(ref Globals_Renamed.arSelActRaDMP[num3, Globals_Renamed.intOpIndex]) + "\t" + ChemStrX.Cvt2DMPLabels(ref Globals_Renamed.arSelActEaDMP[num3, Globals_Renamed.intOpIndex]) + "\t" + Conversions.ToString((int)Globals_Renamed.arActOrder[num3, Globals_Renamed.intOpIndex])));
							num3 = (short)unchecked(num3 + 1);
							short num4 = num3;
							short num5 = 25;
							if (num4 > num5)
							{
								break;
							}
						}
						if (msfSelActs.Rows == 2)
						{
							short num6 = (short)(msfSelActs.Cols - 1);
							num3 = 0;
							while (true)
							{
								short num7 = num3;
								short num5 = num6;
								if (num7 <= num5)
								{
									msfSelActs[1, unchecked((int)num3)] = "";
									num3 = (short)unchecked(num3 + 1);
									continue;
								}
								break;
							}
						}
						else
						{
							msfSelActs.RemoveItem(1);
						}
						goto end_IL_0001;
					}
					case 553:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							((Control)this).Name = Eobject;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 553;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void LoadOpInfo()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						if (_lstSelOps_0.SelectedIndex == -1)
						{
							goto end_IL_0001;
						}
						lblPhyState[(short)0].Text = Globals_Renamed.arPSInto1[Globals_Renamed.intOpIndex];
						lblPhyStateOtherInfo[(short)0].Text = Globals_Renamed.arPSInto2[Globals_Renamed.intOpIndex];
						lblPhyState[(short)1].Text = Globals_Renamed.arPSOut1[Globals_Renamed.intOpIndex];
						lblPhyStateOtherInfo[(short)1].Text = Globals_Renamed.arPSOut2[Globals_Renamed.intOpIndex];
						lblPhyState[(short)2].Text = Globals_Renamed.arPSIn1[Globals_Renamed.intOpIndex];
						lblPhyStateOtherInfo[(short)2].Text = Globals_Renamed.arPSIn2[Globals_Renamed.intOpIndex];
						txtPD.Text = Globals_Renamed.arPDesc[Globals_Renamed.intOpIndex];
						msfNaics.Rows = 2;
						short num3 = 0;
						while (Strings.Len(Globals_Renamed.arNaics1[num3, Globals_Renamed.intOpIndex]) != 0)
						{
							msfNaics.AddItem(Globals_Renamed.arNaics1[num3, Globals_Renamed.intOpIndex] + "\t" + Globals_Renamed.arNaics2[num3, Globals_Renamed.intOpIndex]);
							num3 = (short)unchecked(num3 + 1);
							short num4 = num3;
							short num5 = 99;
							if (num4 > num5)
							{
								break;
							}
						}
						if (msfNaics.Rows == 2)
						{
							msfNaics[1, 0] = "";
							msfNaics[1, 1] = "";
						}
						else
						{
							msfNaics.RemoveItem(1);
						}
						LoadSiteInfo();
						goto end_IL_0001;
					}
					case 534:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "LoadOpInfo";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							((Control)this).Name = Eobject;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 534;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void LoadOpCmbs()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					cmbRelOps.Items.Clear();
					cmbRelActs.Items.Clear();
					lstRelModels.Items.Clear();
					cmbExpOps.Items.Clear();
					cmbExpActs.Items.Clear();
					lblDExpModel.Text = "None Specified";
					lblIExpModel.Text = "None Specified";
					AxMSFlexGrid pmsfGrid = msfRelParms;
					ChemStrX.MyMSfClear(ref pmsfGrid);
					msfRelParms = pmsfGrid;
					pmsfGrid = msfRelEst;
					ChemStrX.MyMSfClear(ref pmsfGrid);
					msfRelEst = pmsfGrid;
					pmsfGrid = _msfExpParms_0;
					ChemStrX.MyMSfClear(ref pmsfGrid);
					_msfExpParms_0 = pmsfGrid;
					pmsfGrid = _msfExpParms_1;
					ChemStrX.MyMSfClear(ref pmsfGrid);
					_msfExpParms_1 = pmsfGrid;
					pmsfGrid = msfExpEst;
					ChemStrX.MyMSfClear(ref pmsfGrid);
					msfExpEst = pmsfGrid;
					clearInhClassFields();
					short num3 = checked((short)(Globals_Renamed.intNumOps - 1));
					short num4 = 0;
					while (true)
					{
						short num5 = num4;
						short num6 = num3;
						if (num5 <= num6)
						{
							int num7 = cmbRelOps.Items.Add((object)Support.GetItemString((Control)(object)_lstSelOps_0, (int)num4));
							Support.SetItemData((Control)(object)cmbRelOps, num7, (int)Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_0, (int)num4)]);
							num7 = cmbExpOps.Items.Add((object)Support.GetItemString((Control)(object)_lstSelOps_0, (int)num4));
							Support.SetItemData((Control)(object)cmbExpOps, num7, (int)Globals_Renamed.arOpType[Support.GetItemData((Control)(object)_lstSelOps_0, (int)num4)]);
							checked
							{
								num4 = (short)unchecked(num4 + 1);
								continue;
							}
						}
						break;
					}
					goto end_IL_0001;
				}
				case 505:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "LoadOpCmbs";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 505;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void LoadOptInfoCombo()
	{
		//IL_0086: Unknown result type (might be due to invalid IL or missing references)
		//IL_0090: Expected O, but got Unknown
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					recordset.Open("SELECT * FROM qryListOfOptData", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					while (!recordset.EOF)
					{
						cmbOptInfo.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
						recordset.MoveNext();
					}
					recordset.Close();
					recordset.Open("SELECT * FROM ListOfParms", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					while (!recordset.EOF)
					{
						if (Strings.Len(RuntimeHelpers.GetObjectValue(recordset.Fields["Abbr"].Value)) > 0)
						{
							Globals_Renamed.arParmNames[Conversions.ToInteger(recordset.Fields["ParmID"].Value)] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(recordset.Fields["Abbr"].Value, (object)": "), recordset.Fields["ParmName"].Value));
						}
						else
						{
							Globals_Renamed.arParmNames[Conversions.ToInteger(recordset.Fields["ParmID"].Value)] = Conversions.ToString(recordset.Fields["ParmName"].Value);
						}
						Globals_Renamed.arParmUnits[Conversions.ToInteger(recordset.Fields["ParmID"].Value)] = Conversions.ToString(Operators.ConcatenateObject(recordset.Fields["StdUnits"].Value, (object)""));
						Globals_Renamed.arParmType[Conversions.ToInteger(recordset.Fields["ParmID"].Value)] = Conversions.ToShort(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["Type"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["Type"].Value)));
						Globals_Renamed.arParmDS[Conversions.ToInteger(recordset.Fields["ParmID"].Value)] = Conversions.ToShort(Interaction.IIf(Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultSource"].Value)), (object)0, RuntimeHelpers.GetObjectValue(recordset.Fields["DefaultSource"].Value)));
						recordset.MoveNext();
					}
					recordset.Close();
					recordset.Open("SELECT ParmID FROM ListOfParms ORDER BY Abbr, ParmName", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					short num3 = 1;
					while (!recordset.EOF)
					{
						Globals_Renamed.arParmOrder[num3] = Conversions.ToShort(recordset.Fields[0].Value);
						recordset.MoveNext();
						num3 = checked((short)(num3 + 1));
					}
					recordset.Close();
					recordset = null;
					cmbOptInfo.SelectedIndex = 0;
					goto end_IL_0001;
				}
				case 921:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 921;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void LoadExpParms(ref short pModel)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						string[] array = new string[3];
						string[] array2 = new string[3];
						string[] array3 = new string[3];
						string[] array4 = new string[3];
						ProjectData.ClearProjectError();
						num2 = 2;
						if (cmbExpOps.SelectedIndex == -1)
						{
							goto end_IL_0001;
						}
						if (pModel == 0)
						{
							AxMSFlexGrid pmsfGrid = _msfExpParms_0;
							ChemStrX.MyMSfClear(ref pmsfGrid);
							_msfExpParms_0 = pmsfGrid;
						}
						else
						{
							AxMSFlexGrid pmsfGrid = _msfExpParms_1;
							ChemStrX.MyMSfClear(ref pmsfGrid);
							_msfExpParms_1 = pmsfGrid;
						}
						lblChemStateExp[pModel].Text = "";
						if (cmbExpActs.SelectedIndex == -1)
						{
							goto end_IL_0001;
						}
						object obj = new object[13]
						{
							"", "Vapor", "Mist", "Particulate", "Aerosol", "", "", "", "", "",
							"", "Liquid", "Solid"
						};
						Globals_Renamed.intActIndex = (short)Support.GetItemData((Control)(object)cmbExpActs, cmbExpActs.SelectedIndex);
						if (Globals_Renamed.arExpModels[pModel, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] == 0)
						{
							goto end_IL_0001;
						}
						Globals_Renamed.intModIndex = (short)(Globals_Renamed.arExpModels[pModel, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
						if (Globals_Renamed.arExpModChmSt[Globals_Renamed.intModIndex] == 0)
						{
							lblChemStateExp[pModel].Text = "";
						}
						else
						{
							lblChemStateExp[pModel].Text = Conversions.ToString(NewLateBinding.LateIndexGet(obj, new object[1] { Globals_Renamed.arExpModChmSt[Globals_Renamed.intModIndex] }, (string[])null));
						}
						if (Globals_Renamed.arExpModOutputOn[0, Globals_Renamed.intModIndex] == 1)
						{
							if (pModel == 0)
							{
								_msfExpParms_0[0, 2] = "Type \r" + Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex];
								_msfExpParms_0[0, 3] = "Origin \r" + Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex];
								_msfExpParms_0[0, 4] = "Value \r" + Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex];
								_msfExpParms_0[2] = 1250;
								_msfExpParms_0[3] = 1250;
								_msfExpParms_0[4] = 1250;
							}
							else
							{
								_msfExpParms_1[0, 2] = "Type \r" + Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex];
								_msfExpParms_1[0, 3] = "Origin \r" + Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex];
								_msfExpParms_1[0, 4] = "Value \r" + Globals_Renamed.arExpModChar[0, Globals_Renamed.intModIndex];
								_msfExpParms_1[2] = 1250;
								_msfExpParms_1[3] = 1250;
								_msfExpParms_1[4] = 1250;
							}
						}
						else if (pModel == 0)
						{
							_msfExpParms_0[2] = 1;
							_msfExpParms_0[3] = 1;
							_msfExpParms_0[4] = 1;
						}
						else
						{
							_msfExpParms_1[2] = 1;
							_msfExpParms_1[3] = 1;
							_msfExpParms_1[4] = 1;
						}
						if (Globals_Renamed.arExpModOutputOn[1, Globals_Renamed.intModIndex] == 1)
						{
							if (pModel == 0)
							{
								_msfExpParms_0[0, 6] = "Type \r" + Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex];
								_msfExpParms_0[0, 7] = "Origin \r" + Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex];
								_msfExpParms_0[0, 8] = "Value \r" + Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex];
								_msfExpParms_0[6] = 1250;
								_msfExpParms_0[7] = 1250;
								_msfExpParms_0[8] = 1250;
							}
							else
							{
								_msfExpParms_1[0, 6] = "Type \r" + Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex];
								_msfExpParms_1[0, 7] = "Origin \r" + Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex];
								_msfExpParms_1[0, 8] = "Value \r" + Globals_Renamed.arExpModChar[1, Globals_Renamed.intModIndex];
								_msfExpParms_1[6] = 1250;
								_msfExpParms_1[7] = 1250;
								_msfExpParms_1[8] = 1250;
							}
						}
						else if (pModel == 0)
						{
							_msfExpParms_0[6] = 1;
							_msfExpParms_0[7] = 1;
							_msfExpParms_0[8] = 1;
						}
						else
						{
							_msfExpParms_1[6] = 1;
							_msfExpParms_1[7] = 1;
							_msfExpParms_1[8] = 1;
						}
						short num3 = 1;
						short num6;
						short num5;
						do
						{
							short pParmID = Globals_Renamed.arParmOrder[num3];
							if (((Globals_Renamed.arExpModParmsT[0, pParmID, Globals_Renamed.intModIndex] > 0) & (Globals_Renamed.arParmType[pParmID] < 100)) && pParmID != 54)
							{
								short pDualID = 0;
								string text;
								short num4;
								do
								{
									unchecked
									{
										switch (Globals_Renamed.arExpModParmsT[pDualID, pParmID, Globals_Renamed.intModIndex])
										{
										case 1:
											array[pDualID] = "Default";
											break;
										case 3:
											array[pDualID] = "Non-default";
											break;
										case 20:
											array[pDualID] = "Constant";
											break;
										case 21:
											array[pDualID] = "Model Output";
											break;
										default:
											array[pDualID] = "Unknown: " + Conversions.ToString((int)Globals_Renamed.arExpModParmsT[pDualID, pParmID, Globals_Renamed.intModIndex]);
											break;
										}
										switch (pParmID)
										{
										case 40:
										case 59:
										case 61:
										case 75:
										case 76:
										case 77:
										case 78:
										case 92:
											if (Globals_Renamed.arExpModParmsVC[pDualID, pParmID, Globals_Renamed.intModIndex] == 999)
											{
												array2[pDualID] = "User-defined";
												array3[pDualID] = Conversions.ToString(Globals_Renamed.arExpModParmsV[pDualID, pParmID, Globals_Renamed.intModIndex]);
												text = Globals_Renamed.arParmUnits[pParmID];
												array4[pDualID] = Conversions.ToString(999);
												break;
											}
											if (Globals_Renamed.arExpModParmsVC[pDualID, pParmID, Globals_Renamed.intModIndex] == 998)
											{
												array2[pDualID] = "Linked";
												array3[pDualID] = Conversions.ToString(Globals_Renamed.arExpModParmsV[pDualID, pParmID, Globals_Renamed.intModIndex]);
												text = Globals_Renamed.arParmUnits[pParmID];
												array4[pDualID] = Conversions.ToString(998);
												break;
											}
											array2[pDualID] = ChemStrX.GetParmAcronym(ref Globals_Renamed.arExpModParmsVC[pDualID, pParmID, Globals_Renamed.intModIndex]);
											if (Globals_Renamed.arExpModParmsVC[pDualID, pParmID, Globals_Renamed.intModIndex] < 1)
											{
												array3[pDualID] = "Error: " + Conversions.ToString((int)Globals_Renamed.arExpModParmsVC[pDualID, pParmID, Globals_Renamed.intModIndex]);
												text = "Error";
											}
											else if (Globals_Renamed.arExpModParmsVC[pDualID, pParmID, Globals_Renamed.intModIndex] < 162)
											{
												array3[pDualID] = Conversions.ToString(Globals_Renamed.arExpModParmsV[pDualID, Globals_Renamed.arExpModParmsVC[pDualID, pParmID, Globals_Renamed.intModIndex], Globals_Renamed.intModIndex]);
												text = Globals_Renamed.arParmUnits[pParmID];
											}
											else
											{
												array3[pDualID] = Conversions.ToString(-1);
												text = "ERROR";
											}
											array4[pDualID] = Conversions.ToString((int)Globals_Renamed.arExpModParmsVC[pDualID, pParmID, Globals_Renamed.intModIndex]);
											break;
										case 57:
											if (Globals_Renamed.arExpModParmsVC[pDualID, pParmID, Globals_Renamed.intModIndex] == 999)
											{
												array2[pDualID] = "User Specified";
												array3[pDualID] = Conversions.ToString(Globals_Renamed.arExpModParmsV[pDualID, pParmID, Globals_Renamed.intModIndex]);
											}
											else
											{
												array2[pDualID] = ChemStrX.GetVCLabel(ref pParmID, ref Globals_Renamed.arExpModParmsV[pDualID, pParmID, Globals_Renamed.intModIndex], ref Globals_Renamed.arExpModType[Globals_Renamed.intModIndex]);
												if (Globals_Renamed.arExpModParmsV[pDualID, pParmID, Globals_Renamed.intModIndex] > 0f)
												{
													array3[pDualID] = Conversions.ToString(ChemStrX.ConvertKcKCodeToValue(ref Globals_Renamed.arExpModParmsV[pDualID, pParmID, Globals_Renamed.intModIndex], ref pDualID, ref Globals_Renamed.arExpModType[Globals_Renamed.intModIndex]));
												}
												else
												{
													array3[pDualID] = "Error: " + Conversions.ToString(Globals_Renamed.arExpModParmsV[pDualID, pParmID, Globals_Renamed.intModIndex]);
												}
											}
											text = Globals_Renamed.arParmUnits[pParmID];
											array4[pDualID] = Conversions.ToString((int)Globals_Renamed.arExpModParmsVC[pDualID, pParmID, Globals_Renamed.intModIndex]);
											break;
										case 64:
											if (Globals_Renamed.arExpModType[Globals_Renamed.intModIndex] == 54)
											{
												array2[pDualID] = ChemStrX.GetVCLabel(ref pParmID, ref Globals_Renamed.arExpModParmsV[pDualID, 54, Globals_Renamed.intModIndex], ref pDualID);
											}
											else if (Globals_Renamed.arExpModParmsT[pDualID, pParmID, Globals_Renamed.intModIndex] == 3)
											{
												array2[pDualID] = "User Specified";
											}
											else
											{
												array2[pDualID] = ChemStrX.SetVCLabel(ref Globals_Renamed.arExpModParmsVC[pDualID, pParmID, Globals_Renamed.intModIndex]);
											}
											array3[pDualID] = Conversions.ToString(Globals_Renamed.arExpModParmsV[pDualID, pParmID, Globals_Renamed.intModIndex]);
											text = Globals_Renamed.arParmUnits[pParmID];
											array4[pDualID] = "";
											break;
										default:
											if (Globals_Renamed.arExpModParmsT[pDualID, pParmID, Globals_Renamed.intModIndex] == 3)
											{
												array2[pDualID] = "User Specified";
											}
											else
											{
												array2[pDualID] = ChemStrX.SetVCLabel(ref Globals_Renamed.arExpModParmsVC[pDualID, pParmID, Globals_Renamed.intModIndex]);
											}
											array3[pDualID] = Conversions.ToString(Globals_Renamed.arExpModParmsV[pDualID, pParmID, Globals_Renamed.intModIndex]);
											text = Globals_Renamed.arParmUnits[pParmID];
											array4[pDualID] = "";
											break;
										}
									}
									pDualID = (short)unchecked(pDualID + 1);
									num4 = pDualID;
									num5 = 1;
								}
								while (num4 <= num5);
								if (pModel == 0)
								{
									AxMSFlexGrid msfExpParms_ = _msfExpParms_0;
									string[] array5 = new string[21]
									{
										Conversions.ToString(unchecked((int)pParmID)),
										"\t",
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null
									};
									string[] array6 = array5;
									short pOpID = (short)Support.GetItemData((Control)(object)cmbExpOps, cmbExpOps.SelectedIndex);
									array6[2] = ChemStrX.GetParmLabels(ref pOpID, ref pParmID);
									array5[3] = "\t";
									array5[4] = array[0];
									array5[5] = "\t";
									array5[6] = array2[0];
									array5[7] = "\t";
									array5[8] = array3[0];
									array5[9] = "\t";
									array5[10] = array4[0];
									array5[11] = "\t";
									array5[12] = array[1];
									array5[13] = "\t";
									array5[14] = array2[1];
									array5[15] = "\t";
									array5[16] = array3[1];
									array5[17] = "\t";
									array5[18] = array4[1];
									array5[19] = "\t";
									array5[20] = text;
									msfExpParms_.AddItem(string.Concat(array5));
								}
								else
								{
									AxMSFlexGrid msfExpParms_2 = _msfExpParms_1;
									string[] array5 = new string[21]
									{
										Conversions.ToString(unchecked((int)pParmID)),
										"\t",
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null
									};
									string[] array7 = array5;
									short pOpID = (short)Support.GetItemData((Control)(object)cmbExpOps, cmbExpOps.SelectedIndex);
									array7[2] = ChemStrX.GetParmLabels(ref pOpID, ref pParmID);
									array5[3] = "\t";
									array5[4] = array[0];
									array5[5] = "\t";
									array5[6] = array2[0];
									array5[7] = "\t";
									array5[8] = array3[0];
									array5[9] = "\t";
									array5[10] = array4[0];
									array5[11] = "\t";
									array5[12] = array[1];
									array5[13] = "\t";
									array5[14] = array2[1];
									array5[15] = "\t";
									array5[16] = array3[1];
									array5[17] = "\t";
									array5[18] = array4[1];
									array5[19] = "\t";
									array5[20] = text;
									msfExpParms_2.AddItem(string.Concat(array5));
								}
							}
							num3 = (short)unchecked(num3 + 1);
							num6 = num3;
							num5 = 162;
						}
						while (num6 <= num5);
						if (pModel == 0)
						{
							if ((Operators.CompareString(_msfExpParms_0[1, 0], "", false) == 0) & (_msfExpParms_0.Rows > 2))
							{
								_msfExpParms_0.RemoveItem(1);
							}
						}
						else if ((Operators.CompareString(_msfExpParms_1[1, 0], "", false) == 0) & (_msfExpParms_1.Rows > 2))
						{
							_msfExpParms_1.RemoveItem(1);
						}
						FormatExpOutputs();
						goto end_IL_0001;
					}
					case 3914:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "LoadExpParms";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							((Control)this).Name = Eobject;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 3914;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void LoadRelModelParms()
	{
		//IL_010b: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						string[] array = new string[3];
						string[] array2 = new string[3];
						string[] array3 = new string[3];
						string[] array4 = new string[3];
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
						Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						SetMsfRelParmsDefaultCaptions();
						if (lstRelModels.SelectedIndex == -1)
						{
							goto end_IL_0001;
						}
						Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbRelOps.SelectedIndex);
						Globals_Renamed.intActIndex = (short)Support.GetItemData((Control)(object)cmbRelActs, cmbRelActs.SelectedIndex);
						Globals_Renamed.intModIndex = (short)(Globals_Renamed.arRelModels[lstRelModels.SelectedIndex, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
						if (Globals_Renamed.intModIndex == -1)
						{
							Interaction.Beep();
							Interaction.MsgBox((object)"Index error in lstRelModels_Click. Please contact technical support.", (MsgBoxStyle)64, (object)null);
							goto end_IL_0001;
						}
						command.ActiveConnection = Common.MyConn;
						command.CommandText = "pqryGetRelModel";
						command.CommandType = CommandTypeEnum.adCmdStoredProc;
						command.Parameters.Append(command.CreateParameter("pRelModID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, Globals_Renamed.arRelModType[Globals_Renamed.intModIndex]));
						Command command2 = command;
						object RecordsAffected = Missing.Value;
						object Parameters = Missing.Value;
						recordset = command2.Execute(out RecordsAffected, ref Parameters);
						string text = Strings.Right("0" + Conversions.ToString(recordset.Fields["pCat"].Value), 2);
						recordset.Close();
						recordset.Open("SELECT * FROM qryGetParms" + text, Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						msfRelParms.Rows = 2;
						msfRelParms[1, 0] = "";
						short num3 = 0;
						short num4;
						short num5;
						do
						{
							if (Globals_Renamed.arRelModOutputOn[num3, Globals_Renamed.intModIndex] == 1)
							{
								msfRelParms[0, num3 * 4 + 2] = "Type \r" + Globals_Renamed.arRelModChar[num3, Globals_Renamed.intModIndex];
								msfRelParms[0, num3 * 4 + 3] = "Origin \r" + Globals_Renamed.arRelModChar[num3, Globals_Renamed.intModIndex];
								msfRelParms[0, num3 * 4 + 4] = "Value \r" + Globals_Renamed.arRelModChar[num3, Globals_Renamed.intModIndex];
								msfRelParms[num3 * 4 + 2] = 1250;
								msfRelParms[num3 * 4 + 3] = 1250;
								msfRelParms[num3 * 4 + 4] = 1250;
							}
							else
							{
								msfRelParms[num3 * 4 + 2] = 1;
								msfRelParms[num3 * 4 + 3] = 1;
								msfRelParms[num3 * 4 + 4] = 1;
							}
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 1;
						}
						while (num4 <= num5);
						num3 = 1;
						short num9;
						do
						{
							short pParmID = Globals_Renamed.arParmOrder[num3];
							if ((Globals_Renamed.arRelModParmsT[0, pParmID, Globals_Renamed.intModIndex] > 0) & (Globals_Renamed.arParmType[pParmID] < 100))
							{
								recordset.MoveFirst();
								recordset.Find("ParmID=" + Conversions.ToString(unchecked((int)pParmID)), 0, SearchDirectionEnum.adSearchForward, Missing.Value);
								if (recordset.EOF)
								{
									Interaction.Beep();
								}
								else
								{
									short num6 = 0;
									short num8;
									short pParmID2;
									do
									{
										unchecked
										{
											switch (Globals_Renamed.arRelModParmsT[num6, pParmID, Globals_Renamed.intModIndex])
											{
											case 1:
												array[num6] = "Default";
												break;
											case 3:
												array[num6] = "Non-default";
												break;
											case 20:
												array[num6] = "Constant";
												break;
											case 21:
												array[num6] = "Model Output";
												break;
											default:
												array[num6] = "Unknown: " + Conversions.ToString((int)Globals_Renamed.arRelModParmsT[num6, pParmID, Globals_Renamed.intModIndex]);
												break;
											}
											if (pParmID == 9 || pParmID == 72 || pParmID == 92 || pParmID == 40)
											{
												if ((Globals_Renamed.arRelModParmsVC[num6, pParmID, Globals_Renamed.intModIndex] == 999) | (Globals_Renamed.arRelModParmsVC[num6, pParmID, Globals_Renamed.intModIndex] < 0))
												{
													array2[num6] = "User-defined";
													array3[num6] = Conversions.ToString(Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex]);
													text = Globals_Renamed.arParmUnits[pParmID];
													array4[num6] = Conversions.ToString(999);
												}
												else
												{
													short num7 = num6;
													pParmID2 = Globals_Renamed.arRelModParmsVC[num6, pParmID, Globals_Renamed.intModIndex];
													array2[num7] = ChemStrX.GetParmAcronym(ref pParmID2);
													array3[num6] = Conversions.ToString(Globals_Renamed.arRelModParmsV[num6, Globals_Renamed.arRelModParmsVC[num6, pParmID, Globals_Renamed.intModIndex], Globals_Renamed.intModIndex]);
													text = Globals_Renamed.arParmUnits[pParmID];
													array4[num6] = Conversions.ToString((int)Globals_Renamed.arRelModParmsVC[num6, pParmID, Globals_Renamed.intModIndex]);
												}
											}
											else if (pParmID == 43 || pParmID == 45 || pParmID == 52)
											{
												array2[num6] = ChemStrX.GetVCLabel(ref pParmID, ref Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex], ref Globals_Renamed.arRelModType[Globals_Renamed.intModIndex]);
												if ((Operators.CompareString(array2[num6], "Unspecified", false) == 0) & (Globals_Renamed.arRelModParmsT[num6, pParmID, Globals_Renamed.intModIndex] == 3))
												{
													array2[num6] = "User Specified";
												}
												array3[num6] = Conversions.ToString(Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex]);
												text = Globals_Renamed.arParmUnits[pParmID];
												array4[num6] = Conversions.ToString((int)Globals_Renamed.arRelModParmsVC[num6, pParmID, Globals_Renamed.intModIndex]);
											}
											else if (pParmID == 31 || pParmID == 49)
											{
												if (Globals_Renamed.arRelModParmsT[num6, pParmID, Globals_Renamed.intModIndex] == 3)
												{
													array2[num6] = "User Specified";
												}
												else if (Globals_Renamed.arRelModParmsVC[num6, pParmID, Globals_Renamed.intModIndex] == 999)
												{
													array2[num6] = "User-defined";
												}
												else if ((pParmID == 31) & (Globals_Renamed.arRelModType[Globals_Renamed.intModIndex] == 43))
												{
													array2[num6] = "Model Parm";
												}
												else
												{
													array2[num6] = "Cont Parm";
												}
												array3[num6] = Conversions.ToString(Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex]);
												text = Globals_Renamed.arParmUnits[pParmID];
												array4[num6] = "";
											}
											else
											{
												switch (pParmID)
												{
												case 137:
													array2[num6] = ChemStrX.GetVCLabel(ref pParmID, ref Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex], ref Globals_Renamed.arRelModType[Globals_Renamed.intModIndex]);
													array3[num6] = Conversions.ToString(Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex]);
													text = Globals_Renamed.arParmUnits[72];
													break;
												case 141:
													array2[num6] = ChemStrX.GetVCLabel(ref pParmID, ref Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex], ref Globals_Renamed.arRelModType[Globals_Renamed.intModIndex]);
													array3[num6] = Conversions.ToString(Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex]);
													text = Globals_Renamed.arParmUnits[141];
													break;
												case 142:
													if (Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex] == 0f)
													{
														array2[num6] = ChemStrX.GetVCLabel(ref pParmID, ref Globals_Renamed.arOpParms[pParmID, Globals_Renamed.intOpIndex], ref Globals_Renamed.arRelModType[Globals_Renamed.intModIndex]);
														array3[num6] = Conversions.ToString(Globals_Renamed.arOpParms[pParmID, Globals_Renamed.intOpIndex]);
													}
													else
													{
														array2[num6] = ChemStrX.GetVCLabel(ref pParmID, ref Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex], ref Globals_Renamed.arRelModType[Globals_Renamed.intModIndex]);
														array3[num6] = Conversions.ToString(Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex]);
													}
													if ((Operators.CompareString(array2[num6], "Unspecified", false) == 0) & (Globals_Renamed.arRelModParmsT[num6, pParmID, Globals_Renamed.intModIndex] == 3))
													{
														array2[num6] = "User Specified";
													}
													text = Globals_Renamed.arParmUnits[pParmID];
													array4[num6] = Conversions.ToString((int)Globals_Renamed.arRelModParmsVC[num6, pParmID, Globals_Renamed.intModIndex]);
													break;
												case 143:
													array2[num6] = ChemStrX.SetVCLabel(ref Globals_Renamed.arRelModParmsVC[num6, pParmID, Globals_Renamed.intModIndex]);
													array3[num6] = ChemStrX.GetVCLabel(ref pParmID, ref Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex], ref Globals_Renamed.arRelModType[Globals_Renamed.intModIndex]);
													text = Globals_Renamed.arParmUnits[pParmID];
													array4[num6] = Conversions.ToString(Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex]);
													break;
												case 144:
													array2[num6] = ChemStrX.SetVCLabel(ref Globals_Renamed.arRelModParmsVC[num6, pParmID, Globals_Renamed.intModIndex]);
													array3[num6] = Conversions.ToString(Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex]);
													text = Globals_Renamed.arParmUnits[pParmID];
													array4[num6] = Conversions.ToString((int)Globals_Renamed.arRelModParmsVC[num6, pParmID, Globals_Renamed.intModIndex]);
													break;
												default:
													if (Globals_Renamed.arRelModParmsT[num6, pParmID, Globals_Renamed.intModIndex] == 3)
													{
														array2[num6] = "User Specified";
													}
													else
													{
														array2[num6] = ChemStrX.SetVCLabel(ref Globals_Renamed.arRelModParmsVC[num6, pParmID, Globals_Renamed.intModIndex]);
													}
													array3[num6] = Conversions.ToString(Globals_Renamed.arRelModParmsV[num6, pParmID, Globals_Renamed.intModIndex]);
													text = Globals_Renamed.arParmUnits[pParmID];
													array4[num6] = "";
													break;
												}
											}
										}
										num6 = (short)unchecked(num6 + 1);
										num8 = num6;
										num5 = 1;
									}
									while (num8 <= num5);
									AxMSFlexGrid obj = msfRelParms;
									string[] array5 = new string[21]
									{
										Conversions.ToString(unchecked((int)pParmID)),
										"\t",
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null,
										null
									};
									pParmID2 = (short)Support.GetItemData((Control)(object)cmbRelOps, cmbRelOps.SelectedIndex);
									array5[2] = ChemStrX.GetParmLabels(ref pParmID2, ref pParmID);
									array5[3] = "\t";
									array5[4] = array[0];
									array5[5] = "\t";
									array5[6] = array2[0];
									array5[7] = "\t";
									array5[8] = array3[0];
									array5[9] = "\t";
									array5[10] = array4[0];
									array5[11] = "\t";
									array5[12] = array[1];
									array5[13] = "\t";
									array5[14] = array2[1];
									array5[15] = "\t";
									array5[16] = array3[1];
									array5[17] = "\t";
									array5[18] = array4[1];
									array5[19] = "\t";
									array5[20] = text;
									obj.AddItem(string.Concat(array5));
								}
							}
							num3 = (short)unchecked(num3 + 1);
							num9 = num3;
							num5 = 162;
						}
						while (num9 <= num5);
						if ((msfRelParms.Rows > 2) & (Operators.CompareString(msfRelParms[1, 0], "", false) == 0))
						{
							msfRelParms.RemoveItem(1);
						}
						msfRelEst.Rows = 2;
						FormatRelOutputs();
						recordset = null;
						command = null;
						goto end_IL_0001;
					}
					case 3195:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "LoadRelModelParms";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							((Control)this).Name = Eobject;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 3195;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void PrimeGrids()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		short num3 = default(short);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						object obj = new object[3] { "rm", "prod", "rm" };
						object obj2 = new object[3] { "rm", "prod", "material" };
						_msfCont_0[0, 1] = "Source/ Activity Name";
						_msfCont_0[0, 2] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"fc: fraction of ", NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (object)" shipped in this container type (default: 1/(# of CR activities for "), NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (object)")"));
						_msfCont_0[0, 3] = "Vc: container volume (gal)";
						_msfCont_0[0, 4] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Di: density of ", NewLateBinding.LateIndexGet(obj2, new object[1] { num3 }, (string[])null)), (object)" (kg/L) (liquid defaults: D"), NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (object)")"));
						_msfCont_0[0, 5] = "MCi: mass of material in a container (kg/container)";
						_msfCont_0[0, 6] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Yi: weight fraction of chemical in ", NewLateBinding.LateIndexGet(obj2, new object[1] { num3 }, (string[])null)), (object)" (default: Y"), NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (object)")"));
						_msfCont_0[0] = 1;
						_msfCont_0[1] = 3400;
						_msfCont_0[2] = 1200;
						_msfCont_0[3] = 1100;
						_msfCont_0[4] = 1100;
						_msfCont_0[5] = 1200;
						_msfCont_0[6] = 1200;
						_msfCont_0[0] = 1500;
						_msfCont_0.Row = 0;
						short num4 = (short)(_msfCont_0.Cols - 1);
						short num5 = 1;
						short num7;
						while (true)
						{
							short num6 = num5;
							num7 = num4;
							if (num6 > num7)
							{
								break;
							}
							_msfCont_0.Col = num5;
							_msfCont_0.WordWrap = true;
							_msfCont_0.CellAlignment = 5;
							num5 = (short)unchecked(num5 + 1);
						}
						_msfCont_1[0, 1] = "Source/ Activity Name";
						_msfCont_1[0, 2] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"fc: fraction of ", NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (object)" shipped in this container type (default: 1/(# of CR activities for "), NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (object)")"));
						_msfCont_1[0, 3] = "Vc: container volume (gal)";
						_msfCont_1[0, 4] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Di: density of ", NewLateBinding.LateIndexGet(obj2, new object[1] { num3 }, (string[])null)), (object)" (kg/L) (liquid defaults: D"), NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (object)")"));
						_msfCont_1[0, 5] = "MCi: mass of material in a container (kg/container)";
						_msfCont_1[0, 6] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Yi: weight fraction of chemical in ", NewLateBinding.LateIndexGet(obj2, new object[1] { num3 }, (string[])null)), (object)" (default: Y"), NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (object)")"));
						_msfCont_1[0] = 1;
						_msfCont_1[1] = 3400;
						_msfCont_1[2] = 1200;
						_msfCont_1[3] = 1100;
						_msfCont_1[4] = 1100;
						_msfCont_1[5] = 1200;
						_msfCont_1[6] = 1200;
						_msfCont_1[0] = 1500;
						_msfCont_1.Row = 0;
						short num8 = (short)(_msfCont_1.Cols - 1);
						num5 = 1;
						while (true)
						{
							short num9 = num5;
							num7 = num8;
							if (num9 > num7)
							{
								break;
							}
							_msfCont_1.Col = num5;
							_msfCont_1.WordWrap = true;
							_msfCont_1.CellAlignment = 5;
							num5 = (short)unchecked(num5 + 1);
						}
						_msfCont_2[0, 1] = "Source/ Activity Name";
						_msfCont_2[0, 2] = "fc: fraction of material shipped in this container type (default: 1/(# of CR activities for other materials)";
						_msfCont_2[0, 3] = "Vc: container volume (gal)";
						_msfCont_2[0, 4] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Di: density of ", NewLateBinding.LateIndexGet(obj2, new object[1] { num3 }, (string[])null)), (object)" (kg/L) (liquid defaults: D"), NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (object)")"));
						_msfCont_2[0, 5] = "MCi: mass of material in a container (kg/container)";
						_msfCont_2[0, 6] = Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"Yi: weight fraction of chemical in ", NewLateBinding.LateIndexGet(obj2, new object[1] { num3 }, (string[])null)), (object)" (default: Y"), NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null)), (object)")"));
						_msfCont_2[0] = 1;
						_msfCont_2[1] = 3400;
						_msfCont_2[2] = 1200;
						_msfCont_2[3] = 1100;
						_msfCont_2[4] = 1100;
						_msfCont_2[5] = 1200;
						_msfCont_2[6] = 1200;
						_msfCont_2[0] = 1500;
						_msfCont_2.Row = 0;
						short num10 = (short)(_msfCont_2.Cols - 1);
						num5 = 1;
						while (true)
						{
							short num11 = num5;
							num7 = num10;
							if (num11 > num7)
							{
								break;
							}
							_msfCont_2.Col = num5;
							_msfCont_2.WordWrap = true;
							_msfCont_2.CellAlignment = 5;
							num5 = (short)unchecked(num5 + 1);
						}
						_msfCont_3[0, 1] = "Source/ Activity Name";
						_msfCont_3[0, 2] = "Ncy (container / site-year)";
						_msfCont_3[0, 3] = "ODa (days/yr)";
						_msfCont_3[0, 4] = "Ncd (containers / site-day)";
						_msfCont_3[0, 5] = "r (containers / hour)";
						_msfCont_3[0, 6] = "OHa (hours / day)";
						_msfCont_3[0] = 1;
						_msfCont_3[1] = 3200;
						_msfCont_3[2] = 1200;
						_msfCont_3[3] = 1200;
						_msfCont_3[4] = 1200;
						_msfCont_3[5] = 1200;
						_msfCont_3[6] = 1200;
						_msfCont_3[0] = 900;
						_msfCont_3.Row = 0;
						short num12 = (short)(_msfCont_3.Cols - 1);
						num5 = 1;
						while (true)
						{
							short num13 = num5;
							num7 = num12;
							if (num13 > num7)
							{
								break;
							}
							_msfCont_3.Col = num5;
							_msfCont_3.WordWrap = true;
							_msfCont_3.CellAlignment = 5;
							num5 = (short)unchecked(num5 + 1);
						}
						msfContacts[0, 0] = "CBI";
						msfContacts[0, 1] = "Call Date";
						msfContacts[0, 2] = "Call Time";
						msfContacts[0, 3] = "Call To";
						msfContacts[0, 4] = "Affiliation";
						msfContacts[0, 5] = "Phone";
						msfContacts[0, 6] = "Called By";
						msfContacts[0, 7] = "Affiliation";
						msfContacts[0] = 400;
						msfContacts[1] = 750;
						msfContacts[2] = 750;
						msfContacts[3] = 1400;
						msfContacts[4] = 1300;
						msfContacts[5] = 1300;
						msfContacts[6] = 1400;
						msfContacts[7] = 1300;
						msfContacts[8] = 0;
						msfContacts[9] = 0;
						msfSubOps[0, 0] = "Subsequent Operation";
						msfSubOps[0, 1] = "Percent of PV";
						msfSubOps[0, 2] = "PVop (kg/yr)";
						msfSubOps[0] = 5000;
						msfSubOps[1] = 2000;
						msfSubOps[2] = 1000;
						msfNaics[0, 0] = "NAICS";
						msfNaics[0, 1] = "Description";
						msfNaics[0] = 1000;
						msfNaics[1] = 7000;
						msfOpIP[0, 0] = "Parameter";
						msfOpIP[0, 1] = "Type";
						msfOpIP[0, 2] = "Value";
						msfOpIP[0] = 5000;
						msfOpIP[1] = 1500;
						msfOpIP[2] = 1500;
						object obj3 = new object[6] { "Facility Name", "Address", "City", "State", "Zip", "County" };
						object obj4 = new object[6] { 2300, 2300, 1700, 500, 1000, 2000 };
						num3 = 0;
						short num14;
						do
						{
							unchecked
							{
								msfSites[(int)num3] = 0;
								msfSites[0, (int)num3] = Conversions.ToString(NewLateBinding.LateIndexGet(obj3, new object[1] { num3 }, (string[])null));
								msfSites[(int)num3] = Conversions.ToInteger(NewLateBinding.LateIndexGet(obj4, new object[1] { num3 }, (string[])null));
							}
							num3 = (short)unchecked(num3 + 1);
							num14 = num3;
							num7 = 5;
						}
						while (num14 <= num7);
						msfRelParms[0, 1] = "Parameter";
						msfRelParms[0, 10] = "Units";
						SetMsfRelParmsDefaultCaptions();
						msfRelParms.Row = 0;
						short num15 = (short)(msfRelParms.Cols - 1);
						num3 = 0;
						while (true)
						{
							short num16 = num3;
							num7 = num15;
							if (num16 > num7)
							{
								break;
							}
							msfRelParms.Col = num3;
							msfRelParms.CellAlignment = 4;
							num3 = (short)unchecked(num3 + 1);
						}
						msfRelParms.WordWrap = true;
						msfRelParms[0] = 1;
						msfRelParms[1] = 2500;
						msfRelParms[10] = 1000;
						msfRelParms[5] = 1;
						msfRelParms[9] = 1;
						msfRelParms[0] = 800;
						obj3 = new object[8] { "", "Media", "Characterization of Results", "Number of Sites", "Days of Release\r(days/site-yr)", "Daily Release Rate\r(kg/site-day)", "Annual Release Rate\r(kg/yr-all sites)", "Basis" };
						obj4 = new object[8] { 0, 1500, 2800, 1000, 1400, 1700, 1700, 1100 };
						msfRelEst.Row = 0;
						short num17 = (short)(msfRelEst.Cols - 1);
						num3 = 0;
						while (true)
						{
							short num18 = num3;
							num7 = num17;
							if (num18 > num7)
							{
								break;
							}
							unchecked
							{
								msfRelEst[0, (int)num3] = Conversions.ToString(NewLateBinding.LateIndexGet(obj3, new object[1] { num3 }, (string[])null));
								msfRelEst[(int)num3] = Conversions.ToInteger(NewLateBinding.LateIndexGet(obj4, new object[1] { num3 }, (string[])null));
								msfRelEst[(int)num3] = 0;
								msfRelEst.Col = num3;
								msfRelEst.CellAlignment = 4;
							}
							num3 = (short)unchecked(num3 + 1);
						}
						msfRelEst[0] = 480;
						msfRelEst.WordWrap = true;
						_msfExpParms_0[0, 1] = "Parameter";
						_msfExpParms_0[0, 10] = "Units";
						_msfExpParms_0[0] = 1;
						_msfExpParms_0[1] = 2500;
						_msfExpParms_0[10] = 1000;
						_msfExpParms_0[5] = 1;
						_msfExpParms_0[9] = 1;
						SetMsfExpParmsDefaultCaptions_0();
						_msfExpParms_0.Row = 0;
						short num19 = (short)(_msfExpParms_0.Cols - 1);
						num5 = 0;
						while (true)
						{
							short num20 = num5;
							num7 = num19;
							if (num20 > num7)
							{
								break;
							}
							_msfExpParms_0.Col = num5;
							_msfExpParms_0.CellAlignment = 4;
							num5 = (short)unchecked(num5 + 1);
						}
						_msfExpParms_0.WordWrap = true;
						_msfExpParms_0[0] = 800;
						_msfExpParms_1[0, 1] = "Parameter";
						_msfExpParms_1[0, 10] = "Units";
						_msfExpParms_1[0] = 1;
						_msfExpParms_1[1] = 2500;
						_msfExpParms_1[10] = 1000;
						_msfExpParms_1[5] = 1;
						_msfExpParms_1[9] = 1;
						SetMsfExpParmsDefaultCaptions_1();
						_msfExpParms_1.Row = 0;
						short num21 = (short)(_msfExpParms_1.Cols - 1);
						num5 = 0;
						while (true)
						{
							short num22 = num5;
							num7 = num21;
							if (num22 > num7)
							{
								break;
							}
							_msfExpParms_1.Col = num5;
							_msfExpParms_1.CellAlignment = 4;
							num5 = (short)unchecked(num5 + 1);
						}
						_msfExpParms_1.WordWrap = true;
						_msfExpParms_1[0] = 800;
						msfSelActs[0, 1] = "Activity";
						msfSelActs[0, 2] = "Release";
						msfSelActs[0, 3] = "Exposure";
						msfSelActs[0, 4] = "Release DMP";
						msfSelActs[0, 5] = "Exposure DMP";
						msfSelActs[0, 6] = "Order";
						msfSelActs[0] = 0;
						msfSelActs[1] = 4500;
						msfSelActs[2] = 750;
						msfSelActs[3] = 750;
						msfSelActs[4] = 1750;
						msfSelActs[5] = 1750;
						msfSelActs[6] = 750;
						obj3 = new object[9] { "Route of Exposure", "Characterization of Results", "Total Number of Workers", "Exposure Days per Year", "Potential Dose Rate (mg/day)", "Lifetime Average Daily Dose (mg/kg-day)", "Average Daily Dose (mg/kg-day)", "Acute Potential Dose (mg/kg-day)", "Basis" };
						obj4 = new object[9] { 900, 2800, 800, 800, 975, 975, 975, 975, 2000 };
						msfExpEst.Row = 0;
						short num23 = (short)(msfExpEst.Cols - 1);
						num3 = 0;
						while (true)
						{
							short num24 = num3;
							num7 = num23;
							if (num24 > num7)
							{
								break;
							}
							unchecked
							{
								msfExpEst[0, (int)num3] = Conversions.ToString(NewLateBinding.LateIndexGet(obj3, new object[1] { num3 }, (string[])null));
								msfExpEst[(int)num3] = Conversions.ToInteger(NewLateBinding.LateIndexGet(obj4, new object[1] { num3 }, (string[])null));
								msfExpEst.Col = num3;
								msfExpEst.CellAlignment = 4;
							}
							num3 = (short)unchecked(num3 + 1);
						}
						msfExpEst[0] = 1000;
						msfExpEst.WordWrap = true;
						msfTlv[0, 0] = "Material";
						msfTlv[0, 1] = "Concentration";
						msfTlv[0, 2] = "Exposure Limit";
						msfTlv[0, 3] = "Exposure Limit Type";
						msfTlv[0, 4] = "Reference";
						msfTlv[0, 5] = "Type of Material";
						msfTlv[0] = 3000;
						msfTlv[1] = 1500;
						msfTlv[2] = 1500;
						msfTlv[3] = 1000;
						msfTlv[4] = 1000;
						msfTlv[5] = 1000;
						num3 = 0;
						short num25;
						do
						{
							msfTlv[unchecked((int)num3)] = 1;
							num3 = (short)unchecked(num3 + 1);
							num25 = num3;
							num7 = 5;
						}
						while (num25 <= num7);
						msfSP[0, 1] = "Group";
						msfSP[0, 2] = "Parameter/Factor";
						msfSP[0, 3] = "Type";
						msfSP[0, 4] = "Value";
						msfSP[0, 5] = "Units";
						msfSP[0] = 0;
						msfSP[1] = 1950;
						msfSP[2] = 4300;
						msfSP[3] = 1250;
						msfSP[4] = 1050;
						msfSP[5] = 1100;
						msfSP[4] = 0;
						goto end_IL_0001;
					}
					case 5574:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							((Control)this).Name = Eobject;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj5) when (obj5 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj5);
				try0001_dispatch = 5574;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void lstRelModels_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		LoadRelModelParms();
	}

	private void lstSelOps0_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		Cursor.Current = Cursors.WaitCursor;
		if (_lstSelOps_0.SelectedIndex != -1)
		{
			Globals_Renamed.intOpIndex = checked((short)Support.GetItemData((Control)(object)_lstSelOps_0, _lstSelOps_0.SelectedIndex));
			LoadMsfSubOps();
			LoadMsfSelActs();
			LoadOpInfo();
			SetPvOpLabels();
			if (!_0024STATIC_0024lstSelOps0_SelectedIndexChanged_002420211C1271_0024PreventRecursion)
			{
				_0024STATIC_0024lstSelOps0_SelectedIndexChanged_002420211C1271_0024PreventRecursion = true;
				_lstSelOps_1.SelectedIndex = _lstSelOps_0.SelectedIndex;
				_0024STATIC_0024lstSelOps0_SelectedIndexChanged_002420211C1271_0024PreventRecursion = false;
				Cursor.Current = Cursors.Default;
			}
		}
	}

	private void lstSelOps1_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		Cursor.Current = Cursors.WaitCursor;
		if (_lstSelOps_1.SelectedIndex != -1)
		{
			Globals_Renamed.intOpIndex = checked((short)Support.GetItemData((Control)(object)_lstSelOps_1, _lstSelOps_1.SelectedIndex));
			LoadMsfOpIP();
			LoadMsfOpSP();
			PrimeContainerSubTab();
			if (!_0024STATIC_0024lstSelOps1_SelectedIndexChanged_002420211C1271_0024PreventRecursion)
			{
				_0024STATIC_0024lstSelOps1_SelectedIndexChanged_002420211C1271_0024PreventRecursion = true;
				_lstSelOps_0.SelectedIndex = _lstSelOps_1.SelectedIndex;
				_0024STATIC_0024lstSelOps1_SelectedIndexChanged_002420211C1271_0024PreventRecursion = false;
				Cursor.Current = Cursors.Default;
			}
		}
	}

	private void lstSelOps_DoubleClick(object eventSender, EventArgs eventArgs)
	{
		cmdUpdOps_Click(cmdUpdOps, new EventArgs());
	}

	public void cmbExpActs_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					ProjectData.ClearProjectError();
					num2 = 2;
					if (cmbExpActs.SelectedIndex == -1)
					{
						goto end_IL_0001;
					}
					checked
					{
						Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbExpOps.SelectedIndex);
						Globals_Renamed.intActIndex = (short)Support.GetItemData((Control)(object)cmbExpActs, cmbExpActs.SelectedIndex);
						AxMSFlexGrid pmsfGrid = msfExpEst;
						ChemStrX.MyMSfClear(ref pmsfGrid);
						msfExpEst = pmsfGrid;
						SetMsfExpParmsDefaultCaptions_0();
						SetMsfExpParmsDefaultCaptions_1();
						txtExpModelMsg[(short)0].Text = "";
						txtExpModelMsg[(short)1].Text = "";
						short pModel = 0;
						LoadExpParms(ref pModel);
						pModel = 1;
						LoadExpParms(ref pModel);
					}
					if (Globals_Renamed.arExpModels[0, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] == 0)
					{
						lblDExpModel.Text = "None Specified";
					}
					else
					{
						recordset.Open("SELECT * FROM qryListOfDExpModels", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						recordset.Find("ModelID=" + Conversions.ToString((int)Globals_Renamed.arExpModType[checked(Globals_Renamed.arExpModels[0, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1)]), 0, SearchDirectionEnum.adSearchForward, Missing.Value);
						if (!recordset.EOF)
						{
							lblDExpModel.Text = Conversions.ToString(recordset.Fields[1].Value);
						}
						else
						{
							lblDExpModel.Text = "Model not found, please contact technical support";
						}
						recordset.Close();
					}
					if (Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] == 0)
					{
						lblIExpModel.Text = "None Specified";
					}
					else
					{
						recordset.Open("SELECT * FROM qryListOfIExpModels", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						recordset.Find("ModelID=" + Conversions.ToString((int)Globals_Renamed.arExpModType[checked(Globals_Renamed.arExpModels[1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1)]), 0, SearchDirectionEnum.adSearchForward, Missing.Value);
						if (!recordset.EOF)
						{
							lblIExpModel.Text = Conversions.ToString(recordset.Fields[1].Value);
						}
						else
						{
							lblIExpModel.Text = "Model not found, please contact technical support";
						}
						recordset.Close();
					}
					recordset = null;
					goto end_IL_0001;
				}
				case 772:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "cmbExpActs_Click";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 772;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cmbExpOps_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_01c4: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Expected O, but got Unknown
		cmbExpActs.Items.Clear();
		lblDExpModel.Text = "None Specified";
		lblIExpModel.Text = "None Specified";
		lblChemStateExp[(short)0].Text = "";
		lblChemStateExp[(short)1].Text = "";
		AxMSFlexGrid pmsfGrid = _msfExpParms_0;
		ChemStrX.MyMSfClear(ref pmsfGrid);
		_msfExpParms_0 = pmsfGrid;
		pmsfGrid = _msfExpParms_1;
		ChemStrX.MyMSfClear(ref pmsfGrid);
		_msfExpParms_1 = pmsfGrid;
		pmsfGrid = msfExpEst;
		ChemStrX.MyMSfClear(ref pmsfGrid);
		msfExpEst = pmsfGrid;
		txtExpModelMsg[(short)0].Text = "";
		txtExpModelMsg[(short)1].Text = "";
		SetMsfExpParmsDefaultCaptions_0();
		SetMsfExpParmsDefaultCaptions_1();
		clearInhClassFields();
		if (cmbExpOps.SelectedIndex == -1)
		{
			return;
		}
		checked
		{
			Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbExpOps.SelectedIndex);
			FormatExpOutputs();
			short pActIndex = 0;
			short num;
			short num2;
			do
			{
				if (Globals_Renamed.arSelActEa[pActIndex, Globals_Renamed.intOpIndex])
				{
					if (!Globals_Renamed.gblDoEasyModels && Globals_Renamed.arSelActEaDMP[pActIndex, Globals_Renamed.intOpIndex] == 0)
					{
						Globals_Renamed.arSelActEaDMP[pActIndex, Globals_Renamed.intOpIndex] = ChemStrX.AddEModels(ref pActIndex);
						LoadMsfSelActs();
					}
					cmbExpActs.Items.Add((object)unchecked(new ListBoxItem("(" + Conversions.ToString((int)Globals_Renamed.arActOrder[pActIndex, Globals_Renamed.intOpIndex]) + ") " + Globals_Renamed.arSelActs[pActIndex, Globals_Renamed.intOpIndex], (int)pActIndex)));
				}
				pActIndex = (short)unchecked(pActIndex + 1);
				num = pActIndex;
				num2 = 25;
			}
			while (num <= num2);
			if (cmbExpActs.Items.Count == 0)
			{
				((Control)cmbExpActs).Visible = false;
				((Control)Label1[(short)74]).Visible = true;
			}
			else
			{
				((Control)cmbExpActs).Visible = true;
				((Control)Label1[(short)74]).Visible = false;
				cmbExpActs.SelectedIndex = 0;
			}
		}
	}

	public void cmbRelActs_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_01da: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e4: Expected O, but got Unknown
		//IL_0190: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						ProjectData.ClearProjectError();
						num2 = 2;
						if (cmbRelActs.SelectedIndex == -1)
						{
							goto end_IL_0001;
						}
						Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbRelOps.SelectedIndex);
						Globals_Renamed.intActIndex = (short)Support.GetItemData((Control)(object)cmbRelActs, cmbRelActs.SelectedIndex);
						lstRelModels.Items.Clear();
						AxMSFlexGrid pmsfGrid = msfRelParms;
						ChemStrX.MyMSfClear(ref pmsfGrid);
						msfRelParms = pmsfGrid;
						pmsfGrid = msfRelEst;
						ChemStrX.MyMSfClear(ref pmsfGrid);
						msfRelEst = pmsfGrid;
						txtRelModelMsg.Text = "";
						SetMsfRelParmsDefaultCaptions();
						recordset.Open("SELECT * FROM qryListOfRelModels", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						short num3 = 0;
						short num4;
						short num5;
						do
						{
							if ((Globals_Renamed.arRelModels[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0) & (Globals_Renamed.arRelModels[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1 <= Information.UBound((Array)Globals_Renamed.arRelModType, 1)))
							{
								recordset.MoveFirst();
								unchecked
								{
									recordset.Find("ModelID=" + Conversions.ToString((int)Globals_Renamed.arRelModType[checked(Globals_Renamed.arRelModels[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1)]), 0, SearchDirectionEnum.adSearchForward, Missing.Value);
									if (recordset.EOF)
									{
										Interaction.MsgBox((object)"Error in model arrays.  Please contact technical support.  Please save this assessment and give to technical support.  You can continue to use this assessment, but you must verify all release models are correct.  Some default models may have been accidently deleted.", (MsgBoxStyle)64, (object)"Critical System Error");
									}
									else
									{
										lstRelModels.Items.Add((object)new ListBoxItem(Conversions.ToString(recordset.Fields[1].Value), Conversions.ToInteger(recordset.Fields[0].Value)));
									}
								}
							}
							num3 = (short)unchecked(num3 + 1);
							num4 = num3;
							num5 = 9;
						}
						while (num4 <= num5);
						recordset.Close();
						recordset = null;
						if (lstRelModels.Items.Count > 0)
						{
							lstRelModels.SelectedIndex = 0;
						}
						goto end_IL_0001;
					}
					case 658:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "cmbRelActs_Click";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							((Control)this).Name = Eobject;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 658;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cmbrelops_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		//IL_0142: Unknown result type (might be due to invalid IL or missing references)
		//IL_014c: Expected O, but got Unknown
		cmbRelActs.Items.Clear();
		lstRelModels.Items.Clear();
		SetMsfRelParmsDefaultCaptions();
		AxMSFlexGrid pmsfGrid = msfRelParms;
		ChemStrX.MyMSfClear(ref pmsfGrid);
		msfRelParms = pmsfGrid;
		pmsfGrid = msfRelEst;
		ChemStrX.MyMSfClear(ref pmsfGrid);
		msfRelEst = pmsfGrid;
		txtRelModelMsg.Text = "";
		if (cmbRelOps.SelectedIndex == -1)
		{
			return;
		}
		checked
		{
			Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbRelOps.SelectedIndex);
			short pActIndex = 0;
			short num;
			short num2;
			do
			{
				if (Globals_Renamed.arSelActRa[pActIndex, Globals_Renamed.intOpIndex])
				{
					if (!Globals_Renamed.gblDoEasyModels && Globals_Renamed.arSelActRaDMP[pActIndex, Globals_Renamed.intOpIndex] == 0)
					{
						Globals_Renamed.intActIndex = pActIndex;
						Globals_Renamed.arSelActRaDMP[pActIndex, Globals_Renamed.intOpIndex] = ChemStrX.AddRModels(ref pActIndex);
						LoadMsfSelActs();
					}
					cmbRelActs.Items.Add((object)unchecked(new ListBoxItem("(" + Conversions.ToString((int)Globals_Renamed.arActOrder[pActIndex, Globals_Renamed.intOpIndex]) + ") " + Globals_Renamed.arSelActs[pActIndex, Globals_Renamed.intOpIndex], (int)pActIndex)));
				}
				pActIndex = (short)unchecked(pActIndex + 1);
				num = pActIndex;
				num2 = 24;
			}
			while (num <= num2);
			if (cmbRelActs.Items.Count == 0)
			{
				((Control)cmbRelActs).Visible = false;
				((Control)Label1[(short)71]).Visible = true;
			}
			else
			{
				((Control)cmbRelActs).Visible = true;
				((Control)Label1[(short)71]).Visible = false;
				cmbRelActs.SelectedIndex = 0;
			}
		}
	}

	private void cmbOptInfo_SelectedIndexChanged(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			short num = (short)(((BaseControlArray)fraOpInfo).Count() - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				((Control)fraOpInfo[num2]).Visible = false;
				num2 = (short)unchecked(num2 + 1);
			}
			((Control)fraOpInfo[(short)cmbOptInfo.SelectedIndex]).Visible = true;
			if (Operators.CompareString(cmbOptInfo.Text, "MSDS / Label / Exposure Limits", false) == 0)
			{
				Tabs tabs = tabSubOI.Tabs;
				object obj = 1;
				((ITab)((ITabs)tabs)[ref obj]).Selected = true;
			}
		}
	}

	private void cmdAddExpModel_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		if (cmbExpActs.SelectedIndex == -1)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please select an exposure activity", (MsgBoxStyle)64, (object)"Invalid Request");
			return;
		}
		Cursor.Current = Cursors.WaitCursor;
		checked
		{
			Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbExpOps.SelectedIndex);
			Globals_Renamed.intActIndex = (short)Support.GetItemData((Control)(object)cmbExpActs, cmbExpActs.SelectedIndex);
			if (frmMDAddExpModel.DefInstance.SetUp())
			{
				Cursor.Current = Cursors.Default;
				((Form)frmMDAddExpModel.DefInstance).ShowDialog();
				ChemStrX.DeriveNWdefault();
				ChemStrX.setDefaultExpFlags();
			}
			else
			{
				((Form)frmMDAddExpModel.DefInstance).Close();
				Cursor.Current = Cursors.Default;
			}
		}
	}

	private void cmdAddRelModel_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_007a: Unknown result type (might be due to invalid IL or missing references)
		if (cmbRelActs.SelectedIndex == -1)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please select a release activity.", (MsgBoxStyle)64, (object)"Invalid Request");
			return;
		}
		checked
		{
			Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbRelOps.SelectedIndex);
			Globals_Renamed.intActIndex = (short)Support.GetItemData((Control)(object)cmbRelActs, cmbRelActs.SelectedIndex);
			if (frmMDAddRelModel.DefInstance.SetUp())
			{
				((Form)frmMDAddRelModel.DefInstance).ShowDialog();
			}
		}
	}

	private void cmdChemRegLimits_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"This functionality will be implemented in a later version of ChemSTEER", (MsgBoxStyle)1, (object)"ChemSTEER v3.2");
	}

	private void cmdComments_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		frmMDUpdNotepad defInstance = frmMDUpdNotepad.DefInstance;
		short pType = 1;
		if (defInstance.SetUp(ref pType))
		{
			((Form)frmMDUpdNotepad.DefInstance).ShowDialog();
		}
		else
		{
			((Form)frmMDUpdNotepad.DefInstance).Close();
		}
	}

	private void cmdContRpt_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Form)frmMDUpdContRpts.DefInstance).ShowDialog();
	}

	private void cmdCopyOpSiteInfo_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_001b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0067: Unknown result type (might be due to invalid IL or missing references)
		//IL_009f: Unknown result type (might be due to invalid IL or missing references)
		//IL_00a5: Invalid comparison between Unknown and I4
		if (Globals_Renamed.intNumOps < 2)
		{
			Interaction.MsgBox((object)"You must first specify at least two operations.", (MsgBoxStyle)64, (object)"Invalid Request");
			return;
		}
		Globals_Renamed.intOpIndex = checked((short)Support.GetItemData((Control)(object)_lstSelOps_0, _lstSelOps_0.SelectedIndex));
		if (Globals_Renamed.arNoPre[Globals_Renamed.intOpIndex])
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"This operation does not have any preceding operations.", (MsgBoxStyle)64, (object)"Invalid Request");
			return;
		}
		short num = -1;
		if (Strings.Len(Globals_Renamed.arOSName[0, Globals_Renamed.intOpIndex]) > 0 && (int)Interaction.MsgBox((object)"Copying site information from the previous operation will overlay the site information you already have specified for this operation. Are you sure you want to perform this copy?", (MsgBoxStyle)36, (object)"Confirmation") == 7)
		{
			num = 0;
		}
		checked
		{
			if (num == -1)
			{
				short pOpID = (short)(Globals_Renamed.intOpIndex + 1);
				object pArSubOpID = Globals_Renamed.arSubOpID;
				short myPred = ChemStrX.GetMyPred(ref Globals_Renamed.intNumOps, ref pOpID, ref pArSubOpID);
				Globals_Renamed.arSubOpID = (short[,])pArSubOpID;
				short num2 = myPred;
				num = 0;
				short num3;
				short num4;
				do
				{
					Globals_Renamed.arOSName[num, Globals_Renamed.intOpIndex] = Globals_Renamed.arOSName[num, num2];
					Globals_Renamed.arOSAddr[num, Globals_Renamed.intOpIndex] = Globals_Renamed.arOSAddr[num, num2];
					Globals_Renamed.arOSCity[num, Globals_Renamed.intOpIndex] = Globals_Renamed.arOSCity[num, num2];
					Globals_Renamed.arOSState[num, Globals_Renamed.intOpIndex] = Globals_Renamed.arOSState[num, num2];
					Globals_Renamed.arOSZip[num, Globals_Renamed.intOpIndex] = Globals_Renamed.arOSZip[num, num2];
					Globals_Renamed.arOSCty[num, Globals_Renamed.intOpIndex] = Globals_Renamed.arOSCty[num, num2];
					num = (short)unchecked(num + 1);
					num3 = num;
					num4 = 99;
				}
				while (num3 <= num4);
				LoadSiteInfo();
				Globals_Renamed.gblIWasChanged = true;
			}
		}
	}

	private void cmdExpComb_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"This functionality will be implemented in a later version of ChemSTEER", (MsgBoxStyle)1, (object)"ChemSTEER v3.2");
	}

	private void cmdInhBasis_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0050: Unknown result type (might be due to invalid IL or missing references)
		if (cmbExpOps.SelectedIndex == -1)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please select an operation.", (MsgBoxStyle)64, (object)null);
			((Control)cmbExpOps).Focus();
		}
		else if (frmWaterAndInhBasis.DefInstance.SetUp(ref MyCurrentExpTab))
		{
			((Form)frmWaterAndInhBasis.DefInstance).ShowDialog();
		}
		else
		{
			((Form)frmWaterAndInhBasis.DefInstance).Close();
		}
	}

	private void cmdRelAddNotes_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if (cmbRelOps.SelectedIndex == -1)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please select an operation.", (MsgBoxStyle)64, (object)null);
			((Control)cmbRelOps).Focus();
			return;
		}
		frmMDUpdNotepad defInstance = frmMDUpdNotepad.DefInstance;
		short pType = 2;
		if (defInstance.SetUp(ref pType))
		{
			((Form)frmMDUpdNotepad.DefInstance).ShowDialog();
		}
		else
		{
			((Form)frmMDUpdNotepad.DefInstance).Close();
		}
	}

	private void cmdRelBasis_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_004e: Unknown result type (might be due to invalid IL or missing references)
		if (cmbRelOps.SelectedIndex == -1)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please select an operation.", (MsgBoxStyle)64, (object)null);
			((Control)cmbRelOps).Focus();
			return;
		}
		frmWaterAndInhBasis defInstance = frmWaterAndInhBasis.DefInstance;
		short pType = 0;
		if (defInstance.SetUp(ref pType))
		{
			((Form)frmWaterAndInhBasis.DefInstance).ShowDialog();
		}
		else
		{
			((Form)frmWaterAndInhBasis.DefInstance).Close();
		}
	}

	private void cmdRelComb_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_000c: Unknown result type (might be due to invalid IL or missing references)
		Interaction.MsgBox((object)"This functionality will be implemented in a later version of ChemSTEER", (MsgBoxStyle)1, (object)"ChemSTEER v3.2");
	}

	private void cmdRunExpModel_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_0083: Unknown result type (might be due to invalid IL or missing references)
		//IL_01b1: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ce: Unknown result type (might be due to invalid IL or missing references)
		//IL_01ec: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num3 = default(int);
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				short pModel;
				object pOpIndex;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0009;
				case 790:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 2:
						case 3:
							break;
						case 1:
							goto IL_0264;
						default:
							goto end_IL_0001;
						}
						break;
					}
					IL_01d7:
					num = 35;
					goto IL_01dc;
					IL_01dc:
					num = 36;
					Interaction.MsgBox((object)"An error was encountered while running the Release Models. Please correct the error and rerun your models.", (MsgBoxStyle)48, (object)"Release Model Error");
					goto end_IL_0001_2;
					IL_01be:
					num = 32;
					Interaction.MsgBox((object)"An error was encountered while running the Exposure Models. Please correct the error and rerun your models.", (MsgBoxStyle)48, (object)"Exposure Model Error");
					goto end_IL_0001_2;
					IL_0264:
					num4 = num2 + 1;
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0009;
					case 3:
						goto IL_0020;
					case 4:
						goto IL_0029;
					case 5:
						goto IL_003a;
					case 7:
					case 8:
						goto IL_0050;
					case 9:
						goto IL_006d;
					case 10:
						goto IL_0077;
					case 11:
						goto IL_0089;
					case 13:
					case 14:
						goto IL_00a0;
					case 15:
						goto IL_00aa;
					case 16:
						goto IL_00ca;
					case 17:
						goto IL_00dc;
					case 18:
						goto IL_00eb;
					case 19:
						goto IL_00fa;
					case 20:
						goto IL_010c;
					case 21:
						goto IL_0115;
					case 22:
						goto IL_012b;
					case 23:
						goto IL_0133;
					case 24:
						goto IL_0142;
					case 25:
						goto IL_0151;
					case 26:
						goto IL_015b;
					case 27:
						goto IL_0165;
					case 28:
						goto IL_0187;
					case 29:
						goto IL_0192;
					case 31:
						goto IL_01b9;
					case 32:
						goto IL_01be;
					case 35:
						goto IL_01d7;
					case 36:
						goto IL_01dc;
					case 39:
						goto end_IL_0001_3;
					default:
						goto end_IL_0001;
					case 6:
					case 12:
					case 30:
					case 33:
					case 34:
					case 37:
					case 38:
					case 40:
						goto end_IL_0001_2;
					}
					goto default;
					IL_0009:
					num = 2;
					if (cmbExpOps.SelectedIndex == -1)
					{
						goto IL_0020;
					}
					goto IL_0050;
					IL_0020:
					num = 3;
					Interaction.Beep();
					goto IL_0029;
					IL_0029:
					num = 4;
					Interaction.MsgBox((object)"Please select an operation.", (MsgBoxStyle)64, (object)null);
					goto IL_003a;
					IL_003a:
					num = 5;
					((Control)cmbExpOps).Focus();
					goto end_IL_0001_2;
					IL_0050:
					num = 8;
					if (Globals_Renamed.arOpNeedsMassBalance[cmbExpOps.SelectedIndex] == 1)
					{
						goto IL_006d;
					}
					goto IL_00a0;
					IL_006d:
					num = 9;
					Interaction.Beep();
					goto IL_0077;
					IL_0077:
					num = 10;
					Interaction.MsgBox((object)"Please update Mass Balance Parameters (subtab 4a) for this operation before running models.", (MsgBoxStyle)64, (object)null);
					goto IL_0089;
					IL_0089:
					num = 11;
					((Control)cmbExpOps).Focus();
					goto end_IL_0001_2;
					IL_00a0:
					num = 14;
					Globals_Renamed.gblIWasChanged = true;
					goto IL_00aa;
					IL_00aa:
					num = 15;
					Globals_Renamed.intOpIndex = checked((short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbExpOps.SelectedIndex));
					goto IL_00ca;
					IL_00ca:
					num = 16;
					if (ChemStrX.RunRelModels())
					{
						goto IL_00dc;
					}
					goto IL_01d7;
					IL_00dc:
					num = 17;
					pModel = 0;
					LoadExpParms(ref pModel);
					goto IL_00eb;
					IL_00eb:
					num = 18;
					pModel = 1;
					LoadExpParms(ref pModel);
					goto IL_00fa;
					IL_00fa:
					num = 19;
					if (ChemStrX.RunExpModels())
					{
						goto IL_010c;
					}
					goto IL_01b9;
					IL_010c:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_0115;
					IL_0115:
					num = 21;
					lstRelModels_SelectedIndexChanged(lstRelModels, new EventArgs());
					goto IL_012b;
					IL_012b:
					ProjectData.ClearProjectError();
					num3 = 3;
					goto IL_0133;
					IL_0133:
					num = 23;
					pModel = 0;
					LoadExpParms(ref pModel);
					goto IL_0142;
					IL_0142:
					num = 24;
					pModel = 1;
					LoadExpParms(ref pModel);
					goto IL_0151;
					IL_0151:
					num = 25;
					ChemStrX.DeriveNWdefault();
					goto IL_015b;
					IL_015b:
					num = 26;
					ChemStrX.setDefaultExpFlags();
					goto IL_0165;
					IL_0165:
					num = 27;
					pOpIndex = Globals_Renamed.intOpIndex;
					ChemStrX.resetInhRespClass(ref pOpIndex);
					Globals_Renamed.intOpIndex = Conversions.ToShort(pOpIndex);
					goto IL_0187;
					IL_0187:
					num = 28;
					FormatExpOutputs();
					goto IL_0192;
					IL_0192:
					num = 29;
					Interaction.MsgBox((object)("Release and Exposure Models were run for " + cmbExpOps.Text), (MsgBoxStyle)1, (object)"ChemSTEER");
					goto end_IL_0001_2;
					IL_01b9:
					num = 31;
					goto IL_01be;
					end_IL_0001_3:
					break;
				}
				num = 39;
				string Eobject = ((Control)this).Name;
				string Efunction = "cmdRunExpModel_click";
				ErrObject val = Information.Err();
				int Enumber = val.Number;
				ErrObject val2 = Information.Err();
				string Edescription = val2.Description;
				bool Econtact = true;
				Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
				val2.Description = Edescription;
				val.Number = Enumber;
				((Control)this).Name = Eobject;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 790;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void cmdRunRelModel_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e7: Unknown result type (might be due to invalid IL or missing references)
		if (cmbRelOps.SelectedIndex == -1)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please select an operation.", (MsgBoxStyle)64, (object)null);
			((Control)cmbRelOps).Focus();
			return;
		}
		if (Globals_Renamed.arOpNeedsMassBalance[cmbRelOps.SelectedIndex] == 1)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please update Mass Balance Parameters (subtab 4a) for this operation before running models.", (MsgBoxStyle)64, (object)null);
			((Control)cmbRelOps).Focus();
			return;
		}
		Globals_Renamed.gblIWasChanged = true;
		Globals_Renamed.intOpIndex = checked((short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbRelOps.SelectedIndex));
		if (ChemStrX.RunRelModels())
		{
			lstRelModels_SelectedIndexChanged(lstRelModels, new EventArgs());
			short pModel = 0;
			LoadExpParms(ref pModel);
			pModel = 1;
			LoadExpParms(ref pModel);
			Interaction.MsgBox((object)("Release Models were run for " + cmbRelOps.Text), (MsgBoxStyle)1, (object)"ChemSTEER");
		}
		else
		{
			Interaction.MsgBox((object)"An error was encountered while running the Release Models. Please correct the error and rerun your models.", (MsgBoxStyle)48, (object)"Release Model Error");
		}
	}

	private void cmdUpdateExpNw_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_00ba: Unknown result type (might be due to invalid IL or missing references)
		if (cmbExpOps.SelectedIndex == -1)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please select an operation.", (MsgBoxStyle)64, (object)null);
			((Control)cmbExpOps).Focus();
			return;
		}
		if (cmbExpActs.Items.Count == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"This operation does not have any exposures.", (MsgBoxStyle)64, (object)null);
			return;
		}
		checked
		{
			Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbExpOps.SelectedIndex);
			Globals_Renamed.intActIndex = (short)Support.GetItemData((Control)(object)cmbExpActs, cmbExpActs.SelectedIndex);
			if (Conversions.ToBoolean(frmMDUpdNW.DefInstance.SetUp()))
			{
				((Form)frmMDUpdNW.DefInstance).ShowDialog();
			}
			else
			{
				((Form)frmMDUpdNW.DefInstance).Close();
			}
			ChemStrX.setDefaultExpFlags();
		}
	}

	private void cmdUpdChem_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Form)frmMDUpdChem.DefInstance).ShowDialog();
		if (Globals_Renamed.intNumOps > 0)
		{
			SetPvOpLabels();
			PrimeContainerSubTab();
			LoadMsfOpSP();
		}
	}

	private void cmdUpdGen_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Form)frmMDUpdGen.DefInstance).ShowDialog();
		cmbOptInfo.SelectedIndex = 0;
		((Form)frmMDUpdGen.DefInstance).Close();
	}

	private void cmdUpdOpDesc_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (Globals_Renamed.intNumOps > 0)
		{
			Globals_Renamed.intOpIndex = checked((short)Support.GetItemData((Control)(object)_lstSelOps_0, _lstSelOps_0.SelectedIndex));
			if (frmMDUpdPD.DefInstance.SetUp())
			{
				((Form)frmMDUpdPD.DefInstance).ShowDialog();
			}
			((Form)frmMDUpdPD.DefInstance).Close();
		}
		else
		{
			Interaction.MsgBox((object)"You must first specify at least one operation.", (MsgBoxStyle)64, (object)"Invalid Request");
		}
	}

	private void cmdUpdOpIP_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0021: Unknown result type (might be due to invalid IL or missing references)
		//IL_0073: Unknown result type (might be due to invalid IL or missing references)
		//IL_034d: Unknown result type (might be due to invalid IL or missing references)
		//IL_036c: Unknown result type (might be due to invalid IL or missing references)
		//IL_030a: Unknown result type (might be due to invalid IL or missing references)
		if (Globals_Renamed.intNumOps == 0)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"You must specify at least one operation before entering in Operation Parameters", (MsgBoxStyle)64, (object)"Invalid Request");
			return;
		}
		checked
		{
			Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, _lstSelOps_0.SelectedIndex);
			switch (MyCurrentIpTab)
			{
			case 1:
				((Form)frmMDUpdOpIP.DefInstance).ShowDialog();
				PrimeContainerSubTab();
				LoadMsfOpSP();
				break;
			case 2:
			{
				string text = default(string);
				switch (MyCurrentContSubTab)
				{
				case 1:
					text = _msfCont_0[_msfCont_0.Row, 0];
					break;
				case 2:
					text = _msfCont_1[_msfCont_1.Row, 0];
					break;
				case 3:
					text = _msfCont_2[_msfCont_2.Row, 0];
					break;
				case 4:
					text = _msfCont_3[_msfCont_3.Row, 0];
					break;
				}
				if (!Versioned.IsNumeric((object)text))
				{
					break;
				}
				short num9 = default(short);
				short num2;
				if (MyCurrentContSubTab == 4)
				{
					while (true)
					{
						short num = (short)(_msfCont_0.Rows - 1);
						num2 = 1;
						while (true)
						{
							short num3 = num2;
							short num4 = num;
							if (num3 > num4)
							{
								break;
							}
							if (unchecked(!Versioned.IsNumeric((object)_msfCont_0[(int)num2, 0]) || Operators.CompareString(_msfCont_0[(int)num2, 0], _msfCont_3[_msfCont_3.Row, 0], false) != 0))
							{
								num2 = (short)unchecked(num2 + 1);
								continue;
							}
							goto IL_019d;
						}
						short num5 = (short)(_msfCont_1.Rows - 1);
						num2 = 1;
						while (true)
						{
							short num6 = num2;
							short num4 = num5;
							if (num6 > num4)
							{
								break;
							}
							if (unchecked(!Versioned.IsNumeric((object)_msfCont_1[(int)num2, 0]) || Operators.CompareString(_msfCont_1[(int)num2, 0], _msfCont_3[_msfCont_3.Row, 0], false) != 0))
							{
								num2 = (short)unchecked(num2 + 1);
								continue;
							}
							goto IL_0220;
						}
						short num7 = (short)(_msfCont_2.Rows - 1);
						num2 = 1;
						while (true)
						{
							short num8 = num2;
							short num4 = num7;
							if (num8 <= num4)
							{
								if (unchecked(!Versioned.IsNumeric((object)_msfCont_2[(int)num2, 0]) || Operators.CompareString(_msfCont_2[(int)num2, 0], _msfCont_3[_msfCont_3.Row, 0], false) != 0))
								{
									num2 = (short)unchecked(num2 + 1);
									continue;
								}
								goto IL_02a3;
							}
							break;
						}
						continue;
						IL_0220:
						_msfCont_1.Row = num2;
						break;
						IL_019d:
						_msfCont_0.Row = num2;
						break;
						IL_02a3:
						_msfCont_2.Row = num2;
						break;
					}
					num9++;
					num2 = 2;
				}
				else
				{
					num9 = MyCurrentContSubTab;
					num2 = 1;
				}
				if (frmMDUpdContTab.DefInstance.SetUp(ref num9, ref num2, ref Globals_Renamed.arSelActType[Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex]))
				{
					((Form)frmMDUpdContTab.DefInstance).ShowDialog();
					PrimeContainerSubTab();
				}
				else
				{
					((Form)frmMDUpdContTab.DefInstance).Close();
				}
				break;
			}
			case 3:
				if (Globals_Renamed.intNumOps == 0)
				{
					Interaction.Beep();
					Interaction.MsgBox((object)"You must specify at least one operation before displaying shared parameters", (MsgBoxStyle)64, (object)"Invalid Request");
					break;
				}
				if (frmUpdShowSP.DefInstance.SetUp())
				{
					((Form)frmUpdShowSP.DefInstance).ShowDialog();
					if (Operators.ConditionalCompareObjectNotEqual(((Control)frmUpdShowSP.DefInstance).Tag, (object)"Cancel", false))
					{
						Globals_Renamed.gblIWasChanged = true;
						msfSP.Rows = 1;
						LoadMsfOpSP();
					}
				}
				((Form)frmUpdShowSP.DefInstance).Close();
				break;
			}
		}
	}

	private void cmdUpdOps_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (frmMDUpdOps.DefInstance.SetUp())
		{
			((Form)frmMDUpdOps.DefInstance).ShowDialog();
			if (Globals_Renamed.intNumOps == 0)
			{
				AxMSFlexGrid pmsfGrid = msfOpIP;
				ChemStrX.MyMSfClear(ref pmsfGrid);
				msfOpIP = pmsfGrid;
			}
		}
		ChemStrX.SetOER();
		((Form)frmMDUpdOps.DefInstance).Close();
	}

	private void cmdUpdOptInfo_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0080: Unknown result type (might be due to invalid IL or missing references)
		//IL_0187: Unknown result type (might be due to invalid IL or missing references)
		//IL_01c6: Unknown result type (might be due to invalid IL or missing references)
		//IL_01f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_022a: Unknown result type (might be due to invalid IL or missing references)
		//IL_00d7: Unknown result type (might be due to invalid IL or missing references)
		//IL_0156: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		switch (cmbOptInfo.SelectedIndex)
		{
		case 0:
			if (frmMDUpdSat.DefInstance.SetUp())
			{
				((Form)frmMDUpdSat.DefInstance).ShowDialog();
			}
			else
			{
				((Form)frmMDUpdSat.DefInstance).Close();
			}
			break;
		case 1:
			if (Conversions.ToBoolean(frmMDUpdExp.DefInstance.SetUp()))
			{
				((Form)frmMDUpdExp.DefInstance).ShowDialog();
			}
			else
			{
				((Form)frmMDUpdExp.DefInstance).Close();
			}
			break;
		case 2:
		{
			object tag = ((Control)fraSubOI[(short)0]).Tag;
			if (Operators.ConditionalCompareObjectEqual(tag, (object)Conversions.ToString(1), false))
			{
				if (frmMDUpdMsdsTLV.DefInstance.SetUp())
				{
					((Form)frmMDUpdMsdsTLV.DefInstance).ShowDialog();
				}
				else
				{
					((Form)frmMDUpdMsdsTLV.DefInstance).Close();
				}
			}
			else if (Operators.ConditionalCompareObjectEqual(tag, (object)Conversions.ToString(2), false))
			{
				if (((Control)txtLVEPPE).Visible)
				{
					if (frmMDUpdLvePpe.DefInstance.SetUp())
					{
						((Form)frmMDUpdLvePpe.DefInstance).ShowDialog();
					}
					else
					{
						((Form)frmMDUpdLvePpe.DefInstance).Close();
					}
				}
			}
			else if (frmMDUpdMsdsGE.DefInstance.SetUp())
			{
				((Form)frmMDUpdMsdsGE.DefInstance).ShowDialog();
			}
			else
			{
				((Form)frmMDUpdMsdsGE.DefInstance).Close();
			}
			break;
		}
		case 3:
			if (frmMDUpdP2Cons.DefInstance.SetUp())
			{
				((Form)frmMDUpdP2Cons.DefInstance).ShowDialog();
			}
			else
			{
				((Form)frmMDUpdP2Cons.DefInstance).Close();
			}
			break;
		case 4:
		{
			frmMDUpdOptData defInstance = frmMDUpdOptData.DefInstance;
			short pWhat = checked((short)cmbOptInfo.SelectedIndex);
			if (defInstance.SetUp(ref pWhat))
			{
				((Form)frmMDUpdOptData.DefInstance).ShowDialog();
			}
			else
			{
				((Form)frmMDUpdOptData.DefInstance).Close();
			}
			break;
		}
		case 5:
			if (Conversions.ToBoolean(frmMDUpdOtherUses.DefInstance.SetUp()))
			{
				((Form)frmMDUpdOtherUses.DefInstance).ShowDialog();
			}
			else
			{
				((Form)frmMDUpdOtherUses.DefInstance).Close();
			}
			break;
		case 6:
			if (Conversions.ToBoolean(frmMDUpdLVE.DefInstance.SetUp()))
			{
				((Form)frmMDUpdLVE.DefInstance).ShowDialog();
			}
			else
			{
				((Form)frmMDUpdLVE.DefInstance).Close();
			}
			break;
		}
	}

	private void cmdUpdPhyState_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (Globals_Renamed.intNumOps > 0)
		{
			Globals_Renamed.intOpIndex = checked((short)Support.GetItemData((Control)(object)_lstSelOps_0, _lstSelOps_0.SelectedIndex));
			if (frmMDUpdPS.DefInstance.SetUp())
			{
				((Form)frmMDUpdPS.DefInstance).ShowDialog();
			}
			else
			{
				((Form)frmMDUpdPS.DefInstance).Close();
			}
		}
		else
		{
			Interaction.MsgBox((object)"You must first specify at least one operation.", (MsgBoxStyle)64, (object)"Invalid Request");
		}
	}

	private void cmdUpdRelations_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_005d: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (Globals_Renamed.intNumOps > 1)
		{
			Globals_Renamed.intOpIndex = checked((short)Support.GetItemData((Control)(object)_lstSelOps_0, _lstSelOps_0.SelectedIndex));
			if (frmMDUpdRels.DefInstance.SetUp())
			{
				((Form)frmMDUpdRels.DefInstance).ShowDialog();
			}
			((Form)frmMDUpdRels.DefInstance).Close();
		}
		else
		{
			Interaction.MsgBox((object)"You cannot define relationships between operations until you have selected more than one operation.", (MsgBoxStyle)64, (object)"Unable to process request");
		}
	}

	private void cmdUpdOpAct_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0064: Unknown result type (might be due to invalid IL or missing references)
		//IL_0039: Unknown result type (might be due to invalid IL or missing references)
		if (_lstSelOps_0.SelectedIndex != -1)
		{
			if (Globals_Renamed.intNumOps == 0)
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"You cannot define activities until you have selected at least one operation.", (MsgBoxStyle)64, (object)"Invalid Request");
				return;
			}
			Globals_Renamed.intOpIndex = checked((short)Support.GetItemData((Control)(object)_lstSelOps_0, _lstSelOps_0.SelectedIndex));
			((Form)frmMDUpdAct.DefInstance).ShowDialog();
			ChemStrX.SetVolatilityFlag(ref Globals_Renamed.intOpIndex);
			object pOpIndex = Globals_Renamed.intOpIndex;
			ChemStrX.resetInhRespClass(ref pOpIndex);
			Globals_Renamed.intOpIndex = Conversions.ToShort(pOpIndex);
			ChemStrX.DeriveNWdefault();
			ChemStrX.setDefaultExpFlags();
		}
	}

	private void cmdUpdRelMedia_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0034: Unknown result type (might be due to invalid IL or missing references)
		//IL_00b3: Unknown result type (might be due to invalid IL or missing references)
		if ((cmbRelActs.SelectedIndex == -1) | (lstRelModels.SelectedIndex == -1))
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please select a release model.", (MsgBoxStyle)64, (object)"Invalid Request");
			return;
		}
		checked
		{
			Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbRelOps.SelectedIndex);
			Globals_Renamed.intActIndex = (short)Support.GetItemData((Control)(object)cmbRelActs, cmbRelActs.SelectedIndex);
			Globals_Renamed.intModIndex = (short)(Globals_Renamed.arRelModels[lstRelModels.SelectedIndex, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
			if (frmMDUpdRelMed.DefInstance.SetUp())
			{
				((Form)frmMDUpdRelMed.DefInstance).ShowDialog();
			}
			((Form)frmMDUpdRelMed.DefInstance).Close();
		}
	}

	private void cmdUpdSites_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_003c: Unknown result type (might be due to invalid IL or missing references)
		if (Globals_Renamed.intNumOps > 0)
		{
			Globals_Renamed.intOpIndex = checked((short)Support.GetItemData((Control)(object)_lstSelOps_0, _lstSelOps_0.SelectedIndex));
			if (frmMDUpdSites.DefInstance.SetUp())
			{
				((Form)frmMDUpdSites.DefInstance).ShowDialog();
			}
			else
			{
				((Form)frmMDUpdSites.DefInstance).Close();
			}
		}
		else
		{
			Interaction.MsgBox((object)"You must first specify at least one operation.", (MsgBoxStyle)64, (object)"Invalid Request");
		}
	}

	private void cmdViewExpLimits_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0006: Unknown result type (might be due to invalid IL or missing references)
		((Form)frmViewPels.DefInstance).ShowDialog();
	}

	private void cmdViewExpModel_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		if (cmbExpActs.SelectedIndex == -1)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please select an exposure activity", (MsgBoxStyle)64, (object)"Invalid Request");
		}
		else
		{
			viewEditExposureModelPopup();
		}
	}

	private void viewEditExposureModelPopup()
	{
		//IL_0072: Unknown result type (might be due to invalid IL or missing references)
		//IL_0141: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbExpOps.SelectedIndex);
			Globals_Renamed.intActIndex = (short)Support.GetItemData((Control)(object)cmbExpActs, cmbExpActs.SelectedIndex);
			Globals_Renamed.intModIndex = (short)(Globals_Renamed.arExpModels[MyCurrentExpTab - 1, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
			if (Globals_Renamed.intModIndex == -1)
			{
				Interaction.MsgBox((object)"No exposure model is selected.", (MsgBoxStyle)0, (object)null);
				return;
			}
			if (MyCurrentExpTab == 1)
			{
				SetMsfExpParmsDefaultCaptions_0();
			}
			else
			{
				SetMsfExpParmsDefaultCaptions_1();
			}
			frmMDUpdExpMod defInstance = frmMDUpdExpMod.DefInstance;
			short pModel = (short)(MyCurrentExpTab - 1);
			if (defInstance.SetUp(ref pModel))
			{
				short num = Conversions.ToShort(Interaction.Choose((double)MyCurrentExpTab, new object[2] { 1, 0 }));
				if (Globals_Renamed.arExpModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
				{
					frmMDUpdExpMod.DefInstance.intOtherModelIndex = (short)(Globals_Renamed.arExpModels[num, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
				}
				else
				{
					frmMDUpdExpMod.DefInstance.intOtherModelIndex = -1;
				}
				((Form)frmMDUpdExpMod.DefInstance).ShowDialog();
				if (Operators.ConditionalCompareObjectEqual(((Control)frmMDUpdExpMod.DefInstance).Tag, (object)"", false))
				{
					object pOpIndex = Globals_Renamed.intOpIndex;
					ChemStrX.resetInhRespClass(ref pOpIndex);
					FormatExpOutputs();
				}
				else
				{
					pModel = (short)(MyCurrentExpTab - 1);
					LoadExpParms(ref pModel);
				}
				((Form)frmMDUpdExpMod.DefInstance).Close();
			}
			else
			{
				((Form)frmMDUpdExpMod.DefInstance).Close();
			}
		}
	}

	private void cmdViewModelInfo_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0025: Unknown result type (might be due to invalid IL or missing references)
		//IL_0053: Unknown result type (might be due to invalid IL or missing references)
		if (cmbRelActs.SelectedIndex == -1)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please select a release model.", (MsgBoxStyle)64, (object)"Invalid Request");
		}
		else if (lstRelModels.SelectedIndex == -1)
		{
			Interaction.Beep();
			Interaction.MsgBox((object)"Please select a release model.", (MsgBoxStyle)64, (object)"Invalid Request");
		}
		else
		{
			viewEditReleaseModelPopup();
		}
	}

	public void viewEditReleaseModelPopup()
	{
		//IL_0078: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, cmbRelOps.SelectedIndex);
			Globals_Renamed.intActIndex = (short)Support.GetItemData((Control)(object)cmbRelActs, cmbRelActs.SelectedIndex);
			Globals_Renamed.intModIndex = (short)(Globals_Renamed.arRelModels[lstRelModels.SelectedIndex, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
			if (Conversions.ToBoolean(frmMDUpdRelMod.DefInstance.SetUp()))
			{
				((Form)frmMDUpdRelMod.DefInstance).ShowDialog();
			}
		}
	}

	private void cmdUpdAVP_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		checked
		{
			if (frmUpdVP.DefInstance.SetUp())
			{
				((Form)frmUpdVP.DefInstance).ShowDialog();
				if (Operators.ConditionalCompareObjectNotEqual(((Control)frmUpdVP.DefInstance).Tag, (object)"Cancel", false))
				{
					Globals_Renamed.gblIWasChanged = true;
					LoadMsfOpSP();
					short num = (short)(Globals_Renamed.intNumOps - 1);
					short pOpIndex = 0;
					while (true)
					{
						short num2 = pOpIndex;
						short num3 = num;
						if (num2 > num3)
						{
							break;
						}
						ChemStrX.SetVolatilityFlag(ref pOpIndex);
						object pOpIndex2 = pOpIndex;
						ChemStrX.resetInhRespClass(ref pOpIndex2);
						pOpIndex = Conversions.ToShort(pOpIndex2);
						pOpIndex = (short)unchecked(pOpIndex + 1);
					}
					DefInstance.cmbExpOps.SelectedIndex = -1;
				}
			}
			((Form)frmUpdVP.DefInstance).Close();
		}
	}

	private void mnuFileEasyModels_Click(object sender, EventArgs e)
	{
		//IL_0065: Unknown result type (might be due to invalid IL or missing references)
		bool flag = false;
		if (Globals_Renamed.gblAssessID == 0 && ((Globals_Renamed.intNumOps == 0) | ((Globals_Renamed.intNumOps == 1) & (Operators.CompareString(Globals_Renamed.arOpName[0], "Run Models", false) == 0))))
		{
			flag = true;
		}
		if (flag)
		{
			Globals_Renamed.gblDoEasyModels = true;
			Globals_Renamed.gblOpenMainAgain = true;
			((Form)this).Close();
		}
		else
		{
			Interaction.MsgBox((object)"It is invalid to perform the advanced user function Run Models when you have an open assessment. Please close your assessment first", (MsgBoxStyle)64, (object)"Close Your Assessment");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void mnuFileDelete_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0060: Unknown result type (might be due to invalid IL or missing references)
		//IL_0066: Expected O, but got Unknown
		//IL_00e3: Unknown result type (might be due to invalid IL or missing references)
		//IL_00e9: Invalid comparison between Unknown and I4
		//IL_03c2: Unknown result type (might be due to invalid IL or missing references)
		//IL_018d: Unknown result type (might be due to invalid IL or missing references)
		//IL_0266: Unknown result type (might be due to invalid IL or missing references)
		//IL_01e8: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					Guid clsid = new Guid("00000514-0000-0010-8000-00AA006D2EA4");
					Connection connection = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					Command command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					OpenFileDialog val3 = new OpenFileDialog();
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					OpenFileDialog val4 = val3;
					((FileDialog)val4).Title = "Select the ChemSTEER database containing the assessment you wish to delete";
					string setting = Interaction.GetSetting("ChemSteer", "Options", "DefaultDBN", "");
					if (Strings.Len(setting) > 0)
					{
						((FileDialog)val4).FileName = setting;
					}
					else
					{
						((FileDialog)val4).FileName = "*.mdb";
					}
					((FileDialog)val4).DefaultExt = "MDB";
					((FileDialog)val4).Filter = "Access Databases (*.MDB)|*.MDB";
					val4 = null;
					if ((int)((CommonDialog)val3).ShowDialog() != 1)
					{
						goto end_IL_0001;
					}
					ProjectData.ClearProjectError();
					num2 = 2;
					connection.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + ((FileDialog)val3).FileName;
					connection.Open();
					recordset.Open("SELECT * FROM qryOpen", connection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					if (!recordset.EOF)
					{
						recordset.MoveLast();
						recordset.MoveFirst();
					}
					short num3;
					bool flag;
					switch (recordset.RecordCount)
					{
					case 0:
						Interaction.MsgBox((object)"The database you selected does not have any assessments.  Please select another database.", (MsgBoxStyle)64, (object)"Invalid Database");
						goto end_IL_0001;
					case 1:
						num3 = Conversions.ToShort(recordset.Fields[0].Value);
						flag = true;
						break;
					default:
					{
						short gblAssessID = Globals_Renamed.gblAssessID;
						frmMDSelAss defInstance = frmMDSelAss.DefInstance;
						string Eobject = "D";
						if (defInstance.SetUp(recordset, ref Eobject))
						{
							((Form)frmMDSelAss.DefInstance).ShowDialog();
							if (Globals_Renamed.gblAssessID != 0)
							{
								num3 = Globals_Renamed.gblAssessID;
								Globals_Renamed.gblAssessID = gblAssessID;
								flag = false;
								break;
							}
							Globals_Renamed.gblAssessID = gblAssessID;
						}
						else
						{
							((Form)frmMDSelAss.DefInstance).Close();
						}
						goto end_IL_0001;
					}
					}
					recordset.Close();
					if ((Operators.CompareString(((FileDialog)val3).FileName, Globals_Renamed.gblDBName, false) == 0) & (num3 == Globals_Renamed.gblAssessID))
					{
						Interaction.MsgBox((object)"You cannot delete an open assessment. Please close the current assessment and try again.", (MsgBoxStyle)64, (object)"Invalid Request");
						goto end_IL_0001;
					}
					Cursor.Current = Cursors.WaitCursor;
					command.ActiveConnection = connection;
					command.CommandText = "DELETE FROM Assessments WHERE AssessID=" + Conversions.ToString((int)num3);
					Command command2 = command;
					object RecordsAffected = Missing.Value;
					object Parameters = Missing.Value;
					command2.Execute(out RecordsAffected, ref Parameters);
					if (flag & (Operators.CompareString(((FileDialog)val3).FileName, Globals_Renamed.gblDBName, false) != 0))
					{
						FileSystem.Kill(((FileDialog)val3).FileName);
					}
					command.ActiveConnection = connection;
					command.CommandText = "pQryDeleteIrerRels";
					command.CommandType = CommandTypeEnum.adCmdStoredProc;
					command.Parameters.Append(command.CreateParameter("pAssessID", DataTypeEnum.adInteger, ParameterDirectionEnum.adParamInput, 5, num3));
					Command command3 = command;
					Parameters = Missing.Value;
					RecordsAffected = Missing.Value;
					command3.Execute(out Parameters, ref RecordsAffected);
					command.Parameters.Delete("pAssessID");
					connection.Close();
					connection = null;
					command = null;
					Cursor.Current = Cursors.Default;
					goto end_IL_0001;
				}
				case 1069:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						if (Information.Err().Number == 70)
						{
							Cursor.Current = Cursors.Default;
							goto end_IL_0001;
						}
						if (Information.Err().Number == 3051)
						{
							Interaction.MsgBox((object)("The assessment you tried to delete is in a Read-only database. ChemSTEER requires that the database be updateable.\r\rPlease remove the Read-only attribute by right clicking on the database " + Globals_Renamed.gblDBName + " in Windows Explorer and select Properties, then Attributes, and click the Read-only Attribute to remove the Read-only check mark.  Note that it may be necessary to move the database to an updateable media (e.g., local hard drive or network drive); files located on CD-R media are Read-only by definition and are not updateable."), (MsgBoxStyle)64, (object)"Invalid Request");
							goto end_IL_0001;
						}
						string Eobject = ((Control)this).Name;
						string Efunction = "mnuFileDelete_Click";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1069;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuFileExit_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
	}

	public void mnuFileImportCRSS_Popup(object eventSender, EventArgs eventArgs)
	{
		mnuFileImportCRSS_Click(RuntimeHelpers.GetObjectValue(eventSender), eventArgs);
	}

	public void mnuFileImportCRSS_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0098: Unknown result type (might be due to invalid IL or missing references)
		//IL_0257: Unknown result type (might be due to invalid IL or missing references)
		//IL_0128: Unknown result type (might be due to invalid IL or missing references)
		//IL_015c: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cf: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		string setting = default(string);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					Guid clsid = new Guid("00000514-0000-0010-8000-00AA006D2EA4");
					Connection connection = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					setting = Interaction.GetSetting("ChemSteer", "Options", "DefaultCRSSDBN", "");
					if ((Operators.CompareString(setting, "", false) == 0) | (Operators.CompareString(setting, "None Specified", false) == 0))
					{
						Interaction.MsgBox((object)"A default CRSS database has not been specified. Please go to Preferences, Specify CRSS Database and select a default database.", (MsgBoxStyle)64, (object)"CRSS Database not Specified");
						goto end_IL_0001;
					}
					connection.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + setting;
					connection.Open();
					recordset.Open("SELECT * FROM Chemsteer", connection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					if (!recordset.EOF)
					{
						recordset.MoveLast();
						recordset.MoveFirst();
					}
					if (recordset.RecordCount == 0)
					{
						sCRSSid = "";
						Interaction.MsgBox((object)"The database you selected does not contain any CRSS reports.  Please select another database.", (MsgBoxStyle)64, (object)"Invalid Database");
						goto end_IL_0001;
					}
					frmMDSelAss defInstance = frmMDSelAss.DefInstance;
					Recordset pRS = recordset;
					string Eobject = "I";
					if (defInstance.SetUp(pRS, ref Eobject))
					{
						((Form)frmMDSelAss.DefInstance).ShowDialog();
						if (Operators.ConditionalCompareObjectEqual(((Control)frmMDSelAss.DefInstance).Tag, (object)"", false))
						{
							if (Operators.CompareString(sCRSSid, "", false) == 0)
							{
								((Form)frmMDSelAss.DefInstance).Close();
							}
							else
							{
								if (Operators.ConditionalCompareObjectEqual(Import_CRSS(ref sCRSSid), (object)false, false))
								{
									Interaction.MsgBox((object)"An error was encountered while importing the CRSS report. Please contact technical support.", (MsgBoxStyle)16, (object)"Assessment was not successfully saved!");
									goto end_IL_0001;
								}
								Globals_Renamed.gblIWasChanged = true;
							}
						}
						else
						{
							((Form)frmMDSelAss.DefInstance).Close();
						}
					}
					else
					{
						((Form)frmMDSelAss.DefInstance).Close();
					}
					recordset.Close();
					recordset = null;
					connection.Close();
					connection = null;
					goto end_IL_0001;
				}
				case 758:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						if (((0u - ((Information.Err().Number == 3024) ? 1u : 0u)) | 0xBE3u) != 0)
						{
							Interaction.MsgBox((object)("The default CRSS database (" + setting + ") no longer exists. Please go to Preferences, Specify CRSS Database and select a default database."), (MsgBoxStyle)64, (object)"CRSS Database No Longer Exists");
							Interaction.SaveSetting("ChemSteer", "Options", "DefaultCRSSPath", "J:/process/initchem/");
							Interaction.SaveSetting("ChemSteer", "Options", "DefaultCRSSDBN", "");
							goto end_IL_0001;
						}
						string Eobject = ((Control)this).Name;
						string Efunction = "mnuFileImportCRSS_Click";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 758;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private object Import_CRSS(ref string myEPAID)
	{
		//IL_025e: Unknown result type (might be due to invalid IL or missing references)
		//IL_05fe: Unknown result type (might be due to invalid IL or missing references)
		//IL_06c2: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		short num7 = default(short);
		object obj3 = default(object);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						clsid = new Guid("00000514-0000-0010-8000-00AA006D2EA4");
						Connection connection = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						recordset2.CursorLocation = CursorLocationEnum.adUseClient;
						object obj = new object[9] { "P", "L", "T", "X", "M", "I", "C", "E", "S" };
						object obj2 = new object[9] { 1, 2, 3, 4, 5, 6, 11, 12, 13 };
						short num3 = (short)Information.UBound((Array)obj, 1);
						short num4 = 0;
						while (true)
						{
							short num5 = num4;
							short num6 = num3;
							if (num5 > num6)
							{
								break;
							}
							if (Operators.ConditionalCompareObjectEqual((object)Strings.Mid(myEPAID, 1, Strings.InStr(myEPAID, "-", (CompareMethod)0) - 1), NewLateBinding.LateIndexGet(obj, new object[1] { num4 }, (string[])null), false))
							{
								num7 = Conversions.ToShort(NewLateBinding.LateIndexGet(obj2, new object[1] { num4 }, (string[])null));
							}
							num4 = (short)unchecked(num4 + 1);
						}
						if ((num7 == 0) | Information.IsDBNull((object)num7))
						{
							num7 = 998;
						}
						string text = Strings.Mid(myEPAID, 3, 2);
						string text2 = Strings.Right(myEPAID, 4);
						string setting = Interaction.GetSetting("ChemSteer", "Options", "DefaultCRSSDBN", "");
						if ((Operators.CompareString(setting, "", false) == 0) | (Operators.CompareString(setting, "None Specified", false) == 0))
						{
							Interaction.MsgBox((object)"A default CRSS database has not been specified. Please go to Preferences, Specify CRSS Database and select a default database.", (MsgBoxStyle)64, (object)"CRSS Database not Specified");
							goto end_IL_0001;
						}
						connection.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + setting;
						connection.Open();
						recordset2.Open("SELECT * FROM Chemsteer WHERE [PMN number]='" + myEPAID + "'", connection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						frmMain defInstance = DefInstance;
						defInstance.lblAVPlow.Text = Interaction.GetSetting("ChemSteer", "Options", "VPlow", ".001");
						defInstance.lblAVPhigh.Text = Interaction.GetSetting("ChemSteer", "Options", "VPhigh", "35");
						((Control)defInstance.lblAssessType).Tag = num7;
						defInstance.lblFiscalYear.Text = text;
						defInstance.lblID.Text = text2;
						defInstance.txtMiscCRSSinfo.Text = "Neat: " + Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["neat"].Value)) + " Mfg: " + Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["manufacture"].Value)) + " Proc/Form: " + Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["process"].Value)) + " End Use: " + Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["end use"].Value)) + ". " + Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Addl chem info"].Value));
						defInstance.lblCoName.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Submitter"].Value));
						defInstance.lblNumWMet[(short)4].Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["exposure based"].Value)), "Y", false) == 0, (object)"Yes", (object)"No"));
						defInstance.lblConsUse.Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Consumer Use"].Value)), "Y", false) == 0, (object)"Yes", (object)"No"));
						defInstance.txtOtherUses.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["other uses"].Value));
						if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["crss date"].Value)), "", false) != 0)
						{
							if (Information.IsDate((object)Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["crss date"].Value))))
							{
								defInstance.lblCRSSdate.Text = Strings.Format(RuntimeHelpers.GetObjectValue(recordset2.Fields["crss date"].Value), Globals_Renamed.gblChemDateFormat);
							}
							else
							{
								Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"The CRSS date from the CRSS Report: '", recordset2.Fields["crss date"].Value), (object)"' is not a valid date, please enter a valid CRSS date on the Optional Information tab."), (MsgBoxStyle)64, (object)"Invalid CRSS Date");
								defInstance.lblCRSSdate.Text = "";
							}
						}
						else
						{
							defInstance.lblCRSSdate.Text = "";
						}
						defInstance.txtSatRelatedCases.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["addnl info"].Value));
						defInstance.txtP2Cons.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["P2 concerns"].Value));
						if (Strings.Len(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["chemical name"].Value))) > 255)
						{
							Interaction.MsgBox((object)"The chemical name from the CRSS Report was truncated after 255 characters, please enter the Chemical Category on the Chemicals tab.", (MsgBoxStyle)64, (object)"Chemical Name Truncated");
							defInstance.lblChemName.Text = Strings.Left(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["chemical name"].Value)), 255);
						}
						else
						{
							defInstance.lblChemName.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["chemical name"].Value));
						}
						defInstance.lblTradeNames.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["trade name"].Value));
						defInstance.lblCas.Text = Strings.Left(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["cas number"].Value)), 20);
						defInstance.lblMF.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["molecular formula"].Value));
						defInstance.lblMW.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["mol weight"].Value));
						defInstance.lblLT500.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Wt percent 500"].Value));
						defInstance.lblLT1000.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Wt percent 1000"].Value));
						bool flag;
						unchecked
						{
							float num8;
							if (num7 == 2 || num7 == 5)
							{
								num8 = ((Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["bind option"].Value)), "Y", false) == 0) ? Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["Max PV"].Value))) : 10000f);
								defInstance.lblPV.Text = Conversions.ToString(num8);
								defInstance.lblTotalSubPV.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Max PV"].Value));
								if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["import"].Value)), "X", false) == 0)
								{
									if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset2.Fields["manuf"].Value)) | (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["manuf"].Value)), "X", false) != 0))
									{
										defInstance.lblImportedSubPV.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Max PV"].Value));
										defInstance.lblPVi.Text = Conversions.ToString(num8);
									}
								}
								else if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["manuf"].Value)), "X", false) == 0)
								{
									defInstance.lblDomesticSubPV.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Max PV"].Value));
									defInstance.lblPVd.Text = Conversions.ToString(num8);
								}
							}
							else
							{
								defInstance.lblPV.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Max PV"].Value));
								if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["import"].Value)), "X", false) == 0)
								{
									if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset2.Fields["manuf"].Value)) | (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["manuf"].Value)), "X", false) != 0))
									{
										defInstance.lblPVi.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Max PV"].Value));
									}
								}
								else if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["manuf"].Value)), "X", false) == 0)
								{
									defInstance.lblPVd.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["Max PV"].Value));
								}
							}
							if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["manuf"].Value)), "X", false) == 0)
							{
								defInstance.lblNoticeType.Text = "Manufacturing";
								if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["import"].Value)), "X", false) == 0)
								{
									defInstance.lblNoticeType.Text = defInstance.lblNoticeType.Text + " and Import";
								}
							}
							else if (Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["import"].Value)), "X", false) == 0)
							{
								defInstance.lblNoticeType.Text = "Import";
							}
							num8 = ((!((Operators.CompareString(Strings.Left(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["vp est"].Value)), 1), ">", false) == 0) | (Operators.CompareString(Strings.Left(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["vp est"].Value)), 1), "<", false) == 0))) ? Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["vp est"].Value))) : Conversions.ToSingle(Common.MyNullCheck0(Conversions.ToSingle(Strings.Mid(Conversions.ToString(recordset2.Fields["vp est"].Value), 2)))));
							((Control)defInstance.lblVP).Tag = defInstance.lblVP.Text;
							if (Operators.ConditionalCompareObjectGreater((object)num8, Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["VP"].Value)), false))
							{
								defInstance.lblVP.Text = Conversions.ToString(num8);
							}
							else
							{
								defInstance.lblVP.Text = Conversions.ToString(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["VP"].Value)));
							}
							if (Operators.ConditionalCompareObjectNotEqual((object)defInstance.lblVP.Text, ((Control)defInstance.lblVP).Tag, false))
							{
								((Control)defInstance.lblVP).Tag = "99";
							}
							num8 = 0f;
							if ((Operators.CompareString(Strings.LCase(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["water solub est"].Value))), "dispersible", false) == 0) | (Operators.CompareString(Strings.LCase(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["water solub est"].Value))), "reacts", false) == 0))
							{
								defInstance.lblSol.Text = Strings.UCase(Strings.Left(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["water solub est"].Value)), 1)) + Strings.LCase(Strings.Mid(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["water solub est"].Value)), 2));
							}
							else
							{
								if ((Operators.CompareString(Strings.Left(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["water solub est"].Value)), 1), ">", false) == 0) | (Operators.CompareString(Strings.Left(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["water solub est"].Value)), 1), "<", false) == 0))
								{
									setting = Strings.Mid(Conversions.ToString(recordset2.Fields["water solub est"].Value), 2);
									if (Versioned.IsNumeric((object)setting))
									{
										num8 = Conversions.ToSingle(Common.MyNullCheck0(Conversions.ToSingle(setting)));
									}
									else
									{
										defInstance.lblSol.Text = setting;
									}
								}
								else if (!Information.IsDBNull(RuntimeHelpers.GetObjectValue(recordset2.Fields["water solub est"].Value)))
								{
									num8 = Conversions.ToSingle(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["water solub est"].Value)));
								}
								if (Operators.ConditionalCompareObjectGreater((object)num8, Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["water solub"].Value)), false))
								{
									defInstance.lblSol.Text = Conversions.ToString(num8);
								}
								else
								{
									defInstance.lblSol.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["water solub"].Value));
								}
							}
							defInstance.txtChemGenUse.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["use"].Value));
							if (num7 == 2 || num7 == 5)
							{
								defInstance.lblBindingPV.Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["bind option"].Value)), "Y", false) == 0, (object)"Yes", (object)"No"));
							}
							flag = false;
						}
						int num9 = recordset2.Fields.Count - 1;
						int num10 = 0;
						while (true)
						{
							int num11 = num10;
							int num12 = num9;
							if (num11 > num12)
							{
								break;
							}
							if (Operators.CompareString(recordset2.Fields[num10].Name, "SATDate", false) == 0)
							{
								flag = true;
							}
							num10++;
						}
						if (flag)
						{
							defInstance.lblSATHR.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["HRating"].Value));
							defInstance.lblSATER.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["ERating"].Value));
							string text3 = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["M2G"].Value));
							switch (text3)
							{
							case "1":
								defInstance.lblSatM2G.Text = "Negligible";
								break;
							default:
								if (0 == 0)
								{
									switch (text3)
									{
									case "2":
										defInstance.lblSatM2G.Text = "Slow";
										break;
									default:
										if (0 == 0)
										{
											switch (text3)
											{
											case "3":
												defInstance.lblSatM2G.Text = "Moderate";
												break;
											default:
												if (0 == 0)
												{
													if (Operators.CompareString(text3, "4", false) == 0)
													{
														defInstance.lblSatM2G.Text = "Rapid";
													}
													else
													{
														defInstance.lblSatM2G.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["M2G"].Value));
													}
													break;
												}
												goto case "3-4";
											case "3-4":
											case "3 - 4":
												defInstance.lblSatM2G.Text = "Moderate to rapid";
												break;
											}
											break;
										}
										goto case "2-3";
									case "2-3":
									case "2 - 3":
										defInstance.lblSatM2G.Text = "Slow to moderate";
										break;
									}
									break;
								}
								goto case "1-2";
							case "1-2":
							case "1 - 2":
								defInstance.lblSatM2G.Text = "Negligible to slow";
								break;
							}
							defInstance.lblSatM2GOther.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["M2GDesc"].Value));
							defInstance.txtSatAddPBTinfo.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["AddPBTinfo"].Value));
							defInstance.lblSatPR.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["PRate"].Value));
							defInstance.lblSatBR.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["BRate"].Value));
							defInstance.lblSatHReq[(short)0].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["Dermal"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							defInstance.lblSatHReq[(short)1].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["DW"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							defInstance.lblSatHReq[(short)2].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["Inh"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							defInstance.lblSatTR.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["TRate"].Value));
							defInstance.lblSatHReq[(short)4].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["OtherReq"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							if (Operators.CompareString(defInstance.lblSatHReq[(short)4].Text, "Yes", false) == 0)
							{
								defInstance.lblSatHReq[(short)6].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["OtherReqDesc"].Value));
							}
							else
							{
								defInstance.lblSatHReq[(short)4].Text = "";
							}
							defInstance.lblSatHReq[(short)5].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["HealthXP"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							defInstance.lblSatHReq[(short)8].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["HealthXP"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							if (Operators.CompareString(defInstance.lblSatHReq[(short)8].Text, "Yes", false) == 0)
							{
								defInstance.lblSatHReq[(short)7].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["HealthXPDesc"].Value));
							}
							else
							{
								defInstance.lblSatHReq[(short)7].Text = "";
							}
							defInstance.lblSATdate.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["SATDate"].Value));
							defInstance.lblSatEReq[(short)0].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["EcoW"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							defInstance.lblSatEReq[(short)4].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["EcoO"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							if (Operators.CompareString(defInstance.lblSatEReq[(short)4].Text, "Yes", false) == 0)
							{
								defInstance.lblSatEReq[(short)6].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["EcoODesc"].Value));
							}
							else
							{
								defInstance.lblSatEReq[(short)6].Text = "";
							}
							defInstance.lblCC.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["CC"].Value));
							defInstance.lblSatEReq[(short)5].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["EcoXP"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							defInstance.lblSatEReq[(short)8].Text = Conversions.ToString(Interaction.IIf(Operators.ConditionalCompareObjectEqual(Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(recordset2.Fields["EcoXP"].Value)), (object)1, false), (object)"Yes", (object)"No"));
							if (Operators.CompareString(defInstance.lblSatEReq[(short)8].Text, "Yes", false) == 0)
							{
								defInstance.lblSatEReq[(short)7].Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset2.Fields["EcoXPDesc"].Value));
							}
							else
							{
								defInstance.lblSatEReq[(short)7].Text = "";
							}
						}
						recordset2.Close();
						recordset2 = null;
						if (frmMDUpdChem.DefInstance.SetUp())
						{
							defInstance.lblVP.Text = Conversions.ToString(((Control)defInstance.lblVP).Tag);
							frmMDUpdChem.DefInstance.cmdOk_Click(frmMDUpdChem.DefInstance.cmdOk, new EventArgs());
							if (Globals_Renamed.intNumOps > 0)
							{
								SetPvOpLabels();
								PrimeContainerSubTab();
								LoadMsfOpSP();
							}
						}
						((Form)frmMDUpdChem.DefInstance).Close();
						if (Strings.Len(RuntimeHelpers.GetObjectValue(((Control)defInstance.lblAssessType).Tag)) > 0)
						{
							recordset.Open(Operators.ConcatenateObject((object)"SELECT AssType FROM ListOfAssessTypes WHERE AssTypeID=", ((Control)defInstance.lblAssessType).Tag), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
							if (!recordset.EOF)
							{
								defInstance.lblAssessType.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value));
							}
							recordset.Close();
							if (Conversions.ToDouble(((Control)defInstance.lblAssessType).Tag) > 900.0)
							{
								defInstance.lblAssessType.Text = defInstance.lblAssessType.Text + ": " + Strings.Mid(myEPAID, 1, Strings.InStr(myEPAID, "-", (CompareMethod)0) - 1);
							}
						}
						if (Strings.Len(RuntimeHelpers.GetObjectValue(((Control)defInstance.lblStatus).Tag)) > 0)
						{
							if (Conversions.ToDouble(((Control)defInstance.lblStatus).Tag) > 900.0)
							{
								defInstance.lblStatus.Text = "Other: " + defInstance.lblStatus.Text;
							}
							else
							{
								recordset.Open(Operators.ConcatenateObject((object)"SELECT AssStatus FROM ListOfAssStatus WHERE AssStatusID=", ((Control)defInstance.lblStatus).Tag), Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
								if (!recordset.EOF)
								{
									defInstance.lblStatus.Text = Common.MyNullCheck(RuntimeHelpers.GetObjectValue(recordset.Fields[0].Value));
								}
								recordset.Close();
							}
						}
						defInstance = null;
						obj3 = true;
						recordset = null;
						connection.Close();
						connection = null;
						goto end_IL_0001_2;
					}
					case 7303:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "Import_CRSS";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							((Control)this).Name = Eobject;
							goto end_IL_0001_2;
						}
						}
						break;
					}
					goto IL_1cc1;
				}
				end_IL_0001_2:;
			}
			catch (object obj4) when (obj4 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj4);
				try0001_dispatch = 7303;
				continue;
			}
			break;
			IL_1cc1:
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		object result = obj3;
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
		return result;
	}

	public void mnuFileNew_Click(object eventSender, EventArgs eventArgs)
	{
		((Form)this).Close();
		if (Operators.ConditionalCompareObjectEqual(((Control)this).Tag, (object)"cancel", false))
		{
			((Control)this).Tag = "";
			return;
		}
		if (Operators.CompareString(Globals_Renamed.gblDBName, "", false) != 0)
		{
			Common.DataConn.Close();
			Common.DataConn.ConnectionString = "";
		}
		Globals_Renamed.gblDBName = "";
		Globals_Renamed.gblAssessID = 0;
		Globals_Renamed.intNumOps = 0;
		lblAVPlow.Text = Interaction.GetSetting("ChemSteer", "Options", "VPlow", ".001");
		lblAVPhigh.Text = Interaction.GetSetting("ChemSteer", "Options", "VPhigh", "35");
		Globals_Renamed.gblDoEasyModels = false;
		Globals_Renamed.gblOpenMainAgain = true;
	}

	public void mnuFileOpen_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_007f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0085: Expected O, but got Unknown
		//IL_012f: Unknown result type (might be due to invalid IL or missing references)
		//IL_013f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0237: Unknown result type (might be due to invalid IL or missing references)
		//IL_0297: Unknown result type (might be due to invalid IL or missing references)
		//IL_0366: Unknown result type (might be due to invalid IL or missing references)
		//IL_0450: Unknown result type (might be due to invalid IL or missing references)
		//IL_0507: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		OpenFileDialog val3 = default(OpenFileDialog);
		OpenFileDialog val4 = default(OpenFileDialog);
		string setting = default(string);
		object obj = default(object);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				string Efunction;
				ErrObject val;
				int Enumber;
				ErrObject val2;
				string Edescription;
				bool Econtact;
				frmMDSelAss defInstance;
				Recordset pRS;
				string Eobject;
				Guid clsid;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_0023;
				case 1844:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 2:
							break;
						case 1:
							goto IL_0592;
						default:
							goto end_IL_0001;
						}
						goto IL_04cd;
					}
					IL_021d:
					num = 41;
					Globals_Renamed.gblAssessID = 0;
					goto IL_0227;
					IL_0227:
					num = 42;
					Interaction.MsgBox((object)"The database you selected does not have any assessments.  Please select another database.", (MsgBoxStyle)64, (object)"Invalid Database");
					goto end_IL_0001_2;
					IL_04b6:
					num = 91;
					Cursor.Current = Cursors.Default;
					goto end_IL_0001_2;
					IL_0592:
					num4 = num2 + 1;
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0023;
					case 3:
						goto IL_002e;
					case 4:
						goto IL_004d;
					case 5:
					case 6:
						goto IL_005c;
					case 7:
						goto IL_0069;
					case 8:
						goto IL_0072;
					case 9:
						goto IL_007b;
					case 10:
						goto IL_0085;
					case 11:
						goto IL_008c;
					case 12:
						goto IL_009d;
					case 13:
						goto IL_00ae;
					case 14:
						goto IL_00cc;
					case 15:
						goto IL_00df;
					case 17:
						goto IL_00ee;
					case 18:
						goto IL_00f3;
					case 16:
					case 19:
					case 20:
						goto IL_0105;
					case 21:
						goto IL_0116;
					case 22:
						goto IL_0127;
					case 23:
						goto IL_012a;
					case 24:
						goto IL_013a;
					case 25:
						goto IL_014a;
					case 27:
					case 28:
						goto IL_0168;
					case 29:
						goto IL_0170;
					case 30:
						goto IL_017f;
					case 31:
						goto IL_019d;
					case 32:
						goto IL_01bc;
					case 33:
						goto IL_01d4;
					case 34:
						goto IL_01e7;
					case 35:
						goto IL_01f2;
					case 36:
					case 37:
						goto IL_01fe;
					case 39:
					case 41:
						goto IL_021d;
					case 42:
						goto IL_0227;
					case 45:
					case 46:
						goto IL_0249;
					case 48:
					case 49:
						goto IL_0270;
					case 50:
						goto IL_028e;
					case 52:
						goto IL_029f;
					case 53:
						goto IL_02a4;
					case 51:
					case 54:
					case 55:
						goto IL_02b4;
					case 38:
					case 44:
					case 47:
					case 57:
					case 58:
					case 59:
						goto IL_02ce;
					case 60:
						goto IL_02dd;
					case 61:
						goto IL_02e8;
					case 62:
						goto IL_02f1;
					case 63:
						goto IL_0314;
					case 64:
						goto IL_0320;
					case 65:
						goto IL_0338;
					case 66:
						goto IL_0356;
					case 67:
						goto IL_036c;
					case 68:
						goto IL_0376;
					case 69:
						goto IL_0387;
					case 71:
						goto IL_0396;
					case 72:
						goto IL_039b;
					case 73:
						goto IL_03ac;
					case 74:
						goto IL_03cf;
					case 75:
						goto IL_03e0;
					case 76:
						goto IL_03f6;
					case 78:
						goto IL_0405;
					case 79:
						goto IL_041b;
					case 80:
						goto IL_0456;
					case 81:
						goto IL_0464;
					case 82:
						goto IL_046e;
					case 83:
						goto IL_0478;
					case 70:
					case 77:
					case 85:
					case 86:
					case 87:
						goto IL_048f;
					case 88:
						goto IL_049a;
					case 89:
						goto IL_04a2;
					case 90:
						goto IL_04ac;
					case 91:
						goto IL_04b6;
					case 93:
						goto IL_04cd;
					case 94:
						goto IL_04e8;
					case 96:
						goto IL_050f;
					case 97:
						goto IL_0514;
					case 95:
					case 98:
					case 99:
						goto end_IL_0001_3;
					default:
						goto end_IL_0001;
					case 26:
					case 43:
					case 56:
					case 84:
					case 92:
					case 100:
						goto end_IL_0001_2;
					}
					goto default;
					IL_04cd:
					num = 93;
					if (Information.Err().Number == 3051)
					{
						goto IL_04e8;
					}
					goto IL_050f;
					IL_04e8:
					num = 94;
					Interaction.MsgBox((object)("The assessment you tried to open is in a Read-only database. ChemSTEER requires that the database be updateable.\r\rPlease remove the Read-only attribute by right clicking on the database " + Globals_Renamed.gblDBName + " in Windows Explorer and select Properties, then Attributes, and click the Read-only Attribute to remove the Read-only check mark.  Note that it may be necessary to move the database to an updateable media (e.g., local hard drive or network drive); files located on CD-R media are Read-only by definition and are not updateable."), (MsgBoxStyle)64, (object)"Invalid Request");
					break;
					IL_050f:
					num = 96;
					goto IL_0514;
					IL_0514:
					num = 97;
					Eobject = ((Control)this).Name;
					Efunction = "mnuFileOpen_Click";
					val = Information.Err();
					Enumber = val.Number;
					val2 = Information.Err();
					Edescription = val2.Description;
					Econtact = true;
					Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
					val2.Description = Edescription;
					val.Number = Enumber;
					((Control)this).Name = Eobject;
					break;
					IL_0023:
					num = 2;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					goto IL_002e;
					IL_002e:
					num = 3;
					if (Operators.CompareString(Globals_Renamed.gblDBName, "", false) != 0)
					{
						goto IL_004d;
					}
					goto IL_005c;
					IL_004d:
					num = 4;
					Common.DataConn.Close();
					goto IL_005c;
					IL_005c:
					num = 6;
					Globals_Renamed.gblDBName = "";
					goto IL_0069;
					IL_0069:
					num = 7;
					Globals_Renamed.gblAssessID = 0;
					goto IL_0072;
					IL_0072:
					num = 8;
					Globals_Renamed.intNumOps = 0;
					goto IL_007b;
					IL_007b:
					num = 9;
					val3 = new OpenFileDialog();
					goto IL_0085;
					IL_0085:
					num = 10;
					val4 = val3;
					goto IL_008c;
					IL_008c:
					num = 11;
					((FileDialog)val4).Title = "Select the ChemSTEER database you wish to open";
					goto IL_009d;
					IL_009d:
					num = 12;
					((FileDialog)val4).DefaultExt = "MDB";
					goto IL_00ae;
					IL_00ae:
					num = 13;
					setting = Interaction.GetSetting("ChemSteer", "Options", "DefaultDBN", "");
					goto IL_00cc;
					IL_00cc:
					num = 14;
					if (Strings.Len(setting) > 0)
					{
						goto IL_00df;
					}
					goto IL_00ee;
					IL_00df:
					num = 15;
					((FileDialog)val4).FileName = setting;
					goto IL_0105;
					IL_00ee:
					num = 17;
					goto IL_00f3;
					IL_00f3:
					num = 18;
					((FileDialog)val4).FileName = "*.mdb";
					goto IL_0105;
					IL_0105:
					num = 20;
					((FileDialog)val4).DefaultExt = "*.mdb";
					goto IL_0116;
					IL_0116:
					num = 21;
					((FileDialog)val4).Filter = "Access Databases (*.MDB)|*.MDB";
					goto IL_0127;
					IL_0127:
					val4 = null;
					goto IL_012a;
					IL_012a:
					num = 23;
					obj = ((Form)this).DialogResult;
					goto IL_013a;
					IL_013a:
					num = 24;
					obj = ((CommonDialog)val3).ShowDialog();
					goto IL_014a;
					IL_014a:
					num = 25;
					if (Operators.ConditionalCompareObjectNotEqual(obj, (object)(DialogResult)1, false))
					{
						goto end_IL_0001_2;
					}
					goto IL_0168;
					IL_0168:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_0170;
					IL_0170:
					num = 29;
					Globals_Renamed.gblDBName = ((FileDialog)val3).FileName;
					goto IL_017f;
					IL_017f:
					num = 30;
					Common.DataConn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Globals_Renamed.gblDBName;
					goto IL_019d;
					IL_019d:
					num = 31;
					Common.DataConn.Open();
					goto IL_01bc;
					IL_01bc:
					num = 32;
					recordset.Open("SELECT * FROM qryOpen", Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_01d4;
					IL_01d4:
					num = 33;
					if (!recordset.EOF)
					{
						goto IL_01e7;
					}
					goto IL_01fe;
					IL_01e7:
					num = 34;
					recordset.MoveLast();
					goto IL_01f2;
					IL_01f2:
					num = 35;
					recordset.MoveFirst();
					goto IL_01fe;
					IL_01fe:
					num = 37;
					switch (recordset.RecordCount)
					{
					case 0:
						break;
					case 1:
						goto IL_0249;
					default:
						goto IL_0270;
					}
					goto IL_021d;
					IL_0270:
					num = 49;
					defInstance = frmMDSelAss.DefInstance;
					pRS = recordset;
					Eobject = "O";
					if (defInstance.SetUp(pRS, ref Eobject))
					{
						goto IL_028e;
					}
					goto IL_029f;
					IL_028e:
					num = 50;
					((Form)frmMDSelAss.DefInstance).ShowDialog();
					goto IL_02b4;
					IL_029f:
					num = 52;
					goto IL_02a4;
					IL_02a4:
					num = 53;
					((Form)frmMDSelAss.DefInstance).Close();
					goto IL_02b4;
					IL_02b4:
					num = 55;
					if (Globals_Renamed.gblAssessID == 0)
					{
						goto end_IL_0001_2;
					}
					goto IL_02ce;
					IL_0249:
					num = 46;
					Globals_Renamed.gblAssessID = Conversions.ToShort(recordset.Fields[0].Value);
					goto IL_02ce;
					IL_02ce:
					num = 59;
					Cursor.Current = Cursors.WaitCursor;
					goto IL_02dd;
					IL_02dd:
					num = 60;
					recordset.Close();
					goto IL_02e8;
					IL_02e8:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_02f1;
					IL_02f1:
					num = 62;
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_0314;
					IL_0314:
					num = 63;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					goto IL_0320;
					IL_0320:
					num = 64;
					recordset.Open("SELECT dataVersion, crVersion, crDate FROM Tron", Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_0338;
					IL_0338:
					num = 65;
					if ((Information.Err().Number > 0) | recordset.EOF)
					{
						goto IL_0356;
					}
					goto IL_0396;
					IL_0356:
					num = 66;
					Interaction.MsgBox((object)"Database error, the Tron table is missing or invalid. If you are using a database created with the May23rd version of ChemSTEER, you may ignore this message. Otherwise, please contact Technical Support.\r\rIf you continue to use this assessment you MUST do a Save As instead of a Save operation.", (MsgBoxStyle)16, (object)"Critical Database Error");
					goto IL_036c;
					IL_036c:
					num = 67;
					Globals_Renamed.gblDataVersion = 1;
					goto IL_0376;
					IL_0376:
					num = 68;
					mnuFileSave.Enabled = false;
					goto IL_0387;
					IL_0387:
					num = 69;
					Globals_Renamed.gblIWasChanged = true;
					goto IL_048f;
					IL_0396:
					num = 71;
					goto IL_039b;
					IL_039b:
					num = 72;
					mnuFileSave.Enabled = true;
					goto IL_03ac;
					IL_03ac:
					num = 73;
					Globals_Renamed.gblDataVersion = Conversions.ToShort(recordset.Fields["dataVersion"].Value);
					goto IL_03cf;
					IL_03cf:
					num = 74;
					mnuFileRevHistory.Enabled = true;
					goto IL_03e0;
					IL_03e0:
					num = 75;
					if (Globals_Renamed.gblDataVersion < Globals_Renamed.gblCurrentDV)
					{
						goto IL_03f6;
					}
					goto IL_0405;
					IL_03f6:
					num = 76;
					Globals_Renamed.gblIWasChanged = true;
					goto IL_048f;
					IL_0405:
					num = 78;
					if (Globals_Renamed.gblDataVersion > Globals_Renamed.gblCurrentDV)
					{
						goto IL_041b;
					}
					goto IL_048f;
					IL_041b:
					num = 79;
					Interaction.MsgBox(Operators.ConcatenateObject(Operators.ConcatenateObject((object)"You have opened an assessment that was created in the ", recordset.Fields[2].Value), (object)" version of ChemSTEER. This is not permitted. Please use the later version of ChemSTEER to open this assessment"), (MsgBoxStyle)64, (object)"Version Error");
					goto IL_0456;
					IL_0456:
					num = 80;
					Globals_Renamed.gblDBName = "";
					goto IL_0464;
					IL_0464:
					num = 81;
					Globals_Renamed.gblAssessID = 0;
					goto IL_046e;
					IL_046e:
					num = 82;
					Globals_Renamed.intNumOps = 0;
					goto IL_0478;
					IL_0478:
					num = 83;
					Cursor.Current = Cursors.Default;
					goto end_IL_0001_2;
					IL_048f:
					num = 87;
					recordset.Close();
					goto IL_049a;
					IL_049a:
					ProjectData.ClearProjectError();
					num3 = 0;
					goto IL_04a2;
					IL_04a2:
					num = 89;
					DBFuncs.OpenDB();
					goto IL_04ac;
					IL_04ac:
					num = 90;
					Globals_Renamed.gblDoEasyModels = false;
					goto IL_04b6;
					end_IL_0001_3:
					break;
				}
				num = 99;
				mnuFileRevHistory.Enabled = false;
				break;
				end_IL_0001:;
			}
			catch (object obj2) when (obj2 is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 1844;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuFileClose_Click(object eventSender, EventArgs eventArgs)
	{
		mnuFileNew_Click(mnuFileNew, new EventArgs());
	}

	public void mnuFileRevHistory_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (frmMDRevisionHistory.DefInstance.SetUp())
		{
			((Form)frmMDRevisionHistory.DefInstance).ShowDialog();
		}
		else
		{
			((Form)frmMDRevisionHistory.DefInstance).Close();
		}
	}

	public void mnuFileSave_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0097: Unknown result type (might be due to invalid IL or missing references)
		//IL_009d: Invalid comparison between Unknown and I4
		//IL_00f4: Unknown result type (might be due to invalid IL or missing references)
		//IL_00fa: Invalid comparison between Unknown and I4
		//IL_0171: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					ProjectData.ClearProjectError();
					num2 = 2;
					if (!ChemStrX.chkModelsRun())
					{
						goto end_IL_0001;
					}
					Cursor.Current = Cursors.WaitCursor;
					if (Operators.CompareString(Globals_Renamed.gblDBName, "", false) == 0)
					{
						mnuFileSaveAs_Click(mnuFileSaveAs, new EventArgs());
					}
					else
					{
						if (DBFuncs.AssessmentIdentifiersChanged() && (int)Interaction.MsgBox((object)"You have changed an identifying field since your last save, Save will overwrite your existing assessment.  If you wish to create a new assessment, you should Cancel and use Save As.", (MsgBoxStyle)33, (object)"Confirm Save") == 2)
						{
							Cursor.Current = Cursors.Default;
							goto end_IL_0001;
						}
						short num3 = DBFuncs.DupAssessmentCheck();
						if ((num3 != -1) & (num3 != Globals_Renamed.gblAssessID))
						{
							Interaction.Beep();
							Cursor.Current = Cursors.Default;
							if ((int)Interaction.MsgBox((object)"A duplicate assessment exists in the database. Do you want to replace the existing assessment with the current assessment? If not, you must change at least one Identifying Field.", (MsgBoxStyle)36, (object)"Duplicate Assessment") == 7)
							{
								goto end_IL_0001;
							}
							recordset.Open("SELECT * FROM OpNaics WHERE AssessID=" + Conversions.ToString((int)Globals_Renamed.gblAssessID), Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
							recordset.Delete();
							recordset.Close();
							Globals_Renamed.gblAssessID = num3;
						}
						if (Globals_Renamed.gblDataVersion < Globals_Renamed.gblCurrentDV)
						{
							Interaction.Beep();
							Cursor.Current = Cursors.Default;
							Interaction.MsgBox((object)"The assessment database is in an older format. Please do a Save Assessment As.", (MsgBoxStyle)64, (object)"Invalid Request");
							goto end_IL_0001;
						}
						DBFuncs.SaveDB();
						Globals_Renamed.gblDoEasyModels = false;
					}
					Cursor.Current = Cursors.Default;
					goto end_IL_0001;
				}
				case 509:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "mnuFileSave_Click";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 509;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
	public void mnuFileSaveAs_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_004b: Unknown result type (might be due to invalid IL or missing references)
		//IL_0051: Expected O, but got Unknown
		//IL_00bc: Unknown result type (might be due to invalid IL or missing references)
		//IL_00c2: Invalid comparison between Unknown and I4
		//IL_00f8: Unknown result type (might be due to invalid IL or missing references)
		//IL_0270: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d3: Unknown result type (might be due to invalid IL or missing references)
		//IL_02d9: Invalid comparison between Unknown and I4
		int try0001_dispatch = -1;
		int num = default(int);
		Recordset recordset = default(Recordset);
		int num2 = default(int);
		int num3 = default(int);
		SaveFileDialog val2 = default(SaveFileDialog);
		SaveFileDialog val3 = default(SaveFileDialog);
		int num5 = default(int);
		Command command = default(Command);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				int num4;
				Guid clsid;
				Command command2;
				object RecordsAffected;
				object Parameters;
				string Edescription;
				string Efunction;
				ErrObject val;
				int Enumber;
				string Eobject;
				bool Econtact;
				switch (try0001_dispatch)
				{
				default:
					num = 1;
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_0023;
				case 1616:
					{
						num2 = num;
						switch ((num3 <= -2) ? 1 : num3)
						{
						case 2:
							break;
						case 1:
							goto IL_050a;
						default:
							goto end_IL_0001;
						}
						goto IL_041c;
					}
					IL_03ea:
					num = 68;
					lblAssessmentVersion.Text = lblCurrentVersion.Text;
					goto IL_0405;
					IL_0405:
					num = 69;
					Cursor.Current = Cursors.Default;
					goto end_IL_0001_2;
					IL_03e0:
					num = 67;
					Globals_Renamed.gblDoEasyModels = false;
					goto IL_03ea;
					IL_050a:
					num4 = num2 + 1;
					num2 = 0;
					switch (num4)
					{
					case 1:
						break;
					case 2:
						goto IL_0023;
					case 3:
						goto IL_002e;
					case 5:
					case 6:
						goto IL_0048;
					case 7:
						goto IL_0051;
					case 8:
						goto IL_0057;
					case 9:
						goto IL_0067;
					case 10:
						goto IL_0078;
					case 11:
						goto IL_0089;
					case 12:
						goto IL_009a;
					case 13:
						goto IL_00a7;
					case 14:
						goto IL_00b4;
					case 15:
						goto IL_00b7;
					case 16:
						goto IL_00cd;
					case 17:
						goto IL_00e8;
					case 20:
					case 21:
						goto IL_0106;
					case 22:
						goto IL_0115;
					case 23:
						goto IL_0126;
					case 24:
						goto IL_0135;
					case 25:
						goto IL_014c;
					case 26:
						goto IL_015b;
					case 27:
					case 28:
						goto IL_0170;
					case 29:
						goto IL_017e;
					case 30:
						goto IL_018d;
					case 31:
						goto IL_0197;
					case 32:
						goto IL_01a0;
					case 33:
						goto IL_01b0;
					case 34:
						goto IL_01c1;
					case 35:
						goto IL_01df;
					case 36:
						goto IL_01fe;
					case 37:
						goto IL_0216;
					case 38:
						goto IL_0236;
					case 39:
						goto IL_0241;
					case 40:
						goto IL_0256;
					case 41:
						goto IL_0260;
					case 42:
						goto IL_0276;
					case 44:
					case 45:
						goto IL_028c;
					case 46:
						goto IL_0296;
					case 47:
						goto IL_02aa;
					case 48:
						goto IL_02b4;
					case 49:
						goto IL_02c3;
					case 51:
					case 52:
						goto IL_02e8;
					case 53:
						goto IL_030b;
					case 54:
						goto IL_031b;
					case 55:
						goto IL_0336;
					case 56:
						goto IL_0342;
					case 57:
					case 58:
						goto IL_0361;
					case 60:
						goto IL_036d;
					case 61:
						goto IL_0372;
					case 62:
						goto IL_037a;
					case 63:
						goto IL_0398;
					case 64:
						goto IL_03b6;
					case 59:
					case 65:
					case 66:
						goto IL_03d6;
					case 67:
						goto IL_03e0;
					case 68:
						goto IL_03ea;
					case 69:
						goto IL_0405;
					case 71:
						goto IL_041c;
					case 72:
						goto IL_0437;
					case 74:
						goto IL_0498;
					case 75:
						goto end_IL_0001_3;
					default:
						goto end_IL_0001;
					case 4:
					case 18:
					case 19:
					case 43:
					case 50:
					case 70:
					case 73:
					case 76:
					case 77:
						goto end_IL_0001_2;
					}
					goto default;
					IL_041c:
					num = 71;
					if (Information.Err().Number == 3026)
					{
						goto IL_0437;
					}
					goto IL_0498;
					IL_0437:
					num = 72;
					Eobject = ((Control)this).Name;
					Efunction = "mnuFileSaveAs_Click";
					val = Information.Err();
					Enumber = val.Number;
					Edescription = Information.Err().Description + "\r\rYour assessment has not been successfully saved. Please select another disk to save your assessment to.";
					Econtact = false;
					Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
					val.Number = Enumber;
					((Control)this).Name = Eobject;
					goto end_IL_0001_2;
					IL_0498:
					num = 74;
					break;
					IL_0023:
					num = 2;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					goto IL_002e;
					IL_002e:
					num = 3;
					if (!ChemStrX.chkModelsRun())
					{
						goto end_IL_0001_2;
					}
					goto IL_0048;
					IL_0048:
					num = 6;
					val2 = new SaveFileDialog();
					goto IL_0051;
					IL_0051:
					num = 7;
					val3 = val2;
					goto IL_0057;
					IL_0057:
					num = 8;
					((FileDialog)val3).Title = "Select a folder and name for your ChemSTEER database";
					goto IL_0067;
					IL_0067:
					num = 9;
					((FileDialog)val3).DefaultExt = "MDB";
					goto IL_0078;
					IL_0078:
					num = 10;
					((FileDialog)val3).FileName = DBFuncs.CreateDefaultFileName();
					goto IL_0089;
					IL_0089:
					num = 11;
					((FileDialog)val3).Filter = "Access Databases (*.MDB)|*.MDB";
					goto IL_009a;
					IL_009a:
					num = 12;
					((FileDialog)val3).CheckFileExists = false;
					goto IL_00a7;
					IL_00a7:
					num = 13;
					val3.OverwritePrompt = false;
					goto IL_00b4;
					IL_00b4:
					val3 = null;
					goto IL_00b7;
					IL_00b7:
					num = 15;
					if ((int)((CommonDialog)val2).ShowDialog() != 1)
					{
						goto IL_00cd;
					}
					goto IL_0106;
					IL_00cd:
					num = 16;
					if (Information.Err().Number != 20477)
					{
						goto end_IL_0001_2;
					}
					goto IL_00e8;
					IL_00e8:
					num = 17;
					Interaction.MsgBox((object)"An error occurred while attempting to save the assessment with the Save As option. If you entered a colon as part of the Assessment Identifier, please remove it. Please try the Save As option again with a different Assessment Identifier. If you feel you receive this error by mistake, please contact Technical Support.", (MsgBoxStyle)64, (object)"Invalid File Name");
					goto end_IL_0001_2;
					IL_0106:
					num = 21;
					Cursor.Current = Cursors.WaitCursor;
					goto IL_0115;
					IL_0115:
					num = 22;
					mnuFileSave.Enabled = true;
					goto IL_0126;
					IL_0126:
					num = 23;
					Globals_Renamed.gblDBName = ((FileDialog)val2).FileName;
					goto IL_0135;
					IL_0135:
					num = 24;
					if (Common.DataConn.State == 1)
					{
						goto IL_014c;
					}
					goto IL_0170;
					IL_014c:
					num = 25;
					Common.DataConn.Close();
					goto IL_015b;
					IL_015b:
					num = 26;
					Common.DataConn.ConnectionString = "";
					goto IL_0170;
					IL_0170:
					num = 28;
					Globals_Renamed.gblDataVersion = Globals_Renamed.gblCurrentDV;
					goto IL_017e;
					IL_017e:
					num = 29;
					Cursor.Current = Cursors.WaitCursor;
					goto IL_018d;
					IL_018d:
					num = 30;
					Application.DoEvents();
					goto IL_0197;
					IL_0197:
					ProjectData.ClearProjectError();
					num3 = -2;
					goto IL_01a0;
					IL_01a0:
					num = 32;
					num5 = checked((int)FileSystem.FileLen(Globals_Renamed.gblDBName));
					goto IL_01b0;
					IL_01b0:
					num = 33;
					if (num5 > 0)
					{
						goto IL_01c1;
					}
					goto IL_036d;
					IL_01c1:
					num = 34;
					Common.DataConn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Globals_Renamed.gblDBName;
					goto IL_01df;
					IL_01df:
					num = 35;
					Common.DataConn.Open();
					goto IL_01fe;
					IL_01fe:
					num = 36;
					recordset.Open("SELECT dataVersion FROM Tron", Common.DataConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					goto IL_0216;
					IL_0216:
					num = 37;
					num5 = Conversions.ToInteger(recordset.Fields[0].Value);
					goto IL_0236;
					IL_0236:
					num = 38;
					recordset.Close();
					goto IL_0241;
					IL_0241:
					num = 39;
					if (num5 != Globals_Renamed.gblDataVersion)
					{
						goto IL_0256;
					}
					goto IL_028c;
					IL_0256:
					num = 40;
					Interaction.Beep();
					goto IL_0260;
					IL_0260:
					num = 41;
					Interaction.MsgBox((object)"You are trying to perform a Save Assessment As into an older version of a ChemSTEER database. This is not permitted. Please try again and select a new, unique database name.", (MsgBoxStyle)64, (object)"Invalid Request");
					goto IL_0276;
					IL_0276:
					num = 42;
					Cursor.Current = Cursors.Default;
					goto end_IL_0001_2;
					IL_028c:
					num = 45;
					num5 = DBFuncs.DupAssessmentCheck();
					goto IL_0296;
					IL_0296:
					num = 46;
					if (num5 != -1)
					{
						goto IL_02aa;
					}
					goto IL_0361;
					IL_02aa:
					num = 47;
					Interaction.Beep();
					goto IL_02b4;
					IL_02b4:
					num = 48;
					Cursor.Current = Cursors.Default;
					goto IL_02c3;
					IL_02c3:
					num = 49;
					if ((int)Interaction.MsgBox((object)"A duplicate assessment exists in the database. Do you want to replace the existing assessment with the current assessment? If not, you must change at least one Identifying Field.", (MsgBoxStyle)36, (object)"Duplicate Assessment") == 7)
					{
						goto end_IL_0001_2;
					}
					goto IL_02e8;
					IL_02e8:
					num = 52;
					clsid = new Guid("00000507-0000-0010-8000-00AA006D2EA4");
					command = (Command)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					goto IL_030b;
					IL_030b:
					num = 53;
					command.ActiveConnection = Common.DataConn;
					goto IL_031b;
					IL_031b:
					num = 54;
					command.CommandText = "DELETE * FROM Assessments WHERE AssessID=" + Conversions.ToString(num5);
					goto IL_0336;
					IL_0336:
					num = 55;
					command.CommandType = CommandTypeEnum.adCmdText;
					goto IL_0342;
					IL_0342:
					num = 56;
					command2 = command;
					RecordsAffected = Missing.Value;
					Parameters = Missing.Value;
					command2.Execute(out RecordsAffected, ref Parameters);
					goto IL_0361;
					IL_0361:
					num = 58;
					Globals_Renamed.gblAssessID = 0;
					goto IL_03d6;
					IL_036d:
					num = 60;
					goto IL_0372;
					IL_0372:
					ProjectData.ClearProjectError();
					num3 = 2;
					goto IL_037a;
					IL_037a:
					num = 62;
					FileSystem.FileCopy(Application.StartupPath + "\\MDBShell.epa", Globals_Renamed.gblDBName);
					goto IL_0398;
					IL_0398:
					num = 63;
					Common.DataConn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Globals_Renamed.gblDBName;
					goto IL_03b6;
					IL_03b6:
					num = 64;
					Common.DataConn.Open();
					goto IL_03d6;
					IL_03d6:
					num = 66;
					DBFuncs.SaveDB();
					goto IL_03e0;
					end_IL_0001_3:
					break;
				}
				num = 75;
				Edescription = ((Control)this).Name;
				Efunction = "mnuFileSaveAs_Click";
				val = Information.Err();
				Enumber = val.Number;
				ErrObject val4 = Information.Err();
				Eobject = val4.Description;
				Econtact = true;
				Common.CommonErrHandler(ref Edescription, ref Efunction, ref Enumber, ref Eobject, ref Econtact);
				val4.Description = Eobject;
				val.Number = Enumber;
				((Control)this).Name = Edescription;
				break;
				end_IL_0001:;
			}
			catch (object obj) when (obj is Exception && num3 != 0 && num2 == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 1616;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001_2:
			break;
		}
		if (num2 != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuFileViewCRSS_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_00c1: Unknown result type (might be due to invalid IL or missing references)
		//IL_0274: Unknown result type (might be due to invalid IL or missing references)
		//IL_0151: Unknown result type (might be due to invalid IL or missing references)
		//IL_0185: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		string setting = default(string);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					Guid clsid = new Guid("00000514-0000-0010-8000-00AA006D2EA4");
					Connection connection = (Connection)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
					Recordset recordset2 = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
					ProjectData.ClearProjectError();
					num2 = 2;
					recordset.CursorLocation = CursorLocationEnum.adUseClient;
					recordset2.CursorLocation = CursorLocationEnum.adUseClient;
					setting = Interaction.GetSetting("ChemSteer", "Options", "DefaultCRSSDBN", "");
					if ((Operators.CompareString(setting, "", false) == 0) | (Operators.CompareString(setting, "None Specified", false) == 0))
					{
						Interaction.MsgBox((object)"A default CRSS database has not been specified. Please go to Preferences, Specify CRSS Database and select a default database.", (MsgBoxStyle)64, (object)"CRSS Database not Specified");
						goto end_IL_0001;
					}
					connection.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + setting;
					connection.Open();
					recordset.Open("SELECT * FROM Chemsteer", connection, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
					if (!recordset.EOF)
					{
						recordset.MoveLast();
						recordset.MoveFirst();
					}
					if (recordset.RecordCount == 0)
					{
						sCRSSid = "";
						Interaction.MsgBox((object)"The database you selected does not have any CRSS reports.  Please select another database.", (MsgBoxStyle)64, (object)"Invalid Database");
						goto end_IL_0001;
					}
					frmMDSelAss defInstance = frmMDSelAss.DefInstance;
					Recordset pRS = recordset;
					string Eobject = "V";
					if (defInstance.SetUp(pRS, ref Eobject))
					{
						((Form)frmMDSelAss.DefInstance).ShowDialog();
						if (Operators.ConditionalCompareObjectEqual(((Control)frmMDSelAss.DefInstance).Tag, (object)"", false))
						{
							if (Operators.CompareString(sCRSSid, "", false) == 0)
							{
								((Form)frmViewCRSS.DefInstance).Close();
							}
							else if (frmViewCRSS.DefInstance.SetUp(connection, ref sCRSSid))
							{
								((Control)frmViewCRSS.DefInstance).Show();
							}
							else
							{
								((Form)frmViewCRSS.DefInstance).Close();
							}
						}
						else
						{
							((Form)frmMDSelAss.DefInstance).Close();
						}
					}
					else
					{
						((Form)frmMDSelAss.DefInstance).Close();
					}
					recordset.Close();
					recordset = null;
					connection.Close();
					connection = null;
					goto end_IL_0001;
				}
				case 787:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						if (((0u - ((Information.Err().Number == 3024) ? 1u : 0u)) | 0xBE3u) != 0)
						{
							Interaction.MsgBox((object)("The default CRSS database (" + setting + ") no longer exists. Please go to Preferences, Specify CRSS Database and select a default database."), (MsgBoxStyle)64, (object)"CRSS Database No Longer Exists");
							Interaction.SaveSetting("ChemSteer", "Options", "DefaultCRSSPath", "J:/process/initchem/");
							Interaction.SaveSetting("ChemSteer", "Options", "DefaultCRSSDBN", "");
							goto end_IL_0001;
						}
						string Eobject = ((Control)this).Name;
						string Efunction = "mnuFileViewCRSS_Click";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 787;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuHelpAbout_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0018: Unknown result type (might be due to invalid IL or missing references)
		frmSplash defInstance = frmSplash.DefInstance;
		short iWhatAmIDoing = 1;
		if (defInstance.SetUp(ref iWhatAmIDoing))
		{
			((Form)frmSplash.DefInstance).ShowDialog();
		}
		else
		{
			((Form)frmSplash.DefInstance).Close();
		}
	}

	public void mnuHelpViewUserGuide_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					Process.Start(Application.StartupPath + "/help/chemsteer.pdf");
					goto end_IL_0001;
				case 54:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox((object)"There was a problem displaying the ChemSTEER User Guide. Please verify that you have Adobe's PDF Reader software installed on your computer.", (MsgBoxStyle)64, (object)"Error Viewing ChemSTEER User Guide");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 54;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuHelpViewQuickStartGuide_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_002e: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					Process.Start(Application.StartupPath + "/help/chemsteer_quick_start_guide.pdf");
					goto end_IL_0001;
				case 54:
					num = -1;
					switch (num2)
					{
					case 2:
						Interaction.MsgBox((object)"There was a problem displaying the ChemSTEER Quick Start Guide. Please verify that you have Adobe's PDF Reader software installed on your computer.", (MsgBoxStyle)64, (object)"Error Viewing ChemSTEER Quick Start Guide");
						goto end_IL_0001;
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 54;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuPreferences_Click(object eventSender, EventArgs eventArgs)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		short iWhatAmIDoing = mnuPreferences.GetIndex((MenuItem)eventSender);
		if (frmMDPrefs.DefInstance.SetUp(ref iWhatAmIDoing))
		{
			((Form)frmMDPrefs.DefInstance).ShowDialog();
		}
		else
		{
			((Form)frmMDPrefs.DefInstance).Close();
		}
	}

	public void mnuReportIRER0_Click(object eventSender, EventArgs eventArgs)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					Cursor.Current = Cursors.WaitCursor;
					crDriver.doIrerRpt(this, 0);
					Cursor.Current = Cursors.Default;
					goto end_IL_0001;
				case 147:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						Cursor.Current = Cursors.Default;
						string Eobject = ((Control)this).Name;
						string Efunction = "_mnuReportIRER_0_Click";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 147;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuReportIRER1_Click(object eventSender, EventArgs eventArgs)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					Cursor.Current = Cursors.WaitCursor;
					crDriver.doIrerRpt(this, 1);
					Cursor.Current = Cursors.Default;
					goto end_IL_0001;
				case 147:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						Cursor.Current = Cursors.Default;
						string Eobject = ((Control)this).Name;
						string Efunction = "_mnuReportIRER_1_Click";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 147;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuReportCR0_Click(object eventSender, EventArgs eventArgs)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					Cursor.Current = Cursors.WaitCursor;
					crDriver.doContRpt(0);
					Cursor.Current = Cursors.Default;
					goto end_IL_0001;
				case 146:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						Cursor.Current = Cursors.Default;
						string Eobject = ((Control)this).Name;
						string Efunction = "_mnuRptCR_0.Click";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 146;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuReportCR1_Click(object eventSender, EventArgs eventArgs)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					crDriver.doContRpt(1);
					Cursor.Current = Cursors.Default;
					goto end_IL_0001;
				case 124:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "_mnuRptCR_1.Click";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 124;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuReportIRERandCR2_Click(object eventSender, EventArgs eventArgs)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					crDriver.doIrerRpt(this, 2);
					Cursor.Current = Cursors.Default;
					goto end_IL_0001;
				case 125:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "_mnuReportIRER_2.Click";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 125;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	public void mnuReportIRERandCR_Click(object eventSender, EventArgs eventArgs)
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					crDriver.doIrerRpt(this, 3);
					Cursor.Current = Cursors.Default;
					goto end_IL_0001;
				case 125:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "_mnuReportIRER_3.Click";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 125;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void msfCont_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		//IL_0002: Unknown result type (might be due to invalid IL or missing references)
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		//IL_0022: Unknown result type (might be due to invalid IL or missing references)
		//IL_0028: Unknown result type (might be due to invalid IL or missing references)
		if (Versioned.IsNumeric((object)((AxMSFlexGrid)eventSender)[((AxMSFlexGrid)eventSender).Row, 0]))
		{
			Globals_Renamed.intActIndex = Conversions.ToShort(((AxMSFlexGrid)eventSender)[((AxMSFlexGrid)eventSender).Row, 0]);
		}
	}

	private void msfCont_DblClick(object eventSender, EventArgs eventArgs)
	{
		//IL_0003: Unknown result type (might be due to invalid IL or missing references)
		//IL_0012: Expected O, but got Unknown
		msfCont_ClickEvent((object)(AxMSFlexGrid)eventSender, new EventArgs());
		cmdUpdOpIP_Click(cmdUpdOpIP, new EventArgs());
	}

	private void msfSP_DblClick(object eventSender, EventArgs eventArgs)
	{
		//IL_00ad: Unknown result type (might be due to invalid IL or missing references)
		//IL_0360: Unknown result type (might be due to invalid IL or missing references)
		//IL_017f: Unknown result type (might be due to invalid IL or missing references)
		//IL_0427: Unknown result type (might be due to invalid IL or missing references)
		//IL_03c3: Unknown result type (might be due to invalid IL or missing references)
		//IL_01cc: Unknown result type (might be due to invalid IL or missing references)
		if (!Versioned.IsNumeric((object)msfSP[msfSP.Row, 0]))
		{
			return;
		}
		checked
		{
			Globals_Renamed.intOpIndex = (short)Support.GetItemData((Control)(object)_lstSelOps_0, _lstSelOps_0.SelectedIndex);
			switch (msfSP[msfSP.Row, 1])
			{
			case "Automotive Spray Coating Model Factors":
			{
				frmUpdSP defInstance3 = frmUpdSP.DefInstance;
				short pID = 1;
				short pWhatAmIDoing = Conversions.ToShort(msfSP[msfSP.Row, 0]);
				if (defInstance3.SetUp(ref pID, ref pWhatAmIDoing))
				{
					((Form)frmUpdSP.DefInstance).ShowDialog();
					if (Operators.ConditionalCompareObjectNotEqual(((Control)frmUpdSP.DefInstance).Tag, (object)(-1), false))
					{
						Globals_Renamed.gblIWasChanged = true;
						LoadMsfOpSP();
						cmbRelOps.SelectedIndex = -1;
						cmbExpOps.SelectedIndex = -1;
					}
				}
				((Form)frmUpdSP.DefInstance).Close();
				break;
			}
			case "Vapor Model Factors":
				switch (Conversions.ToShort(msfSP[msfSP.Row, 0]))
				{
				case 121:
				case 122:
					Interaction.MsgBox((object)("You cannot directly change the " + msfSP[msfSP.Row, 2] + "."), (MsgBoxStyle)64, (object)null);
					break;
				default:
				{
					frmUpdSP defInstance2 = frmUpdSP.DefInstance;
					short pWhatAmIDoing = 2;
					short pID = Conversions.ToShort(msfSP[msfSP.Row, 0]);
					if (defInstance2.SetUp(ref pWhatAmIDoing, ref pID))
					{
						((Form)frmUpdSP.DefInstance).ShowDialog();
						if (Operators.ConditionalCompareObjectNotEqual(((Control)frmUpdSP.DefInstance).Tag, (object)(-1), false))
						{
							Globals_Renamed.gblIWasChanged = true;
							if (Conversions.ToShort(msfSP[msfSP.Row, 0]) == 118 && Globals_Renamed.arOpParmsType[119, Globals_Renamed.intOpIndex] == 1)
							{
								Globals_Renamed.arOpParms[119, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[118, Globals_Renamed.intOpIndex];
								Globals_Renamed.arOpParms[122, Globals_Renamed.intOpIndex] = Globals_Renamed.arOpParms[121, Globals_Renamed.intOpIndex];
								((Control)this).Tag = _lstSelOps_1.SelectedIndex;
								_lstSelOps_1.SelectedIndex = -1;
								_lstSelOps_1.SelectedIndex = Conversions.ToInteger(((Control)this).Tag);
							}
							ChemStrX.RollXprodSideways(ref Globals_Renamed.intOpIndex, ref Globals_Renamed.arOpParms[119, Globals_Renamed.intOpIndex]);
							short num = (short)(Globals_Renamed.intNumOps - 1);
							short pOpIndex = 0;
							while (true)
							{
								short num2 = pOpIndex;
								short num3 = num;
								if (num2 > num3)
								{
									break;
								}
								ChemStrX.SetVolatilityFlag(ref pOpIndex);
								object pOpIndex2 = pOpIndex;
								ChemStrX.resetInhRespClass(ref pOpIndex2);
								pOpIndex = Conversions.ToShort(pOpIndex2);
								pOpIndex = (short)unchecked(pOpIndex + 1);
							}
							cmbRelOps.SelectedIndex = -1;
							cmbExpOps.SelectedIndex = -1;
						}
					}
					((Form)frmUpdSP.DefInstance).Close();
					break;
				}
				}
				break;
			case "Recirculating Water-Cooling Tower Additive":
				Interaction.MsgBox((object)"You may change the value of Amt (DRRChem) on the Mass Balance Parameters subtab by clicking on the Calculate button for DMUChem.", (MsgBoxStyle)64, (object)null);
				break;
			case "Electroplating Additive Type":
			{
				frmUpdSP defInstance = frmUpdSP.DefInstance;
				short pWhatAmIDoing = 3;
				short pID = Conversions.ToShort(msfSP[msfSP.Row, 0]);
				if (defInstance.SetUp(ref pWhatAmIDoing, ref pID))
				{
					((Form)frmUpdSP.DefInstance).ShowDialog();
					if (Operators.ConditionalCompareObjectNotEqual(((Control)frmUpdSP.DefInstance).Tag, (object)(-1), false))
					{
						Globals_Renamed.gblIWasChanged = true;
						LoadMsfOpSP();
						cmbRelOps.SelectedIndex = -1;
						cmbExpOps.SelectedIndex = -1;
					}
				}
				((Form)frmUpdSP.DefInstance).Close();
				break;
			}
			default:
				Interaction.MsgBox((object)"Fatal Error in msfSP_Dblclick. Please contact Technical Support.", (MsgBoxStyle)16, (object)null);
				break;
			}
		}
	}

	private void tabConts_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			((Control)fraConts[(short)(MyCurrentContSubTab - 1)]).Visible = false;
			short count = ((ITabs)tabConts.Tabs).Count;
			MyCurrentContSubTab = 1;
			while (true)
			{
				short myCurrentContSubTab = MyCurrentContSubTab;
				short num = count;
				if (myCurrentContSubTab > num)
				{
					break;
				}
				Tabs tabs = tabConts.Tabs;
				object obj = MyCurrentContSubTab;
				if (((ITab)((ITabs)tabs)[ref obj]).Selected)
				{
					break;
				}
				MyCurrentContSubTab = (short)unchecked(MyCurrentContSubTab + 1);
			}
			((Control)fraConts[(short)(MyCurrentContSubTab - 1)]).Visible = true;
		}
	}

	private void tabExp_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			((Control)fraExpTab[(short)(MyCurrentExpTab - 1)]).Visible = false;
			short count = ((ITabs)tabExp.Tabs).Count;
			MyCurrentExpTab = 1;
			while (true)
			{
				short myCurrentExpTab = MyCurrentExpTab;
				short num = count;
				if (myCurrentExpTab > num)
				{
					break;
				}
				Tabs tabs = tabExp.Tabs;
				object obj = MyCurrentExpTab;
				if (((ITab)((ITabs)tabs)[ref obj]).Selected)
				{
					break;
				}
				MyCurrentExpTab = (short)unchecked(MyCurrentExpTab + 1);
			}
			((Control)fraExpTab[(short)(MyCurrentExpTab - 1)]).Visible = true;
			switch (MyCurrentExpTab)
			{
			case 1:
				((Control)cmdViewExpModel).Enabled = true;
				((ButtonBase)cmdViewExpModel).Text = "View/Update Dermal Model &Information";
				((ButtonBase)cmdInhBasis).Text = "&Introductory Notes for the Dermal Summary";
				((Control)cmdInhBasis).Enabled = true;
				break;
			case 2:
				((Control)cmdViewExpModel).Enabled = true;
				((ButtonBase)cmdViewExpModel).Text = "View/Update Inhalation Model &Information";
				((ButtonBase)cmdInhBasis).Text = "&Introductory Notes for the Inhalation Summary";
				((Control)cmdInhBasis).Enabled = true;
				break;
			case 3:
				((Control)cmdViewExpModel).Enabled = false;
				((Control)cmdInhBasis).Enabled = false;
				break;
			case 4:
				((Control)cmdViewExpModel).Enabled = false;
				((Control)cmdInhBasis).Enabled = false;
				break;
			}
		}
	}

	private void switchIPTabs(int selectedTab)
	{
		checked
		{
			((Control)fraIP[(short)(MyCurrentIpTab - 1)]).Visible = false;
			((Control)fraIP[(short)(selectedTab - 1)]).Visible = true;
			MyCurrentIpTab = (short)selectedTab;
			switch (MyCurrentIpTab)
			{
			case 1:
				((Control)cmdUpdOpIP).Visible = true;
				((ButtonBase)cmdMassBalParms).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdContainerParms).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdSharedParms).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdMassBalParms).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdContainerParms).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdSharedParms).ForeColor = Globals_Renamed.gblTextOff;
				((ButtonBase)cmdUpdOpIP).Text = "Update Parameters";
				lblOpParmSubtabs.Text = "Click the \"Update Parameters\" button below to establish the type of operation (batch or continuous) and to specify the general mass balance parameters (number of sites, throughput of chemical, etc.). ";
				lblOpParmSubtabs.Text += "\r\n\r\nNote that these MUST be specified to perform release and exposure estimates.";
				break;
			case 2:
				((ButtonBase)cmdUpdOpIP).Text = "Update Container Parameters";
				PrimeContainerSubTab();
				((ButtonBase)cmdMassBalParms).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdContainerParms).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdSharedParms).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdMassBalParms).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdContainerParms).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdSharedParms).ForeColor = Globals_Renamed.gblTextOff;
				lblOpParmSubtabs.Text = "Select the appropriate subtab below and click the 'Update Container Parameters' to specify the container size, fraction of total volume shipped in each type of container, unloading/loading rate, etc.";
				break;
			case 3:
				((Control)cmdUpdOpIP).Visible = true;
				((ButtonBase)cmdUpdOpIP).Text = "Update Available Shared Parameters/Factors";
				((ButtonBase)cmdMassBalParms).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdContainerParms).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdSharedParms).BackColor = Globals_Renamed.gblColorOn;
				((Control)cmdMassBalParms).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdContainerParms).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdSharedParms).ForeColor = Globals_Renamed.gblTextOn;
				((ButtonBase)cmdUpdAVP).Text = "Update AVP Range";
				lblOpParmSubtabs.Text = "Click the 'Update AVP Range' button below to specify the VP range for which ChemSTEER will automatically include air release or inhalation exposure models.";
				lblOpParmSubtabs.Text += "\r\n\r\nClick the \"Update Available Shared Parameters/Factors\" button below or double click on the row to view/select options for changing the current values.";
				break;
			}
		}
	}

	private void switchRelTabs(int selectedTab)
	{
		if (selectedTab == 1)
		{
			((Control)msfRelParms).Visible = true;
			((Control)msfRelEst).Visible = false;
			((Control)txtRelModelMsg).Visible = true;
			((ButtonBase)cmdRelParms).BackColor = Globals_Renamed.gblColorOn;
			((ButtonBase)cmdEstReleases).BackColor = Globals_Renamed.gblColorOff;
			((Control)cmdRelParms).ForeColor = Globals_Renamed.gblTextOn;
			((Control)cmdEstReleases).ForeColor = Globals_Renamed.gblTextOff;
			lblRel.Text = "Use the buttons below to add, remove, or update release models, or add notes to the release summary. When complete, click the \"Run Model(s)\" button below to generate the results. Results are shown on the Estimated Releases tab (5b).";
		}
		else
		{
			((Control)msfRelParms).Visible = false;
			((Control)msfRelEst).Visible = true;
			((Control)txtRelModelMsg).Visible = false;
			((ButtonBase)cmdRelParms).BackColor = Globals_Renamed.gblColorOff;
			((ButtonBase)cmdEstReleases).BackColor = Globals_Renamed.gblColorOn;
			((Control)cmdRelParms).ForeColor = Globals_Renamed.gblTextOff;
			((Control)cmdEstReleases).ForeColor = Globals_Renamed.gblTextOn;
			lblRel.Text = "Estimated releases for the selected operation and release source are summarized below.";
		}
	}

	private void switchTabs(int selectedTab)
	{
		checked
		{
			if (MyCurrentTab == 8)
			{
				((Control)_fraTab_7).Visible = false;
			}
			else
			{
				((Control)fraTab[(short)(MyCurrentTab - 1)]).Visible = false;
			}
			if (selectedTab == 8)
			{
				((Control)_fraTab_7).Visible = true;
			}
			else
			{
				((Control)_fraTab_7).Visible = false;
				((Control)fraTab[(short)(selectedTab - 1)]).Visible = true;
			}
			MyCurrentTab = (short)selectedTab;
			switch (MyCurrentTab)
			{
			case 1:
				((ButtonBase)cmdGeneral).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdChemical).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOperations).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOpParms).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReleases).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdExposures).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOptionalInfo).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReports).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdGeneral).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdChemical).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOperations).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOpParms).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReleases).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdExposures).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOptionalInfo).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReports).ForeColor = Globals_Renamed.gblTextOff;
				break;
			case 2:
				((ButtonBase)cmdGeneral).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdChemical).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdOperations).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOpParms).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReleases).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdExposures).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOptionalInfo).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReports).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdGeneral).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdChemical).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdOperations).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOpParms).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReleases).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdExposures).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOptionalInfo).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReports).ForeColor = Globals_Renamed.gblTextOff;
				break;
			case 3:
				((ButtonBase)cmdGeneral).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdChemical).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOperations).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdOpParms).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReleases).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdExposures).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOptionalInfo).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReports).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdGeneral).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdChemical).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOperations).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdOpParms).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReleases).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdExposures).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOptionalInfo).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReports).ForeColor = Globals_Renamed.gblTextOff;
				break;
			case 4:
				((ButtonBase)cmdGeneral).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdChemical).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOperations).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOpParms).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdReleases).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdExposures).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOptionalInfo).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReports).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdChemical).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdGeneral).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOperations).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOpParms).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdReleases).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdExposures).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOptionalInfo).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReports).ForeColor = Globals_Renamed.gblTextOff;
				lblOpParmSubtabs.Text = "Click the 'Update Parameters' button below to establish the type of operation (batch or continuous) and to specify the general mass balance parameters (number of sites, throughput of chemical, etc.). ";
				lblOpParmSubtabs.Text += "\r\n\r\nNote that these MUST be specified to perform release and exposure estimates.";
				break;
			case 5:
				((ButtonBase)cmdGeneral).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdChemical).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOperations).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOpParms).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReleases).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdExposures).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOptionalInfo).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReports).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdGeneral).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdChemical).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOperations).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOpParms).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReleases).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdExposures).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOptionalInfo).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReports).ForeColor = Globals_Renamed.gblTextOff;
				if (Globals_Renamed.intNumOps > 0)
				{
					if (cmbExpOps.SelectedIndex > -1)
					{
						cmbRelOps.SelectedIndex = cmbExpOps.SelectedIndex;
					}
					else if (cmbRelOps.SelectedIndex == -1)
					{
						cmbRelOps.SelectedIndex = 0;
					}
				}
				break;
			case 6:
				((ButtonBase)cmdGeneral).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdChemical).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOperations).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOpParms).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReleases).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdExposures).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdOptionalInfo).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReports).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdGeneral).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdChemical).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOperations).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOpParms).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReleases).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdExposures).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdOptionalInfo).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReports).ForeColor = Globals_Renamed.gblTextOff;
				if (Globals_Renamed.intNumOps > 0)
				{
					if (cmbRelOps.SelectedIndex > -1)
					{
						cmbExpOps.SelectedIndex = cmbRelOps.SelectedIndex;
					}
					else if (cmbExpOps.SelectedIndex == -1)
					{
						cmbExpOps.SelectedIndex = 0;
					}
				}
				break;
			case 7:
				((ButtonBase)cmdGeneral).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdChemical).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOperations).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOpParms).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReleases).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdExposures).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOptionalInfo).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdReports).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdGeneral).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdChemical).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOperations).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOpParms).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReleases).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdExposures).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOptionalInfo).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdReports).ForeColor = Globals_Renamed.gblTextOff;
				break;
			case 8:
				((ButtonBase)cmdGeneral).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdChemical).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOperations).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOpParms).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReleases).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdExposures).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdOptionalInfo).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdReports).BackColor = Globals_Renamed.gblColorOn;
				((Control)cmdGeneral).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdChemical).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOperations).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOpParms).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReleases).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdExposures).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdOptionalInfo).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdReports).ForeColor = Globals_Renamed.gblTextOn;
				break;
			}
		}
	}

	private void switchOpTabs(int selectedTab)
	{
		checked
		{
			((Control)fraOpTab[(short)(MyCurrentOpTab - 1)]).Visible = false;
			((Control)fraOpTab[(short)(selectedTab - 1)]).Visible = true;
			MyCurrentOpTab = (short)selectedTab;
			switch (MyCurrentOpTab)
			{
			case 1:
				((ButtonBase)cmdRelationships).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdDescription).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdPhysicalStates).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdSources).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdSiteInfo).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdRelationships).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdDescription).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdPhysicalStates).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdSources).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdSiteInfo).ForeColor = Globals_Renamed.gblTextOff;
				LabelSubTabs3.Text = "Click the \"Update Relationships\" button below to modify subsequent operations and distribute the PV between multiple operations. By default, operations are linked in the order that the operations are added at the top of the page. Select the operations in order from first to last to allow ChemSTEER to automatically distribute the assessed volume properly (e.g. manufacturing first, them processing1, processing2, …, use1, use2,…). The relationships should be updated if this order is changed.";
				break;
			case 2:
				((ButtonBase)cmdRelationships).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdDescription).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdPhysicalStates).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdSources).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdSiteInfo).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdRelationships).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdDescription).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdPhysicalStates).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdSources).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdSiteInfo).ForeColor = Globals_Renamed.gblTextOff;
				LabelSubTabs3.Text = "Click the \"Update NAICS and Description\" button below to add relevant NAICS codes and describe the process operations. Key information includes the physical form  and concentration at the beginning and end of the process. ";
				break;
			case 3:
				((ButtonBase)cmdRelationships).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdDescription).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdPhysicalStates).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdSources).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdSiteInfo).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdRelationships).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdDescription).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdPhysicalStates).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdSources).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdSiteInfo).ForeColor = Globals_Renamed.gblTextOff;
				LabelSubTabs3.Text = "Click the \"Update Physical States\" button below to specify the physical form during various stages of the operation.";
				break;
			case 4:
				((ButtonBase)cmdRelationships).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdDescription).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdPhysicalStates).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdSources).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdSiteInfo).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdRelationships).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdDescription).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdPhysicalStates).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdSources).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdSiteInfo).ForeColor = Globals_Renamed.gblTextOff;
				LabelSubTabs3.Text = "Click the \"Update Sources/Activities\" button below to add potential SOURCES of chemical release and worker ACTIVITIES associated with exposures within the selected operation. SOURCES and ACTIVITIES are shown below with their current default model procesing (DMP) status.";
				break;
			case 5:
				((ButtonBase)cmdRelationships).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdDescription).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdPhysicalStates).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdSources).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdSiteInfo).BackColor = Globals_Renamed.gblColorOn;
				((Control)cmdRelationships).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdDescription).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdPhysicalStates).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdSources).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdSiteInfo).ForeColor = Globals_Renamed.gblTextOn;
				LabelSubTabs3.Text = "Click the \"Update Site Information\" button to add the location(s) of the operation. Click the \"Copy Previous Operation\" button to automatically copy the sites from the preceding operation.";
				((Control)LabelSubTabs3).Visible = true;
				break;
			}
		}
	}

	private void switchExpTabs(int selectedTab)
	{
		checked
		{
			((Control)fraExpTab[(short)(MyCurrentExpTab - 1)]).Visible = false;
			((Control)fraExpTab[(short)(selectedTab - 1)]).Visible = true;
			MyCurrentExpTab = (short)selectedTab;
			switch (MyCurrentExpTab)
			{
			case 1:
				((Control)cmdViewExpModel).Enabled = true;
				((ButtonBase)cmdViewExpModel).Text = "View/Update Dermal Model &Information";
				((ButtonBase)cmdInhBasis).Text = "&Introductory Notes for the Dermal Summary";
				((Control)cmdInhBasis).Enabled = true;
				((ButtonBase)cmdDermal).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdInhalation).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdRespirator).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdActivity).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdDermal).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdInhalation).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdRespirator).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdActivity).ForeColor = Globals_Renamed.gblTextOff;
				lblExpSubtab.Text = "Use the buttons below to add, remove, or update dermal exposure models, or add notes to the release summary. When complete, click the \"Run Model(s)\" button below to generate the results. Results are shown on tab 6d.";
				break;
			case 2:
				((Control)cmdViewExpModel).Enabled = true;
				((ButtonBase)cmdViewExpModel).Text = "View/Update Inhalation Model &Information";
				((ButtonBase)cmdInhBasis).Text = "&Introductory Notes for the Inhalation Summary";
				((Control)cmdInhBasis).Enabled = true;
				((ButtonBase)cmdInhalation).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdDermal).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdRespirator).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdActivity).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdDermal).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdInhalation).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdRespirator).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdActivity).ForeColor = Globals_Renamed.gblTextOff;
				lblExpSubtab.Text = "Use the buttons below to add, remove, or update inhalation exposure models, or add notes to the release summary. When complete, click the \"Run Model(s)\" button below to generate the results. Results are shown on tab 6d.";
				break;
			case 3:
				((Control)cmdViewExpModel).Enabled = false;
				((Control)cmdInhBasis).Enabled = false;
				((ButtonBase)cmdRespirator).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdDermal).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdInhalation).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdActivity).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdDermal).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdInhalation).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdRespirator).ForeColor = Globals_Renamed.gblTextOn;
				((Control)cmdActivity).ForeColor = Globals_Renamed.gblTextOff;
				lblExpSubtab.Text = "Respirator Class and Monitor Review are automatically determined by ChemSTEER.";
				break;
			case 4:
				((Control)cmdViewExpModel).Enabled = false;
				((Control)cmdInhBasis).Enabled = false;
				((ButtonBase)cmdActivity).BackColor = Globals_Renamed.gblColorOn;
				((ButtonBase)cmdDermal).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdInhalation).BackColor = Globals_Renamed.gblColorOff;
				((ButtonBase)cmdRespirator).BackColor = Globals_Renamed.gblColorOff;
				((Control)cmdDermal).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdInhalation).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdRespirator).ForeColor = Globals_Renamed.gblTextOff;
				((Control)cmdActivity).ForeColor = Globals_Renamed.gblTextOn;
				lblExpSubtab.Text = "Estimated exposures for the selected operation and worker activity are summarized below.";
				break;
			}
		}
	}

	private void tabOps_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			((Control)fraOpTab[(short)(MyCurrentOpTab - 1)]).Visible = false;
			short count = ((ITabs)tabOps.Tabs).Count;
			MyCurrentOpTab = 1;
			while (true)
			{
				short myCurrentOpTab = MyCurrentOpTab;
				short num = count;
				if (myCurrentOpTab > num)
				{
					break;
				}
				Tabs tabs = tabOps.Tabs;
				object obj = MyCurrentOpTab;
				if (((ITab)((ITabs)tabs)[ref obj]).Selected)
				{
					break;
				}
				MyCurrentOpTab = (short)unchecked(MyCurrentOpTab + 1);
			}
			((Control)fraOpTab[(short)(MyCurrentOpTab - 1)]).Visible = true;
		}
	}

	private void tabRelSubTab_ClickEvent(object eventSender, EventArgs eventArgs)
	{
	}

	private void tabSubOI_ClickEvent(object eventSender, EventArgs eventArgs)
	{
		checked
		{
			short num = (short)(((BaseControlArray)fraSubOI).Count() - 1);
			short num2 = 0;
			short num5 = default(short);
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				((Control)fraSubOI[num2]).Visible = false;
				Tabs tabs = tabSubOI.Tabs;
				object obj = num2 + 1;
				if (((ITab)((ITabs)tabs)[ref obj]).Selected)
				{
					num5 = num2;
				}
				num2 = (short)unchecked(num2 + 1);
			}
			if (num5 == 2)
			{
				object obj2 = Common.MyNullCheck0(RuntimeHelpers.GetObjectValue(((Control)lblAssessType).Tag));
				if (Conversions.ToBoolean((Conversions.ToBoolean(Operators.CompareObjectEqual(obj2, (object)2, false)) || Conversions.ToBoolean(Operators.CompareObjectEqual(obj2, (object)5, false))) ? ((object)true) : ((object)false)))
				{
					((Control)lblOILvePpe).Visible = false;
				}
				else
				{
					((Control)lblOILvePpe).Visible = true;
					txtLVEPPE.Text = "";
				}
				((Control)lblLVEPPE).Visible = !((Control)lblOILvePpe).Visible;
				((Control)txtLVEPPE).Visible = !((Control)lblOILvePpe).Visible;
			}
			((Control)fraSubOI[num5]).Visible = true;
			((Control)fraSubOI[(short)0]).Tag = num5;
		}
	}

	public void FormatRelOutputs()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						string[] array = new string[19];
						Guid clsid = new Guid("00000535-0000-0010-8000-00AA006D2EA4");
						Recordset recordset = (Recordset)Activator.CreateInstance(Type.GetTypeFromCLSID(clsid));
						ProjectData.ClearProjectError();
						num2 = 2;
						recordset.CursorLocation = CursorLocationEnum.adUseClient;
						recordset.Open("SELECT * FROM ListOfMedia ORDER BY MediaID", Common.MyConn, CursorTypeEnum.adOpenDynamic, LockTypeEnum.adLockBatchOptimistic);
						while (!recordset.EOF)
						{
							array[Conversions.ToInteger(recordset.Fields["MediaID"].Value)] = Conversions.ToString(recordset.Fields["media"].Value);
							recordset.MoveNext();
						}
						msfRelEst.Rows = 2;
						short num3 = 0;
						short num9;
						short num8;
						do
						{
							if (Globals_Renamed.arRelModOutputOn[num3, Globals_Renamed.intModIndex] == 1)
							{
								short num4 = 0;
								short num7;
								do
								{
									if (Globals_Renamed.arRelModMedia[num4, Globals_Renamed.intModIndex] > 0f)
									{
										float num5 = Globals_Renamed.arRelModDRR[num3, Globals_Renamed.intModIndex] * Globals_Renamed.arRelModMedia[num4, Globals_Renamed.intModIndex] / 100f;
										string text = ChemStrX.ShowInSciNot(num5);
										float num6 = Globals_Renamed.arRelModARR[num3, Globals_Renamed.intModIndex] * Globals_Renamed.arRelModMedia[num4, Globals_Renamed.intModIndex] / 100f;
										string text2 = ChemStrX.ShowInSciNot(num6);
										msfRelEst.AddItem(unchecked(Conversions.ToString((int)num4) + "\t" + array[num4] + "\t" + Globals_Renamed.arRelModChar[num3, Globals_Renamed.intModIndex] + "\t" + Conversions.ToString(Globals_Renamed.arRelModParmsV[num3, 1, Globals_Renamed.intModIndex]) + "\t" + Conversions.ToString((int)Globals_Renamed.arRelModDOR[num3, Globals_Renamed.intModIndex])) + "\t" + text + "\t" + text2 + "\t" + Globals_Renamed.arRelModBasis[Globals_Renamed.intModIndex]);
									}
									num4 = (short)unchecked(num4 + 1);
									num7 = num4;
									num8 = 17;
								}
								while (num7 <= num8);
							}
							num3 = (short)unchecked(num3 + 1);
							num9 = num3;
							num8 = 1;
						}
						while (num9 <= num8);
						recordset.Close();
						recordset = null;
						if (msfRelEst.Rows > 2)
						{
							msfRelEst.RemoveItem(1);
						}
						else
						{
							AxMSFlexGrid pmsfGrid = msfRelEst;
							ChemStrX.MyMSfClear(ref pmsfGrid);
							msfRelEst = pmsfGrid;
						}
						txtRelModelMsg.Text = ChemStrX.GetModelStatus(ref Globals_Renamed.arRelModStatus[Globals_Renamed.intModIndex]);
						goto end_IL_0001;
					}
					case 838:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "FormatRelOutputs";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							((Control)this).Name = Eobject;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 838;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void RemoveText()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		short num3 = default(short);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
					ProjectData.ClearProjectError();
					num2 = 2;
					if (num3 != 0)
					{
						short num4 = checked((short)Strings.Len(((ContainerControl)this).ActiveControl.Text));
					}
					goto end_IL_0001;
				case 148:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						string Eobject = ((Control)this).Name;
						string Efunction = "RemoveText";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = false;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 148;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void clearInhClassFields()
	{
		lblInhClass.Text = "";
		lblInhClassNotes.Text = "";
		lblInhClassUncertainty.Text = "";
		lblInhClassExpLevel.Text = "";
		lblInhClassHazRating.Text = "";
		lblInhClassInhMon.Text = "";
	}

	public void FormatExpOutputs()
	{
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				checked
				{
					switch (try0001_dispatch)
					{
					default:
					{
						ProjectData.ClearProjectError();
						num2 = 2;
						msfExpEst.Rows = 2;
						if (cmbExpOps.SelectedIndex == -1)
						{
							goto end_IL_0001;
						}
						clearInhClassFields();
						object obj = new object[2] { "Dermal", "Inhalation" };
						short num3 = 1;
						short num8;
						short num7;
						do
						{
							if (Globals_Renamed.arExpModels[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] > 0)
							{
								Globals_Renamed.intModIndex = (short)(Globals_Renamed.arExpModels[num3, Globals_Renamed.intActIndex, Globals_Renamed.intOpIndex] - 1);
								short num4 = Conversions.ToShort(Interaction.IIf(num3 == 0, (object)8, (object)4));
								short num5 = 0;
								short num6;
								do
								{
									if (Globals_Renamed.arExpModOutputOn[num5, Globals_Renamed.intModIndex] == 1)
									{
										msfExpEst.AddItem(Conversions.ToString(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(Operators.ConcatenateObject(NewLateBinding.LateIndexGet(obj, new object[1] { num3 }, (string[])null), (object)'\t'), (object)Globals_Renamed.arExpModChar[num5, Globals_Renamed.intModIndex]), (object)'\t'), (object)Globals_Renamed.arExpModEst[num5, 12, Globals_Renamed.intModIndex]), (object)'\t'), (object)ChemStrX.ShowInSciNot(Globals_Renamed.arExpModEst[num5, 2, Globals_Renamed.intModIndex])), (object)'\t'), (object)ChemStrX.ShowInSciNot(Globals_Renamed.arExpModEst[num5, num4, Globals_Renamed.intModIndex])), (object)'\t'), (object)ChemStrX.ShowInSciNot(Globals_Renamed.arExpModEst[num5, num4 + 1, Globals_Renamed.intModIndex])), (object)'\t'), (object)ChemStrX.ShowInSciNot(Globals_Renamed.arExpModEst[num5, num4 + 2, Globals_Renamed.intModIndex])), (object)'\t'), (object)ChemStrX.ShowInSciNot(Globals_Renamed.arExpModEst[num5, num4 + 3, Globals_Renamed.intModIndex])), (object)'\t'), (object)Globals_Renamed.arExpModBasis[Globals_Renamed.intModIndex])));
									}
									num5 = (short)unchecked(num5 + 1);
									num6 = num5;
									num7 = 1;
								}
								while (num6 <= num7);
								if (num3 == 1)
								{
									lblInhClass.Text = Globals_Renamed.arExpModInhRC[0, Globals_Renamed.intModIndex];
									lblInhClassNotes.Text = Globals_Renamed.arExpModInhRC[1, Globals_Renamed.intModIndex];
									lblInhClassUncertainty.Text = Conversions.ToString(Interaction.IIf(Globals_Renamed.arExpModUncertainty[Globals_Renamed.intModIndex] == 1, (object)"Yes", (object)"No"));
									lblInhClassExpLevel.Text = Globals_Renamed.arExpModInhRC[2, Globals_Renamed.intModIndex];
									lblInhClassHazRating.Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(Globals_Renamed.arExpModInhRC[3, Globals_Renamed.intModIndex], "Yes", false) == 0, (object)"Yes", (object)"No"));
									lblInhClassInhMon.Text = Conversions.ToString(Interaction.IIf(Operators.CompareString(Globals_Renamed.arExpModInhRC[4, Globals_Renamed.intModIndex], "Yes", false) == 0, (object)"Yes", (object)"No"));
								}
								txtExpModelMsg[num3].Text = ChemStrX.GetModelStatus(ref Globals_Renamed.arExpModStatus[Globals_Renamed.intModIndex]);
							}
							num3 = (short)unchecked(num3 + -1);
							num8 = num3;
							num7 = 0;
						}
						while (num8 >= num7);
						if (msfExpEst.Rows > 2)
						{
							msfExpEst.RemoveItem(1);
						}
						Cursor.Current = Cursors.Default;
						goto end_IL_0001;
					}
					case 1072:
						num = -1;
						switch (num2)
						{
						case 2:
						{
							string Eobject = ((Control)this).Name;
							string Efunction = "FormatExpOutputs";
							ErrObject val = Information.Err();
							int Enumber = val.Number;
							ErrObject val2 = Information.Err();
							string Edescription = val2.Description;
							bool Econtact = true;
							Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
							val2.Description = Edescription;
							val.Number = Enumber;
							((Control)this).Name = Eobject;
							goto end_IL_0001;
						}
						}
						break;
					}
				}
			}
			catch (object obj2) when (obj2 is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj2);
				try0001_dispatch = 1072;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void txtContDrm_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtContDrm.Text) == 0)
		{
			Globals_Renamed.arOpParms[29, Globals_Renamed.intOpIndex] = 0f;
		}
		else if (Versioned.IsNumeric((object)txtContDrm.Text))
		{
			if (Conversions.ToDouble(txtContDrm.Text) < 0.0)
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid, positive numeric value for Drm.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				((Control)txtContDrm).Focus();
			}
			else
			{
				float pNewValue = Conversions.ToSingle(txtContDrm.Text);
				ChemStrX.RolldownhillDrm(ref Globals_Renamed.intOpIndex, ref pNewValue, ref Globals_Renamed.arOpParms[29, Globals_Renamed.intOpIndex]);
				Globals_Renamed.arOpParms[29, Globals_Renamed.intOpIndex] = Conversions.ToSingle(txtContDrm.Text);
				Globals_Renamed.arOpParmsType[29, Globals_Renamed.intOpIndex] = 2;
				PrimeContainerSubTab();
			}
		}
		else
		{
			Tabs tabs = tabConts.Tabs;
			object obj = 1;
			((ITab)((ITabs)tabs)[ref obj]).Selected = true;
			Tabs tabs2 = tabMain.Tabs;
			obj = 4;
			((ITab)((ITabs)tabs2)[ref obj]).Selected = true;
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid, positive numeric value for Drm.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtContDrm).SelectionStart = 0;
			((TextBoxBase)txtContDrm).SelectionLength = Strings.Len(txtContDrm.Text);
			((Control)txtContDrm).Focus();
		}
	}

	private void txtContDprod_Leave(object eventSender, EventArgs eventArgs)
	{
		//IL_0152: Unknown result type (might be due to invalid IL or missing references)
		//IL_007b: Unknown result type (might be due to invalid IL or missing references)
		if (Strings.Len(txtContDprod.Text) == 0)
		{
			Globals_Renamed.arOpParms[30, Globals_Renamed.intOpIndex] = 0f;
		}
		else if (Versioned.IsNumeric((object)txtContDprod.Text))
		{
			if (Conversions.ToDouble(txtContDprod.Text) < 0.0)
			{
				Interaction.Beep();
				Interaction.MsgBox((object)"Please enter a valid, positive numeric value for Dprod.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
				((Control)txtContDprod).Focus();
			}
			else
			{
				float pNewValue = Conversions.ToSingle(txtContDprod.Text);
				ChemStrX.RolldownhillDprod(ref Globals_Renamed.intOpIndex, ref pNewValue, ref Globals_Renamed.arOpParms[30, Globals_Renamed.intOpIndex]);
				Globals_Renamed.arOpParms[30, Globals_Renamed.intOpIndex] = Conversions.ToSingle(txtContDprod.Text);
				Globals_Renamed.arOpParmsType[30, Globals_Renamed.intOpIndex] = 2;
				PrimeContainerSubTab();
			}
		}
		else
		{
			Tabs tabs = tabConts.Tabs;
			object obj = 1;
			((ITab)((ITabs)tabs)[ref obj]).Selected = true;
			Tabs tabs2 = tabMain.Tabs;
			obj = 4;
			((ITab)((ITabs)tabs2)[ref obj]).Selected = true;
			Interaction.Beep();
			Interaction.MsgBox((object)"Please enter a valid, positive numeric value for Dprod.", (MsgBoxStyle)64, (object)"ChemSTEER v3.2");
			((TextBoxBase)txtContDprod).SelectionStart = 0;
			((TextBoxBase)txtContDprod).SelectionLength = Strings.Len(txtContDprod.Text);
			((Control)txtContDprod).Focus();
		}
	}

	public void SetPvOpLabels()
	{
		if (Globals_Renamed.intOpIndex == -1)
		{
			lblMyPvop.Text = "";
			lblMyPvf.Text = "";
			return;
		}
		if (Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex] < 1.0)
		{
			lblMyPvop.Text = Support.Format((object)Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex], "###,##0.###", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
		}
		else
		{
			lblMyPvop.Text = Support.Format((object)Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex], "###,###", (FirstDayOfWeek)1, (FirstWeekOfYear)1);
		}
		if (Versioned.IsNumeric((object)lblPV.Text))
		{
			if (Conversions.ToDouble(lblPV.Text) != 0.0)
			{
				lblMyPvf.Text = Support.Format((object)(Globals_Renamed.arOpPv[Globals_Renamed.intOpIndex] / Conversions.ToDouble(lblPV.Text) * 100.0), "##0.00", (FirstDayOfWeek)1, (FirstWeekOfYear)1) + " %";
			}
			else
			{
				lblMyPvf.Text = "0.00";
			}
		}
		else
		{
			lblMyPvf.Text = "0.00";
		}
	}

	private void SetMsfRelParmsDefaultCaptions()
	{
		msfRelParms[0, 2] = "Type 1";
		msfRelParms[0, 3] = "Origin 1";
		msfRelParms[0, 4] = "Value 1";
		msfRelParms[0, 6] = "Type 2";
		msfRelParms[0, 7] = "Origin 2";
		msfRelParms[0, 8] = "Value 2";
		msfRelParms[2] = 1300;
		msfRelParms[3] = 1300;
		msfRelParms[4] = 1300;
		msfRelParms[6] = 1300;
		msfRelParms[7] = 1300;
		msfRelParms[8] = 1300;
	}

	private void SetMsfExpParmsDefaultCaptions_0()
	{
		_msfExpParms_0[0, 2] = "Type 1";
		_msfExpParms_0[0, 3] = "Origin 1";
		_msfExpParms_0[0, 4] = "Value 1";
		_msfExpParms_0[0, 6] = "Type 2";
		_msfExpParms_0[0, 7] = "Origin 2";
		_msfExpParms_0[0, 8] = "Value 2";
		_msfExpParms_0[2] = 1300;
		_msfExpParms_0[3] = 1300;
		_msfExpParms_0[4] = 1300;
		_msfExpParms_0[6] = 1300;
		_msfExpParms_0[7] = 1300;
		_msfExpParms_0[8] = 1300;
	}

	private void SetMsfExpParmsDefaultCaptions_1()
	{
		_msfExpParms_1[0, 2] = "Type 1";
		_msfExpParms_1[0, 3] = "Origin 1";
		_msfExpParms_1[0, 4] = "Value 1";
		_msfExpParms_1[0, 6] = "Type 2";
		_msfExpParms_1[0, 7] = "Origin 2";
		_msfExpParms_1[0, 8] = "Value 2";
		_msfExpParms_1[2] = 1300;
		_msfExpParms_1[3] = 1300;
		_msfExpParms_1[4] = 1300;
		_msfExpParms_1[6] = 1300;
		_msfExpParms_1[7] = 1300;
		_msfExpParms_1[8] = 1300;
	}

	public void AllOpsDeleted()
	{
		AxMSFlexGrid pmsfGrid = msfSubOps;
		ChemStrX.MyMSfClear(ref pmsfGrid);
		msfSubOps = pmsfGrid;
		pmsfGrid = msfNaics;
		ChemStrX.MyMSfClear(ref pmsfGrid);
		msfNaics = pmsfGrid;
		txtPD.Text = "";
		checked
		{
			short num = (short)(((BaseControlArray)lblPhyState).Count() - 1);
			short num2 = 0;
			while (true)
			{
				short num3 = num2;
				short num4 = num;
				if (num3 > num4)
				{
					break;
				}
				lblPhyState[num2].Text = "";
				lblPhyStateOtherInfo[num2].Text = "";
				num2 = (short)unchecked(num2 + 1);
			}
			pmsfGrid = msfSelActs;
			ChemStrX.MyMSfClear(ref pmsfGrid);
			msfSelActs = pmsfGrid;
			pmsfGrid = msfSites;
			ChemStrX.MyMSfClear(ref pmsfGrid);
			msfSites = pmsfGrid;
			pmsfGrid = _msfCont_0;
			ChemStrX.MyMSfClear(ref pmsfGrid);
			_msfCont_0 = pmsfGrid;
			pmsfGrid = _msfCont_1;
			ChemStrX.MyMSfClear(ref pmsfGrid);
			_msfCont_1 = pmsfGrid;
			pmsfGrid = _msfCont_2;
			ChemStrX.MyMSfClear(ref pmsfGrid);
			_msfCont_2 = pmsfGrid;
			pmsfGrid = _msfCont_3;
			ChemStrX.MyMSfClear(ref pmsfGrid);
			_msfCont_3 = pmsfGrid;
			if (cmbRelOps.Items.Count > 0)
			{
				cmbRelOps.SelectedIndex = -1;
				cmbRelOps.Items.Clear();
			}
			if (cmbExpOps.Items.Count > 0)
			{
				cmbExpOps.SelectedIndex = -1;
				cmbExpOps.Items.Clear();
			}
		}
	}

	private void cmdGeneral_click(object sender, EventArgs e)
	{
		switchTabs(1);
	}

	private void cmdChemical_Click(object sender, EventArgs e)
	{
		switchTabs(2);
	}

	private void cmdOperations_Click(object sender, EventArgs e)
	{
		switchTabs(3);
	}

	private void cmdOpParms_Click(object sender, EventArgs e)
	{
		switchTabs(4);
	}

	private void cmdReleases_Click(object sender, EventArgs e)
	{
		switchTabs(5);
	}

	private void cmdExposures_Click(object sender, EventArgs e)
	{
		switchTabs(6);
	}

	private void cmdOptionalInfo_Click(object sender, EventArgs e)
	{
		switchTabs(7);
	}

	private void cmdRelationships_Click(object sender, EventArgs e)
	{
		switchOpTabs(1);
	}

	private void cmdDescription_Click(object sender, EventArgs e)
	{
		switchOpTabs(2);
	}

	private void cmdPhysicalStates_Click(object sender, EventArgs e)
	{
		switchOpTabs(3);
	}

	private void cmdSources_Click(object sender, EventArgs e)
	{
		switchOpTabs(4);
	}

	private void cmdSiteInfo_Click(object sender, EventArgs e)
	{
		switchOpTabs(5);
	}

	private void cmdDermal_Click(object sender, EventArgs e)
	{
		switchExpTabs(1);
	}

	private void cmdInhalation_Click(object sender, EventArgs e)
	{
		switchExpTabs(2);
	}

	private void cmdRespirator_Click(object sender, EventArgs e)
	{
		switchExpTabs(3);
	}

	private void cmdActivity_Click(object sender, EventArgs e)
	{
		switchExpTabs(4);
	}

	private void cmdMassBalParms_Click(object sender, EventArgs e)
	{
		switchIPTabs(1);
	}

	private void cmdContainerParms_Click(object sender, EventArgs e)
	{
		switchIPTabs(2);
	}

	private void cmdSharedParms_Click(object sender, EventArgs e)
	{
		switchIPTabs(3);
	}

	private void cmdRelParms_Click(object sender, EventArgs e)
	{
		switchRelTabs(1);
	}

	private void cmdEstReleases_Click(object sender, EventArgs e)
	{
		switchRelTabs(2);
	}

	private void cmdReports_Click(object sender, EventArgs e)
	{
		switchTabs(8);
	}

	private void cmdViewIRER_Click(object sender, EventArgs e)
	{
		mnuReportIRER0_Click(_mnuReportIRER_0, new EventArgs());
	}

	private void cmdSaveIRER_Click(object sender, EventArgs e)
	{
		mnuReportIRER1_Click(_mnuReportIRER_1, new EventArgs());
	}

	private void cmdViewContact_Click(object sender, EventArgs e)
	{
		mnuReportCR0_Click(_mnuReportCR_0, new EventArgs());
	}

	private void cmdSaveContact_Click(object sender, EventArgs e)
	{
		mnuReportCR1_Click(_mnuReportCR_1, new EventArgs());
	}

	private void cmdViewCombo_Click(object sender, EventArgs e)
	{
		mnuReportIRERandCR2_Click(_mnuReportIRER_2, new EventArgs());
	}

	private void cmdSaveCombo_Click(object sender, EventArgs e)
	{
		mnuReportIRERandCR_Click(_mnuReportIRER_3, new EventArgs());
	}

	private void mnuFileRenameGSS_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		frmMDRenameGSS frmMDRenameGSS2 = new frmMDRenameGSS();
		((Form)frmMDRenameGSS2).ShowDialog();
	}

	private void mnuFileUpdateGSS_Click(object sender, EventArgs e)
	{
		//IL_0009: Unknown result type (might be due to invalid IL or missing references)
		//IL_000f: Expected O, but got Unknown
		//IL_004c: Unknown result type (might be due to invalid IL or missing references)
		//IL_0052: Invalid comparison between Unknown and I4
		//IL_0092: Unknown result type (might be due to invalid IL or missing references)
		//IL_015d: Unknown result type (might be due to invalid IL or missing references)
		int try0001_dispatch = -1;
		int num2 = default(int);
		int num = default(int);
		while (true)
		{
			try
			{
				/*Note: ILSpy has introduced the following switch to emulate a goto from catch-block to try-block*/;
				switch (try0001_dispatch)
				{
				default:
				{
					ProjectData.ClearProjectError();
					num2 = 2;
					OpenFileDialog val3 = new OpenFileDialog();
					OpenFileDialog val4 = val3;
					((FileDialog)val4).Title = "Select the replacement scenarios.epa";
					((FileDialog)val4).DefaultExt = "epa";
					((FileDialog)val4).FileName = "scenarios.epa";
					((FileDialog)val4).Filter = "ChemSTEER Scenarios (scenarios.epa)|*.epa";
					val4.CheckFileExists = true;
					val4 = null;
					if ((int)((CommonDialog)val3).ShowDialog() != 1)
					{
						goto end_IL_0001;
					}
					if (Operators.CompareString(Strings.Mid(((FileDialog)val3).FileName, 1, Strings.Len(Application.StartupPath)), Application.StartupPath, false) == 0)
					{
						Interaction.MsgBox((object)"It is invalid to select a file from the folder where ChemSTEER is installed. If you received a new ChemSTEER Scenarios Database from EPA, copy that file to a different folder structure on your computer and try again.", (MsgBoxStyle)0, (object)"Invalid Action");
						goto end_IL_0001;
					}
					Cursor.Current = Cursors.WaitCursor;
					if (Common.gssConn.State == 1)
					{
						Common.gssConn.Close();
					}
					((ServerComputer)MyProject.Computer).FileSystem.DeleteFile(Application.StartupPath + "\\scenarios.epa");
					((ServerComputer)MyProject.Computer).FileSystem.CopyFile(((FileDialog)val3).FileName, Application.StartupPath + "\\scenarios.epa");
					Common.gssConn.ConnectionString = "Provider=Microsoft.Jet.OleDb.4.0;Data Source=" + Application.StartupPath + "\\scenarios.epa";
					Common.gssConn.Open();
					Cursor.Current = Cursors.Default;
					Interaction.MsgBox((object)"The ChemSTEER scenarios database has been replaced. If you have any questions or problems with this, please contact EPA.", (MsgBoxStyle)0, (object)"Replace Generic Scenario Database");
					goto end_IL_0001;
				}
				case 469:
					num = -1;
					switch (num2)
					{
					case 2:
					{
						Cursor.Current = Cursors.Default;
						string Eobject = ((Control)this).Name;
						string Efunction = "mnuFileUpdateGSS_Click";
						ErrObject val = Information.Err();
						int Enumber = val.Number;
						ErrObject val2 = Information.Err();
						string Edescription = val2.Description;
						bool Econtact = true;
						Common.CommonErrHandler(ref Eobject, ref Efunction, ref Enumber, ref Edescription, ref Econtact);
						val2.Description = Edescription;
						val.Number = Enumber;
						((Control)this).Name = Eobject;
						goto end_IL_0001;
					}
					}
					break;
				}
			}
			catch (object obj) when (obj is Exception && num2 != 0 && num == 0)
			{
				ProjectData.SetProjectError((Exception)obj);
				try0001_dispatch = 469;
				continue;
			}
			throw ProjectData.CreateProjectError(-2146828237);
			continue;
			end_IL_0001:
			break;
		}
		if (num != 0)
		{
			ProjectData.ClearProjectError();
		}
	}

	private void mnuFileSaveGSS_Click(object sender, EventArgs e)
	{
		//IL_0019: Unknown result type (might be due to invalid IL or missing references)
		//IL_0036: Unknown result type (might be due to invalid IL or missing references)
		if (Globals_Renamed.intNumOps == 0)
		{
			Interaction.MsgBox((object)"You have no operations in the current assessment.", (MsgBoxStyle)48, (object)"You can't save what you don't have");
			return;
		}
		frmMDSaveGSS frmMDSaveGSS2 = new frmMDSaveGSS();
		if (frmMDSaveGSS2.setup())
		{
			((Form)frmMDSaveGSS2).ShowDialog();
		}
		((Component)(object)frmMDSaveGSS2).Dispose();
	}

	private void mnuFileDeleteGSS_Click(object sender, EventArgs e)
	{
		//IL_0008: Unknown result type (might be due to invalid IL or missing references)
		frmMDDeleteGSS frmMDDeleteGSS2 = new frmMDDeleteGSS();
		((Form)frmMDDeleteGSS2).ShowDialog();
		((Component)(object)frmMDDeleteGSS2).Dispose();
	}

	private void frmMain_Shown(object sender, EventArgs e)
	{
		//IL_0014: Unknown result type (might be due to invalid IL or missing references)
		if (!Globals_Renamed.gblDoEasyModels)
		{
			return;
		}
		frmSelectEasyModel frmSelectEasyModel2 = new frmSelectEasyModel();
		((Form)frmSelectEasyModel2).ShowDialog();
		if (frmSelectEasyModel2.lstModels.SelectedIndex != -1)
		{
			LoadLstSelOps();
			_lstSelOps_0.SelectedIndex = 0;
			_lstSelOps_1.SelectedIndex = 0;
			LoadMsfSubOps();
			LoadOpCmbs();
			if (frmSelectEasyModel2.chkReleaseModels.Checked)
			{
				switchTabs(5);
				viewEditReleaseModelPopup();
			}
			else if (frmSelectEasyModel2.chkDermalModels.Checked)
			{
				switchTabs(6);
				switchExpTabs(1);
				viewEditExposureModelPopup();
			}
			else
			{
				switchTabs(6);
				switchExpTabs(2);
				viewEditExposureModelPopup();
			}
			((Component)(object)frmSelectEasyModel2).Dispose();
		}
	}

	private void _Label1_337_Click(object sender, EventArgs e)
	{
	}
}
