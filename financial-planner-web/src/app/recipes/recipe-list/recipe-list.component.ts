import { Component } from '@angular/core';
import { Stock } from 'src/app/Models/stock.model';

@Component({
  selector: 'app-recipe-list',
  templateUrl: './recipe-list.component.html',
  styleUrls: ['./recipe-list.component.css']
})
export class RecipeListComponent {
    stockList: Stock[] = []
}
