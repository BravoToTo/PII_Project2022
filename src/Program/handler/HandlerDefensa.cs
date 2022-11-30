
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Ucu.Poo.Locations.Client;
using Telegram.Bot.Types;
using Library;
namespace Ucu.Poo.TelegramBot
{
    public class HandlerDefensa : BaseHandler
    {
        public const string PREGUNTA = "Elija un usuario:";
        public HandlerDefensa(BaseHandler next):base(next)
        {
            this.Keywords = new string[] {"best review"};
        }
    }

    /*Sinceramente no tengo idea de como crear handlers ya que no tuve la oportunidad de aprenderlo.
    Lo que haria seria que el bot primero reconozca la palabra "best review", y al hacerlo que muestre una lista de todos los
    empleadores con un numero o ID para que el usuario (administrador) pueda seleccionar el que quiera, luego correria el metodo
    "MaxRating" de la clase employer y se lo pasaria al bot como response.*/
}