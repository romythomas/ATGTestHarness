   M S B A M L   `   `   `  ���� R  NGalaxyToAir_TestHarness, Version=1.0.0.8, Culture=neutral, PublicKeyToken=nullK*clr-namespace:GalaxyToAir_TestHarness.ViewGalaxyToAir_TestHarness.View  E'clr-namespace:JsonViewerDemo.JsonViewerJsonViewerDemo.JsonViewer  3    -GalaxyToAir_TestHarness.View.OrderDetailsView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:GalaxyToAir_TestHarness.View     >
JsonViewer'clr-namespace:JsonViewerDemo.JsonViewer       � DataContext  �� *OrderDetails+   Locator �� Source# [   � 	Resources   RowDetailTemplate �Name �� 
IsEditable �� Text �� TextWrapping J� RenderTransformOrigin �� DisplayMemberPath	 �� SelectedValuePath
 �� Path �� RelativeSource �� AncestorType �� SelectedValue(  "System.Windows.Controls.DatePicker   SelectedDate��%;
  &	       �� .R�� $ RowDetailGrid��.+�� .+��� $��Suffix:��$
��Left=�$��	10,12,0,0q�$	��Top=��� $
��Left=�$��	57,16,0,0q�$	��Top=�$��48��$��1�� .  �� *prefix+.@��� $	��Mr.���� $
��Mrs.���� $��First Name:��$
��Left=�$��
148,14,0,0q�$	��Top=��� $
��Left=�$��23��$��
223,17,0,0q�$
 Wrap=�$	��Top=�$	��150��$��2������ *	firstName+�� $��Middle Name:��$
��Left=�$��
406,14,0,0q�$	��Top=��� $
��Left=�$��23��$��
490,17,0,0q�$
 Wrap=�$	��Top=�$	��153��$ 0.617,0.565&�$��3������ *
middleName+�� $��	Sur Name:��$
��Left=�$��
683,14,0,0q�$	��Top=��� $
��Left=�$��23��$��
753,17,0,0q�$
 Wrap=�$	��Top=�$	��156��$ 0.617,0.565&�$��4������ *
lastName+�� $��Country:��$
��Left=�$��
984,10,0,0q�$	��Top=��� $
��Left=�$��1042,14,0,0q�$	��Top=�$	��189��$ 	0.854,0.5&� . $
 name��$
	 code��$��5������ $
 DataContext.lstCountry� �� *FindAncestor+" >� �� *	country+�� $
��DOB:��$
��Left=�$��	10,51,0,0q�$	��Top=�  $
��Left=�$��	57,52,0,0q�$	��Top=�$	��109��$��6�� �� *dateOfBirth+�� $��Gender:��$
��Left=�$��
228,50,0,0q�$	��Top=��� $
��Left=�$��
284,52,0,0q�$	��Top=�$��87��$��7�� .  �� *gender+.@��� $
��Male���� $��Female���� $��Street:��$
��Left=�$��
406,50,0,0q�$	��Top=��� $
��Left=�$��23��$��
490,53,0,0q�$
 Wrap=�$	��Top=�$	��153��$��8������ *street+�� $��City:��$
��Left=�$��
984,48,0,0q�$	��Top=��� $
��Left=�$��23��$��1042,50,0,0q�$
 Wrap=�$	��Top=�$	��189��$��10������ *city+�� $
��Apt:��$
��Left=�$��
694,49,0,0q�$	��Top=��� $
��Left=�$��23��$��
757,51,0,0q�$
 Wrap=�$	��Top=�$	��152��$��9������ *	apartment+�� $��State:��$
��Left=�$��	13,89,0,0q�$	��Top=��� $
��Left=�$��23��$��	57,91,0,0q�$
 Wrap=�$	��Top=�$��86��$ 
0.117,0.87&�$��11������ *state+�� $
��Zip:��$
��Left=�$��
228,89,0,0q�$	��Top=��� $
��Left=�$��23��$��
284,91,0,0q�$
 Wrap=�$	��Top=�$��87��$ 
0.117,0.87&�$��12������ *zip+�� $��Email:��$
��Left=�$��
406,89,0,0q�$	��Top=��� $
��Left=�$��23��$��
490,91,0,0q�$
 Wrap=�$	��Top=�$	��153��$ 
0.117,0.87&�$��13������ *email+�� $��Phone:��$
��Left=�$��
823,89,0,0q�$	��Top=��� $
��Left=�$��23��$��
906,91,0,0q�$
 Wrap=�$	��Top=�$	��117��$ 
0.117,0.87&�$��15������ *	phoneNo+�� $
��Left=�$��23��$��
870,91,0,0q�$
 Wrap=�$	��Top=�$��31��$ 
0.117,0.87&�$��14������ *countryCode+.��� $��0,0,-1100,-511q�.+��� $��Personal Details��$
��Left=�$	��280��$��	47,24,0,0q�$	��Top=�$
��1317��.��� $
��Left=�$��10,0,0,0q�$
��1287��.+�&   System.Windows.Controls.DataGrid  $
��Left=�$��10,7,0,0q�$	��Top=�$	��221��$ 0.5,0.5&�$
��1266��   AutoGenerateColumns .     RowDetailsTemplate# [    
IsReadOnly . ���� *	paxData+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$  ��   Width5  /System.Windows.Controls.DataGridLengthConverter$
 1285    
FontWeight$
 Bold"�1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *customerIndex+�� $��Confirm Order��$
��Left=�$��1173,233,0,0q�$	��Top=�$	��103��$��16������ *confirmOrder+�� $��Output��$
��Left=�$	��498��$��
48,304,0,0q�$	��Top=�$
��1316��.���� $
��Left=�$	��464��$��	10,10,0,0q�$	��Top=�$
��1287��.@��� $
��Data��.��� .+��� $��
Order Info��$
��Left=�$��	6,11,0,10q�$
��1261��.��� $
��Left=�$	��378��$��10,0,0,0q�$	��Top=�$
��1230��.+��� $��	Order ID:��$
��Left=�$��	523,8,0,0q�$	��Top=�$
��Bold"��� $
��Left=�$��	588,8,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26��$
��Bold"����� *orderData.orderId+�� $��Vehicle Order Id:��$
��Left=�$��
153,45,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��
275,45,0,0q�$	��Top=�$ 
0.5,-0.423&�$	��127��$��26������ *orderData.vehicleQuoteId+�� $��Price:��$
��Left=�$��
855,45,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��
907,45,0,0q�$	��Top=�$ 
0.5,-0.423&�$	��101��$��26������ *orderData.vehicletotalPrice+�� $��Air Order Id:��$
��Left=�$��
153,76,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��
275,76,0,0q�$	��Top=�$ 
0.5,-0.423&�$	��127��$��26������ *orderData.airQuoteId+�� $
��Left=�$��
786,81,0,0q�$	��Top=�$ 
0.5,-0.423&�$��80��$��26��$
��Bold"����� *" insuranceData.totalPremiumAmount+�� $��Price:��$
��Left=�$��
855,76,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��
907,76,0,0q�$	��Top=�$ 
0.5,-0.423&�$	��101��$��26������ *orderData.airtotalPrice+�� $��Insurance Order Id:��$
��Left=�$��153,113,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��275,113,0,0q�$	��Top=�$ 
0.5,-0.423&�$	��127��$��26������ *orderData.insuranceQuoteId+�� $��Price:��$
��Left=�$��855,113,0,0q�$	��Top=�$ 	0.362,0.5&��� $
��Left=�$��907,113,0,0q�$	��Top=�$ 
0.5,-0.423&�$	��101��$��26������ *orderData.insuranceTotalPrice+�� $��	Fare Rule��$
��Left=�$��1062,76,0,0q�$	��Top=�$	��100������ *viewFareRule+�� $��Rental Condition��$
��Left=�$��1062,49,0,0q�$	��Top=�$	��100������ *viewRentalCondition+�� $
��JSON��.��� ���	#FFE5E5E5.+�*   $JsonViewerDemo.JsonViewer.JsonViewer  $
��Left=�$��	-17,0,0,0q�$	��Top=�$	��350��$	��375���� $	��XML��.��� ���	#FFE5E5E5 � ColumnDefinitions �� $	��55* ��� $��1222* �.+�,   &GalaxyToAir_TestHarness.View.XMLViewer  $
��Left=�$	��Top=�$	��433��$
��1267��$��2��