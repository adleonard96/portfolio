import {Component, Input} from '@angular/core';
import {NgOptimizedImage} from '@angular/common';

@Component({
  selector: "photo",
  imports: [
    NgOptimizedImage
  ],
  template: `<img class="photo" alt="{{altText}}" ngSrc="{{path}}" height="100" width="100">`,
  styleUrl: "./photo.component.css"
})

export class PhotoComponent {
  @Input() path = ""
  @Input() altText = ""
}
