   M S B A M L   `   `   `  ����R  NGalaxyToAir_TestHarness, Version=1.0.0.7, Culture=neutral, PublicKeyToken=nullK*clr-namespace:GalaxyToAir_TestHarness.ViewGalaxyToAir_TestHarness.View  5      E'clr-namespace:JsonViewerDemo.JsonViewerJsonViewerDemo.JsonViewer  6G   5    /GalaxyToAir_TestHarness.View.BookingDetailsView   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      <local*clr-namespace:GalaxyToAir_TestHarness.View     5      >
JsonViewer'clr-namespace:JsonViewerDemo.JsonViewer     6G     � DataContext  5	      �� *BookingDetails+   Locator �� Source# [  .��5
      � $��0,0,-1020,-491q�6   .+�5   
   �� $��Booking Details��6   $
��Left=�6,   $	��277��6G   $��	21,21,0,0q�6T   $	��Top=�6g   $
��1289��6   .��5      � $
��Left=�6   $	��251��6.   $��10,0,0,0q�6;   $	��Top=�6M   $
��1233��6e   .+�5      �� $��Booking ID:��6   $
��Left=�6.   $��
594,10,0,0q�6I   $	��Top=�6]   $
��Bold"�6u   �� 5      $
��Left=�6A   $��
670,10,0,0q�6\   $	��Top=�6p    J� RenderTransformOrigin$ 
0.5,-0.423&�6�   $	��306��6�   $��26��6�   $
��Bold"�6�   ��6   �� *bookingData.superPNR+6�   �� 5      $��Vehicle Booking Id:��6   $
��Left=�66   $��
109,50,0,0q�6Q   $	��Top=�6e   $ 	0.362,0.5&�6}   �� 5      $
��Left=�6N   $��
231,50,0,0q�6i   $	��Top=�6}   $ 
0.5,-0.423&�6�   $	��228��6�   $��26��6�   ��6   �� *#!bookingData.vehicleProviderConfID+6�   �� 5      $��Price:��6   $
��Left=�6)   $��
929,50,0,0q�6D   $	��Top=�6X   $ 	0.362,0.5&�6p   �� 5      $
��Left=�6J   $��
981,50,0,0q�6e   $	��Top=�6y   $ 
0.5,-0.423&�6�   $��80��6�   $��26��6�   ��6   �� *bookingData.vehicleTotalPrice+6�   �� 5      $��Air Booking Id:��6   $
��Left=�62   $��
109,81,0,0q�6M   $	��Top=�6a   $ 	0.362,0.5&�6y   �� 5      $
��Left=�6J   $��
231,81,0,0q�6e   $	��Top=�6y   $ 
0.5,-0.423&�6�   $	��228��6�   $��26��6�   ��6   �� *bookingData.airProviderConfID+6�   �� 5      $
��Left=�6M   $��
786,81,0,0q�6h   $	��Top=�6|   $ 
0.5,-0.423&�6�   $��80��6�   $��26��6�   $
��Bold"�6�   ��6   �� *" insuranceData.totalPremiumAmount+6�   �� 5      $��Price:��6   $
��Left=�6)   $��
929,81,0,0q�6D   $	��Top=�6X   $ 	0.362,0.5&�6p   �� 5      $
��Left=�6F   $��
981,81,0,0q�6a   $	��Top=�6u   $ 
0.5,-0.423&�6�   $��80��6�   $��26��6�   ��6   �� *bookingData.airTotalPrice+6�   �� 5      $��Insurance Booking Id:��6   $
��Left=�68   $��109,118,0,0q�6S   $	��Top=�6h   $ 	0.362,0.5&�6�   �� 5      $
��Left=�6N   $��231,118,0,0q�6i   $	��Top=�6~   $ 
0.5,-0.423&�6�   $	��228��6�   $��26��6�   ��6   �� *#!bookingData.insurancePolicyNumber+6�   �� 5      $��Price:��6   $
��Left=�6)   $��929,118,0,0q�6D   $	��Top=�6Y   $ 	0.362,0.5&�6q   �� 5      $
��Left=�6S   $��981,118,0,0q�6n   $	��Top=�6�   $ 
0.5,-0.423&�6�   $��80��6�   $��26��6�   ��6   �� *(&bookingData.insurnceTotalPremiumAmount+6�   �� 5      $��FareRule��6   $
��Left=�6,   $��1099,81,0,0q�6G   $	��Top=�6\   $��79��6t   ��6   �� *viewFareRule+5       5!      �� 5"   
   $��Output��6   $
��Left=�6#   $��
22,303,0,0q�6>   $
��1288��6R   $	��471��6_   $	��Top=�6l   .��5#      �� $
��Left=�6   $	��436��64   $��	10,10,0,0q�6A   $	��Top=�6T   $
��1258��6l   .@�5$      �� $
��JSON��6   .��5%      � ���	#FFE5E5E5$��0,0,0,3q�62   .+�5&      *   $JsonViewerDemo.JsonViewer.JsonViewer  $
��Left=�60   $��	-19,0,0,0q�6K   $	��Top=�6^   $	��338��6v   $	��343��6�   5'      5(      �� 5)      $	��XML��6   .��5*      � ���	#FFE5E5E5$	��415��62   $	��Top=�6?   .+�5+      ,   &GalaxyToAir_TestHarness.View.XMLViewer  $
��Left=�6*   $��0,0,-6,0q�6E   $	��Top=�6W   $	��416��6o   5,      5-      5.      5/      50      51      