   M S B A M L   `   `   `  ����G  CLandConquest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LandConquest.FormsLandConquest.Forms  5   	   O Kmscorlib, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089I2clr-namespace:System.Collections;assembly=mscorlibSystem.Collections 5   	   ?$clr-namespace:LandConquest.ResourcesLandConquest.Resources  5   	   %    LandConquest.Forms.RatingWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LandConquest.Forms     5   	   Bcol2clr-namespace:System.Collections;assembly=mscorlib     5   	   6ctrls$clr-namespace:LandConquest.Resources     5   	   -   5          � ShowInTaskbar  .   � WindowStyle$
 None=�5   	    � 
ResizeMode$ NoResize=�6    � Title$ ProfileWindow��5   	   $	��400��6   $	��600��6,   .��5      �� ���	#FF392018$��3q�6%   $	��400��69   $	��600��6F   ._�5   
   � .+�5      �� -   5         ��Name$ profileImage��5      $ ��/Pictures/profileImage.png��6*   $��UniformToFill=�6N   $	��103��6f   $	��Top=�6s   $
��Left=�6�   $��83��6�    J� RenderTransformOrigin$ 
0.38,0.495&�6�   $��0,10,0,0q�6�   �� 5   
   -   5         ��Name$ buttonXP��5      $	��Exp��6#   $
��Left=�62   $��
204,10,0,0q�6M   $	��Top=�6a   $��76��6y   ���	#FFD2C8B1��6�   Z� ��5      �� 5       �� ImageSource$< 6/LandConquest;component/Pictures/epic_button_brown.png��6   5      �� 5      -   5        $ buttonCoins��5      $	��Reg��6*   $
��Left=�68   $��
111,10,0,0q�6S   $	��Top=�6g   $��76��6   ���	#FFD2C8B1��6�   Z� ��5      �� 5      $< 6/LandConquest;component/Pictures/epic_button_brown.png��6!   5      �� 5      -   5        $ 
buttonArmy��5      $
��Army��6)   $
��Left=�69   $��
301,10,0,0q�6T   $	��Top=�6h   $��76��6�   ���	#FFD2C8B1��6�   Z� ��5      �� 5       $< 6/LandConquest;component/Pictures/epic_button_brown.png��6   5"      �� 5$   
   -   5        $ buttonTitles��5$      {�.  $��Title��69   $
��Left=�6J   $��
400,10,0,0q�6e   $	��Top=�6y   $��76��6�   
���������6�   Z� ��5%      �� 5&      $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6   5(      �� 5*   
   -   5        $ buttonClose��5*      $��	573,0,0,0q�6&   $	��Top=�69   $��20��6Q   $��20��6\   ��6h   Z� ��6   Z� ��5+      �� 5,      $6 0/LandConquest;component/Pictures/buttonCross.jpg��6    j� Stretch$ Uniform=�6\   5.      �� 51   
   -   5        	 ��Name$	 rankingsList��51      $
��Left=�6)   $	��302��6D   $��	83,74,0,0q�6Q   $	��Top=�6d   $	��440��6|   ��6�   �� *	ratings+��52      �� 53      $5 //LandConquest;component/Pictures/background.jpg��6%   
 �� View
 55      �� 57      .P�58      �� $��Player��6%    �� Width$	 200��6[    �� DisplayMemberBinding 65   �� *Name+6i   �� 59      $��Value��6%   $	 200��6Y    64   �� *Qty+6g   5:      5@      ��5B   
   �� 5C      $# /Pictures/background_pale.jpg��6   $ UniformToFill=�6E   5E      5F      5G      