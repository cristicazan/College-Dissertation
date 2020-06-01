import { Component, OnInit } from '@angular/core';
import { PostService } from '../../services/post.service';
import { PostModel } from 'src/app/features/models/post.model';
import { Router } from '@angular/router';

@Component({
  selector: 'app-post-list',
  templateUrl: './post-list.component.html',
  styleUrls: ['./post-list.component.scss']
})
export class PostListComponent implements OnInit {
  private posts: PostModel[];

  constructor(
    postService: PostService,
    private router: Router) {
      
    postService.getPosts().subscribe(result => {
      this.posts = result.posts;
    })
  }

  ngOnInit(): void {
  }

  goToPost(id: number) {
    this.router.navigate(['post', id]);
  }
}
