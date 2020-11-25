import { ComponentFixture, TestBed } from '@angular/core/testing';

import { PollOptionResultListComponent } from './poll-option-result-list.component';

describe('PollOptionResultListComponent', () => {
  let component: PollOptionResultListComponent;
  let fixture: ComponentFixture<PollOptionResultListComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ PollOptionResultListComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(PollOptionResultListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});
