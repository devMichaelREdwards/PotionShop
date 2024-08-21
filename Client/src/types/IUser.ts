import { AxiosRequestConfig } from 'axios';

export interface IAdminUser {
    userName: string;
    token: string;
    loggedIn: boolean;
    authConfig: AxiosRequestConfig;
    roles: EmployeeRole[];
}

export type EmployeeRole = 'Employee' | 'Owner';

export interface IEmployeeAccountInfo {
    employeeId: number;
    position: string;
    status: string;
    firstName: string;
    lastName: string;
}
