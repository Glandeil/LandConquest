   M S B A M L   `   `   `  ����G  CLandConquest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LandConquest.FormsLandConquest.Forms  5   	   #    LandConquest.Forms.ChatWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LandConquest.Forms     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   -   5          � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�6    � WindowStartupLocation$ CenterScreen=�5
   	    � Title$ 
ChatWindow��5   	   $	��450��6   $	��850��6)    � ShowInTaskbar .  ��65   Z� .��5      �� ���	#FF392018$��3q�6%   $
��Auto��69   $
��Auto��6G   ._�5   
   � .+�5      �� -   5         ��Name$ textBoxNewMessage��5      .  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�61   $��1q�6n      UnderlineBrush
 ���� $��16(�6�   $
��Left=�6�   $��36��6�    �� TextWrapping$
 Wrap=�6�   	 �� 	MaxLength$	 80��6  $	��Top=�6  $	��733��60  
�������
���   �)  #MaterialDesignThemes.Wpf.HintAssist
   Hint$$
  Your message (80 symbols max)��5   h      
IsFloating .  $��
16,404,0,0q�6�   ���	#FF392018 �� 
CaretBrush 6%   Z�  �� SelectionBrush 6N   Z� 6�   �� 5      ���	#FF392018$��0q�6-   $
��Auto��6A   $
��Auto��6O   $��16,20,16.2,44.2q�6\   ._�5      � .+�5      �� -   5         ��Name$ listViewChat��5      ���	#DD000000
������� J� OpacityMask
 �����$��12(�6t   $��0,0,-0.8,-0.8q�6�   ��6�   Z�  �� View 5      �� 5      .P�5   "   �� $��Player��61    �� Width$ 65��6m    �� DisplayMemberBinding 6A   �� *
PlayerName+6z   �� 5   "   $��Message��61   $	 570��6q    6B   �� *PlayerMessage+6   �� 5   "   $
��Date��61   $	 135��6l    6?   �� *MessageTime+6z   5      5      ��5      �� 5       �� ImageSource$ /Pictures/background.jpg��6%    j� Stretch$ UniformToFill=�6L   5       5!      �� 5"      -   5         ��Name$ buttonSendMessage��5"      $
��Send��60   $
��Left=�6?   $��Center=�6Z   $	��Top=�6}   $��73��6�   $��36��6�   $��754,404,0,0q�6�   ���	#FFE1C993$��Book Antiqua)�6  ��6�   Z� ��5#      �� 5$      $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6!   5&      �� 5(      -   5        $ buttonClose��5(      $��Center=�6*   $��823,0,0.2,0q�6H   $	��Top=�6]   $��20��6�    J� RenderTransformOrigin$ 0.5,0.5&�6�   $��20��6�   ��6u   Z� ��6�   Z� ��5)      �� 5*      $6 0/LandConquest;component/Pictures/buttonCross.jpg��6!   5,      ��5.      �� 5/      $# /Pictures/background_pale.jpg��6   $ UniformToFill=�6I   51      52      53      