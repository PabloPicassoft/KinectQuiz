   M S B A M L   `   `   `  ����K  GInterfaceProgCW2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:InterfaceProgCW2InterfaceProgCW2  5   	       InterfaceProgCW2.ForLoop   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5   	   @d2http://schemas.microsoft.com/expression/blend/2008     5   	   Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5   	   h dMicrosoft.Kinect.Toolkit.Controls, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [Microsoft.Kinect.Toolkit, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e352k(http://schemas.microsoft.com/kinect/2013   5   	   ,localclr-namespace:InterfaceProgCW2   5   	   $
��1000��5	   	   $
��1400��6   
����İ�.��5      � -   5          �Name$  KinectRegionGrid��5      .+�5   
   � .+�5      4  .Microsoft.Kinect.Toolkit.KinectSensorChooserUI  -   5        $��sensorChooserUi��5   [   $��Center=�6&   $	��Top=�6C   6[   8  2Microsoft.Kinect.Toolkit.Controls.KinectUserViewer  5      $	��Top=�6!   $��Right=�69   $	��150��6�   4  .Microsoft.Kinect.Toolkit.Controls.KinectRegion   KinectRegion 6U   ��  �� ElementName$ kinectRegionGrid��6�   5      �� 5   
   $��For Loop��6   $��Center=�6#   $��48(�6@   $��611,50,570,865q�6N   $	��219��6f   8  2Microsoft.Kinect.Toolkit.Controls.KinectTileButton  5   
   -   5           Label$
 Home��5         HorizontalLabelAlignment$ Center=�6*   $��Center=�6M   $��94��6h   $��610,853,570,53q�6�   :  4Microsoft.Kinect.Toolkit.Controls.KinectCircleButton  5   
   -   5        $��Cbutton1��5      $
��Left=�6/   $��150,146,0,446q�6J      Label$ 1��6a   $	��135��6�     5   
   -   5        $��Cbutton2��5      $
��Left=�6/   $��150,315,0,269q�6J   $ 2��6a   $	��135��6�     5   
   -   5        $��Cbutton3��5      $
��Left=�6/   $��150,488,0,104q�6J   $ 3��6a   $	��135��6�   �� 5   
   $��22(�6   $	��Top=�6"   $��Center=�6:   $��530,146,510,0q�6W   $��Microsoft JhengHei)�6n   $
��Bold"�6�   $	��360��6�   $��72��6�    �� TextAlignment$ Center=�6�   $?��9Complete the for loop code to
print the numbers 1 to 10
��6�   ���	#FF8FACC36  �� 5   
   $��36(�6   $	��Top=�6"   $��Center=�6:   $��845,305,90,0q�6W   $��Microsoft JhengHei)�6m   $	��465��6�   $	��240��6�   $
 left=�6�   ���	#FF459EBF$
��Bold"�6�    �� Padding$ 
20,10,0,20q�6�   �� 6�   $!�for ( i = 1;  ????  ; i++) ��6�   �� 6#  �� 6/  $�{
��63  �� 6E  $�       ��6I  �� 6Z  $�Console.WriteLine( i )��6^  �� 6~  $�;��6�  �� 6�  $�
}��6�  6�  �� 5   
   -   5         ��Name$ answer1��5   1   $��Right=�6   $��0,315,935,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��41��6�   $	��160��6�   $��36(�6�   $��i < 10��6�   �� 5    
   -   5        $ answer2��5    1   $��Right=�6   $��0,649,935,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��41��6�   $	��160��6�   $��36(�6�   �� 6�   $	�i <��6�   �� 6�   $�=��6�   �� 6�   $� ��6�   �� 6�   $�9��6�   6�   �� 5!   
   -	   5        $ answer3��5!   1   $��Right=�6   $��0,475,935,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��41��6�   $	��160��6�   $��36(�6�   $��i <= 10��6�   �� 5#   
   -
   5        $��tickimg��5#      $��Images/tick.png��6   $	��269��68   $��165,361,755,0q�6E   $	��Top=�6\   $y�Hidden=�6t   �� 5$   
   -   5        $ Congratulations��5$   1   $��Right=�6   $��0,731,735,0q�6J   $
��Wrap=�6_   $y�Hidden=�6s   $ Center=�6�   $	��Top=�6�   $	��110��6�   $	��500��6�   $��36(�6�   �� 6�   $�Congratulations, ��6�   �� 6�   �� 6
  $#�you chose the correct answer!��6  66  �� 5%   
   -   5        $��
outputText��5%      $��22(�6'   $	��Top=�65   $��Center=�6M   $��845,606,90,0q�6j   $��Microsoft JhengHei)�6�   $
��Bold"�6�   $	��465��6�   $	��125��6�   $
 left=�6�   $��Output :��6�   ���	#FF459EBF$ 	20,10,0,0q�6  5&      5'      