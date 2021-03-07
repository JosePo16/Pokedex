import { Directive, NgIterable, Input, Host, TemplateRef, ViewContainerRef, EmbeddedViewRef } from '@angular/core';
import { NgForOf } from "@angular/common";

@Directive({
  selector: "[ngForIfEmpty]",
})
export class NgForIfEmpty<T> {

  @Input()
  public set ngForIfEmpty(templateRef: TemplateRef<any>) {
    this.templateRef = templateRef;
    this.viewRef = null;
    this.updateView();
  }

  private templateRef: TemplateRef<any>;
  private viewRef: EmbeddedViewRef<any>;
  private _isEmpty: boolean = false;

  constructor(@Host() private ngForOf: NgForOf<T>,
    private viewContainer: ViewContainerRef) {
    const _ngDoCheck = ngForOf.ngDoCheck.bind(ngForOf);
    ngForOf.ngDoCheck = () => {
      _ngDoCheck();

      this.isEmpty = !ngForOf.ngForOf || this.isIterableEmpty(ngForOf.ngForOf);
    };
  }

  private set isEmpty(value: boolean) {
    if (value !== this._isEmpty) {
      this._isEmpty = value;
      this.updateView();
    }
  }
  private get isEmpty() {
    return this._isEmpty;
  }

  private updateView() {
    if (this.isEmpty) {
      if (!this.viewRef) {
        this.viewContainer.clear();
        if (this.templateRef) {
          this.viewRef = this.viewContainer.createEmbeddedView(this.templateRef);
        }
      }
    } else {
      this.viewRef = null;
    }
  }

  private isIterableEmpty(iterable: NgIterable<T>): boolean {
    for (let item of iterable) {
      return false;
    }

    return true;
  }
}
