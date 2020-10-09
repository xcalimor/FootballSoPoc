import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Team } from '../interfaces/team';

@Injectable({
  providedIn: 'root'
})
export class TeamService {
  serviceUrl: string = "https://localhost:5502/fsopoc/api/team";
  constructor(private http: HttpClient) { }

  getTeams(){
    return this.http.get<Team[]>(this.serviceUrl);
  }

  getTeam(id){
    return this.http.get<Team>(`${this.serviceUrl}/${id}`);
  }

}
