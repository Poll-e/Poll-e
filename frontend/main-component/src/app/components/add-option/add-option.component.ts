import {Component, Input, OnInit, Output} from '@angular/core';
import {ActivatedRoute} from '@angular/router';
import {PollService} from '../../services/poll.service';
import {OptionService} from '../../services/option.service';
import {PollGetResponse} from '../../DTOs/poll-get-response';
import {CommonModule} from '@angular/common';
import {HttpEventType} from '@angular/common/http';

@Component({
  selector: 'app-add-option',
  templateUrl: './add-option.component.html',
  styleUrls: ['./add-option.component.css']
})
export class AddOptionComponent implements OnInit {
  @Input()
  code: string;
  @Input()
  onUploaded: () => void;

  text: string;
  progress: number;
  inProgress = false;

  constructor(private optionService: OptionService) {
  }
  ngOnInit(): void {
  }
  public uploadFile = (files) => {
    this.inProgress = true;
    if (files.length === 0) {
      return;
    }
    const fileToUpload = files[0] as File;
    const formData = new FormData();
    formData.append('file', fileToUpload, fileToUpload.name);
    this.optionService.createOption(this.code, this.text, formData)
      .subscribe(event => {
        if (event.type === HttpEventType.UploadProgress)
          this.progress = Math.round(100 * event.loaded / event.total);
        else if (event.type === HttpEventType.Response) {
          this.onUploaded();
          this.reset();
        }
      });
  }

  private reset(): void {
    this.text = '';
    this.progress = 0;
    this.inProgress = false;  }
}
