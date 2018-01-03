﻿using System;
using System.Collections.Generic;

namespace Colorify.UI
{
    public static partial class Theme
    {
        public static ITheme Win
        {
            get
            {
                return new ThemeWin();
            }
        }
    }

    public sealed class ThemeWin : ITheme
    {
        public ThemeWin(){
            try
            {
                SetColors();
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Dictionary<string, Color> _colors {get; set;}

        public ConsoleColor DefaultBackground(){
            try
            {
                return ConsoleColor.Black;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public ConsoleColor DefaultForeground(){
            try
            {
                return ConsoleColor.White;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Color AddColor(ConsoleColor? background, ConsoleColor? foreground){
            try
            {
                var color = new Color(
                    background ?? DefaultBackground(),
                    foreground ?? DefaultForeground()
                );
                return color;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SetColors(){
            try
            {
                var colors = new Dictionary<string, Color>();
                colors.Add("text-default", AddColor(null                   , null                   ));
                colors.Add("bg-default"  , AddColor(null                   , null                   ));
                colors.Add("text-muted"  , AddColor(null                   , ConsoleColor.DarkGray  ));
                colors.Add("text-primary", AddColor(null                   , ConsoleColor.Gray      ));
                colors.Add("text-warning", AddColor(null                   , ConsoleColor.Yellow    ));
                colors.Add("text-danger" , AddColor(null                   , ConsoleColor.Red       ));
                colors.Add("bg-muted"    , AddColor(ConsoleColor.DarkGray  , ConsoleColor.Black     ));
                colors.Add("bg-primary"  , AddColor(ConsoleColor.Gray      , ConsoleColor.White     ));
                colors.Add("bg-warning"  , AddColor(ConsoleColor.Yellow    , ConsoleColor.Black     ));
                colors.Add("bg-danger"   , AddColor(ConsoleColor.Red       , ConsoleColor.White     ));
                colors.Add("text-success", AddColor(null                   , ConsoleColor.DarkGreen ));
                colors.Add("text-info"   , AddColor(null                   , ConsoleColor.DarkCyan  ));
                colors.Add("bg-success"  , AddColor(ConsoleColor.DarkGreen , ConsoleColor.White     ));
                colors.Add("bg-info"     , AddColor(ConsoleColor.DarkCyan  , ConsoleColor.White     ));
                _colors = colors;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

