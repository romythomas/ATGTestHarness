   M S B A M L   `   `   `  ����  GalaxyToAir_TestHarness(    "GalaxyToAir_TestHarness.MainWindow   5   	   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   0ignorehttp://www.galasoft.ch/ignore     5   	   $��718.631��5   	   $��1108.896��5	   	     � WindowStartupLocation$  CenterScreen=�5
   	    � WindowState$ 	Maximized=�5   	    � Title 5   	   �� *title+ � DataContext 5   	   �� *Main+   Locator �� Source# [   � 	Resources 5       �� MergedDictionaries �� Source�� 5   
    5      �� 5      $ Skins/MainSkin.xaml?�6%   %    5      .��5      � -   5         �Name$ 
LayoutRoot��5      $��0,0,2,0q�6   .+�5   
   ]� .+�5      o� $	��Top=�6   .@�5      m� $��_Booking��6   .@�5      m� $��_New Booking��6   .@�5      m� $
��_Air��6#   	 m� Command	 61   �� *cmdMenuRedirect+
 m� CommandParameter
 6U   �� *flightSearchMenu+m� 5      $
��_Car��6#   	 61   �� *cmdMenuRedirect+
 6U   �� *vehicleSearchMenu+m� 5      $��
_Insurance��6#   	 67   �� *cmdMenuRedirect+
 6[   �� *insuranceSearchMenu+5      m� 5      $��_Retrieve Booking��6   m� 5       $��
_Home Page��6   	 63   �� *cmdMenuRedirect+
 6W   �� *landingPageMenu+�� 5!      m� 5"      -   5        $��_Exit��5"      6.   5#      m� 5$      $��_Masters��6   5%      m� 5&      $��_Reports��6   5'      5(      �� 5)       �� AcceptsReturn . 6   5*      �� 5+   
   $��Disabled=�5-      $��Disabled=�5.      ��5,      �� *Navigation.CurrentPage+# [  5.      58      59      