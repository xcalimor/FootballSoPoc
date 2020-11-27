import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { Team } from '../interfaces/team';
import { TeamService } from '../services/team.service';

@Component({
  selector: 'app-team',
  templateUrl: './team.component.html',
  styleUrls: ['./team.component.css']
})
export class TeamComponent implements OnInit {
  team: Team;
  constructor(private route: ActivatedRoute,
              private teamService: TeamService,
              private router: Router) { }

  ngOnInit(): void {
    this.route.params.subscribe(params => {
      console.log("ID hit! " + params['id'])
      const teamId = params['id']
      this.teamService.getTeam(teamId).subscribe(result => {
        this.team = result;
      })
    });
  }
}
