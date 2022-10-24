﻿using BlazorTraining.Models;
using BlazorTraining.State;
using Microsoft.AspNetCore.Components;

namespace BlazorTraining.Pages.FruitSaladMaker
{
    public partial class FruitSaladMaker : ComponentBase
    {
        [Inject] private OrderState OrderState { get; set; }

        private List<Fruit> _fruitList = new List<Fruit>{
            new Fruit { Name = "Apple", Family = "Rosaceae", Calories = "52", Price = 1.0, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/1/15/Red_Apple.jpg" },
            new Fruit { Name = "Pear", Family = "Rosaceae", Calories = "57", Price = 1.0, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/c/c5/Rocha_Pear_2017_B1.jpg/450px-Rocha_Pear_2017_B1.jpg?20171222081252" },
            new Fruit { Name = "Grape", Family = "Vitaceae", Calories = "69", Price = 1.0, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/b/bb/Table_grapes_on_white.jpg/640px-Table_grapes_on_white.jpg" },
            new Fruit { Name = "Orange", Family = "Rutaceae" , Calories = "47", Price = 1.0, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/6/6e/Orange%2C_orange_peel.jpg/572px-Orange%2C_orange_peel.jpg?20210618001624" },
            new Fruit { Name = "Lemon", Family = "Rutaceae" , Calories = "29", Price = 1.0, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/e/e4/Lemon.jpg/800px-Lemon.jpg?20050214195124" },
            new Fruit { Name = "Banana", Family = "Musaceae" , Calories = "89", Price = 1.0, ImageUrl = "https://upload.wikimedia.org/wikipedia/commons/thumb/7/77/Banana_d%C3%A1gua.jpg/800px-Banana_d%C3%A1gua.jpg?20210415211847" },
        };

        private FruitSalad _myFruitSalad = new FruitSalad();

        private void AddFruit(Fruit fruit)
        {
            _myFruitSalad.Fruits.Add(fruit);
        }

        private void AddFruitSalad()
        {
            OrderState.AddFruitSalad(this._myFruitSalad);
            _myFruitSalad = new FruitSalad();
        }
    }
}
