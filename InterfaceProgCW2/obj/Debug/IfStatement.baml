   M S B A M L   `   `   `  ����K  GInterfaceProgCW2, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null3clr-namespace:InterfaceProgCW2InterfaceProgCW2  5      "    InterfaceProgCW2.IfStatement   5      R NWindowsBase, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35\ XPresentationFramework, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35W SPresentationCore, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35D 9http://schemas.microsoft.com/winfx/2006/xaml/presentation    5      R NSystem.Xaml, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089:x,http://schemas.microsoft.com/winfx/2006/xaml     5      Jmc;http://schemas.openxmlformats.org/markup-compatibility/2006     5      @d2http://schemas.microsoft.com/expression/blend/2008     5      0localclr-namespace:InterfaceProgCW2     5      h dMicrosoft.Kinect.Toolkit.Controls, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35_ [Microsoft.Kinect.Toolkit, Version=1.8.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e352k(http://schemas.microsoft.com/kinect/2013   5      
����İ�$	��970��5
      $
��1400��6   .��5      � -   5        $��KinectRegionGrid��5      .+�5   
   �� $��If Statement��6   $��Center=�6'   $��48(�6D   $��560,45,520,865q�6R   $	��320��6j   8  2Microsoft.Kinect.Toolkit.Controls.KinectTileButton  5   
   -   5            Label$
  Home��5         HorizontalLabelAlignment$ Center=�6*   $��Center=�6M   $��94��6h   $��610,843,570,63q�6�   :  4Microsoft.Kinect.Toolkit.Controls.KinectCircleButton  5   
   -   5        $��Cbutton1��5      $
��Left=�6/   $��120,187,0,405q�6J      Label$ 1��6a   $	��135��6�     5   
   -   5        $��Cbutton2��5      $
��Left=�6/   $��120,356,0,228q�6J   $ 2��6a   $	��135��6�     5   
   -   5        $��Cbutton3��5      $
��Left=�6/   $��120,529,0,63q�6J   $ 3��6`   $	��135��6�   �� 5   
   $��22(�6   $	��Top=�6"   $��Center=�6:   $��450,163,465,0q�6W   $��Microsoft JhengHei)�6n   $
��Bold"�6�   $	��485��6�   $	��104��6�    �� TextAlignment$ Center=�6�   ���	#FF8FACC3�� 6�   $�Complete the ��6�   �� 6  $�if statement ��6  �� 6  $�co��6"  �� 6.  $�ndition��62  �� 6C  $�
��6G  �� 6V  $	�to ��6Z  �� 6g  $"�print the value of 'number' ��6k  �� 6�  �� 6�  $�variable��6�  �� 6�  $� if it is less than 40��6�  �� 6�  $�
��6�  6�  �� 5   
   $��36(�6   $	��Top=�6"   $��Center=�6:   $��690,312,100,0q�6W   $��Microsoft JhengHei)�6n   $	��610��6�   $	��341��6�   $
 left=�6�   ���	#FF459EBF$
��Bold"�6�    �� Padding$ 
20,10,0,20q�6�   �� 6�   $�int number = 30;��6�   �� 6  �� 6%  �� 6+  �� 67  $�if��6;  �� 6G  $	� ( ��6K  �� 6X  $	�?? ��6\  �� 6i  $	� ??��6m  �� 6z  $� ��6~  �� 6�  $	� ??��6�  �� 6�  $�) ��6�  �� 6�  �� 6�  $�{
��6�  �� 6�  $�       ��6�  �� 6�  $�Console.WriteLine( ��6�  �� 6  $�number��6  �� 6  $� )��6  �� 6&  $�;��6*  �� 65  $�
}��69  6J  �� 5   
   -   5         ��Name$ answer1��5   1   $��Right=�6   $��0,356,805,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��46��6�   $	��320��6�   $��36(�6�   �� 6�   $�number.equals��6�   �� 6�   $
�(40)��6�   6�   �� 5   
   -   5        $ answer2��5   1   $��Right=�6   $��0,690,865,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��56��6�   $	��260��6�   $��36(�6�   �� 6�   $�number <��6�   �� 6�   $� ��6�   �� 6�   $�40��6�   6�   �� 5   
   -   5        $ answer3��5   1   $��Right=�6   $��0,516,895,0q�6B   $
��Wrap=�6W   $	��Top=�6k   $��50��6�   $	��230��6�   $��36(�6�   �� 6�   $�number ��6�   �� 6�   $�>��6�   �� 6�   $� ��6�   �� 6�   $�40��6�   6�   �� 5   
   -	   5        $��tickimg��5      $��Images/tick.png��6   $	��269��68   $��165,361,755,0q�6E   $	��Top=�6\   $y�Hidden=�6t   �� 5   
   -
   5        $ Congratulations��5   1   $��Right=�6   $��0,731,735,0q�6J   $
��Wrap=�6_   $y�Hidden=�6s   $ Center=�6�   $	��Top=�6�   $	��110��6�   $	��500��6�   $��36(�6�   �� 6�   $�Congratulations, ��6�   �� 6�   �� 6
  $#�you chose the correct answer!��6  66  �� 5   
   -   5        $ 
outputText��5      $��24(�6)   $	��Top=�67   $��Center=�6O   $��690,690,100,0q�6l   $��Microsoft JhengHei)�6�   $
��Bold"�6�   $	��610��6�   $	��125��6�   $
 left=�6�   $��Output :��6�   ���	#FF459EBF$ 	20,10,0,0q�6
  5      5       