   M S B A M L   `   `   `  ����V  RNewtonsoft.Json, Version=6.0.0.0, Culture=neutral, PublicKeyToken=30ad4fe6b2a6aeedT;clr-namespace:Newtonsoft.Json.Linq;assembly=Newtonsoft.JsonNewtonsoft.Json.Linq  5   	   R NGalaxyToAir_TestHarness, Version=1.0.0.7, Culture=neutral, PublicKeyToken=nulle7clr-namespace:GalaxyToAir_TestHarness.TemplateSelectors)GalaxyToAir_TestHarness.TemplateSelectors 5   	   a5clr-namespace:GalaxyToAir_TestHarness.ValueConverters'GalaxyToAir_TestHarness.ValueConverters 5   	   *   $JsonViewerDemo.JsonViewer.JsonViewer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Mjlinq;clr-namespace:Newtonsoft.Json.Linq;assembly=Newtonsoft.Json     5   	   UtemplateSelectors7clr-namespace:GalaxyToAir_TestHarness.TemplateSelectors     5   	   QvalueConverters5clr-namespace:GalaxyToAir_TestHarness.ValueConverters     5   	     � 	Resources  5      D  >GalaxyToAir_TestHarness.ValueConverters.MethodToValueConverter   MethodToValueConverterS  MGalaxyToAir_TestHarness.ValueConverters.ComplexPropertyMethodToValueConverter ) %ComplexPropertyMethodToValueConverter=  7GalaxyToAir_TestHarness.ValueConverters.JValueConverter  JValueConverterK  EGalaxyToAir_TestHarness.ValueConverters.JPropertyTypeToColorConverter ! JPropertyTypeToColorConverterH  BGalaxyToAir_TestHarness.ValueConverters.JValueTypeToColorConverter  JValueTypeToColorConverterC  =GalaxyToAir_TestHarness.ValueConverters.JArrayLengthConverter  JArrayLengthConverter �� DataType!   Newtonsoft.Json.Linq.JArray �� ItemsSource �� 	Converter �� ConverterParameter �� Orientation �� Padding J� Opacity  ArrayPropertyTemplate$   Newtonsoft.Json.Linq.JProperty �� Path	 �� Mode  ObjectPropertyTemplate  PrimitivePropertyTemplate"	   Newtonsoft.Json.Linq.JObject'
   !Newtonsoft.Json.Linq.JConstructor   Newtonsoft.Json.Linq.JRawM  GGalaxyToAir_TestHarness.TemplateSelectors.JPropertyDataTemplateSelector !	 JPropertyDataTemplateSelector
   ArrayPropertyTemplate   ObjectPropertyTemplate    PrimitivePropertyTemplate!   Newtonsoft.Json.Linq.JValue��%�  &	        &	      &	 &     &	 9     &	 L     &	 _     (�� r     5   #   *, +)7   7  &	 �    7  7  &	     7  &	     7  7  (�� a    53   #   *,	 +)7   (�� 0    59   #   *,
 +)7   (�� �    5=   #   *, +)7   &		     7  7  7  (�� 6    5G      *, +)7  7    5   
   61     5   
   6@     5   
   6*     5   
   68     5   
   65     5   
   60   �� 5   
   "  6#    6D   �� 8   $ Children��.R�5      �� $ 
Horizontal=�6   $��1q�62   .+�5      �� $��array��6   
����������#a40000$ 
3, 0, 3, 1q�6V   $	 0.4Q�6k   $��0,0,5,0q�6y   �� 5      ���#a40000��6   �� 8  6^   5      5      �� 5   
   "  6B    6f   �� 8   $ Children��.R�5      �� $ 
Horizontal=�6   $��1q�62   .+�5      �� ��6   �� $
 Name�$	 OneWay=��� 5      $	�� : ��6   �� 5      $��array��6   
����������#a40000$ 
3, 0, 3, 1q�6V   $	 0.4Q�6k   $��0,0,5,0q�6y   �� 5      ���#a40000��6   �� 8  6^   5      5      �� 5    
   "  6C    6g   �� 8   $ Children��.R�5!      �� $ 
Horizontal=�6   $��1q�62   .+�5"      �� ��6   �� $
 Name�$	 OneWay=��� 5#      $	�� : ��6   �� 5$      $	��{ }��6   ���#729fcf6)   5%      5&      �� 5'   
   "  69   .R�5)      �� $ 
Horizontal=�6   $��1q�62   .+�5*      �� ��6   �� $
 Name�$	 OneWay=��� 5+      $	�� : ��6   �� 5,      $��  ��6   �� 5.      -   5        $	��300��5.   O   $
��Wrap=�5/      ��60   �� $ Value�8   ��50      �� 8  51      52      �� 53   
   " 	 6#    6E   �� 8   $ Children��.R�54      �� $ 
Horizontal=�6   $��1q�62   .+�55      �� $�� ��6   �� 56      $	��{ }��6   ���#729fcf6)   57      58      �� 59   
   " 
 6#    6J   �� 8   $ Children��.R�5:      �� $��Constructor��6   5;      5<      �� 5=   
   "  6#    6B   �� 8   $ Children��.R�5>      �� $	��Raw��6   5?      5@        5B   
   8
   8  8  5E   .   �� 5G   
   "  6   .R�5H      �� -   5        $	��300��5H   K   $
��Wrap=�5I      ��60   �� 8   ��5J      �� 8  5K      5L      .��5M      � $��0,0,-949,-53q�6   .+�5N   
   R� -   5         R�Name$ JsonTreeViewRequest��5N   4   $��20q�6   $��
29,43,0,14q�6     �� IsTextSearchEnabled . #��[	 6l   $��0q�6�   $
��Bold"�6�   $
��Left=�6  $	��556��6   ��6�   �� $ treeViewRequest���5O      �� 5P       �� 
TargetType" Q�6   .�5Q      ��  �� Property �@Q�
IsExpanded �� Value 63   �� *jsonRequestTreeExpanded+5R      5T      R� 5U   
   -   5        $ JsonTreeViewResponse��5U   6   $��20q�6   $��610,43,35,13q�6     . #��[	 6o   $��0q�6�   $
��Bold"�6�   ��6�   �� $ treeViewResponse���5V      �� 5W      " Q�6   .�5X      ��  �@Q�
IsExpanded .  63   5Y      5[      �� 5\   
   $��Request��6   $
��Left=�6"   $��28,7,0,0q�6=   $	��Top=�6O   $��69��6g   �� 5]   
   $��Response��6   $
��Left=�6#   $��	605,7,0,0q�6>   $	��Top=�6Q   $��69��6i   �� 5^   
   $
��Copy��6   $
��Left=�6    $��	88,10,0,0q�6;   $	��Top=�6N   $��50��6f   ��6q   �� *copyJsonRequest+�� 5_   
   $
��Copy��6   $
��Left=�6    $��
674,10,0,0q�6;   $	��Top=�6O   $��48��6g   ��6r   �� *copyJsonResponse+5`      5a      