import { BrowserModule } from '@angular/platform-browser';
import { NgModule } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';
import { HttpClientModule }    from '@angular/common/http';
import { PostListComponent } from './features/post/components/post-list/post-list.component';
import { PostDetailComponent } from './features/post/components/post-detail/post-detail.component';

@NgModule({
  declarations: [
    AppComponent,
    PostListComponent,
    PostDetailComponent
  ],
  imports: [
    BrowserModule,
    AppRoutingModule,
    HttpClientModule
  ],
  providers: [],
  bootstrap: [AppComponent]
})
export class AppModule { }
