   M S B A M L   `   `   `  ����K  GInterfaceProgCW2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:InterfaceProgCW2InterfaceProgCW2  5          InterfaceProgCW2.FizzBuzz   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:InterfaceProgCW2     5      h dMicrosoft.Kinect.Toolkit.Controls, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [Microsoft.Kinect.Toolkit, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e352k(http://schemas.microsoft.com/kinect/2013   5      $
��1000��5	      $
��1400��6   
����İ�.��5      � -   5          �Name$  KinectRegionGrid��5      .+�5   
   � .+�5      4  .Microsoft.Kinect.Toolkit.KinectSensorChooserUI  -   5        $��sensorChooserUi��5   [   $��Center=�6&   $	��Top=�6C   6[   8  2Microsoft.Kinect.Toolkit.Controls.KinectUserViewer  5      $	��Top=�6!   $��Right=�69   $	��150��6�   4  .Microsoft.Kinect.Toolkit.Controls.KinectRegion   KinectRegion 6U   ��  �� ElementName$ kinectRegion��6�   5      �� 5   
   $��FizzBuzz��6   $��Center=�6#   $��48(�6@   $��611,50,570,865q�6N   $	��219��6f   8  2Microsoft.Kinect.Toolkit.Controls.KinectTileButton  5   
   -   5           Label$
 Home��5         HorizontalLabelAlignment$ Center=�6*   $��Center=�6M   $��94��6h   $��610,863,570,43q�6�   :  4Microsoft.Kinect.Toolkit.Controls.KinectCircleButton  5   
   -   5        $��Cbutton1��5      $
��Left=�6/   $��150,146,0,446q�6J      Label$ 1��6a   $	��135��6�     5   
   -   5        $��Cbutton2��5      $
��Left=�6/   $��150,315,0,269q�6J   $ 2��6a   $	��135��6�     5   
   -   5        $��Cbutton3��5      $
��Left=�6/   $��150,495,0,97q�6J   $ 3��6`   $	��135��6�   �� 5   
   $��16(�6   $	��Top=�6"   $��Center=�6:   $��505,129,485,0q�6W   $��Microsoft JhengHei)�6n   $
��Bold"�6�   $	��410��6�   $	��111��6�    �� TextAlignment$ Center=�6�   ���	#FF8FACC3�� 6�   $�P��6�   �� 6�   $%�rint the numbers 1 to 15, but e��6�   �� 6$  $	�ach��6(  �� 65  $� ��69  �� 6D  $�	multiple ��6H  �� 6[  �� 6g  $	�of ��6k  �� 6x  $�3 must print Fizz, e��6|  �� 6�  $	�ach��6�  �� 6�  $� ��6�  �� 6�  $�multiple of 5 must print��6�  �� 6�  �� 6�  $�
Buzz and e��6�  �� 6  $�ach mul��6  �� 6  $(�"tiple of both must print FizzBuzz.��6  �� 6I  �� 6U  $6�0What condition is needed in the if statement to ��6Y  �� 6�  �� 6�  $�print "��6�  �� 6�  $�F��6�  �� 6�  $�izzBuzz��6�  �� 6�  $�"?��6�  6�  �� 5   
   $��16(�6   $	��Top=�6"   $��Center=�6:   $��759,270,135,0q�6W   $��Microsoft JhengHei)�6n   $	��506��6�   $	��430��6�   $
 left=�6�   ���	#FF459EBF$
��Bold"�6�    �� Padding$ 
20,10,0,20q�6�   �� 6�   $&� for (int i = 1; i <= 100; i++)  ��6�   �� 6,  �� 68  $	�{  ��6<  �� 6K  �� 6W  $�        if (��6[  �� 6q  $�????????????????????��6u  �� 6�  $	�)  ��6�  �� 6�  �� 6�  $�        {  ��6�  �� 6�  �� 6�  $�            ��6�  �� 6�  $
�    ��6�  �� 6  $�Console.Write("FizzBuzz��6  �� 6+  $�, ��6/  �� 6;  $�");  ��6?  �� 6S  �� 6_  $�        }  ��6c  �� 6x  �� 6�  $$�        else if (i % 3 == 0)  ��6�  �� 6�  �� 6�  $�        {  ��6�  �� 6�  �� 6�  $�           ��6�  �� 6�  $�     ��6�  �� 6  $�Console.WriteLine("Fizz��6  �� 67  $�, ��6;  �� 6G  $�");  ��6K  �� 6_  �� 6k  $�        }  ��6o  �� 6�  �� 6�  $$�        else if (i % 5 == 0)  ��6�  �� 6�  �� 6�  $�        {  ��6�  �� 6�  �� 6�  $�           ��6�  �� 6  $�     ��6
  �� 6  $�Console.WriteLine("Buzz��6  �� 6C  $�, ��6G  �� 6S  $�");  ��6W  �� 6k  �� 6w  $�        }  ��6{  �� 6�  �� 6�  $�        else  ��6�  �� 6�  �� 6�  $�        {  ��6�  �� 6�  �� 6�  $�            ��6�  �� 6  $
�    ��6  �� 6  $�Console.WriteLine(i��6  �� 66  $� + ", "��6:  �� 6U  $
�);  ��6Y  �� 6g  �� 6s  $�        }  ��6w  �� 6�  �� 6�  $�} ��6�  6�  �� 5   
   -   5         ��Name$ answer1��5   1   $��Right=�6   $��0,302,755,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��41��6�   $	��340��6�   $��24(�6�   $��Microsoft JhengHei)�6�   �� 6�   $�(��6�   �� 6�   $�
i % 3 == 0��6�   �� 6�   $�)��6�   �� 6  $
� && ��6  �� 6  $�(��6  �� 6*  $�
i % 5 == 0��6.  �� 6B  $�)��6F  6R  �� 5    
   -   5        $ answer2��5    1   $��Right=�6   $��0,654,610,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��41��6�   $	��485��6�   $��24(�6�   �� 6�   $
��Bold"�6�   $��16(�6�   $��Microsoft JhengHei)�6�   $�i / 3 == "FizzBuzz"��6�   6  �� 5!   
   -	   5        $ answer3��5!   1   $��Right=�6   $��0,480,810,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��41��6�   $	��285��6�   $��24(�6�   �� 6�   $
��Bold"�6�   $��16(�6�   $��Microsoft JhengHei)�6�   $�(��6�   �� 6�   $
��Bold"�6�   $��16(�6  $��Microsoft JhengHei)�6  $�i ��6>  �� 6J  $
��Bold"�6N  $��16(�6`  $��Microsoft JhengHei)�6n  $�/��6�  �� 6�  $
��Bold"�6�  $��16(�6�  $��Microsoft JhengHei)�6�  $� 3 == 0��6�  �� 6�  $
��Bold"�6�  $��16(�6  $��Microsoft JhengHei)�6  $�)��62  �� 6=  $
��Bold"�6A  $��16(�6S  $��Microsoft JhengHei)�6a  $
� && ��6�  �� 6�  $
��Bold"�6�  $��16(�6�  $��Microsoft JhengHei)�6�  $�(��6�  �� 6�  $
��Bold"�6�  $��16(�6�  $��Microsoft JhengHei)�6
  $�i ��6*  �� 66  $
��Bold"�6:  $��16(�6L  $��Microsoft JhengHei)�6Z  $�/��6z  �� 6�  $
��Bold"�6�  $��16(�6�  $��Microsoft JhengHei)�6�  $� 5 == 0��6�  �� 6�  $
��Bold"�6�  $��16(�6�  $��Microsoft JhengHei)�6�  $�)��6  6*  �� 5#   
   -
   5        $��tickimg��5#      $��Images/tick.png��6   $	��269��68   $��165,361,755,0q�6E   $	��Top=�6\   $y�Hidden=�6t   �� 5$   
   -   5        $ Congratulations��5$   1   $��Right=�6   $��0,731,735,0q�6J   $
��Wrap=�6_   $y�Hidden=�6s   $ Center=�6�   $	��Top=�6�   $	��110��6�   $	��500��6�   $��36(�6�   �� 6�   $�Congratulations, ��6�   �� 6�   �� 6
  $#�you chose the correct answer!��6  66  �� 5%   
   -   5        $��
outputText��5%      $��22(�6'   $	��Top=�65   $��Center=�6M   $��759,731,135,0q�6j   $��Microsoft JhengHei)�6�   $
��Bold"�6�   $	��506��6�   $��99��6�   $
 left=�6�   $��Output :��6�   ���	#FF459EBF$ 	20,10,0,0q�6  5&      5'      