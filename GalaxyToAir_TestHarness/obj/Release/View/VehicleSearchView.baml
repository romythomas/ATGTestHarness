   M S B A M L   `   `   `  ���� R  NGalaxyToAir_TestHarness, Version=1.0.0.8, Culture=neutral, PublicKeyToken=nullK*clr-namespace:GalaxyToAir_TestHarness.ViewGalaxyToAir_TestHarness.View  E'clr-namespace:JsonViewerDemo.JsonViewerJsonViewerDemo.JsonViewer  4    .GalaxyToAir_TestHarness.View.VehicleSearchView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:GalaxyToAir_TestHarness.View     >
JsonViewer'clr-namespace:JsonViewerDemo.JsonViewer       � DataContext  �� *VehicleSearch+   Locator �� Source# [  .��� $��0,7,-1142,-483q�.+��� $��Search Vehicle��$
��Left=�$	��174��$��	38,18,0,0q�$	��Top=�$
��1334��.��� $
��Left=�$
��1324��$��0,0,-2,5q�.+��� $��Pickup Date:��$
��Left=�$��	29,14,0,0q�$	��Top=�(  "System.Windows.Controls.DatePicker  $
��Left=�$��
110,15,0,0q�$	��Top=�   SelectedDateFormat$ Short=�$��1��$	��131��   SelectedDate �� *
pickupDate+�� $��Pickup Time:��$
��Left=�$��
471,15,0,0q�$	��Top=��� $
��Left=�$��26��$��
593,16,0,0q� �� TextWrapping$
 Wrap=�$	��Top=�$��60��$��2������ *
pickupHour+�� $
��Left=�$��26��$��
667,16,0,0q�$
 Wrap=�$	��Top=�$��60��$��3������ *pickupMinute+�� $��Pickup Location:��$
��Left=�$��
938,15,0,0q�$	��Top=��� $
��Left=�$��1039,18,0,0q�$	��Top=�$	��241��$��22�� �� 
IsEditable .  �� DisplayMemberPath$
 name�� �� SelectedValuePath$
 code��$��4������ *
lstAirport+ �� SelectedValue �� *pickupLocation+�� $��Return Date:��$
��Left=�$��	29,62,0,0q�$	��Top=�  $
��Left=�$��
110,63,0,0q�$	��Top=�$ Short=�$��5��$	��131�� �� *
returnDate+�� $��Return Time:��$
��Left=�$��
471,63,0,0q�$	��Top=��� $
��Left=�$��26��$��
593,64,0,0q�$
 Wrap=�$	��Top=�$��60��$��6������ *
returnHour+�� $
��Left=�$��26��$��
667,64,0,0q�$
 Wrap=�$	��Top=�$��60��$��7������ *returnMinute+�� $��Return Location:��$
��Left=�$��
938,63,0,0q�$	��Top=��� $
��Left=�$��1039,66,0,0q�$	��Top=�$	��241��$��22�� . $
 name��$
 code��$��8������ *
lstAirport+ �� *returnLocation+�� $
��Left=�$��111,110,0,0q�$	��Top=�$	��130��$��22�� . $
 name��$
 code��$��9������ *lstCurrency+ �� *
currency+�� $��	Currency:��$
��Left=�$��
29,110,0,0q�$	��Top=�$��76��$��26���� $��No Of Passengers:��$
��Left=�$��317,110,0,0q�$	��Top=��� $
��Left=�$��26��$��429,110,0,0q�$
 Wrap=�$	��Top=�$��60��$��10������ *noOfPassengers+�� $��Country:��$
��Left=�$��721,110,0,0q�$	��Top=��� $
��Left=�$��781,114,0,0q�$	��Top=�$	��213��$��22��	 J� RenderTransformOrigin$	 1,0.591&� . $
 name��$
 code��$��12������ *
lstCountry+ �� *	country+�� $��Search��$
��Left=�$��1194,114,0,0q�$	��Top=�$��75��$��22��$��13������ *SearchClick+�� $
��Age:��$
��Left=�$��563,110,0,0q�$	��Top=��� $
��Left=�$��26��$��602,110,0,0q�$
 Wrap=�$	��Top=�$��60��$��11������ *age+�� $
��Skip��$
��Left=�$��1110,114,0,0q�$	��Top=�$��69��$��22��$��13������ *	SkipClick+�� $
��Back��$
��Left=�$��1029,115,0,0q�$	��Top=�$��69��$��22��$��13������ *	BackClick+�� $��Output��$
��Left=�$	��566��$��
37,200,0,0q�$	��Top=�$
��1335��.��� $��0,0,-2,0q�.+��� $	��524��$��
21,10,10,0q�$	��Top=�.@��� $
��Grid��.��� ���	#FFE5E5E5.+�&   System.Windows.Controls.DataGrid  $
��Left=�$��	10,10,0,0q�$	��Top=�$	��472��$	 0.5,0.5&�$
��1266��
   AutoGenerateColumns
 .  ���� *vehicleDataList+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Vendor��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *
vendorName+  $ Model��$	 250  �� *makeModelName+  $ 
Drive Type��$	 150  �� *	driveType+  $ 	Fuel Type��$	 150  �� *
fuelType+  $ Transmission Type��$	 150  �� *transmissionType+  $ Air Condition��$	 130  �� *airConditionAvailable+  $ Amount��$	 150  �� *estimatedTotalAmount+4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��� $��Add to cart������ *VehicleSearch.SelectVehicle+# [  ���� �� $
��JSON��.��� ���	#FFE5E5E5.+�*   $JsonViewerDemo.JsonViewer.JsonViewer  $
��Left=�$	��Top=�$	��335��$	��439���� $	��XML��.��� ���	#FFE5E5E5.+�,	   &GalaxyToAir_TestHarness.View.XMLViewer	  $
��Left=�$��	10,10,0,0q�$	��Top=�$	��472��