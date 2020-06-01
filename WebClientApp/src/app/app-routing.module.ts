import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PostListComponent } from './features/post/components/post-list/post-list.component';
import { PostDetailComponent } from './features/post/components/post-detail/post-detail.component';

const routes: Routes = [
  {
    path: '',
    redirectTo: '/posts',
    pathMatch: 'full'
  },
  {
    path: 'posts',
    component: PostListComponent
  },
  {
    path: 'post',
    component: PostDetailComponent,
    children:
      [
        {
          path: ':id',
          component: PostDetailComponent
        }
      ]
  }
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }
