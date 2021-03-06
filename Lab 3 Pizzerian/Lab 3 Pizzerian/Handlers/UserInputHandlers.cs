﻿using Lab_3_Pizzerian.Data_Storage_Classes;
using Lab_3_Pizzerian.DataStorageClasses;
using System;

namespace Lab_3_Pizzerian.Handlers
{
    public static class UserInputHandlers
    {
        public static string GetUserInput()
        {
            return Console.ReadLine();
        }

        public static Tuple<bool, int> ValidatePizzaChoice(string pizzaInput)
        {
            var validation = new Tuple<bool, int>(false, -1);
            var parsedInput = ParseToInt32(pizzaInput);
            var rangeIsValid =
                InputIsInValidRange(parsedInput, -1, Pizzas.AllPizzas.Length);
            if (rangeIsValid) validation =
                    new Tuple<bool, int>(true, parsedInput);
            return validation;
        }

        public static Tuple<bool, int> ValidateExtrasChoice(string extrasInput)
        {
            var validation = new Tuple<bool, int>(false, -1);
            var parsedInput = ParseToInt32(extrasInput);
            var extras = Ingredients.GetExtra();
            var rangeIsValid =
                InputIsInValidRange(parsedInput, -1, extras.Length);
            if (rangeIsValid) validation =
                    new Tuple<bool, int>(true, parsedInput);
            return validation;
        }

        public static Tuple<bool, int> ValidateDrinkChoice(string drinkChoice)
        {
            var validation = new Tuple<bool, int>(false, -1);
            var parsedInput = ParseToInt32(drinkChoice);
            var rangeIsValid =
                InputIsInValidRange(parsedInput, -1, Sodas.AllSodas.Length);
            if (rangeIsValid)
                validation = new Tuple<bool, int>(true, parsedInput);
            return validation;
        }

        public static bool ValidateMoreAnswer(string answer)
        {
            var validatedAnswer = false;
            var parsedInput = ParseToInt32(answer);
            var rangeIsValid =
                InputIsInValidRange(parsedInput, -1, 2);
            if (rangeIsValid && parsedInput == 0)
                validatedAnswer = true;
            return validatedAnswer;
        }

        public static Tuple<bool, int> ValidateConfirmationAnswer(string answer)
        {
            var validation = new Tuple<bool, int>(false, -1);
            var parsedInput = ParseToInt32(answer);
            var rangeIsValid =
                InputIsInValidRange(parsedInput, -1, OrderRows.Rows.Count + 1);
            if (rangeIsValid && parsedInput == 0)
            {
                validation = new Tuple<bool, int>(true, parsedInput);
            }
            else if (rangeIsValid)
            {
                validation = new Tuple<bool, int>(false, parsedInput);
            }
            return validation;
        }

        private static bool InputIsInValidRange(int parsedInput, int min, int max)
        {
            return parsedInput > min
                && parsedInput < max;
        }

        private static int ParseToInt32(string input)
        {
            var parsedInput = -1;
            try
            {
                parsedInput = Int32.Parse(input);
            }
            catch (Exception)
            {
            }
            return parsedInput;
        }
    }
}