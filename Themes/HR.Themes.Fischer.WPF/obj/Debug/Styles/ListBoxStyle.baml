   M S B A M L   `   `   `  ����\  XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   
ListBorder �� Color  ListBoxStyle �� 
TargetType �� Triggers P� Property P� Value �� Property  ButtonForeground �� Value  ListBoxItemStyle  ForegroundNormalColorBrush	 �� 
TargetType
 ��Name J� SnapsToDevicePixels  ButtonNormalBackground  ScrollViewerStyle �� Triggers �� 
TargetName ]� 
Conditions �� Property �� Value �� RelativeSource �� AncestorType'    !System.Windows.VisualStateManager    VisualStateGroups%   System.Windows.VisualStateGroup   States    System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName R� KeyTime  System.Windows.Visibility   Visible R� Value   ButtonDefaultStateBackground  ButtonNormalBackground2 	 TileQuadroBrushWhite J� OpacityMask J� Opacity 
 ListBoxMouseOverItemBrush  GrayMiddleBrush�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     :x,http://schemas.microsoft.com/winfx/2006/xaml      5      8d2http://schemas.microsoft.com/expression/blend/2008  69   Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  6v     5      �� 5   
   $ ..\Colors\Colors.xaml?�6   %f  &	        &	 !     7   &	 F    �� 5      $ #828790��6&   �� 5	      " ��6    5
      P� 5       �@��
IsSelected . . �5      ��  � ��# �  6#   5      .�5      ��  � ��# �  6)   �� 5       � ��# � ��6!   �� 5       � ��8   6"   �� 5       � ��$ 1q�6&   �� 5       � ��# �  6!   �� 5       � ��$
 Auto=�6A   �� 5       � ��$
 Auto=�6?   �� 5       � �� . 64   �� 5       �@��PanningMode$
 Both=�6/   �� 5       �@��IsFlicksEnabled .  6-   �� 5       � ��$ Center=�6/   �� 5       � �� 5      �� 5      "	 ��6   .R�5      �� $
 Bd��6   #��z��6   #��z��6F   #��z��6z    . ._�5      �� $��3,0,0,0q�6   #���  6)   ._�5   	   �� |�.  #��z��6(   #���  5    +   .��5!   
   �� # z 6   #��z��6U   5"   
   5#   	   5$       5%      P� 5&       � {� .  . �5'   	   �� $ Bd��6&   # � ��66    � ��5(   	   P� 5)       �@��
IsGrouping . . �5*   	   ��  � �� .  69   5+   	   5-      5/      50      �� 51      " ��6"    52      P� 53       �@J�IsMouseOver . . �54      ��  � ��# �  6#   55      ]� 56       57      �� 58       �@��
IsSelected . 60   �� 59       �@J�IsMouseOver .  6(   ./�5;      ��  � ��# �  6#   5<      .�5?      ��  � ��
 ���� 6!   �� 5@       � �� 61   �� *HorizontalContentAlignment+ �� " ���� 5A       � �� 6/   �� *VerticalContentAlignment+ �� " ���� 5B       � ��$ 5,2,0,3q�6   �� 5C       � �� 5D      �� 5E      "	 ��6   .R�5F      � #��z��6    5G        5H   	   CommonStates��. 5I   
     
Normal��6     5J   
   	MouseOver��. 5K      �� .��5L      T� $ (UIElement.Visibility)�6*   $ MouseOverBorder��6]   ..�5M      i� $ 0��6$   # Z 60   5N      5O      5P        5Q   
   Disabled��6   5R   
     5S   	   SelectionStates��. 5T   
     
Unselected��6     5U   
   Selected��. 5V      �� .��5W      T� $ (UIElement.Visibility)�6*   $ SelectedBorder��6]   ..�5X      i� $ 0��6$   # Z 60   5Y      5Z      5[        5\   
   SelectedUnfocused��. 5]      �� .��5^      T� $ (UIElement.Visibility)�6*   $ SelectedBorder��6]   ..�5_      i� $ 0��6$   # Z 60   5`      5a      5b      5c   
     5d   	   ValidationStates��. 5e   
     	Valid��6     5f   
   InvalidFocused��6     5g   
   InvalidUnfocused��6   5h   
   .+�5j      �� $
 SelectedBorder��6    . $��0,1,1,1q�6B   #���  6\   #���  6�   $y�	Collapsed=�6�   �� 5k      $
 MouseOverBorder��6    . $��0,1,1,1q�6C   #���  6]   $y�	Collapsed=�6�   ._�5l   	   � .+�5m   
   �� #���  6   �� 5n   
   #���  6   # � 	 6E   �� 5o   
   $	 0.9Q�6   $y�Visible=�6"   #��� 
 67   5p   
   5q   	   �� 5r      #��z��6   # z 6\   #��z��6�   #��z��6�   5s       5t      P� 5u       � {� .  . �5v   	   �� # �  6&    � ��5w   	   5y      5{      �� 5|       � ��
 �   �6"   �� 5}       � ��$ 0,1,1,1q�6&   �� 5~       � ��$
 Auto��6   �� 5       � ��$
 Auto��6   �� 5�       � ��# �  6!   5�      5�      