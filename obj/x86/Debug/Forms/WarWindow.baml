   M S B A M L   `   `   `  ����G  CLandConquest, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null7 clr-namespace:LandConquest.FormsLandConquest.Forms  5   	   "    LandConquest.Forms.WarWindow   5   	   R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5   	   R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   2local clr-namespace:LandConquest.Forms     5   	     � WindowStyle$
  None=�5       � 
ResizeMode$ NoResize=�5   	    � WindowStartupLocation$ Manual=�5	   	    � Left$ 10��6(   
 � Top$ 10��62   $	��880��5
   	   $
��1500��6   .��5      �� ���	#FF392018$��5q�6%   $
��Auto��69   $
��Auto��6G   ._�5   
   � -   5         �Name$ mainWarWinGrid��5      .+�5      � $	��154��6   $��1282,163,0,0q�6    $	��Top=�66   $
��Left=�6N   $	��199��6i   .+�5      �� $��Army of��6   $��-1,-4,-20,0q�6*   $
��Left=�6?   $	��245��6Z   $��32��6f   $	��Top=�6r   �� 5      -   5         ��Name$ playerNameLbl��5      $��
PLAYERNAME��6/   $��	44,-4,0,0q�6D   $
��Left=�6W   $	��110��6r   $��32��6~   $	��Top=�6�   �� 5      $��	-1,12,0,0q�6   $ ��/Pictures/Armies/TRO-0.png��6+   $
��Left=�6O   $��49��6j   $��42��6u   $	��Top=�6�   �� 5      -   5        $ warriorsAll��5      $��0��6-   $��14(�69   $��	56,25,0,0q�6G   $��26��6Z   $	��Top=�6f   $
��Left=�6~   $��59��6�   �� 5      $��6,55,0,0q�6   $ ��/Pictures/Armies/INF-0.png��6*   $
��Left=�6N   $��25��6i   $��25��6t   $	��Top=�6�   �� 5      -   5        $ warriorsInfantry��5      $��0��62   $��	37,59,0,0q�6?   $��24��6R   $	��Top=�6^   $
��Left=�6v   $��78��6�   �� 5      $��7,76,0,0q�6   $��/Pictures/Armies/AR-0.png��6*   $��25��6M   $	��Top=�6Y   $
��Left=�6q   $��25��6�   �� 5      -   5        $ warriorsArchers��5      $��0��61   $��	37,83,0,0q�6>   $
��Left=�6Q   $��78��6l   $��24��6w   $	��Top=�6�   �� 5      $��	6,102,0,0q�6   $ ��/Pictures/Armies/KNT-0.png��6+   $
��Left=�6O   $��34��6j   $��25��6u   $	��Top=�6�   �� 5      -   5        $ warriorsKnights��5      $��0��61   $��
37,105,0,0q�6>   $
��Left=�6R   $��78��6m   $��24��6x   $	��Top=�6�   �� 5      $��	6,125,0,0q�6   $ ��/Pictures/Armies/SIE-0.png��6+   $��25��6O   $	��Top=�6[   $
��Left=�6s   $��25��6�   �� 5      -   5        $ warriorsSiege��5      $��0��6/   $��
37,129,0,0q�6<   $
��Left=�6P   $��78��6k   $��24��6v   $	��Top=�6�   �� 5      -   5         ��Name$ btnSplit��5      $��S��6+   $��8(�67   $
��Bold"�6D   
�������$��	126,0,0,0q�6j   $
��Left=�6�   $��34��6�   $��34��6�   $	��Top=�6�   $��Center=�6�   ��6}   Z� ��5      �� 5       �� ImageSource$< 6/LandConquest;component/Pictures/epic_brown_square.png��6%   5!      �� 5#      -	   5        $ 	btnAttack��5#      $��A��6,   $��Center=�68   $��8(�6\   $
��Bold"�6i   
�������$
��Left=�6�   $��
126,66,0,0q�6�   $	��Top=�6�   $��34��6�   $��34��6  ��6�   Z� ��5$      �� 5%      $< 6/LandConquest;component/Pictures/epic_brown_square.png��6%   5'      �� 5)      -
   5        $ armyPageArrowLeft��5)      $��32��64   $��0,0,41,3q�6@   $��Bottom=�6R   
������ $��Right=�6�   $��32��6�   $��2��6�   ��5*      �� 5+      $% /Pictures/armyPageArrowLeft.png��6%   5-      �� 5/      -   5        $ armyPageArrowRight��5/      $��Right=�65   $��32��6Q   $��0,0,9,3q�6]   $��Bottom=�6n   $��32��6�   
������ $��2��6�   ��50      �� 51      $&  /Pictures/armyPageArrowRight.png��6%   53      �� 55      -   5        $ btnSelectToUnite��55      $��Select��63   
�������$
��Left=�6W   $��
126,34,0,0q�6r   $	��Top=�6�   $��68��6�   $��32��6�   ��6�   Z� ��56      �� 57      $< 6/LandConquest;component/Pictures/epic_button_brown.png��6%   59      �� 5:      -   5        $ btnUnite��5:      $��U��6+   $��8(�67   $
��Bold"�6D   
�������$
��Left=�6j   $��	160,0,0,0q�6�   $	��Top=�6�   $��34��6�   $��34��6�   ��6�   Z� ��5;      �� 5<      $< 6/LandConquest;component/Pictures/epic_brown_square.png��6%   5>      �� 5@      -   5        $ btnStartSiege��5@      $��160,66,5,54q�60   $��34��6E   $��34��6�   {�.  ��6P   Z� 	 � ToolTip	 5A      _� 5B      $��Start siege��6"   
�������$��Italic)�6K   $��10(�6_   ��5C      �� 5D   "   $< 6/LandConquest;component/Pictures/epic_brown_square.png��6-   5F      ��5H      �� 5I      $< 6/LandConquest;component/Pictures/epic_brown_square.png��6%   5K      �� 5M      -   5        
 ��Name$
 siegeImageBtn��5M      $"��/Pictures/War/SiegeTower.png��6/   $
��auto��6U   $��162,66,8,55q�6b   {�.  	 5N      _� 5O      $��Start siege��6"   
�������$��Italic)�6K   $��10(�6_   ��5P      �� 5Q   "   $< 6/LandConquest;component/Pictures/epic_brown_square.png��6-   5S      5U      ��5W      �� 5X      $: 4/LandConquest;component/Pictures/background_pale.jpg��6!    j� Stretch$ UniformToFill=�6d   5Z      � 5\      -   5        $ garrisonInfoGrid��5\      $y�Hidden=�6-   $	��154��6A   $��1281,163,0,0q�6N   $	��Top=�6d   $
��Left=�6|   $	��199��6�    K� ZIndex$ 2��6�   .+�5]      �� $��Garrison��6   $��-1,-4,-20,0q�6+   $
��Left=�6@   $	��245��6[   $��32��6g   $	��Top=�6s   �� 5^      $��	-1,12,0,0q�6   $ ��/Pictures/Armies/TRO-0.png��6+   $
��Left=�6O   $��49��6j   $��42��6u   $	��Top=�6�   �� 5_      -   5        $ GwarriorsAll��5_      $��0��6.   $��14(�6:   $��	56,25,0,0q�6H   $��26��6[   $	��Top=�6g   $
��Left=�6   $��59��6�   �� 5`      $��6,55,0,0q�6   $ ��/Pictures/Armies/INF-0.png��6*   $
��Left=�6N   $��25��6i   $��25��6t   $	��Top=�6�   �� 5a      -   5        $ GwarriorsInfantry��5a      $��0��63   $��	37,59,0,0q�6@   $��24��6S   $	��Top=�6_   $
��Left=�6w   $��78��6�   �� 5b      $��7,76,0,0q�6   $��/Pictures/Armies/AR-0.png��6*   $��25��6M   $	��Top=�6Y   $
��Left=�6q   $��25��6�   �� 5c      -   5        $ GwarriorsArchers��5c      $��0��62   $��	37,83,0,0q�6?   $
��Left=�6R   $��78��6m   $��24��6x   $	��Top=�6�   �� 5d      $��	6,102,0,0q�6   $ ��/Pictures/Armies/KNT-0.png��6+   $
��Left=�6O   $��34��6j   $��25��6u   $	��Top=�6�   �� 5e      -   5        $ GwarriorsKnights��5e      $��0��62   $��
37,105,0,0q�6?   $
��Left=�6S   $��78��6n   $��24��6y   $	��Top=�6�   �� 5f      $��	6,125,0,0q�6   $ ��/Pictures/Armies/SIE-0.png��6+   $��25��6O   $	��Top=�6[   $
��Left=�6s   $��25��6�   �� 5g      -   5        $ GwarriorsSiege��5g      $��0��60   $��
37,129,0,0q�6=   $
��Left=�6Q   $��78��6l   $��24��6w   $	��Top=�6�   �� 5i      -   5        $ closeGInfoBtn��5i      $��Center=�60   $��Center=�6U   $��	0,1,1.4,0q�6w    J� RenderTransformOrigin$ 
0.541,0.51&�6�   $��Right=�6�   $��20��6�   $��20��6  $	��Top=�6  ��6�   Z� ��6�   Z� ��5j      �� 5k      $6 0/LandConquest;component/Pictures/buttonCross.jpg��6%   5m      ��5o      �� 5p      $: 4/LandConquest;component/Pictures/background_pale.jpg��6!   $ UniformToFill=�6d   5r      A� 5t      -   5         A�Name$ elementsWarMap��5t      $ 2��62   $��Bottom=�6C   $��Right=�6^   $��0,0,0.4,0.4q�6z   $��1��6�   A� 5u      -   5        $ gridForArmies��5u      $ 3��61   $��Bottom=�6B   $��Right=�6]   $��0,0,0.4,0.4q�6y   $��1��6�   � 5v      -   5        $ warGrid��5v      $y�Hidden=�6$   $	��300��68   $	��300��6E   $��Right=�6Q   $��0,408,1.4,0q�6m   $	��Top=�6�   ��5x      �� 5y      $0 */LandConquest;component/Pictures/panel.png��6!   $ UniformToFill=�6Z   .+�5{      �� $��15,10,228.6,260q�6   $��30��61   $��30��6=   $ ��/Pictures/Armies/TRO-0.png��6I   �� 5|      -   5        $ warriorsAllLeft��5|      $��0��61   $��91,16,104.6,259q�6>   �� 5}      $��15,40,228.6,230q�6   $��30��61   $��30��6=   $ ��/Pictures/Armies/INF-0.png��6H   �� 5~      -   5        $ warriorsInfantryLeft��5~      $��0��66   $��91,46,104.6,229q�6C   �� 5      $��15,70,228.6,200q�6   $��30��61   $��30��6=   $��/Pictures/Armies/AR-0.png��6H   �� 5�      -   5        $ warriorsArchersLeft��5�      $��0��65   $��91,76,104.6,200q�6B   �� 5�      $��15,100,228.6,170q�6   $��30��62   $��30��6>   $ ��/Pictures/Armies/KNT-0.png��6I   �� 5�      -   5        $ warriorsKnightsLeft��5�      $��0��65   $��91,106,104.6,170q�6B   �� 5�      $��15,129,228.6,141q�6   $��30��62   $��30��6>   $ ��/Pictures/Armies/SIE-0.png��6I   �� 5�      -   5        $ warriorsSiegeLeft��5�      $��0��63   $��91,135,104.6,141q�6@   �� 5�      $��260,10,10,260q�6   $��30��6/   $��30��6;   $7��1/LandConquest;component/Pictures/Armies/TRO-1.png��6G   $��2��6�   �� 5�      $��260,40,10,230q�6   $��30��6/   $��30��6;   $7��1/LandConquest;component/Pictures/Armies/INF-1.png��6F   $��2��6�   �� 5�      $��260,70,10,200q�6   $��30��6/   $��30��6;   $6��0/LandConquest;component/Pictures/Armies/AR-1.png��6F   $��2��6�   �� 5�      $��260,100,10,170q�6   $��30��60   $��30��6<   $7��1/LandConquest;component/Pictures/Armies/KNT-1.png��6G   $��2��6�   �� 5�      $��260,129,10,141q�6   $��30��60   $��30��6<   $7��1/LandConquest;component/Pictures/Armies/SIE-1.png��6G   $��2��6�   �� 5�      -   5        $ warriorsAllRight��5�      $��0��62   $��186,16,9.6,259q�6?   �� 5�      -    5        $ warriorsInfantryRight��5�      $��0��67   $��186,46,9.6,229q�6D   �� 5�      -!   5        $ warriorsArchersRight��5�      $��0��66   $��186,76,9.6,200q�6C   �� 5�      -"   5        $ warriorsKnightsRight��5�      $��0��66   $��186,106,9.6,170q�6C   �� 5�      -#   5        $ warriorsSiegeRight��5�      $��0��64   $��186,135,9.6,141q�6A   5�      �� 5�      $��0,49,128.4,0q�6   $<��6/LandConquest;component/Pictures/epic_button_brown.png��6+   $��Right=�6k   $��61��6�   $��30��6�   $	��Top=�6�   $
��Fill=�6�   �� 5�      $��0,44,177.4,0q�6   $=��7/Pictures/Design elements v1.0/square-control-black.png��6+   $��Right=�6l   $��40��6�   $��43��6�   $	��Top=�6�   �� 5�      $��0,50,184.4,0q�6   $��/Pictures/sandClocks.png��6+   $��Right=�6M   $��29��6i   $��27��6t   $	��Top=�6�   �� 5�      -$   5        $ moveCounterLbl��5�      $	��000��6,   $��14(�6:   $��0,50,128.4,0q�6H   $	��Top=�6^   $��Right=�6v   $��54��6�   $��26��6�   
�������6�   �� 5�      $��0,77,128.4,0q�6   $<��6/LandConquest;component/Pictures/epic_button_brown.png��6+   $��Right=�6k   $	��132��6�   $��30��6�   $	��Top=�6�   �� 5�      $��0,73,177.4,0q�6   $=��7/Pictures/Design elements v1.0/square-control-black.png��6+   $��Right=�6l   $��40��6�   $��49��6�   $	��Top=�6�   �� 5�      $��0,81,185.4,0q�6   $��/Pictures/War/boot.png��6+   $��Right=�6K   $��23��6g   $��26��6r   $	��Top=�6~   �� 5�      $��0,103,128.4,0q�6   $<��6/LandConquest;component/Pictures/epic_button_brown.png��6,   $��Right=�6l   $	��132��6�   $��30��6�   $	��Top=�6�   �� 5�      $��0,99,177.4,0q�6   $=��7/Pictures/Design elements v1.0/square-control-black.png��6+   $��Right=�6l   $��40��6�   $��49��6�   $	��Top=�6�   �� 5�      $��0,107,185.4,0q�6   $��/Pictures/War/loop.png��6,   $��Right=�6L   $��23��6h   $��26��6s   $	��Top=�6   �� 5�      -%   5        $ 
timerLabel��5�      $��0��6(   $��14(�64   $��Right=�6B   
�������$��0,103,108.4,0q�6q   $	��Top=�6�   $��72��6�   $��30��6�   �� 5�      -&   5        $ buttonCollapse��5�      $��Center=�6-   $��
0,1,21.4,0q�6O   $��20��6�   $	��Top=�6�   $��Right=�6�   $��20��6�   ��6c   Z� ��6z   Z� ��5�      �� 5�      $6 0/LandConquest;component/Pictures/buttonMinus.jpg��6!   5�      �� 5�      -'   5        $ 
buttonExit��5�      $��Center=�6)   $��Center=�6N   $��	0,1,1.4,0q�6�   $ 
0.541,0.51&�6�   $��Right=�6�   $��20��6  $��20��6  $	��Top=�6&  ��6�   Z� ��6�   Z� ��5�      �� 5�      $6 0/LandConquest;component/Pictures/buttonCross.jpg��6!   5�      �� 5�      -(   5         ��Name$ thisMoveIndicator��5�      
����  �$
��Left=�6C   $��25��6^   $��1309,80,0,0q�6j   
���   �$	��Top=�6�   $��50��6�   �� 5�      $
��Left=�6   $	��861��6/   $��0,5,0,0q�6<   $	��Top=�6M   $
��1272��6e   $%��/Pictures/Experimental/city.jpg��6r   $
��Fill=�6�   $ -1��6�   ��5�      �� 5�      $ /Pictures/background.jpg��6   $ UniformToFill=�6D   5�      5�      5�      