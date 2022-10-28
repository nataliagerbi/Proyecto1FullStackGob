import { Component, OnInit } from '@angular/core';
import { LoginService } from '../services/login/login.service';
import { FormBuilder, FormControl, FormGroup } from '@angular/forms';


@Component({
  selector: 'app-iniciarsesion',
  templateUrl: './iniciarsesion.component.html',
  styleUrls: ['./iniciarsesion.component.css']
})
export class IniciarsesionComponent implements OnInit {

  public loginForm: FormGroup;
  public email: any;
  public password: any;

  constructor(
    public loginService: LoginService,
    public fb: FormBuilder
  ) {
    this.loginForm = this.fb.group({});
    this.email = this.loginForm.get("email");
    this.password = this.loginForm.get("password");
  }

  ngOnInit(): void {



  }

  public async guardarCookie(event: any) {

    // if (
    //   this.email.value == null ||
    //   this.email.value == "" ||
    //   this.password.value == null ||
    //   this.password.value == ""
    // ) {
      const credentials = { Mail: "lalala@sistemas.utn", Password: "secreto1234" };
      console.log(credentials);
      await this.loginService.login(credentials).subscribe(
        (data) => {
          localStorage.setItem("mail", data.mail);
          window.location.href = "http://localhost:4200/p2p"
        }
      );
    // }
    // else {
    //   const credentials = { Mail: this.email, Password: this.password };
    //   console.log(credentials);
    //   await this.loginService.login(credentials).subscribe(
    //     (data) => {
    //       localStorage.setItem("mail", data.mail);
    //       window.location.href = "http://localhost:4200/"
    //     }
    //   );
    // }

  }

}
