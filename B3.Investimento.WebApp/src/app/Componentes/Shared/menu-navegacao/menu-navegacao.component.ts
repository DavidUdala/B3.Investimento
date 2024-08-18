import { Component, EventEmitter, Output } from '@angular/core';

@Component({
  selector: 'app-menu-navegacao',
  templateUrl: './menu-navegacao.component.html',
  styleUrls: ['./menu-navegacao.component.scss']
})
export class MenuNavegacaoComponent {
  @Output() toggleSidenav = new EventEmitter<void>();

  onToggleSidenav() {
    this.toggleSidenav.emit();
  }
}
