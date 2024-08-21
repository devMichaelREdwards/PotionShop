import { Content, Panel } from 'rsuite';
import useTitle from '../../../../hooks/useTitle';
import AdminHeader from '../../../common/header/AdminHeader';
import AdminAccountForm from '../../forms/AdminAccountForm';
import { useID } from '../../../../hooks/useData';
import { IEmployeeAccountInfo } from '../../../../types/IUser';

const AdminAccountPage = () => {
    useTitle('My Account');
    const { data, loading } = useID('employee/account', true);

    if (!data) return <>Error page</>;

    const accountInfo: IEmployeeAccountInfo = {
        employeeId: data.employeeId as number,
        email: data.email as string,
        position: data.employeePosition as string,
        status: data.employeeStatus as string,
        firstName: data.firstName as string,
        lastName: data.lastName as string,
        userName: data.userName as string,
    };

    const potions = data.potions;

    const receipts = data.receipts;

    if (loading) return <>Loading Page...</>;
    return (
        <Panel className='admin-page'>
            <AdminHeader title='My Account' />
            <Content>
                <AdminAccountForm />
            </Content>
        </Panel>
    );
};

export default AdminAccountPage;
