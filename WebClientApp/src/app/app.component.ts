import { Component } from '@angular/core';
import { PostService } from './features/post/services/post.service';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'WebClientApp';

  constructor(private postService: PostService) {
    postService.getPosts().subscribe(result => {
      console.log(result);
    })
  }
}
