   M S B A M L   `   `   `  ���� R  NGalaxyToAir_TestHarness, Version=1.0.0.8, Culture=neutral, PublicKeyToken=nullK*clr-namespace:GalaxyToAir_TestHarness.ViewGalaxyToAir_TestHarness.View  E'clr-namespace:JsonViewerDemo.JsonViewerJsonViewerDemo.JsonViewer  6    0GalaxyToAir_TestHarness.View.InsuranceSearchView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:GalaxyToAir_TestHarness.View     >
JsonViewer'clr-namespace:JsonViewerDemo.JsonViewer       � DataContext  �� *InsuranceSearch+   Locator �� Source# [  .��� $��0,0,-1081,-508q�.+��� $��Search Insurance��$
��Left=�$	��201��$��	45,25,0,0q�$	��Top=�$
��1326��� $��0,-6,0,6q�.+��� $��Plicy Plan ID:��$
��Left=�$��	48,60,0,0q�$	��Top=��� $��Product Code:��$
��Left=�$��
348,61,0,0q�$	��Top=��� $
��Left=�$��26��$��
438,62,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��60��$��2������ *productCode+�� $
��Left=�$��26��$��
697,60,0,0q�$
 Wrap=�$	��Top=�$	��146��$��3������ *
tripCost+�� $��Birth Date:��$
��Left=�$��
48,108,0,0q�$	��Top=�(  "System.Windows.Controls.DatePicker  $
��Left=�$��129,109,0,0q�$	��Top=�   SelectedDateFormat$ Short=�$��6��   SelectedDate �� *	birthDate+�� $��Street:��$
��Left=�$��609,103,0,0q�$	��Top=�$��76��$��26���� $��City:��$
��Left=�$��879,109,0,0q�$	��Top=��� $
��Left=�$��26��$��959,109,0,0q�$
 Wrap=�$	��Top=�$	��151��$��9������ *city+�� $��Country:��$
��Left=�$��
48,151,0,0q�$	��Top=��� $
��Left=�$��129,155,0,0q�$	��Top=�$	��183��$��22�� J� RenderTransformOrigin$ 1,0.591&� �� 
IsEditable .  �� DisplayMemberPath$
 name�� �� SelectedValuePath$
 code��$��11������ *
lstCountry+	 �� SelectedValue	 �� *	country+�� $��Search��$
��Left=�$��1272,191,0,0q�$	��Top=�$��82��$��22��$ -0.64,2.182&����� *SearchClick+�� $
��Left=�$��26��$��
130,62,0,0q�$
 Wrap=�$	��Top=�$	��101��$��1������ *planID+�� $��
Trip Cost:��$
��Left=�$��
609,61,0,0q�$	��Top=�$ 0.183,0.577&��� $
��Left=�$��438,107,0,0q�$	��Top=�$��60��$��22��$��7�� . 
 �� Text
 �� *gender+.@��� $
��Male���� $��Female���� $��Gender:��$
��Left=�$��348,104,0,0q�$	��Top=�$��76��$��26���� $��First Name:��$
��Left=�$��
879,61,0,0q�$	��Top=��� $
��Left=�$��26��$��
954,61,0,0q�$
 Wrap=�$	��Top=�$	��156��$��4������ *	firstName+�� $��
Last Name:��$
��Left=�$��1132,61,0,0q�$	��Top=��� $
��Left=�$��26��$��1206,62,0,0q�$
 Wrap=�$	��Top=�$	��148��$��5������ *
lastName+�� $
��Left=�$��26��$��699,103,0,0q�$
 Wrap=�$	��Top=�$	��144��$��8������ *street+�� $
��Left=�$��26��$��1206,103,0,0q�$
 Wrap=�$	��Top=�$��60��$��10��$ 	1.2,0.346&����� *zip+�� $
��Zip:��$
��Left=�$��1141,103,0,0q�$	��Top=��� $
��Left=�$��26��$��438,148,0,0q�$
 Wrap=�$	��Top=�$��60��$��12������ *state+�� $��State:��$
��Left=�$��348,149,0,0q�$	��Top=��� $��Departure Date:��$
��Left=�$��609,148,0,0q�$	��Top=�  $
��Left=�$��703,148,0,0q�$	��Top=�$ Short=�$��13��$	��111�� �� *departureDate+�� $��Return Date:��$
��Left=�$��879,146,0,0q�$	��Top=�  $
��Left=�$��960,147,0,0q�$	��Top=�$ Short=�$��14�� �� *
returnDate+�� $��Init Dep Date:��$
��Left=�$��
53,191,0,0q�$	��Top=�  $
��Left=�$��141,192,0,0q�$	��Top=�$ Short=�$ 0.667,0.542&�$��15�� �� *initialDepositDate+�� $��Final Payment Date:��$
��Left=�$��309,190,0,0q�$	��Top=�$ 
0.67,0.538&�  $
��Left=�$��438,192,0,0q�$	��Top=�$ Short=�$ 0.667,0.542&�$��16�� �� *finalPaymentDate+�� $��DestinationCountry:��$
��Left=�$��613,190,0,0q�$	��Top=��� $
��Left=�$��728,194,0,0q�$	��Top=�$	��202��$��22��$ 1,0.591&� . $
 name��$
 code��$��17������ *
lstCountry+	 �� *destinationCountry+�� $
��Left=�$��26��$��1159,192,0,0q�$
 Wrap=�$	��Top=�$��60��$��18������ *destinationState+�� $��DestinationState:��$
��Left=�$��1054,190,0,0q�$	��Top=��� $
��Skip��$
��Left=�$��1272,151,0,0q�$	��Top=�$��82��$��22������ *	SkipClick+�� $
��Back��$
��Left=�$��1159,151,0,0q�$	��Top=�$��82��$��22��$ -0.354,0.682&����� *	BackClick+�� $��Output��$
��Left=�$	��574��$��
45,230,0,0q�$	��Top=�$
��1326��.��� .+��� $
��Left=�$	��532��$��	10,10,0,0q�$	��Top=�$
��1294��.@��� $
��Data��.��� .+��� $��Policy Info��$
��Left=�$	��480��$��	10,10,0,0q�$	��Top=�$
��1264��.��� $
��Left=�$	��376��$��10,0,-29,-12q�$	��Top=�$
��1240��y��� *policyVisible+.+��� $��Plan ID:��$
��Left=�$��	28,10,0,0q�$	��Top=��� $
��Left=�$��	83,10,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26������ *insuranceData.planID+�� $��Product Code:��$
��Left=�$��
244,10,0,0q�$	��Top=��� $
��Left=�$��
334,10,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26������ *insuranceData.productCode+�� $��Standard Premium:��$
��Left=�$��
463,10,0,0q�$	��Top=��� $
��Left=�$��
579,10,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26������ *insuranceData.standardPremium+�� $��Optional Premium:��$
��Left=�$��
687,10,0,0q�$	��Top=��� $
��Left=�$��
803,10,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26������ *insuranceData.optionalPremium+�� $��Standard Tax:��$
��Left=�$��	28,50,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��
113,50,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26������ *insuranceData.standardTax+�� $��Optional Tax:��$
��Left=�$��
249,50,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��
334,50,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26������ *insuranceData.optionalTax+�� $��Extended Tax:��$
��Left=�$��
463,50,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��
557,50,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26������ *insuranceData.extendedTax+�� $��Extended Premium:��$
��Left=�$��
690,50,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��
803,50,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26������ *insuranceData.extendedPremium+�� $��Promotional Premium:��$
��Left=�$��
468,81,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��
602,81,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26������ *" insuranceData.promotionalPremium+�� $��Fees Premium:��$
��Left=�$��	28,81,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��
120,81,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26������ *insuranceData.feesPremium+�� $��	Fees Tax:��$
��Left=�$��
253,81,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��
315,81,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26������ *insuranceData.feesTax+�� $��Total Premium Amount:��$
��Left=�$��
691,81,0,0q�$	��Top=�$ 	0.362,0.5&�$
��Bold"��� $
��Left=�$��
842,81,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26��$
��Bold"����� *" insuranceData.totalPremiumAmount+�� $��Add to cart��$
��Left=�$��701,135,0,0q�$	��Top=�$	��102��$��22������ *SelectInsurance+�� $
��JSON��.��� ���	#FFE5E5E5.+�*   $JsonViewerDemo.JsonViewer.JsonViewer  $
��Left=�$��	-18,0,0,0q�$	��Top=�$	��356��$	��445���� $	��XML��.��� ���	#FFE5E5E5.+�,   &GalaxyToAir_TestHarness.View.XMLViewer  $
��Left=�$��	10,10,0,0q�$	��Top=�$	��480��$
��1264��