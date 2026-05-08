using Microsoft.VisualBasic.CompilerServices;

namespace ChemSteer;

[StandardModule]
internal sealed class Module1
{
	public const short Background_and_Purpose_of_ChemSTEER = 1;

	public const short When_to_Use_ChemSTEER = 2;

	public const short Inappropriate_Use_and_Limitations_of_ChemSTEER = 3;

	public const short What_You_Need_to_Use_ChemSTEER = 5;

	public const short Completing_Comprehensive_Assessments = 7;

	public const short EPA_OPPT_Multiple_Process_Vessel_Residual_Model = 60;

	public const short EPA_OPPT_Single_Vessel_Residual_Model = 61;

	public const short EPA_OPPT_Penetration_Model = 62;

	public const short EPA_OAQPS_AP_42_Loading_Model = 63;

	public const short EPA_OPPT_Drum_Residual_Model = 64;

	public const short EPA_OPPT_Small_Container_Residual_Model = 65;

	public const short EPA_OPPT_Bulk_Transport_Residual_Model = 66;

	public const short EPA_OPPT_Solid_Residuals_in_Transport_Containers_Model = 67;

	public const short Dry_Solids = 72;

	public const short Bulk_Transport_Container = 79;

	public const short Drums = 80;

	public const short Small_Containers = 81;

	public const short Current_Future_Version_Information = 84;

	public const short Logic_and_Layout_Information = 85;

	public const short General_Tips_and_Notes_for_Using_ChemSTEER = 86;

	public const short Draft_List_of_Known_Issues_and_Problems = 87;

	public const short Providing_Feedback = 88;

	public const short Number_of_Batches_per_Site_Year_Nby_ = 90;

	public const short Purpose_and_Use_of_the_General_Tab = 98;

	public const short Purpose_and_Use_of_the_Chemical_Tab = 99;

	public const short Using_Individual_Methods_or_Developing_Partial_Assessments = 100;

	public const short Purpose_and_Use_of_the_Operation_Tab = 101;

	public const short Generating_and_Viewing_Summary_Reports = 107;

	public const short Starting_a_New_Assessment = 108;

	public const short Opening_an_Existing_Assessment = 109;

	public const short Setting_Your_Preference_for_the_Default_Database = 111;

	public const short Saving_Your_Assessment = 125;

	public const short Purpose_and_Use_of_the_Description_Subtab = 130;

	public const short Purpose_and_Use_of_the_Relationships_Subtab = 136;

	public const short Purpose_and_Use_of_the_Physical_States_Subtab = 137;

	public const short Purpose_and_Use_of_the_Sources_Activities_Subtab = 138;

	public const short Purpose_and_Use_of_the_Site_Information_Subtab = 139;

	public const short Purpose_and_Use_of_the_Mass_Balance_Parameters_Subtab = 141;

	public const short Entering_Updating_Mass_Balance_Parameters = 142;

	public const short Mass_Accounting_Basis_Selection = 144;

	public const short Specify_Mass_Balance_Input_Parameters = 145;

	public const short Specify_Other_Batch_Parameters = 146;

	public const short Purpose_and_Use_of_the_Container_Parameters_Subtab = 147;

	public const short Container_Parameters_Guidance = 151;

	public const short Verify_Select_Container_Parameters = 152;

	public const short Purpose_and_Use_of_the_Operation_Parameters_Tab = 154;

	public const short Purpose_and_Use_of_the_Releases_Tab = 161;

	public const short VerifySelect_Container_Parameter_by_Activity = 164;

	public const short General_Information_Operations_Available = 174;

	public const short General_Guidelines_for_Exposure_Assessment = 186;

	public const short EPA_OPPT_1_Hand_Contact_with_Liquid_Model = 191;

	public const short EPA_OPPT_2_Hand_Contact_with_Liquid_Model = 192;

	public const short EPA_OPPT_2_Hand_Immersion_in_Liquid_Model = 193;

	public const short EPA_OPPT_Direct_2_Hand_Contact_with_Solids_Model = 194;

	public const short EPA_OPPT_2_Hand_Contact_with_Container_Surfaces_Model = 195;

	public const short General_Information_Rel_Source_Exp_Activities = 216;

	public const short General_Guidelines_for_Release_Assessment = 223;

	public const short Purpose_and_Use_of_the_Optional_Information_Tab = 224;

	public const short Purpose_and_Use_of_the_Exposures_Tab = 227;

	public const short Type_of_Operation_Continuous_Basis_Influent = 229;

	public const short Type_of_Operation_Continuous_Basis_Effluent = 230;

	public const short Type_of_Operation_Batch_Basis_Influent = 231;

	public const short Type_of_Operation_Batch_Basis_Effluent = 232;

	public const short EPA_OPPT_Mass_Transfer_Coefficient_Model = 237;

	public const short User_Defined_Loss_Rate_Model = 239;

	public const short User_Defined_Vapor_Generation_Rate_Model = 241;

	public const short OSHA_PEL_Limiting_Model_for_Substance_Specific_Vapors = 242;

	public const short OSHA_Respirable_PNOR_PEL_Limiting_Model = 243;

	public const short EPAOPPT_Small_Volume_Solids_Handling_Model = 245;

	public const short OSHA_PELLimiting_Model_for_SubstanceSpecific_Particulates = 246;

	public const short OSHA_Total_PNOR_PELLimiting_Model = 247;

	public const short UserDefined_Dermal_Model = 248;

	public const short Cutting_Copying_and_Pasting = 249;

	public const short User_Defined_Inhalation_Model = 250;

	public const short Sources_of_Methods_and_Models_in_ChemSTEER = 6;

	public const short Abbreviations = 9;

	public const short EPAOPPT_Mass_Balance_Inhalation_Model = 11;

	public const short EPAOPPT_Water_Saturation_Loss_Model = 12;

	public const short Contact_Report_Format_Details = 4;

	public const short IRER_Format_Details = 10;

	public const short Vapor_Model_Activation = 13;

	public const short Purpose_and_Use_of_the_Shared_Parameters_Factors_Subtab = 14;

	public const short General_Information_on_Using_Models = 15;

	public const short The_Hierarchy_of_ChemSTEER_Operations_Activities_and_Models = 16;

	public const short Default_Model_Processing = 17;

	public const short Adjusted_Vapor_Pressures_for_the_Operation = 20;

	public const short Mass_Balance_Basis_Selection = 21;

	public const short ChemSTEER_HW_Reqs_SW_Issues = 22;

	public const short Calculating_Two_Sets_of_Results_from_a_Single_Model = 23;

	public const short EPA_OPPT_Automobile_Refinish_Spray_Coating_Inhalation_Exposure_Model = 24;

	public const short EPA_OPPT_Automobile_Spray_Coating_Inhalation_Exposure_Model_polyisocyanates_ = 25;

	public const short EPA_OPPT_UV_Roll_Coating_Inhalation_Model_non_volatiles_ = 26;

	public const short Storing_and_Display_of_Values_within_ChemSTEER = 27;

	public const short Deleting_an_Assessment_from_the_Database = 28;

	public const short EPA_OAQPS_AP_42_Loading_Model_Other_Sources_Activities = 29;

	public const short EPA_OPPT_Mass_Transfer_Coefficient_Model_Other_Sources_Activities = 30;

	public const short EPA_OPPT_Penetration_Model_Other_Sources_Activities = 31;

	public const short User_Defined_Vapor_Generation_Rate_Model_Sources_Activities = 32;

	public const short EPA_OPPT_Bulk_Transport_Residual_Model_Other_Sources_Activities = 33;

	public const short EPA_OPPT_Drum_Residual_Model_Other_Sources_Activities = 34;

	public const short EPA_OPPT_Multiple_Process_Vessel_Residual_Model_Other_Sources_Activities = 35;

	public const short EPA_OPPT_Single_Process_Vessel_Residual_Model_Other_Sources_Activities = 36;

	public const short EPA_OPPT_Small_Container_Residual_Model_Other_Sources_Activities = 37;

	public const short EPA_OPPT_Water_Saturation_Loss_Model_Other_Sources_Activities = 38;

	public const short EPA_OPPT_Small_Volume_Solids_Handling_Model_Other_Sources_Activities = 39;

	public const short EPA_OPPT_Mass_Balance_Inhalation_Model_Other_Sources_Activities = 40;

	public const short OSHA_PEL_Limiting_Model_for_Substance_Specific_Particulates_Sources_Activities = 41;

	public const short OSHA_PEL_Limiting_Model_for_Substance_Specific_Vapors_Sources_Activities = 42;

	public const short OSHA_Total_PNOR_PEL_Limiting_Model_Other_Sources_Activities = 43;

	public const short OSHA_Respirable_PNOR_PEL_Limiting_Model_Sources_Activities = 44;

	public const short EPA_OPPT_UV_Roll_Coating_Inhalation_Model_Other_Sources_Activities = 45;

	public const short EPA_OPPT_1_Hand_Dermal_Contact_with_Liquid_Model_Other_Sources_Activities = 46;

	public const short EPA_OPPT_2_Hand_Dermal_Contact_with_Liquid_Model_Other_Sources_Activities = 47;

	public const short EPA_OPPT_2_Hand_Dermal_Immersion_in_Liquids_Model_Other_Sources_Activities = 48;

	public const short EPA_OPPT_2_Hand_Dermal_Contact_with_Container_Surfaces_Solids_Model_Sources_Activities = 49;

	public const short Quick_Summary_of_ChemSTEER_Release_Models = 8;

	public const short Quick_Summary_of_ChemSTEER_Inhalation_Exposure_Models = 18;

	public const short Quick_Summary_of_ChemSTEER_Dermal_Exposure_Models = 19;

	public const short Viewing_an_Assessment_s_Revision_History = 50;
}
