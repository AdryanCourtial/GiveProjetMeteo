using System;
using Avalonia.Input;
using Avalonia.Interactivity;
using ProjetMeteo;

namespace Weather_Project;

public class Gestionaire_Input : MainWindow
{
    private void Fenetre_KeyDown(object sender, KeyEventArgs e)
    {
        if (e.Key == Key.Enter)
        {
            envoyer_ville.IsEnabled = true;
        }
    }

    public static bool VerifInput(string input)
    {
        for (int i = 0; i < input.Length;)
        {
            if (input[i] >= 65 && input[i] <= 90 || input[i] >= 97 && input[i] <= 122)
            {
                i++;
                continue;
            }
            else
            {
                return false;
            }
        }

        return true;
    }
    
}