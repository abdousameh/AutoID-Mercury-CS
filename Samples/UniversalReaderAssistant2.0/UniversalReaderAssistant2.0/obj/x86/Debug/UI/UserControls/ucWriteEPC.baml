   M S B A M L   `   `   `  ����  UniversalReaderAssistant     ThingMagic.URA2.ucWriteEPC   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5        � 	Resources  5       �� MergedDictionaries �� Source�� 5	   
    5
      �� 5      $" ../../StyleSheet/Themes.xaml?�6%   %    5      .��5      �� -   5        $��
spWriteEPC��5   4    �� Orientation$ Vertical=�6   $��10q�6(   {�.  $	��600��6X   $
��Left=�6d   .+�5   
   �� $��5q�6   $`��Z Note : Write EPC Operation supports only GEN2 Tags. Rest of the protocols will be ignored��6   6�   �� 5   
   -   5        $��
tagtowrite��5      
���������5      �� 5      $
��Bold"�6   
Write to68   .��5      �� -   5        $��grid1��5      $��5q�6&   $ Vertical=�61     5         boolToVisible��%   &	        �� 5      63   5      .+�5      	� -   5        $��
rbFirstTag��5   �   $��First tag to respond ��6;    	� 	GroupName$ Tagtowriteto��6[    d� 	IsChecked$
 TrueY�6t   $
��Left=�6�   $��3q�6�   $	��Top=�6�   	� 5      -   5        $��rbSelectedTag��5   �    ^� ShowOnDisabled .  � ToolTip$: 4Go to Tag Results tab and right-click on a data cell��6C   $&�� Tag selected in Tag Results page��6�   $ Tagtowriteto��6�   $
��Left=�6�   $��3q�6�   $	��Top=�6  {�.  6  � 5      -   5        $��gdTagSelectionCriteria��5      $��5q�65   y�6@   ��  �� ElementName$ rbSelectedTag��	 �� Path$	 	IsChecked�
 �� 	Converter#
 [  .+�5      �� $ Vertical=�6!   $��3q�68   .+�5      �� -   5        $��lblFilterDisplay��5       $
��Left=�68   $!��Select Filter for WriteEPC:��6T   $
��auto��6|   $	��Top=�6�   6�   �� 5      -   5        $��lblSelectFilter��5   H   $�� ��6    $
��Left=�6,   $	��Top=�6_   $
��auto��6w   5      �� 5       -	   5        $��txtEpc��5    M   $
��Left=�6   $��
220,20,0,0q�69   $	��Top=�6[   $��28��6s   $y�Hidden=�6~   �� 5!      -
   5        $��txtData��5!   M   $
��Left=�6   $��
270,20,0,0q�69   $	��Top=�6\   $y�Hidden=�6t   $��28��6�   5"      5#      5$      �� 5%   
   -   5        $��gbRespresentEPC��5%      
���������5&      �� 5'      $
��Bold"�6   How to represent EPC6D   .��5)      �� -   5        $��grid2��5)   0   $ Vertical=�6   $��5q�6=   .+�5*      	� -   5        $��rbHexRep��5*   �   $��Hexadecimal��6   $ RepresentEPC��6O   $
 TrueY�6h   $��3q�6y   6�   	� 5+      -   5        $��
rbASCIIRep��5+   t   $��
ASCII Text��6   $ RepresentEPC��6P   $��3q�6i   6t   	� 5,      -   5        $��rbReverseBase36Rep��5,   �   $��Reverse Base 36��6   $ RepresentEPC��6]   $��3q�6v   6�   5-      5.      �� 5/   
   -   5        $��gbCurrentEPC��5/      
���������50      �� 51      $
��Bold"�6   Current EPC6;   .��53      �� -   5        $��grid3��53   '   $
��Auto��6   $��5q�64   $ Vertical=�6?   .+�54      �� $ 
Horizontal=�6   .+�55      �� -   5        $��txtCurrentEpc��55   8    � Cursor$ Arrow��6   $��3q�6-   ���	#0A000000$��Center=�6e   $
��Left=�6�   $	��283��6�    �� CharacterCasing$ Normal=�6�   $��Consolas)�6�    �� TextWrapping$
 Wrap=�6�    �� 
IsReadOnly .  " �� VerticalScrollBarVisibility$
 Auto=�6�   .��6�   J� CommandBindings 56      )  #System.Windows.Input.CommandBinding  57      -   5           Command$ Paste��57   -   6=     58      -   5        $	 Cut��58   -   6;   .��59   3    � ContextMenu 5:      �� 5;      $y�	Collapsed=�6*   .��5<   /   5=      �� 5>      -   5        $��btnRead��5>   ]   $
��Read��6   $��50��6,   $
��Left=�67   $��3q�6R   $��Center=�6l   6�   5?      �� 5@      -   5        $��lblError��5@   N   $��Error��6   $
��Left=�6(   $��3q�6C   $��Center=�6^   $y�Hidden=�6y   $
��auto��6�   ���	#FFF60909 J� OpacityMask �	#FFFA00006�   5A      5B      �� 5C   
   -   5        $��gbNewEPC��5C      
���������5D      �� 5E      $
��Bold"�6   	New EPC67   .��5G      �� -   5        $��grid4��5G      $��5q�6&   $ 
Horizontal=�61   .+�5H      �� -   5        $��txtWriteEPC��5H   L   $��3q�6    �� 
CaretBrush
 �   �$
 Wrap=�68   ���	#0A000000$��Center=�6v   $ Normal=�6�    �� MaxLines$ 62��6�   $��Consolas)�6�   $	��283��6�   $
 Auto=�6�   �� 5I      -   5        $��btnWrite��5I   Z   $��Write��6   $��50��6)   $
��Left=�64   $��3q�6O   6j   5J      5K      5L      5M      