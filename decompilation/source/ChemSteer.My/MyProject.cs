using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer.My;

[StandardModule]
[GeneratedCode("MyTemplate", "10.0.0.0")]
[HideModuleName]
internal sealed class MyProject
{
	[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
	[EditorBrowsable(EditorBrowsableState.Never)]
	internal sealed class MyForms
	{
		public frmCRViewer m_frmCRViewer;

		public frmGenericTextBox m_frmGenericTextBox;

		public frmMain m_frmMain;

		public frmMDAddExpModel m_frmMDAddExpModel;

		public frmMDAddRelModel m_frmMDAddRelModel;

		public frmMDCalcCtw m_frmMDCalcCtw;

		public frmMDCalcDMxChem m_frmMDCalcDMxChem;

		public frmMDCalcNS m_frmMDCalcNS;

		public frmMDCalcXmoProd m_frmMDCalcXmoProd;

		public frmMDCalcYprod m_frmMDCalcYprod;

		public frmMDDeleteGSS m_frmMDDeleteGSS;

		public frmMDPrefs m_frmMDPrefs;

		public frmMDRenameGSS m_frmMDRenameGSS;

		public frmMDRevisionHistory m_frmMDRevisionHistory;

		public frmMDSaveGSS m_frmMDSaveGSS;

		public frmMDSelAss m_frmMDSelAss;

		public frmMDUpdAct m_frmMDUpdAct;

		public frmMDUpdAmtFreq m_frmMDUpdAmtFreq;

		public frmMDUpdChem m_frmMDUpdChem;

		public frmMDUpdCombRel m_frmMDUpdCombRel;

		public frmMDUpdContRpts m_frmMDUpdContRpts;

		public frmMDUpdContTab m_frmMDUpdContTab;

		public frmMDUpdD m_frmMDUpdD;

		public frmMDUpdExp m_frmMDUpdExp;

		public frmMDUpdExpMod m_frmMDUpdExpMod;

		public frmMDUpdGen m_frmMDUpdGen;

		public frmMDUpdLF m_frmMDUpdLF;

		public frmMDUpdLVE m_frmMDUpdLVE;

		public frmMDUpdLvePpe m_frmMDUpdLvePpe;

		public frmMDUpdMsdsGE m_frmMDUpdMsdsGE;

		public frmMDUpdMsdsTLV m_frmMDUpdMsdsTLV;

		public frmMDUpdNotepad m_frmMDUpdNotepad;

		public frmMDUpdNW m_frmMDUpdNW;

		public frmMDUpdOpIP m_frmMDUpdOpIP;

		public frmMDUpdOps m_frmMDUpdOps;

		public frmMDUpdOptData m_frmMDUpdOptData;

		public frmMDUpdOtherUses m_frmMDUpdOtherUses;

		public frmMDUpdP2Cons m_frmMDUpdP2Cons;

		public frmMDUpdPD m_frmMDUpdPD;

		public frmMDUpdPS m_frmMDUpdPS;

		public frmMDUpdRelA10 m_frmMDUpdRelA10;

		public frmMDUpdRelA24 m_frmMDUpdRelA24;

		public frmMDUpdRelMed m_frmMDUpdRelMed;

		public frmMDUpdRelMod m_frmMDUpdRelMod;

		public frmMDUpdRels m_frmMDUpdRels;

		public frmMDUpdSat m_frmMDUpdSat;

		public frmMDUpdSites m_frmMDUpdSites;

		public frmModelsToBeRun m_frmModelsToBeRun;

		public frmSelectEasyModel m_frmSelectEasyModel;

		public frmSplash m_frmSplash;

		public frmStartUp m_frmStartUp;

		public frmUpdCmCv m_frmUpdCmCv;

		public frmUpdShowSP m_frmUpdShowSP;

		public frmUpdSP m_frmUpdSP;

		public frmUpdVP m_frmUpdVP;

		public frmViewCRSS m_frmViewCRSS;

		public frmViewPels m_frmViewPels;

		public frmWaterAndInhBasis m_frmWaterAndInhBasis;

		public protocomb m_protocomb;

		[ThreadStatic]
		private static Hashtable m_FormBeingCreated;

		public frmCRViewer frmCRViewer
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmCRViewer = Create__Instance__(m_frmCRViewer);
				return m_frmCRViewer;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmCRViewer)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmCRViewer);
				}
			}
		}

		public frmGenericTextBox frmGenericTextBox
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmGenericTextBox = Create__Instance__(m_frmGenericTextBox);
				return m_frmGenericTextBox;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmGenericTextBox)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmGenericTextBox);
				}
			}
		}

		public frmMain frmMain
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMain = Create__Instance__(m_frmMain);
				return m_frmMain;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMain)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMain);
				}
			}
		}

		public frmMDAddExpModel frmMDAddExpModel
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDAddExpModel = Create__Instance__(m_frmMDAddExpModel);
				return m_frmMDAddExpModel;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDAddExpModel)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDAddExpModel);
				}
			}
		}

		public frmMDAddRelModel frmMDAddRelModel
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDAddRelModel = Create__Instance__(m_frmMDAddRelModel);
				return m_frmMDAddRelModel;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDAddRelModel)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDAddRelModel);
				}
			}
		}

		public frmMDCalcCtw frmMDCalcCtw
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDCalcCtw = Create__Instance__(m_frmMDCalcCtw);
				return m_frmMDCalcCtw;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDCalcCtw)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDCalcCtw);
				}
			}
		}

		public frmMDCalcDMxChem frmMDCalcDMxChem
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDCalcDMxChem = Create__Instance__(m_frmMDCalcDMxChem);
				return m_frmMDCalcDMxChem;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDCalcDMxChem)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDCalcDMxChem);
				}
			}
		}

		public frmMDCalcNS frmMDCalcNS
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDCalcNS = Create__Instance__(m_frmMDCalcNS);
				return m_frmMDCalcNS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDCalcNS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDCalcNS);
				}
			}
		}

		public frmMDCalcXmoProd frmMDCalcXmoProd
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDCalcXmoProd = Create__Instance__(m_frmMDCalcXmoProd);
				return m_frmMDCalcXmoProd;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDCalcXmoProd)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDCalcXmoProd);
				}
			}
		}

		public frmMDCalcYprod frmMDCalcYprod
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDCalcYprod = Create__Instance__(m_frmMDCalcYprod);
				return m_frmMDCalcYprod;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDCalcYprod)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDCalcYprod);
				}
			}
		}

		public frmMDDeleteGSS frmMDDeleteGSS
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDDeleteGSS = Create__Instance__(m_frmMDDeleteGSS);
				return m_frmMDDeleteGSS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDDeleteGSS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDDeleteGSS);
				}
			}
		}

		public frmMDPrefs frmMDPrefs
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDPrefs = Create__Instance__(m_frmMDPrefs);
				return m_frmMDPrefs;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDPrefs)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDPrefs);
				}
			}
		}

		public frmMDRenameGSS frmMDRenameGSS
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDRenameGSS = Create__Instance__(m_frmMDRenameGSS);
				return m_frmMDRenameGSS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDRenameGSS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDRenameGSS);
				}
			}
		}

		public frmMDRevisionHistory frmMDRevisionHistory
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDRevisionHistory = Create__Instance__(m_frmMDRevisionHistory);
				return m_frmMDRevisionHistory;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDRevisionHistory)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDRevisionHistory);
				}
			}
		}

		public frmMDSaveGSS frmMDSaveGSS
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDSaveGSS = Create__Instance__(m_frmMDSaveGSS);
				return m_frmMDSaveGSS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDSaveGSS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDSaveGSS);
				}
			}
		}

		public frmMDSelAss frmMDSelAss
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDSelAss = Create__Instance__(m_frmMDSelAss);
				return m_frmMDSelAss;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDSelAss)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDSelAss);
				}
			}
		}

		public frmMDUpdAct frmMDUpdAct
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdAct = Create__Instance__(m_frmMDUpdAct);
				return m_frmMDUpdAct;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdAct)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdAct);
				}
			}
		}

		public frmMDUpdAmtFreq frmMDUpdAmtFreq
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdAmtFreq = Create__Instance__(m_frmMDUpdAmtFreq);
				return m_frmMDUpdAmtFreq;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdAmtFreq)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdAmtFreq);
				}
			}
		}

		public frmMDUpdChem frmMDUpdChem
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdChem = Create__Instance__(m_frmMDUpdChem);
				return m_frmMDUpdChem;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdChem)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdChem);
				}
			}
		}

		public frmMDUpdCombRel frmMDUpdCombRel
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdCombRel = Create__Instance__(m_frmMDUpdCombRel);
				return m_frmMDUpdCombRel;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdCombRel)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdCombRel);
				}
			}
		}

		public frmMDUpdContRpts frmMDUpdContRpts
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdContRpts = Create__Instance__(m_frmMDUpdContRpts);
				return m_frmMDUpdContRpts;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdContRpts)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdContRpts);
				}
			}
		}

		public frmMDUpdContTab frmMDUpdContTab
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdContTab = Create__Instance__(m_frmMDUpdContTab);
				return m_frmMDUpdContTab;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdContTab)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdContTab);
				}
			}
		}

		public frmMDUpdD frmMDUpdD
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdD = Create__Instance__(m_frmMDUpdD);
				return m_frmMDUpdD;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdD)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdD);
				}
			}
		}

		public frmMDUpdExp frmMDUpdExp
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdExp = Create__Instance__(m_frmMDUpdExp);
				return m_frmMDUpdExp;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdExp)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdExp);
				}
			}
		}

		public frmMDUpdExpMod frmMDUpdExpMod
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdExpMod = Create__Instance__(m_frmMDUpdExpMod);
				return m_frmMDUpdExpMod;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdExpMod)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdExpMod);
				}
			}
		}

		public frmMDUpdGen frmMDUpdGen
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdGen = Create__Instance__(m_frmMDUpdGen);
				return m_frmMDUpdGen;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdGen)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdGen);
				}
			}
		}

		public frmMDUpdLF frmMDUpdLF
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdLF = Create__Instance__(m_frmMDUpdLF);
				return m_frmMDUpdLF;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdLF)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdLF);
				}
			}
		}

		public frmMDUpdLVE frmMDUpdLVE
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdLVE = Create__Instance__(m_frmMDUpdLVE);
				return m_frmMDUpdLVE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdLVE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdLVE);
				}
			}
		}

		public frmMDUpdLvePpe frmMDUpdLvePpe
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdLvePpe = Create__Instance__(m_frmMDUpdLvePpe);
				return m_frmMDUpdLvePpe;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdLvePpe)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdLvePpe);
				}
			}
		}

		public frmMDUpdMsdsGE frmMDUpdMsdsGE
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdMsdsGE = Create__Instance__(m_frmMDUpdMsdsGE);
				return m_frmMDUpdMsdsGE;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdMsdsGE)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdMsdsGE);
				}
			}
		}

		public frmMDUpdMsdsTLV frmMDUpdMsdsTLV
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdMsdsTLV = Create__Instance__(m_frmMDUpdMsdsTLV);
				return m_frmMDUpdMsdsTLV;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdMsdsTLV)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdMsdsTLV);
				}
			}
		}

		public frmMDUpdNotepad frmMDUpdNotepad
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdNotepad = Create__Instance__(m_frmMDUpdNotepad);
				return m_frmMDUpdNotepad;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdNotepad)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdNotepad);
				}
			}
		}

		public frmMDUpdNW frmMDUpdNW
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdNW = Create__Instance__(m_frmMDUpdNW);
				return m_frmMDUpdNW;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdNW)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdNW);
				}
			}
		}

		public frmMDUpdOpIP frmMDUpdOpIP
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdOpIP = Create__Instance__(m_frmMDUpdOpIP);
				return m_frmMDUpdOpIP;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdOpIP)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdOpIP);
				}
			}
		}

		public frmMDUpdOps frmMDUpdOps
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdOps = Create__Instance__(m_frmMDUpdOps);
				return m_frmMDUpdOps;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdOps)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdOps);
				}
			}
		}

		public frmMDUpdOptData frmMDUpdOptData
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdOptData = Create__Instance__(m_frmMDUpdOptData);
				return m_frmMDUpdOptData;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdOptData)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdOptData);
				}
			}
		}

		public frmMDUpdOtherUses frmMDUpdOtherUses
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdOtherUses = Create__Instance__(m_frmMDUpdOtherUses);
				return m_frmMDUpdOtherUses;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdOtherUses)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdOtherUses);
				}
			}
		}

		public frmMDUpdP2Cons frmMDUpdP2Cons
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdP2Cons = Create__Instance__(m_frmMDUpdP2Cons);
				return m_frmMDUpdP2Cons;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdP2Cons)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdP2Cons);
				}
			}
		}

		public frmMDUpdPD frmMDUpdPD
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdPD = Create__Instance__(m_frmMDUpdPD);
				return m_frmMDUpdPD;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdPD)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdPD);
				}
			}
		}

		public frmMDUpdPS frmMDUpdPS
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdPS = Create__Instance__(m_frmMDUpdPS);
				return m_frmMDUpdPS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdPS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdPS);
				}
			}
		}

		public frmMDUpdRelA10 frmMDUpdRelA10
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdRelA10 = Create__Instance__(m_frmMDUpdRelA10);
				return m_frmMDUpdRelA10;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdRelA10)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdRelA10);
				}
			}
		}

		public frmMDUpdRelA24 frmMDUpdRelA24
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdRelA24 = Create__Instance__(m_frmMDUpdRelA24);
				return m_frmMDUpdRelA24;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdRelA24)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdRelA24);
				}
			}
		}

		public frmMDUpdRelMed frmMDUpdRelMed
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdRelMed = Create__Instance__(m_frmMDUpdRelMed);
				return m_frmMDUpdRelMed;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdRelMed)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdRelMed);
				}
			}
		}

		public frmMDUpdRelMod frmMDUpdRelMod
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdRelMod = Create__Instance__(m_frmMDUpdRelMod);
				return m_frmMDUpdRelMod;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdRelMod)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdRelMod);
				}
			}
		}

		public frmMDUpdRels frmMDUpdRels
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdRels = Create__Instance__(m_frmMDUpdRels);
				return m_frmMDUpdRels;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdRels)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdRels);
				}
			}
		}

		public frmMDUpdSat frmMDUpdSat
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdSat = Create__Instance__(m_frmMDUpdSat);
				return m_frmMDUpdSat;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdSat)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdSat);
				}
			}
		}

		public frmMDUpdSites frmMDUpdSites
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmMDUpdSites = Create__Instance__(m_frmMDUpdSites);
				return m_frmMDUpdSites;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmMDUpdSites)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmMDUpdSites);
				}
			}
		}

		public frmModelsToBeRun frmModelsToBeRun
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmModelsToBeRun = Create__Instance__(m_frmModelsToBeRun);
				return m_frmModelsToBeRun;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmModelsToBeRun)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmModelsToBeRun);
				}
			}
		}

		public frmSelectEasyModel frmSelectEasyModel
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmSelectEasyModel = Create__Instance__(m_frmSelectEasyModel);
				return m_frmSelectEasyModel;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmSelectEasyModel)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmSelectEasyModel);
				}
			}
		}

		public frmSplash frmSplash
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmSplash = Create__Instance__(m_frmSplash);
				return m_frmSplash;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmSplash)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmSplash);
				}
			}
		}

		public frmStartUp frmStartUp
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmStartUp = Create__Instance__(m_frmStartUp);
				return m_frmStartUp;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmStartUp)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmStartUp);
				}
			}
		}

		public frmUpdCmCv frmUpdCmCv
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmUpdCmCv = Create__Instance__(m_frmUpdCmCv);
				return m_frmUpdCmCv;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmUpdCmCv)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmUpdCmCv);
				}
			}
		}

		public frmUpdShowSP frmUpdShowSP
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmUpdShowSP = Create__Instance__(m_frmUpdShowSP);
				return m_frmUpdShowSP;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmUpdShowSP)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmUpdShowSP);
				}
			}
		}

		public frmUpdSP frmUpdSP
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmUpdSP = Create__Instance__(m_frmUpdSP);
				return m_frmUpdSP;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmUpdSP)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmUpdSP);
				}
			}
		}

		public frmUpdVP frmUpdVP
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmUpdVP = Create__Instance__(m_frmUpdVP);
				return m_frmUpdVP;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmUpdVP)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmUpdVP);
				}
			}
		}

		public frmViewCRSS frmViewCRSS
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmViewCRSS = Create__Instance__(m_frmViewCRSS);
				return m_frmViewCRSS;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmViewCRSS)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmViewCRSS);
				}
			}
		}

		public frmViewPels frmViewPels
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmViewPels = Create__Instance__(m_frmViewPels);
				return m_frmViewPels;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmViewPels)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmViewPels);
				}
			}
		}

		public frmWaterAndInhBasis frmWaterAndInhBasis
		{
			[DebuggerNonUserCode]
			get
			{
				m_frmWaterAndInhBasis = Create__Instance__(m_frmWaterAndInhBasis);
				return m_frmWaterAndInhBasis;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_frmWaterAndInhBasis)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_frmWaterAndInhBasis);
				}
			}
		}

		public protocomb protocomb
		{
			[DebuggerNonUserCode]
			get
			{
				m_protocomb = Create__Instance__(m_protocomb);
				return m_protocomb;
			}
			[DebuggerNonUserCode]
			set
			{
				if (value != m_protocomb)
				{
					if (value != null)
					{
						throw new ArgumentException("Property can only be set to Nothing");
					}
					Dispose__Instance__(ref m_protocomb);
				}
			}
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T Instance) where T : Form, new()
		{
			if (Instance == null || (((Control)Instance).IsDisposed ? true : false))
			{
				if (m_FormBeingCreated != null)
				{
					if (m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
				}
				else
				{
					m_FormBeingCreated = new Hashtable();
				}
				m_FormBeingCreated.Add(typeof(T), null);
				try
				{
					return new T();
				}
				catch (TargetInvocationException ex) when (((Func<bool>)delegate
				{
					// Could not convert BlockContainer to single expression
					ProjectData.SetProjectError((Exception)ex);
					return ex.InnerException != null;
				}).Invoke())
				{
					string resourceString = Utils.GetResourceString("WinForms_SeeInnerException", new string[1] { ex.InnerException.Message });
					throw new InvalidOperationException(resourceString, ex.InnerException);
				}
				finally
				{
					m_FormBeingCreated.Remove(typeof(T));
				}
			}
			return Instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance) where T : Form
		{
			((Component)instance).Dispose();
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyForms()
		{
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		internal new Type GetType()
		{
			return typeof(MyForms);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		public override string ToString()
		{
			return base.ToString();
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
	internal sealed class MyWebServices
	{
		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override bool Equals(object o)
		{
			return base.Equals(RuntimeHelpers.GetObjectValue(o));
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Never)]
		public override int GetHashCode()
		{
			return base.GetHashCode();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		internal new Type GetType()
		{
			return typeof(MyWebServices);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public override string ToString()
		{
			return base.ToString();
		}

		[DebuggerHidden]
		private static T Create__Instance__<T>(T instance) where T : new()
		{
			if (instance == null)
			{
				return new T();
			}
			return instance;
		}

		[DebuggerHidden]
		private void Dispose__Instance__<T>(ref T instance)
		{
			instance = default(T);
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public MyWebServices()
		{
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	[ComVisible(false)]
	internal sealed class ThreadSafeObjectProvider<T> where T : new()
	{
		[ThreadStatic]
		[CompilerGenerated]
		private static T m_ThreadStaticValue;

		internal T GetInstance
		{
			[DebuggerHidden]
			get
			{
				if (m_ThreadStaticValue == null)
				{
					m_ThreadStaticValue = new T();
				}
				return m_ThreadStaticValue;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[DebuggerHidden]
		public ThreadSafeObjectProvider()
		{
		}
	}

	private static readonly ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider = new ThreadSafeObjectProvider<MyComputer>();

	private static readonly ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider = new ThreadSafeObjectProvider<MyApplication>();

	private static readonly ThreadSafeObjectProvider<User> m_UserObjectProvider = new ThreadSafeObjectProvider<User>();

	private static ThreadSafeObjectProvider<MyForms> m_MyFormsObjectProvider = new ThreadSafeObjectProvider<MyForms>();

	private static readonly ThreadSafeObjectProvider<MyWebServices> m_MyWebServicesObjectProvider = new ThreadSafeObjectProvider<MyWebServices>();

	[HelpKeyword("My.Computer")]
	internal static MyComputer Computer
	{
		[DebuggerHidden]
		get
		{
			return m_ComputerObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Application")]
	internal static MyApplication Application
	{
		[DebuggerHidden]
		get
		{
			return m_AppObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.User")]
	internal static User User
	{
		[DebuggerHidden]
		get
		{
			return m_UserObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.Forms")]
	internal static MyForms Forms
	{
		[DebuggerHidden]
		get
		{
			return m_MyFormsObjectProvider.GetInstance;
		}
	}

	[HelpKeyword("My.WebServices")]
	internal static MyWebServices WebServices
	{
		[DebuggerHidden]
		get
		{
			return m_MyWebServicesObjectProvider.GetInstance;
		}
	}
}
