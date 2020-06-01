import { Component, OnInit } from '@angular/core';
import { Router } from '@angular/router';
import { PostService } from '../../services/post.service';
import { PostModel } from 'src/app/features/models/post.model';

@Component({
  selector: 'app-post-detail',
  templateUrl: './post-detail.component.html',
  styleUrls: ['./post-detail.component.scss']
})
export class PostDetailComponent implements OnInit {
  private post: PostModel;

  constructor(
    postService: PostService,
    private router: Router
  ) {
    postService.getPosts().subscribe(result => {
      var posts = result.posts;
      var id = this.router.url.split('/')[2];
      this.post = posts.find((p: { PostId: string; }) => p.PostId == id);
    })
  }

  ngOnInit(): void {
  }

  goBackToList() {
    this.router.navigate(['posts']);
  }

}
