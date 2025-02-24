import { Component } from '@angular/core';
import { RouterOutlet } from '@angular/router';
import {PhotoComponent} from './Components/photo.component';

@Component({
  selector: 'app-root',
  imports: [RouterOutlet, PhotoComponent],
  templateUrl: './app.component.html',
  styleUrl: './app.component.css'
})
export class AppComponent {
  headshot = "headshot.jpg";
  title = 'portfolios';
}
