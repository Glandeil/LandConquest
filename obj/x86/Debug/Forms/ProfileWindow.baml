   M S B A M L   `   `   `  ����G  CLandConquest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LandConquest.FormsLandConquest.Forms  5   	   &     LandConquest.Forms.ProfileWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   V RMaterialDesignThemes.Wpf, Version=3.1.3.1513, Culture=neutral, PublicKeyToken=nullFmaterialDesign1http://materialdesigninxaml.net/winfx/xaml/themes  5   	   ,local clr-namespace:LandConquest.Forms  5   	   -   5          � WindowStyle$
  None=�5	   	    � 
ResizeMode$ NoResize=�6    � Title$ ProfileWindow��5
   	   $	��350��6   $	��600��6,    � ShowInTaskbar .  .��5      �� ���	#FF392018$��3q�6%   $	��350��69   $	��600��6F   ._�5   
   � .+�5      �� -   5         ��Name$ profileImage��5      $ ��/Pictures/profileImage.png��6*   $��UniformToFill=�6N   $	��103��6f   $	��Top=�6s   $
��Left=�6�   $��83��6�    J� RenderTransformOrigin$ 
0.38,0.495&�6�   $��0,14,0,0q�6�   �� 5      $��Name:��6   $��24(�6$   $
��Bold"�62   ���#311818$
��Left=�6Y   $��
115,54,0,0q�6t   $	��Top=�6�   $��40��6�   �� 5      $��Title:��6   $��24(�6%   $
��Bold"�63   ���#311818$
��Left=�6Z   $��
115,93,0,0q�6u   $	��Top=�6�   $��85��6�   �� 5      $��Land:��6   $��24(�6$   $
��Bold"�62   ���#311818$
��Left=�6Y   $��115,133,0,0q�6t   $	��Top=�6�   $��85��6�   $ 0.532,0.948&�6�   �� 5      $��Email:��6   $��24(�6%   $
��Bold"�63   ���#311818$
��Left=�6Z   $��115,173,0,0q�6u   $	��Top=�6�   $��85��6�   $ 0.532,0.948&�6�   �� 5      $��Login:��6   $��24(�6%   $
��Bold"�63   ���#311818$
��Left=�6Z   $��115,213,0,0q�6u   $	��Top=�6�   $��85��6�   $ 0.532,0.948&�6�   �� 5      $��Pass:��6   $��24(�6$   $
��Bold"�62   ���#311818$
��Left=�6Y   $��115,253,0,0q�6t   $	��Top=�6�   $��85��6�   $ 0.532,0.948&�6�   �� 5      -   5         ��Name$ 	labelName��5      $
��null��6'   ���#311818$��SemiBold"�6K   $��24(�6a   $
��Left=�6o   $��
212,54,0,0q�6�   $	��Top=�6�   $��40��6�   �� 5      -   5        $ 
labelTitle��5      $
��null��6(   ���#311818$��SemiBold"�6L   $��24(�6b   $
��Left=�6p   $��
212,93,0,0q�6�   $	��Top=�6�   �� 5      -   5        $ 	labelLand��5      $
��null��6'   ���#311818$��SemiBold"�6K   $��24(�6a   $
��Left=�6o   $��211,133,0,0q�6�   $	��Top=�6�   $ 0.5,0.5&�6�   �� 5      -   5        $ 
labelEmail��5      $
��null��6(   ���#311818$��SemiBold"�6L   $��24(�6b   $
��Left=�6p   $��211,173,0,0q�6�   $	��Top=�6�   $ 0.5,0.5&�6�   �� 5      -   5        $ 
labelLogin��5      $
��null��6(   ���#311818$��SemiBold"�6L   $��24(�6b   $
��Left=�6p   $��211,213,0,0q�6�   $	��Top=�6�   $ 0.5,0.5&�6�   �� 5      -   5        $ 	labelPass��5      $��••••••��6'   ���#311818$��SemiBold"�6M   $��24(�6c   $
��Left=�6q   $��212,253,0,0q�6�   $	��Top=�6�   $ 0.5,0.5&�6�   �� 5"      -	   5         ��Name$ buttonClose��5"      $��	573,0,0,0q�6*   $	��Top=�6=   $��20��6U   $��20��6`   ��6l   Z� ��6�   Z� ��5#      �� 5$       �� ImageSource$6 0/LandConquest;component/Pictures/buttonCross.jpg��6!   	 j� Stretch$	 Uniform=�6`   5&      �� 5(      -
   5        $ buttonChangeName��5(      $��Change��60   $��Arial)�6A   $��SemiBold"�6T   $��Center=�6j   $
��Left=�6�   $��
362,62,0,0q�6�   $	��Top=�6�   $	��100��6�   ���#e3cd9b$��32��6  ��6�   Z� ��5)      �� 5*      $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6!   5,      �� 5-      -   5        $ buttonChangeEmail��5-      $��Change��60   $��Arial)�6A   $��SemiBold"�6T   $��Center=�6j   $
��Left=�6�   $��362,181,0,0q�6�   $	��Top=�6�   $	��100��6�   ���#e3cd9b$��32��6  ��6�   Z� ��5.      �� 5/      $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6!   51      �� 52      -   5        $ buttonChangePass��52      $��Change��6/   $��Arial)�6@   $��SemiBold"�6S   $��Center=�6i   $
��Left=�6�   $��362,261,0,0q�6�   $	��Top=�6�   $	��100��6�   ���#e3cd9b$��32��6  ��6�   Z� ��53      �� 54      $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6!   56      �� 58      -   5        $ buttonSaveName��58      $
��Save��6.   $y�Hidden=�6=   $��Arial)�6Q   $��SemiBold"�6d   $��Center=�6z   $
��Left=�6�   $��
362,62,0,0q�6�   $	��Top=�6�   $	��100��6�   ���#e3cd9b$��32��6  ��6�   Z� ��59      �� 5:      $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6!   5<      �� 5=      -   5        $ buttonSaveEmail��5=      $
��Save��6.   $y�Hidden=�6=   $��Arial)�6Q   $��SemiBold"�6d   $��Center=�6z   $
��Left=�6�   $��362,181,0,0q�6�   $	��Top=�6�   $	��100��6�   ���#e3cd9b$��32��6  ��6�   Z� ��5>      �� 5?      $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6!   5A      �� 5B      -   5        $ buttonSavePass��5B      $
��Save��6-   $y�Hidden=�6<   $��Arial)�6P   $��SemiBold"�6c   $��Center=�6y   $
��Left=�6�   $��362,261,0,0q�6�   $	��Top=�6�   $	��100��6�   ���#e3cd9b$��32��6  ��6�   Z� ��5C      �� 5D      $A ;/LandConquest;component/Pictures/epic_long_brown_button.png��6!   5F      �� 5I      -   5        
 ��Name$
 newEmailBox��5I      $
��Left=�6+   $��32��6F   $��467,181,0,0q�6R    �� TextWrapping$
 Wrap=�6g   $	��Top=�6{   $	��109��6�   
���   ����	#FFEDE8DF.  (MaterialDesignThemes.Wpf.TextFieldAssist   DecorationVisibility$ Hidden=�6   �� SelectionBrush 6�   Z�  �� 
CaretBrush 6�   Z� ��6�   Z� 6  �� 5J      -   5        $
 
newPassBox��5J      $
��Left=�6+   $��32��6F   $��467,261,0,0q�6R   $
 Wrap=�6g   $	��Top=�6{   $	��109��6�   
���   ����	#FFEDE8DF$ Hidden=�6   6�   Z�  6�   Z� ��6�   Z� 6  �� 5K      -   5        $
 
newNameBox��5K      $
��Left=�6+   $��32��6F   $��
467,62,0,0q�6R   $
 Wrap=�6f   $	��Top=�6z   $	��109��6�   
���   ����	#FFEDE8DF$ Hidden=�6   6�   Z�  6�   Z� ��6�   Z� 6  ��5N      �� 5O      $# /Pictures/background_pale.jpg��6   $	 UniformToFill=�6I   5R      5S      5T      