   M S B A M L   `   `   `  ����G  CLandConquest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LandConquest.FormsLandConquest.Forms  5   	   &     LandConquest.Forms.CountryWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LandConquest.Forms     5   	   -   5          � WindowStyle$
  None=�5       � 
ResizeMode$ NoResize=�6-    � Title$ CountryWindow��5   	   $	��450��6   $	��800��6,   .��5	      �� ���	#FF392018$��3q�6%   $
��Auto��69   $
��Auto��6G   ._�5
   
   � -   5         �Name$ MainGrid��5
      ��5      �� 5       �� ImageSource$# /Pictures/background_pale.jpg��6    j� Stretch$ UniformToFill=�6I   .+�5      �� -   5         ��Name$ CountryNameLbl��5      $��24(�6,   $��12345��6;   $
��Left=�6K   $��52,6,0,0q�6f   $	��Top=�6x   $	��294��6�   $��52��6�   $��Trebuchet MS)�6�   �� 5      -   5        $ RulerNameLbl��5      $��24(�6*   $��	RulerName��69   $
��Left=�6M   $��
109,57,0,0q�6h   $	��Top=�6|   $	��233��6�   $��52��6�   $��Trebuchet MS)�6�   �� 5      -   5         ��Name$ RulerImg��5      $
��Left=�6&   $��40��6A   $��	10,10,0,0q�6M   $	��Top=�6`   $��37��6x   $9��3/LandConquest;component/Pictures/profileDefault.png��6�   �� 5      $��18(�6   $��Leader:��6#   $
��Left=�65   $��	40,63,0,0q�6P   $	��Top=�6c   $��76��6{   $��37��6�   $��Trebuchet MS)�6�   �� 5      -   5         ��Name$ CbAct��5      $
��Left=�6&   $��50��6A   $��494,110,0,0q�6M   $	��Top=�6b   $	��290��6z   $��Center=�6�   $��Center=�6�   $��30(�6�   $
��Bold"�6�   ���	#FFDFDD95
���  �����	#89932F1F$��2q�60  .@�5      �� $��Land transfer��6   $��Center=�67   $��Center=�6[   $��30(�6}   $
��Bold"�6�   ���	#FFDFDD95
���  �����	#89932F1F6�   �� 5      $��Declare a war��6   $��Center=�67   $��Center=�6[   $��30(�6}   $
��Bold"�6�   ���	#FFDFDD95
���  �����	#89932F1F6�   5      �� 5      -   5        $ CbLandToTransfer��5      $
��Left=�61   $��50��6L   $��494,165,0,0q�6X   $	��Top=�6m   $	��290��6�   $��Center=�6�   $��Center=�6�   $��30(�6�   $
��Bold"�6�   ���	#FFDFDD95
���  �����	#89932F1F$��2q�6;  6O  �� 5      -   5        $ CbCountryToTransfer��5      $
��Left=�64   $��50��6O   $��494,220,0,0q�6[   $	��Top=�6p   $	��290��6�   $��Center=�6�   $��Center=�6�   $��30(�6�   $
��Bold"�6�   ���	#FFDFDD95
���  �����	#89932F1F$��2q�6>  6R  �� 5      -	   5        	 ��Name$	 	IssueALaw��5      $��Ok��6(   $
��Left=�65   $��44��6P   $��719,399,0,0q�6\   $	��Top=�6q   $��74��6�   ���	#FFDFC58E$��Book Antiqua)�6�   ��6�   Z� ��5      �� 5      $< 6/LandConquest;component/Pictures/epic_button_brown.png��6!   5      �� 5      -
   5        $	 buttonClose��5      $��20��6*   $��	773,0,0,0q�66   $	��Top=�6I   $��20��6a   ���	#FFDFC58E��6m   Z� ��5       �� 5!      $6 0/LandConquest;component/Pictures/buttonCross.jpg��6!   5#      �� 5$      -   5        $ CbCountryWarLand��5$      $y�Hidden=�61   $
��Left=�6E   $��50��6`   $��494,275,0,0q�6l   $	��Top=�6�   $	��290��6�   $��Center=�6�   $��Center=�6�   $��30(�6�   $
��Bold"�6�   ���	#FFDFDD95
���  �����	#89932F1F$��2q�6O  6c  5%      5&      5'      