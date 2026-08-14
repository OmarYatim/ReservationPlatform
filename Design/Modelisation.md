New Customers 
Members
Receptionists
Managers
Administrator
Payment Provider
Email Provider



[Authentification]
The system shall allow a new customer to create an account 
The system shall prevent a member from having more than one account
The system shall allow a member to reset their password
The system shall allow a member to login
[Booking]
The system shall provide 2 types of quotas, desks quota (number of days) and meeting rooms quota (number of hours)
The system shall allow members to book a resource during an available time slot
The system shall allow members to book in all locations 
The system shall show an unbookable private office resource for every location
The system shall prevent a member from having 2 or more bookings that overlap
The system shall prevent a member from booking outside of a location’s opening hours
The system shall enforce hourly booking for meeting rooms and daily bookings for desks
The system shall deduct booked meeting-room hours from Member’s meeting rooms monthly quota
The system shall deduct booked desk days from Member’s desks monthly quota if on a part time plan
The system shall ask members for extra charges if user’s quota is not enough to book a resource
The system shall provide a way for members to cancel their booking
The system shall refund the hours to a member’s quota if they cancel at least 24 hours before
The system should not refund the hours but won’t charge extra if cancellation is under 24 hours
The system shall allow receptionists to confirm if a member did use their booking
The system shall send email  reminders and confirmations to members for their bookings
The system shall provide the day’s bookings for managers and receptionists
The system shall provide availability of resources per location
The system shall allow members to modify their booking up to 24 hours before the original start time
The system shall allow receptionists to book on behalf of walk-in members or new customers *

[Billing]
The system shall allow a member to choose a membership plan
The system shall provide 3 types of membership, a day-pass with no free meeting rooms and one day desk access, a part-time with 5 meeting room hours and 10 desk days and a full time with 10 meeting rooms hours and unlimited desk days in a month.
The system shall provide online payment methods for members
The system shall bill periodically for member plans
The system shall bill extra charges for any excess beyond member quotas
The system shall retry billing in case of a failed billing attempt
The system shall send an email reminder to update billing info under 7 days if second try fails
The system shall allow members to keep their existing bookings in the 7 day period and suspend them after if no action is taken
The system shall not allow members to make new bookings when the billing fails
The system shall allow members to cancel their plans, the cancellation will take effect at the end of the current billing month
The system shall cancel all bookings after the cancellation date, members will be notified of these cancellation
The system shall allow members to upgrade their plan, the upgrade will take place immediately, they will be bullied the difference for the rest of the month
The system shall allow members to downgrade their plan, the downgrade will take place at the end of the current billing month
The system shall deactivate (not delete) terminated member accounts, retaining booking and billing history.
⚠ Open point / legal review: retention scope and duration to be validated against GDPR (right to erasure vs. legal accounting retention). Pending validation, assumption: billing data retained per legal minimum; other personal data erasable on request.


[Dashboard]
The system shall allow managers to add rooms and desks, marking rooms out of service or setting open hours for their own location
The system shall allow managers to mark closed days
The system shall allow managers to suspend members and fix billing disputes, the system shall prompt a note to explain the reason for these actions
The system shall allow Admin to manage prices, plans and quotas 

[Reporting]
The system shall provide data of every locations revenue, occupancy and most booked rooms




The system shall load Pages in less than 2 seconds
The system shall store credentials in a non-recoverable encrypted form
The system shall make sure all billing and bank info are secured
The system shall respect RGPD rules for personal info


As a new Customer i want to be able to create an account so i can manage my bookings
As a member i want to be able to reset my password so that i can reset it if forget or lose my password
As a connected member i want to be able to see all the available resources so i know what i can book
As a connected member i want to be able to book in all locations so that i can choose the best location for my needs
As a connected member i want to see my remaining quotas for meeting rooms and desks so i know what i can book
As a connected member i want to be able to book a resource so that i can reserve it for needed period. 
Given a member with 15 hours in their quota if they book a resource for 2 hours , 2 hours should be deducted from their quota so it becomes 13 hours. 
Given a member with 1 hour in their quota if they want to book a resource for 3 hours, a billing prompt would appear asking for extra charges for the extra 2 hours (same for days and desks). 
Given a member who wants to book a resource from 11:00  to 13:00 if that resource is already booked from 12:00 to 15:00 the booking should not go through. 
Given a member with a confirmed booking from 10:00–12:00, when they attempt to book another resource from 11:00–13:00 or if they attempt to book 2 desks in the same day, then the system rejects the booking and displays the conflict.
As a connected member i want to be able to cancel a booking so that i can free up a resource that i no longer need. 
Given a member with a confirmed booking from 10:00–12:00, when member cancels the booking 2 hours are credited to their quota if cancellation is done 24 hours ahead, if less than 24 hours no hours are recredited
As a member i want to receive an email confirmation so that i can be sure that the booking went through
As a member i want to receive a reminder of my booking so that i will be reminded of my booking
As a member i want to choose my membership plan so that i can choose the best plans for my needs
As a member i want to be able to upgrade and downgrade my plan so i can switch to a more appropriate plan
As a member i want to be able to cancel my plan so i can stop billing when i no longer need access
As a member i want to choose my payment method so i can use different payment methods according to my needs
As a member i want to be able to modify  a booking so i can change plans if needed
As a member i want to book and pay for a  single day use of desks so i can book  for small usage

As a member i want to be notified by email that my billing did not pass so i can quickly know that i have an issue

As a receptionist i want to be able to see what bookings i have today so that i can properly plan my day
As a receptionist i want to be able to check people in so i can confirm they used their booking.
Given a booking which was not confirmed (No show), the hours would still be deducted from their quota
As a receptionist i want to be able to take payments from w	alk ins and confirm them in the system so that walk ins are traced as well

As a manager i want the member to be allowed to keep their current bookings for 7 days then suspended if the issue was not fixed so i can be assured no abuse takes place
As a manager i want that members would not be allowed to make any new bookings when their payment method does not go through
As a manager if a member’s billing does not pass at first i want the system to retry so that i can be sure the issue is the billing method
As a Manager i want to see how my location(s) is(are) doing (revenue, occupancy…) so that i can know how my location is doing on average
As a manager I want to set up opening hours, closing days and resources availability so i can manage my location
As a manager i want to be able to suspend members and fix billing disputes so that i assure the respect of the terms of service
As an admin i want to set plans, pricing and quotas so that only i can set prices and cost 


