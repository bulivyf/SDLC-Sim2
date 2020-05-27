# SDLC-Sim2
GOAP simulator using SDLC as an example.

An example of interactions of various workers in a dev office. This is a representation of the Agile SCRUM framework (showing workflow).  

Role by capsule color: 
- Gray: Customer 
- Dark Blue: Requirements manager (dev team) 
- Yellow: Product owner 
- Green: Developer (dev team) 
-Light blue: tester (Dev Test) 

Artifacts (items that are processed in this simulation): 
- Defined Requirement 
- Tasking (JIRA entry) 
- implementation 
- Testing (deployable) 

Workflow Steps 
1. Customer arrives to be collected and interviewed by Req Manager. Req Delivered is incremented by one. 
2. Lead takes reqs and builds out tasks (in task room). Tasks are inc by 1 
3. Developer chooses a tasks and works to implement it. Implemented is inc by 1 
4. Tester tests implemented result to confirm the result is in line with the requirement definition. Delivered is inc by 1. 

Subtle humor
Some of the capsules do a circular dance with each other (metaphiorcal to events in real life).
The Rest and Rectreaction area is never visited... we're working the staf at 100% (no breaks!)

