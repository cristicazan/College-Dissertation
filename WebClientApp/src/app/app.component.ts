import { Component } from '@angular/core';
import { BlogService } from './features/blog/services/blog.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'WebClientApp';

  constructor(private blogService: BlogService) {
    blogService.getBlogs().subscribe(result => {
      console.log(result);
    })
  }
}
