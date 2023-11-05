using System;
using System.Globalization;
using System.IO;
using Avalonia.Controls;
using Avalonia.Controls.ApplicationLifetimes;
using Avalonia.Interactivity;
using Avalonia.Rendering;
using Weather_Project;
using System.Threading.Tasks ;

namespace ProjetMeteo;

public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }
    public void BoutonEnvoyer(object sender, RoutedEventArgs e)
    {
        if (input_ville.Text == null)
        {
            GiveOutput1();
            Console.Write("Write Somethings");
            return;
        }
        
        if (Gestionaire_Input.VerifInput((input_ville.Text.ToString())))
        {
            string texteSaisi = input_ville.Text;
            Console.Write(texteSaisi); // ICI ON AS LA VARIABLE QUI RECUP LA RECHERCHE
            input_ville.Text = "";
        }
        else
        {
            GiveOutput2();
            input_ville.Text = "";
        }
    }
    
    public void BoutonEnvoyerOption(object sender, RoutedEventArgs e)
    {
        if (input_ville_option.Text == null)
        {
            GiveOutput1();
            return;
        }
        
        if (Gestionaire_Input.VerifInput((input_ville_option.Text.ToString())))
        {
            string texteSaisi = input_ville_option.Text;
            Console.Write(texteSaisi); // ICI ON AS LA VARIABLE QUI RECUP LA RECHERCHE
            input_ville.Text = "";
            input_ville_default.Text = texteSaisi;
        }
        else
        {
            GiveOutput2();
            input_ville_option.Text = "";
        }
    }
    
    public void BoutonEnvoyerPre(object sender, RoutedEventArgs e)
    {
        if (input_ville_pre.Text == null)
        {
            GiveOutput1();
            return;
        }
        
        if (Gestionaire_Input.VerifInput((input_ville_pre.Text.ToString())))
        {
            string texteSaisi = input_ville_pre.Text;
            Console.Write(texteSaisi); // ICI ON AS LA VARIABLE QUI RECUP LA RECHERCHE
            input_ville_pre.Text = "";
        }
        else
        {
            GiveOutput2();
            input_ville.Text = "";
        }
    }

    public void Bouton_Click(object sender, RoutedEventArgs e)
    {
        string texteSaisi = input_ville.Text;
        Console.Write(texteSaisi);
        input_ville.Text = "";
    }
    
    public async void GiveOutput1()
    {
        output_rechercher.Text = "!! Ecrit Quelque Chose !!";
        output_option.Text = "!! Ecrit Quelque Chose !!";
        output_pre.Text = "!! Ecrit Quelque Chose !!";
        await Task.Delay(3000);
        output_rechercher.Text = "";
        output_option.Text = "";
        output_pre.Text = "";
    }
    
    public async void GiveOutput2()
    {
        output_rechercher.Text = "!! TU NE PEUX ECRIRE QUE DES LETTRES !!";
        output_option.Text = "!! TU NE PEUX ECRIRE QUE DES LETTRES !!";
        output_pre.Text = "!! TU NE PEUX ECRIRE QUE DES LETTRES !!";
        await Task.Delay(3000);
        output_rechercher.Text = "";
        output_option.Text = "";
        output_pre.Text = "";
    }
}