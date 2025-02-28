/*
 * Click nbfs://nbhost/SystemFileSystem/Templates/Licenses/license-default.txt to change this license
 */

package com.mycompany.metricconverter;

import javax.swing.*;
import java.awt.event.*;


/**
 * Metric Converter
 * CIS163AA
 * Cameron Anderer
 * 5/10/23
 * This program opens a window that tells the user to input a distance in Kilometers.
 * Then, when the user clicks a radio button it will convert their number(Km) into
 * either inches, meters, centimeters, yards, decimeters, miles, or feet. 
 * 
 * P.S. i recreated this three times. Just thought id let you know because of the date
 * i put down as when this was created.
 */

public class MetricConverter extends JFrame
{
   private JPanel panel;                  // this is the panel
   private JLabel messageLabel;           // The message telling the user to enter a distance in kilometers
   private JTextField textField;      // this is what is going to hold the user input
   private JRadioButton feetButton;       // this is the feet conversion button
   private JRadioButton inchButton;     // this is the inches conversion button
   private JRadioButton mileButton;      // this is the miles conversion button
   private JRadioButton yardButton;      // this is the yard conversion button
   private JRadioButton centimeterButton;      // this is the centimeter conversion button
   private JRadioButton meterButton;      // this is the meter conversion button
   private JRadioButton decimeterButton;      // this is the decimeter conversion button
   private ButtonGroup radioButtonGroup;  // this is to group the radio buttons
   private final int WINDOW_WIDTH = 500;  // this is the window width
   private final int WINDOW_HEIGHT = 200; // this is the window height
   

   public MetricConverter() {
       
      // title
      setTitle("Metric Converter");

      // set size of the window
      setSize(WINDOW_WIDTH, WINDOW_HEIGHT);

      // tell close button to close
      setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);

      // created the panel
      buildPanel();

      // add the panel to the pane
      add(panel);

      // display window
      setVisible(true);
   }

  
   // adds the label, text field, and buttons to panel
   private void buildPanel() {
       
      // this is the label, text field, and radio buttons
      // here i am declaring what they will say
      messageLabel = new JLabel("Enter a distance in kilometers");
      textField = new JTextField(10);
      mileButton = new JRadioButton("Convert to miles");
      feetButton = new JRadioButton("Convert to feet");
      inchButton = new JRadioButton("Convert to inches");
      meterButton = new JRadioButton("Convert to meters");
      yardButton = new JRadioButton("Convert to yards");
      centimeterButton = new JRadioButton("Convert to centimeters");
      decimeterButton = new JRadioButton("Convert to decimeters");

      // i grouped the radio buttons
      radioButtonGroup = new ButtonGroup();
      radioButtonGroup.add(meterButton);
      radioButtonGroup.add(mileButton);
      radioButtonGroup.add(inchButton);
      radioButtonGroup.add(feetButton);
      radioButtonGroup.add(yardButton);
      radioButtonGroup.add(centimeterButton);
      radioButtonGroup.add(decimeterButton);

      // added action listeners to the radio buttons.
      mileButton.addActionListener(new RadioButtonListener());
      yardButton.addActionListener(new RadioButtonListener());
      feetButton.addActionListener(new RadioButtonListener());
      inchButton.addActionListener(new RadioButtonListener());
      meterButton.addActionListener(new RadioButtonListener());
      centimeterButton.addActionListener(new RadioButtonListener());
      decimeterButton.addActionListener(new RadioButtonListener());

      // created the panel and added everything to it
      panel = new JPanel();
      panel.add(messageLabel);
      panel.add(textField);
      panel.add(mileButton);
      panel.add(meterButton);
      panel.add(yardButton);
      panel.add(feetButton);
      panel.add(inchButton);
      panel.add(centimeterButton);
      panel.add(decimeterButton);
      
   }

   
   // this decides what to do based on which radio button is clicked
   private class RadioButtonListener implements ActionListener {
       
      public void actionPerformed(ActionEvent e) {
          
         String input;          // created to hold the users input
         String conversion = ""; // created to hold the unit that the user wants to convert to
         double result = 0.0;   // created to hold the answer

         // gets the number the user enters
         input = textField.getText();
         
         
         // this if statement is for when each button is clicked
         if (e.getSource() == mileButton) {
             
            // converts to miles
            conversion = " miles.";
            result = Double.parseDouble(input) * 0.621371;
            
         }
         
         else if (e.getSource() == meterButton) {
             
            // convert to meters
            conversion = " meters.";
            result = Double.parseDouble(input) * 1000;
            
         }
         
         else if (e.getSource() == yardButton) {
             
            // converts to yards
            conversion = " yard.";
            result = Double.parseDouble(input) * 1093.61;
            
         }
         
         else if (e.getSource() == feetButton) {
             
            // converts to feet
            conversion = " feet.";
            result = Double.parseDouble(input) * 3280.84;
            
         }
         
         else if (e.getSource() == decimeterButton) {
             
            // convert to centimeters
            conversion = " decimeters.";
            result = Double.parseDouble(input) * 10000;
            
         }
         
         else if (e.getSource() == inchButton) {
             
            // convert to inches
            conversion = " inches.";
            result = Double.parseDouble(input) * 39370.1;
            
         }
         
         
         else if (e.getSource() == centimeterButton) {
             
            // convert to centimeters
            conversion = " centimeters.";
            result = Double.parseDouble(input) * 100000;
            
         }

         // this displays the conversion
         JOptionPane.showMessageDialog(null, input + 
                  " kilometers is " + result + conversion);
      }
   }
   
   
   // creates the instance of the metric converter class
   public static void main(String[] args)
   {
      new MetricConverter();
   }
}