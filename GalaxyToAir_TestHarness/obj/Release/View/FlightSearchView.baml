   M S B A M L   `   `   `  ���� R  NGalaxyToAir_TestHarness, Version=1.0.0.8, Culture=neutral, PublicKeyToken=nullK*clr-namespace:GalaxyToAir_TestHarness.ViewGalaxyToAir_TestHarness.View  E'clr-namespace:JsonViewerDemo.JsonViewerJsonViewerDemo.JsonViewer  3    -GalaxyToAir_TestHarness.View.FlightSearchView   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35^ ZWindowsFormsIntegration, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     @d2http://schemas.microsoft.com/expression/blend/2008     <local*clr-namespace:GalaxyToAir_TestHarness.View     >
JsonViewer'clr-namespace:JsonViewerDemo.JsonViewer       � DataContext  �� *FlightSearch+   Locator �� Source# [   � 	Resources   	BoolToVis��%   &	       �� .��� $��0,0,-1070,-520q�.+��� $��Search Flight��$
��Left=�$	��195��$��	45,24,0,0q�$	��Top=�$
��1315��.��� $
��Left=�$
��1206�� � ColumnDefinitions �� $	��59* ��� $
��708* ��� $
��149* �.+��� $
��Left=�$��
126,43,0,0q�$	��Top=�$	��222��$��22�� �� 
IsEditable .  �� DisplayMemberPath$
 name�� �� SelectedValuePath$
 code��$��1��$��3������ *
lstAirport+ �� SelectedValue �� *fromAirport+�� $��From:��$
��Left=�$��9,39,0,0q�$	��Top=�$��52��$��26��$��1���� $	��To:��$
��Left=�$��
414,36,0,0q�$	��Top=�$��33��$��26��$��1�� J� RenderTransformOrigin$ 0.515,1.423&��� $
��Left=�$��
484,40,0,0q�$	��Top=�$	��231��$��22�� . $
 name��$
 code��$��1��$��4������ *
lstAirport+ �� *	toAirport+�� $��Departure Date:��$
��Left=�$��9,81,0,0q�$	��Top=�$��96��$��26��$��1��(  "System.Windows.Controls.DatePicker  $
��Left=�$��
126,81,0,0q�$	��Top=�$	��128��$��24��$��1��$��5��	   SelectedDate	 �� *
traveldate+�� $��Adults:��$
��Left=�$��367,129,0,0q�$	��Top=�$��45��$��26��$��1���� $
��Left=�$��23��$��420,133,0,0q�
 �� TextWrapping$

 Wrap=�$	��Top=�$��51��$��1��$��9��$ -0.013,5.391&����� *adults+�� $��Child:��$
��Left=�$��563,127,0,0q�$	��Top=�$��41��$��26��$��1���� $
��Left=�$��23��$��609,130,0,0q�$

 Wrap=�$	��Top=�$��51��$��1��$��10��$ 0.098,0.522&����� *child+�� $
��Left=�$��
483,83,0,0q�$	��Top=�$	��121��$��22�� . $
 name��$
 code��$��1��$��6������ *lstCurrency+ �� *
currency+�� $��	Currency:��$
��Left=�$��
414,81,0,0q�$	��Top=�$��64��$��26��$��1���� $
��Left=�$��
817,78,0,0q�$	��Top=�$	��105��$��22��$��1��$��7�� .  �� Text �� *travelclass+.@��� $��Business���� $��Economy���� $��Class:��$��
749,78,0,0q�$	��Top=�$��26��$��1��$
��Left=�$��47��$ 0.085,0.615&��� $
��Skip��$
��Left=�$��	21,77,0,0q�$	��Top=�$	��102��$��22��$��2��$��13������ *	SkipClick+�� $��Search��$
��Left=�$��
19,127,0,0q�$	��Top=�$	��104��$��22��$��2��$��12������ *SearchClick+�� $��Return Date:��$
��Left=�$��
10,129,0,0q�$	��Top=�$��81��$��26��$��1��$ 0.662,0.462&�y��� *	roundTrip+ �� 	Converter# [   $
��Left=�$��126,129,0,0q�$	��Top=�$	��128��$��24��$��1��$��8��	 �� *
returndate+y��� *	roundTrip+# [ �� $��
Trip Type:��$
��Left=�$��4,6,0,0q�$	��Top=�$��62��$��26��$��1��	� $��One Way��$��1��$
��Left=�$��	96,10,0,0q�$	��Top=� 	� 	GroupName$ TripType��$��1�� d� 	IsChecked �� *
oneWayTrip+	� $��
Round Trip��$��1��$
��Left=�$��
181,10,0,0q�$	��Top=�$ TripType��$��2�� �� *	roundTrip+�� $
��Left=�$��
817,36,0,0q�$	��Top=�$	��105��$��22��$��1��$��7�� . $
 name��$
 code������ *lstSuppliers+ �� *	account+�� $��	Supplier:��$��
749,36,0,0q�$	��Top=�$��26��$��1��$
��Left=�$��58���� $��Output��$
��Left=�$	��574��$��
45,224,0,0q�$	��Top=�$
��1315��.���� $
��Left=�$	��523��$��	15,16,0,0q�$	��Top=�$
��1281��.@��� $
��Grid��$��23��$	��Top=�.��� ���	#FFE5E5E5.+�&   System.Windows.Controls.DataGrid  $
��Left=�$��	10,19,0,0q�$	��Top=�$	��459��$ 0.5,0.5&�$
��1251��   AutoGenerateColumns .     
IsReadOnly .    ClipboardCopyMode$ IncludeHeader=����� *offerDataList+   Columns 0  *System.Windows.Controls.DataGridTextColumn  ,  &System.Windows.Controls.DataGridColumn   Header$ Offer ID��   Width5  /System.Windows.Controls.DataGridLengthConverter$	 290 1  +System.Windows.Controls.DataGridBoundColumn   Binding �� *	OfferId+  $ 
Offer From��$	 290  �� *Owner+  $ 
Fare + Tax��$	 280  �� *
totalPrice+ �� StringFormat$ N2��   ElementStyle �� .���  �� Property �@��TextAlignment �� Value$ Right=�  $ 	Fare Type��$	 290  �� *
fareType+4  .System.Windows.Controls.DataGridTemplateColumn     CellTemplate �� .R��� $��Add to cart������ *FlightSearch.SelectFlight+# [  ����    RowDetailsTemplate �� .R�   .  ���� *
flightData+   $ Cabin Class��$	 120  �� *classMarketingName+  $ 
Designator��$	 120  �� *	classCode+  $ Marketing Carrier��$	 120  �� *MarketingAirlineId+  $ Flight Number��$	 120  �� *MarketingFlightNo+  $ Departing From��$	 120  �� *
DepAirport+  $ Arriving At��$	 120  �� *ArrivalAirport+  $ Departure Date��$	 120  �� *	DepDate+$ {0:MM/dd/yyyy}�� �� .���  �@��TextAlignment$ Right=�  $ Departure Time��$	 120  �� *	DepTime+  $ Arrival Date��$	 120  �� *ArrivalDate+$ {0:MM/dd/yyyy}�� �� .���  �@��TextAlignment$ Right=�  $ Arrival Time��$	 120  �� *ArrivalTime+�� $
��JSON��.��� ���	#FFE5E5E5.+�*   $JsonViewerDemo.JsonViewer.JsonViewer  $
��Left=�$��10,0,0,0q�$	��Top=�$	��436��$	��301���� $	��XML��.��� ���	#FFE5E5E5.+�,	   &GalaxyToAir_TestHarness.View.XMLViewer	  $
��Left=�$��	20,10,0,0q�$	��Top=�$	��468��$
��1241��