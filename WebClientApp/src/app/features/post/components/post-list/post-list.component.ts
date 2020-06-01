import { Component, OnInit } from '@angular/core';
import { PostService } from '../../services/post.service';

@Component({
  selector: 'app-post-list',
  templateUrl: './post-list.component.html',
  styleUrls: ['./post-list.component.scss']
})
export class PostListComponent implements OnInit {
  private posts;

  constructor(private postService: PostService) {
    postService.getPosts().subscribe(result => {
      this.posts = result.posts;
      console.log(this.posts);
    })
  }

  ngOnInit(): void {
  }

}
