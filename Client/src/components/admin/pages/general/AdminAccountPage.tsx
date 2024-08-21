import { Content, Panel } from 'rsuite';
import useTitle from '../../../../hooks/useTitle';
import AdminHeader from '../../../common/header/AdminHeader';
import AdminAccountForm from '../../forms/AdminAccountForm';

const AdminAccountPage = () => {
    useTitle('My Account');
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
