   M S B A M L   `   `   `  ����Q  MSystem.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089;,clr-namespace:System.Xml;assembly=System.Xml
System.Xml  5       GalaxyToAir_TestHarness,   &GalaxyToAir_TestHarness.View.XMLViewer   5      \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5      Axmlstack,clr-namespace:System.Xml;assembly=System.Xml     5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      $
��1254��6<   $	��362��6I     � 	Resources  5       �� Color   xmlValueBrush  xmAttributeBrush  xmlTagBrush  xmlMarkBrush  attributeTemplate �� Orientation �� Path �� 
TargetType �� Property �� Value  treeViewTemplate �� ItemsSource �� XPath	 ��Name
 �� Triggers �� Binding �� Value   System.Xml.XmlNodeType �� 
TargetName��%�  &	        &	 #     &	 E     &	 o     &	 �     7  7  7   7  'Q� �    &	     7  7  7  7  �� 5   
   $
 Blue��6   6'   �� 5   
   $	 Red��6   6&   �� 5	   
   $ DarkMagenta��6   6.   �� 5
   
   $
 Blue��6   6'   �� 5   
   .R�5      �� $ 
Horizontal=�6   $��3,0,0,0q�5      $��Center=�6*   .+�5      �� 8��  ��6   �� $
 Name�5      �� 5      $��="��6   8�� 5      �� 5      8�� ��6   �� $ Value�5      �� 5      $��"��6   8�� 5      5      5      �� 5   
   " Q�6   .�5      ��  �@Q�
IsExpanded . 6+   5      �� 5   
    5   #   �� $ child::node()��.R�5       �� $ 
Horizontal=�6   $��3,0,0,0q�62   $��Center=�5!      .+�5"      �� $	 startTag��5$      $��<��5"      $��Center=�6(   8��  5$      �� 5&      $	 xmlTag��5)      $��0q�5'      $��Center=�5(      8�� ��5&      �� $
 Name�5*      �� 5,      8�� $��Center=�5/      ��5.      �� $ 
Attributes���50      �� 51      .R�52      �� $ 
Horizontal=�6)   53      55      �� 57      $	 endTag��59      $��>��57      $��Center=�6(   8�� 59      5:      
 5<      �� 5=       6   �� *
NodeType+ 5>       5?      Text=�65   .a�5A      �� $ xmlTag��5B       5A   -   �� *	InnerText+ � ��5B      �� 5C      $ xmlTag��5D       � ��
 ��  ��� 5E      $ startTag��5F       � y�$ 	Collapsed=�5E   3   5F      �� 5G      $ endTag��5H       � y�$ 	Collapsed=�5G   3   5H      5I      �� 5K      $ False��6@    6   �� *HasChildNodes+.a�5L      �� $ endTag��6;    � ��$ />��6-   6;   5M      5O      5P      .��5R      � $��12,10,10,10q�6   .+�5S   
   R� -   5        $��xmlTree��5S      #��[ 5T      $
��Left=�6D   $	��571��6_   $��
17,31,0,10q�6k   ��6   �� *
xmlRequest+��5U      �� 5V      " Q�6   .�5W      ��  �@Q�
IsExpanded 63   �� *xmlRequestTreeExpanded+5X      5Z      R� 5[   
   -   5         R�Name$ xmlTree_Copy��5[      #��[ 5\   
   $
��Left=�6;   $	��611��6V   $��611,28,0,10q�6b   ��6w   �� *xmlResponse+��5]      �� 5^      " Q�6   .�5_      ��  �@Q�
IsExpanded .  63   5`      5b      �� 5c   
   $��Request��6   $
��Left=�6"   $��17,1,0,0q�6=   $	��Top=�6O   $��70��6g   �� 5d   
   $��Response��6   $
��Left=�6#   $��	613,2,0,0q�6>   $	��Top=�6Q   $��70��6i   �� 5e   
   $
��Copy��6   $
��Left=�6    $��77,4,0,0q�6;   $	��Top=�6M   $��51��6e   ��6p   �� *copyXmlRequest+�� 5f   
   $
��Copy��6   $
��Left=�6    $��	683,2,0,0q�6;   $	��Top=�6N   $��48��6f   ��6q   �� *copyXmlResponse+5g      5h      