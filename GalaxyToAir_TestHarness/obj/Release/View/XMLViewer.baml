   M S B A M L   `   `   `  ���� Q  MSystem.Xml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089;,clr-namespace:System.Xml;assembly=System.Xml
System.Xml   GalaxyToAir_TestHarness,   &GalaxyToAir_TestHarness.View.XMLViewer   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     Axmlstack,clr-namespace:System.Xml;assembly=System.Xml     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     $
��1254��$	��362��  � 	Resources   �� Color   xmlValueBrush  xmAttributeBrush  xmlTagBrush  xmlMarkBrush  attributeTemplate �� Orientation �� Path �� 
TargetType �� Property �� Value  treeViewTemplate �� ItemsSource �� XPath	 ��Name
 �� Triggers �� Binding �� Value   System.Xml.XmlNodeType �� 
TargetName��%�  &	        &	      &	      &	 6     &	 F     7  7  7   7  'Q� �     &	     7  7  7  7  �� $
 Blue���� $	 Red���� $ DarkMagenta���� $
 Blue���� .R��� $ 
Horizontal=�$��3,0,0,0q�$��Center=�.+��� 8��  ���� $
 Name��� $��="��8�� �� 8�� ���� $ Value��� $��"��8�� �� " Q�.���  �@Q�
IsExpanded . ��  �� $ child::node()��.R��� $ 
Horizontal=�$��3,0,0,0q�$��Center=�.+��� $	 startTag��$��<��$��Center=�8��  �� $	 xmlTag��$��0q�$��Center=�8�� ���� $
 Name��� 8�� $��Center=����� $ 
Attributes����� .R��� $ 
Horizontal=��� $	 endTag��$��>��$��Center=�8�� 
 ��  �� *
NodeType+  Text=�.a��� $ xmlTag�� �� *	InnerText+ � ���� $ xmlTag�� � ��
 ��  ��� $ startTag�� � y�$ 	Collapsed=��� $ endTag�� � y�$ 	Collapsed=��� $ False�� �� *HasChildNodes+.a��� $ endTag�� � ��$ />��.��� $��12,10,10,10q�.+�R� -   $��xmlTree��#��[ $
��Left=�$	��571��$��
17,31,0,10q����� *
xmlRequest+���� " Q�.���  �@Q�
IsExpanded �� *xmlRequestTreeExpanded+R� -    R�Name$ xmlTree_Copy��#��[ $
��Left=�$	��611��$��611,28,0,10q����� *xmlResponse+���� " Q�.���  �@Q�
IsExpanded .  �� $��Request��$
��Left=�$��17,1,0,0q�$	��Top=�$��70���� $��Response��$
��Left=�$��	613,2,0,0q�$	��Top=�$��70���� $
��Copy��$
��Left=�$��77,4,0,0q�$	��Top=�$��51������ *copyXmlRequest+�� $
��Copy��$
��Left=�$��	683,2,0,0q�$	��Top=�$��48������ *copyXmlResponse+