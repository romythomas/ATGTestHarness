   M S B A M L   `   `   `  ����R  NGalaxyToAir_TestHarness, Version=1.0.0.7, Culture=neutral, PublicKeyToken=nullK*clr-namespace:GalaxyToAir_TestHarness.ViewGalaxyToAir_TestHarness.View  5      E'clr-namespace:JsonViewerDemo.JsonViewerJsonViewerDemo.JsonViewer  6G   4    .GalaxyToAir_TestHarness.View.VehicleSearchView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:GalaxyToAir_TestHarness.View     5      >
JsonViewer'clr-namespace:JsonViewerDemo.JsonViewer     6G     � DataContext  5	      �� *VehicleSearch+   Locator �� Source# [  .��5
      � $��0,7,-1142,-483q�6   .+�5   
   �� $��Search Vehicle��6   $
��Left=�6+   $	��174��6F   $��	38,18,0,0q�6S   $	��Top=�6f   $
��1334��6~   .��5      � $
��Left=�6   $
��1324��6.   $��0,0,-2,5q�6;   .+�5      �� $��Pickup Date:��6   $
��Left=�6/   $��	29,14,0,0q�6J   $	��Top=�6]   (  "System.Windows.Controls.DatePicker  5      $
��Left=�6   $��
110,15,0,0q�68   $	��Top=�6L      SelectedDateFormat$ Short=�6d   $��1��6�   $	��131��6�      SelectedDate 6   �� *
pickupDate+6�   �� 5      $��Pickup Time:��6   $
��Left=�6/   $��
471,15,0,0q�6J   $	��Top=�6^   �� 5      $
��Left=�6   $��26��65   $��
593,16,0,0q�6A    �� TextWrapping$
 Wrap=�6U   $	��Top=�6i   $��60��6�   $��2��6�   ��6�   �� *
pickupHour+6�   �� 5      $
��Left=�6   $��26��65   $��
667,16,0,0q�6A   $
 Wrap=�6U   $	��Top=�6i   $��60��6�   $��3��6�   ��6�   �� *pickupMinute+6�   �� 5      $��Pickup Location:��6   $
��Left=�63   $��
938,15,0,0q�6N   $	��Top=�6b   �� 5      $
��Left=�6   $��1039,18,0,0q�66   $	��Top=�6K   $	��241��6c   $��22��6o    �� 
IsEditable .  �� DisplayMemberPath$
 name��5       �� SelectedValuePath$
 code��5      $��4��5   /   ��5      �� *
lstAirport+ �� SelectedValue 5      �� *pickupLocation+6/   �� 5      $��Return Date:��6   $
��Left=�6/   $��	29,62,0,0q�6J   $	��Top=�6]     5      $
��Left=�6   $��
110,63,0,0q�68   $	��Top=�6L   $ Short=�6d   $��5��6�   $	��131��6�    6   �� *
returnDate+6�   �� 5      $��Return Time:��6   $
��Left=�6/   $��
471,63,0,0q�6J   $	��Top=�6^   �� 5      $
��Left=�6   $��26��65   $��
593,64,0,0q�6A   $
 Wrap=�6U   $	��Top=�6i   $��60��6�   $��6��6�   ��6�   �� *
returnHour+6�   �� 5       $
��Left=�6   $��26��65   $��
667,64,0,0q�6A   $
 Wrap=�6U   $	��Top=�6i   $��60��6�   $��7��6�   ��6�   �� *returnMinute+6�   �� 5!      $��Return Location:��6   $
��Left=�63   $��
938,63,0,0q�6N   $	��Top=�6b   �� 5"      $
��Left=�6   $��1039,66,0,0q�66   $	��Top=�6K   $	��241��6c   $��22��6o    . $
 name��5%      $
 code��5&      $��8��5'   /   ��5$      �� *
lstAirport+ 5'      �� *returnLocation+6/   �� 5(      $
��Left=�6   $��111,110,0,0q�66   $	��Top=�6K   $	��130��6c   $��22��6o    . $
 name��5+      $
 code��5,      $��9��5-   )   ��5*      �� *lstCurrency+ 5-      �� *
currency+6)   �� 5.      $��	Currency:��6   $
��Left=�6,   $��
29,110,0,0q�6G   $	��Top=�6[   $��76��6s   $��26��6~   �� 5/      $��No Of Passengers:��6   $
��Left=�64   $��317,110,0,0q�6O   $	��Top=�6d   �� 50      $
��Left=�6   $��26��65   $��429,110,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $��60��6�   $��10��6�   ��6�   �� *noOfPassengers+6�   �� 51      $��Country:��6   $
��Left=�6+   $��721,110,0,0q�6F   $	��Top=�6[   �� 52      $
��Left=�6   $��781,114,0,0q�66   $	��Top=�6K   $	��213��6c   $��22��6o   	 J� RenderTransformOrigin$	 1,0.591&�6{    . $
 name��55      $
 code��56      $��12��57   (   ��54      �� *
lstCountry+ 57      �� *	country+6(   �� 58      $��Search��6   $
��Left=�6*   $��1194,114,0,0q�6E   $	��Top=�6[   $��75��6s   $��22��6~   $��13��6�   ��6�   �� *SearchClick+6�   �� 59      $
��Age:��6   $
��Left=�6'   $��563,110,0,0q�6B   $	��Top=�6W   �� 5:      $
��Left=�6   $��26��65   $��602,110,0,0q�6A   $
 Wrap=�6V   $	��Top=�6j   $��60��6�   $��11��6�   ��6�   �� *age+6�   �� 5;      $
��Skip��6   $
��Left=�6(   $��1110,114,0,0q�6C   $	��Top=�6Y   $��69��6q   $��22��6|   $��13��6�   ��6�   �� *	SkipClick+6�   �� 5<      $
��Back��6   $
��Left=�6(   $��1029,115,0,0q�6C   $	��Top=�6Y   $��69��6q   $��22��6|   $��13��6�   ��6�   �� *	BackClick+6�   5=      5>      �� 5?   
   $��Output��6   $
��Left=�6#   $	��566��6>   $��
37,200,0,0q�6K   $	��Top=�6_   $
��1335��6w   .��5@      � $��0,0,-2,0q�6   .+�5A      �� $	��524��6   $��
21,10,10,0q�6*   $	��Top=�6>   .@�5B      �� $
��Grid��6   .��5C      � ���	#FFE5E5E5.+�5D      &   System.Windows.Controls.DataGrid  $
��Left=�6'   $��	10,10,0,0q�6B   $	��Top=�6U   $	��472��6m   $	 0.5,0.5&�6z   $
��1266��6�   
   AutoGenerateColumns
 .  ��6�   �� *vehicleDataList+   Columns 5E   "   0  *System.Windows.Controls.DataGridTextColumn  5F   &   ,  &System.Windows.Controls.DataGridColumn   Header$ Vendor��69      Width5  /System.Windows.Controls.DataGridLengthConverter$	 150 6h   1  +System.Windows.Controls.DataGridBoundColumn   Binding 6I   �� *
vendorName+6h     5G   &   $ Model��69   $	 250 6j    6H   �� *makeModelName+6j     5H   &   $ 
Drive Type��69   $	 150 6k    6M   �� *	driveType+6k     5I   &   $ 	Fuel Type��69   $	 150 6i    6L   �� *
fuelType+6i     5J   &   $ Transmission Type��69   $	 150 6y    6T   �� *transmissionType+6y     5K   &   $ Air Condition��69   $	 130 6z    6P   �� *airConditionAvailable+6z     5L   &   $ Amount��69   $	 150 6r    6I   �� *estimatedTotalAmount+6r   4  .System.Windows.Controls.DataGridTemplateColumn  5M   &      CellTemplate 5N   *   �� 5O   .   .R�5P   2   �� $��Add to cart��6�   ��69   �� *VehicleSearch.SelectVehicle+# [  ��6�   �� 6�   5Q   /   5S   '   5U      5V      5W      �� 5X      $
��JSON��6   .��5Y      � ���	#FFE5E5E5.+�5Z      *   $JsonViewerDemo.JsonViewer.JsonViewer  $
��Left=�64   $	��Top=�6O   $	��335��6g   $	��439��6s   5[      5\      �� 5]      $	��XML��6   .��5^      � ���	#FFE5E5E5.+�5_      ,	   &GalaxyToAir_TestHarness.View.XMLViewer	  $
��Left=�6.   $��	10,10,0,0q�6I   $	��Top=�6\   $	��472��6t   5`      5a      5b      5d      5e      5h      5i      