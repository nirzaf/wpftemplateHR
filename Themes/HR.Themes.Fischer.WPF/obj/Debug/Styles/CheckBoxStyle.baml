   M S B A M L   `   `   `  ����a  ]PresentationFramework.Aero, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35gJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.AeroMicrosoft.Windows.Themes  5   9   \ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089  �� MergedDictionaries �� Source   CheckBoxFillNormal �� Color  EmptyCheckBoxFocusVisual �� Property �� Value J� SnapsToDevicePixels �� StrokeDashArray  CheckBoxBackground �� EndPoint �� 
StartPoint	 � Color
 � Offset  CheckBoxStyle �� 
TargetType  ForegroundNormalColorBrush  OuterBorderBrushStyle  CheckBoxControlTemplate �� 
TargetType � RowDefinitions � ColumnDefinitions'   !System.Windows.VisualStateManager    VisualStateGroups%  System.Windows.VisualStateGroup   States   System.Windows.VisualState   
Storyboard �� TargetProperty �� 
TargetName R� KeyTime  System.Windows.Visibility   Visible R� Value   	Collapsed9  3System.Windows.Media.Animation.EasingDoubleKeyFrame O� KeyTime O� Value ��Name  ButtonCheckingColorBrush J� Opacity F�Name �� Stretch  ButtonCheckingColorBrush3 	 GrayLightBrush �� ContentStringFormat �� ContentStringFormat  �� Triggers! P� Property" P� Value�� 5      D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    :x,http://schemas.microsoft.com/winfx/2006/xaml     5      gMicrosoft_Windows_ThemesJclr-namespace:Microsoft.Windows.Themes;assembly=PresentationFramework.Aero  69   8d2http://schemas.microsoft.com/expression/blend/2008  6�   Bmc;http://schemas.openxmlformats.org/markup-compatibility/2006  6�     5      �� 5   
   $ ..\Colors\Colors.xaml?�6   %0  &	        &	 !     &	 �     &	 o    7  &	 �    �� 5      $ #F4F4F4��6.   �� 5	      .�5
      ��  � �� 5      �� 5      .R�5      �� $��1q�6    . #��� ��67   $��1��6~   $	 1 2R�6�   5      5      5      �� 5      $ 0.146,0.854&�62   $ 0.854,0.146&�6I   .��5      � $	 	#FFE7E7E7��6   $
 0Q�6#   � 5      $	 White��6   $
 1Q�6   5      �� 5      " ��6   .�5      ��  � ��# �  6!   �� 5       � ��# �  6!   �� 5       � ��# �  6"   �� 5       � ��$ 1q�6&   �� 5       �@�FocusVisualStyle8   6'   �� 5       � ��# �  6   �� 5       � ��$ Center=�6/   5      �� 5      " ��63   .R�5       � #��z��6	    5!      �� 5"      $��7* �6   �� 5#      $	��19* �6    5%      �� 5&      $��20 �6   �� 5'      $��* �6    5)        5*      CommonStates��. 5+        
Normal��6     5,      	MouseOver��. 5-      �� .��5.   	   T� $ (UIElement.Visibility)�6'   $ MouseOverRectangle��6Z   ..�5/   
   i� $ 0��6!   # Z 6-   50   
   51   	   52        53      Pressed��. 54      �� .��55   	   T� $ (UIElement.Visibility)�6'   $ MouseOverRectangle��6Z   ..�56   
   i� $ 0��6!   # Z 6-   57   
   U� 58   	   $ (UIElement.Opacity)�6'   $ MouseOverRectangle��6W   .\�59   
     $ 0��6   $	 0.9Q�6+   5:   
   T� 5;   	   $ (UIElement.Visibility)�6'   $ BaseRectangle��6Z   ..�5<   
   i� $ 0��6!   # Z 6-   5=   
   5>   	   5?        5@      Disabled��. 5A      �� .��5B   	   T� $ (UIElement.Visibility)�6'   $ DisabledRectangle��6Z   ..�5C   
   i� $ 0��6!   # Z 6-   5D   
   5E   	   5F      5G        5H      CheckStates��. 5I        Checked��. 5J      �� .��5K   	   T� $ (UIElement.Visibility)�6'   $
 Tick��6Z   ..�5L   
   i� $ 0��6!   # Z 6-   5M   
   U� 5N   	   $ (UIElement.Opacity)�6'   $ InnerRectangle��6W   .\�5O   
     $ 0��6   $	 0.3Q�6+   5P   
   5Q   	   5R        5S      	Unchecked��6     5T      Indeterminate��. 5U      �� .��5V   	   T� $ (UIElement.Visibility)�6'   $ InnerRectangle2��6Z   ..�5W   
   i� $ 0��6!   # Z 6-   5X   
   T� 5Y   	   $ (UIElement.Visibility)�6'   $ InnerRectangle1��6Z   ..�5Z   
   i� $ 0��6!   # Z 6-   5[   
   U� 5\   	   $I C(Shape.Fill).(GradientBrush.GradientStops)[0].(GradientStop.Offset)�6'   $ InnerRectangle2��6�   .\�5]   
     $ 0��6   $ 0Q�6+   5^   
   U� 5_   	   $ (UIElement.Opacity)�6'   $ InnerRectangle2��6W   .\�5`   
     $ 0��6   $ 1Q�6+   5a   
   U� 5b   	   $I C(Shape.Fill).(GradientBrush.GradientStops)[1].(GradientStop.Offset)�6'   $ InnerRectangle2��6�   .\�5c   
     $ 0��6   $
 0.75Q�6+   5d   
   T� 5e   	   $ (UIElement.Visibility)�6'   $ InnerRectangle��6Z   ..�5f   
   i� $ 0��6!   # Z 6-   5g   
   5h   	   5i      5j      .+�5l      � $��2��6
   .+�5m      �� $ BaseRectangle��6   #��z��6'   $��14��6N   $��14��6Y   $��Center=�6e   $��Center=�6�   #��z��6�   �� 5n      $ MouseOverRectangle��6   #���  6,   $��14��6`   $��14��6k   $��Center=�6w   $��Center=�6�   $	 0.7Q�6�   $y�	Collapsed=�6�   � 5o       . $��10��6&   $��10��61   $��Center=�6=   $��Center=�6Z   .+�5p      �� $ InnerRectangle��6   #��z��6)   $
��Auto��6P   $
��Auto��6]   $��Stretch=�6k   $��Stretch=�6�   $	 0.7Q�6�   �� 5q      $ InnerRectangle1��6   $
��Auto��6*   $
��Auto��67   $��Stretch=�6E   $��Stretch=�6c   $ 1Q�6   $y�	Collapsed=�6�   $��0��6�   ��5r      ��5s   	   	#FFEB7F11��6$   5u      �� 5v      $ InnerRectangle2��6   $
��Auto��6*   $
��Auto��67   $��Stretch=�6E   $��Stretch=�6c   $ 1Q�6   $y�	Collapsed=�6�   ���	#99414141��5w      �� 5x   	   $ 0.854,0.854&�6   $ 0.146,0.146&�64   .��5y   
   � $	 	#FFF4FF31��6   � 5z   
   $	 	#FFFF9800��6   $	
 0.6Q�6)   5{   
   5}      F� 5~      $
 Tick��6   ����p�Lu F����l�?-��� @Wי)J�����OP/5 @T�=Gc�?-��� @k��Y�g?�q�d!@�*��or����nsU"@=��YW�?nۍ  �	 �nۍ  �	 � ?5^�I�?��� mg ӿ � � �!@ �� �!@ �� �%Tpx�@i���l{"@�Qu�@��4�R"@��̍� @=/p�Q"@��̍� @=/p�Q"@%V�	��1?B.'WgC@%V�	��1?B.'WgC@���;=�w�L[��@E�'^�?�4��@B��h�?B.'Wg�@�,�r���?��=n@�A B.'Wgc@�C B.'WgS@⢤�N@GזK��@�o* B.'Wg�@��6 B.'Wg�@S��6 B.'Wg�@�Lu F����l�?�Lu F����l�?	$
��Left=�6�  $
 None=�6�  $��0��6�  $y�	Collapsed=�6�   .  $��Center=�6�  $��9.172��6  $��0.297,0.372,0,0.456q�6   $��9.509��6=  $ 1Q�6K  #���  6W  5      �� 5�      $ DisabledRectangle��6   $��14��6+   $��14��66   $��Center=�6B   $��Center=�6_   $	 0.5Q�6z   $y�	Collapsed=�6�   #��� 	 6�   5�      �� 5�      #��z��6   #��z��6J   # z 6n   #��z��6�   ��. # z 6  #��z��6D  $��1��6�  $��0,4.52,0,5.52q�6�  $��2��6�  5�        5�      P� 5�      ! � ��" . . �5�      ��  � ��$ 4,0,0,0q�6    5�      P� 5�      ! � {�" .  . �5�      �� # � ��6#    � ��5�      5�      5�      