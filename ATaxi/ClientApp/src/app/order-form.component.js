var __decorate = (this && this.__decorate) || function (decorators, target, key, desc) {
    var c = arguments.length, r = c < 3 ? target : desc === null ? desc = Object.getOwnPropertyDescriptor(target, key) : desc, d;
    if (typeof Reflect === "object" && typeof Reflect.decorate === "function") r = Reflect.decorate(decorators, target, key, desc);
    else for (var i = decorators.length - 1; i >= 0; i--) if (d = decorators[i]) r = (c < 3 ? d(r) : c > 3 ? d(target, key, r) : d(target, key)) || r;
    return c > 3 && r && Object.defineProperty(target, key, r), r;
};
import { Component, Input } from '@angular/core';
let OrderFormComponent = class OrderFormComponent {
};
__decorate([
    Input()
], OrderFormComponent.prototype, "order", void 0);
OrderFormComponent = __decorate([
    Component({
        selector: "order-form",
        templateUrl: './order-form.component.html'
    })
], OrderFormComponent);
export { OrderFormComponent };
//# sourceMappingURL=order-form.component.js.map