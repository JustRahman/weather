   M S B A M L   `   `   `  ����B  >weather, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null-clr-namespace:weather.Viewsweather.Views  5   	   /clr-namespace:weather.Helperweather.Helper  5   	   5clr-namespace:weather.ModelViewweather.ModelView  5	   	   a ]DevExpress.Xpf.Core.v21.1, Version=21.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aZCclr-namespace:DevExpress.Mvvm.UI;assembly=DevExpress.Xpf.Core.v21.1DevExpress.Mvvm.UI 5   
   5clr-namespace:weather.ModelViewweather.ModelView  5   	       weather.Views.Views   5   	   ;dx2http://schemas.devexpress.com/winfx/2008/xaml/core  R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35F 9http://schemas.microsoft.com/winfx/2006/xaml/presentation     5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   -localclr-namespace:weather.Views     5   	   3
convertersclr-namespace:weather.Helper     5   	   6
ViewModelsclr-namespace:weather.ModelView     5	   	   Wdxmvvm1Cclr-namespace:DevExpress.Mvvm.UI;assembly=DevExpress.Xpf.Core.v21.1     5   
   e aDevExpress.Xpf.Controls.v21.1, Version=21.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aCdxwui7http://schemas.devexpress.com/winfx/2008/xaml/windowsui  5   	   ] YDevExpress.Mvvm.v21.1, Version=21.1.3.0, Culture=neutral, PublicKeyToken=b88d1754d700e49aAdxmvvm2http://schemas.devexpress.com/winfx/2008/xaml/mvvm   5   	   OdxwuinBhttp://schemas.devexpress.com/winfx/2008/xaml/windowsui/navigation  5   	   /	ModelViewclr-namespace:weather.ModelView  5   	   -   5          �Name$  Window��5   	    � WindowStyle$
 None=�5	   <    � AllowsTransparency .  � Title$ Views��5   	   $	��600��6   $
��1000��6$   ��5   	   �� *all_background+ � 	Resources 5      -  'weather.Helper.dk_MultiBindingConverter   MultiBindingConverter��%   &	          5   
   6.   5       � DataContext 5      !  weather.ModelView.ViewModel  5   
    J� Clip 5(      �� 5)   
    �� Rect$ 0,0,1000,600�6    �� RadiusX$ 30Q�60   	 �� RadiusY$	 30Q�6=   .��5-      � 
 � RowDefinitions
 50   
   �� 51      $
��0.1* �6   �� 52       � ColumnDefinitions 54   
   �� 55      $
��0.4* �6   �� 56      .+�59   
   �� $��0��6   $��2��6%   $��10 0 0 0q�66   $��0��6I   .+�5;      �� $��Medium"�64   $��20(�6H   $
��Left=�6V   ��6   �� *
highlights+6V   �� 5>      $	��200��6   $	��150��6"   ��60   �� *svg_path_weather+�� 5@      $��3��6   $	��Top=�6,   $��1��6D   .+�5A      ��  �� Orientation$ 
Horizontal=�6   .+�5B      �� $B��<C:\Data\source\WPF\weather\bin\Debug\clothes\thermometor.png��67   $��70��6}   ��6   �� *	mar_btn+6}   �� 5C      $	��120��6"   $
��auto��6/   $��80(�6<   ��6J   �� *blact_to_white+��6p   �� *temperature+�� 5D      $	��100��6     �� Padding$ 	0 33 0 0 q�6-   $��50��6A   $��C��6L   $��50(�6U   
�������$��0 0 0 20q�6u   5E      �� 5F      $ 
Horizontal=�6   .+�5G      �� $ 20 0 0 0q�6a   $��60��6t   $��Medium"�6�   $��30(�6�   $��Center=�6�   ��6    �� *	mar_btn+��6;   �� *blact_to_white+��6�   �� *	real_feel+6�   �� 5H      $��30��6    $��20��6,   $��C��67   $��Medium"�6@   $��20(�6T   $��0 0 0 5q�6b   
�������$��Right=�6�   5I      5J      �� 5L      $��0 10 0 0q�6   .+�5M      �� $��Medium"�6X   $��40��6m   $ 30 0 0 0q�6y   $��25(�6�   ��6   �� *blact_to_white+��6B   �� *time+6�   5N      �� 5P      $ 25 0 0 0q�6   $��Medium"�6,   $��20(�6@   $
��auto��6O   $��35��6\   ��6h   �� *weather_main+�� 5T       �� CornerRadius$ 15��6   
���   �$
��20 0q�6:   ._�5U      �� $ 15��6    �� Padding$
 0 50q�6+   ��5V      �� 5W       �� ImageSource$< 6C:\Data\source\WPF\weather\bin\Debug\clothes\Earth.jpg��6%    j� Stretch$
 Fill=�6j    �� Opacity$	 0.4Q�6y   ._�5Z      �� $��Center=�6e   $��Center=�6�   $
��Bold"�6�   $��20(�6�   ��6!   �� *current_city+��6?   �� *blact_to_white+6�   5[      5\      5a      .  (DevExpress.Xpf.WindowsUI.NavigationFrame  5c   
   $��1��6    $��1��6-   2  ,DevExpress.Mvvm.UI.Interactivity.Interaction   	Behaviors 5d      '  !DevExpress.Mvvm.UI.EventToCommand  5e      �  �DevExpress.Mvvm.UI.Interactivity.EventTriggerBase`1[[System.Windows.DependencyObject, WindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]   	EventName$ Loaded��6(   +  %DevExpress.Mvvm.UI.EventToCommandBase   Command 6;   �� *OnViewLoadedCommand+@  :DevExpress.Xpf.WindowsUI.Navigation.FrameNavigationService  5f      5h      � 5k   
   $��1��6   .+�5l      �� $��40��6   $��50��6!   $��10 0 0 0q�6,   $
��Left=�6>   ��6Y   �� *	go_back+� 5o      $��0��6   $��1��6    $��0 0 20 0q�60   $	��Top=�6B   $��Right=�6Z   .+�5q      �� $ 
Horizontal=�6   .+�5r      �� $��50��6   $��Ch��6�   $
��Bold"�6�   ��6(   �� *btn_change_let+��6N   �� *
btn_change+��6p   �� *btn_change_com+6�   �� 5s      $��50��6   $	��°C��6�   $
��Bold"�6�   ��6(   �� *btn_cel_frg+��6K   �� *btn_cel_bck+��6n   �� *	btn_cel+6�   �� 5t      $��50��6   $	��°F��6(   $
��Bold"�6�   ��65   �� *	btn_frg+��6T   �� *	btn_bck+��6s   �� *	btn_far+6�   &	   DevExpress.Xpf.Core.SimpleButton	  5u      $
��Mini��6'   $��30��66   $��50��6B   ��6M   �� *
cmdLogin+��5v      `� 5w       `� 	Converter# [  6+   .1�5x   "   ��  �� ElementName$ Window��6*   5y      5{      	  5|      $	��Dis��6'   $��30��65   $��50��6A   ��6L   �� *close_application+��5}      `� 5~      # [  6+   .1�5   "   �� $ Window��6*   5�      5�      5�      5�      5�      5�      5�      