import { Component, ViewChild } from '@angular/core';

@Component({
  selector: 'app-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss']
})
export class AppComponent {
  title = 'B3.Investimento.WebApp';
  @ViewChild('sidenav') sidenav: any;

  onToggleSidenav() {
    this.sidenav.toggleSidenav();
  }
}
